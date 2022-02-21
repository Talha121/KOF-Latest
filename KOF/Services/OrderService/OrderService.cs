using KOF.Context;
using KOF.Models;
using KOF.Models.Email;
using KOF.Services.EmailService;
using KOF.Services.GenericService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.OrderService
{
    public class OrderService: GenericRepository<Order>, IOrderService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailservice;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public OrderService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, IEmailService emailservice, IHttpContextAccessor httpContextAccessor) : base(context)
        {

            _webHostEnvironment = webHostEnvironment;
            _context = context;
            _emailservice = emailservice;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<object> Changestatus(Order dto)
        {
            await UpdateAsync(dto);
            return "success";
        }

        public async Task<string> Checkout(string streadaddress, string homeadderess, string city, string phone, string email, string Ordernote,string Name)
        {

            try
            {
                var orderno = _context.Orders.Max(x => x.OrderNumber);
                int no = 10000;
                if(orderno==null)
                {
                    no = no;
                }
                else
                {
                    no = Convert.ToInt32(orderno)+1;
                }
                var cartinfo = _session.GetString("mycart");
                var mysession = JsonConvert.DeserializeObject<IEnumerable<Cart>>(cartinfo);              
                Order order = new Order()
                {
                    
                    Order_phoneno = phone,
                    Order_emailaddress = email,
                    order_streataddress = streadaddress,
                    Order_city = city,
                    Order_Notes = Ordernote,
                    HouseNo= homeadderess,
                    OrderFrom = "Web",
                    OrderNumber =no.ToString(),
                    OrderStatus = "Pending",
                    OrderType = "Online",
                    CreatedOn = DateTime.Now,
                    Name=Name
                };
                
                _context.Orders.Add(order);
                _context.SaveChanges();
                var orderid = order.Id;
                foreach (var item in mysession)
                {
                    OrderItem items = new OrderItem()
                    {
                        OrderId = orderid,
                        PerUnitCost = item.PerUnitCost,
                        PerUnitPrice = item.PerUnitPrice,
                        ProductId = item.ProductId,
                        TotalCost = item.TotalCost,
                        TotalPrice = item.TotalPrice,
                        Quantity = item.Quantity,
                        CreatedOn = DateTime.Now

                    };
                    _context.OrderItems.Add(items);
                    _context.SaveChanges();
                }
                EmailSource useremail = new EmailSource()
                {
                    EmailTo = email,
                    UserName = email

                };
                _emailservice.SendEmailTemplateAsync(useremail, mysession, order);

                EmailSource useremail2 = new EmailSource()
                {
                    EmailTo = "Khanorganicfoods.pk@gmail.com",
                    UserName = "Admin"

                };
                _emailservice.SendEmailTemplateAsync(useremail2, mysession, order);
                var cart = new List<Cart>();
                var str = JsonConvert.SerializeObject(cart);
                _session.SetString("mycart", str);
                return "Success";
            }
            catch (Exception ex)
            {
                var ddd = ex.Message;

                throw;
            }
       
            //await mycart.RemoveRange(mycart)
            return "";
        }

        public async Task<object> contactus()
        {
            var data = await _context.ContactUs.ToListAsync();
            return data;
        }

        public async Task<object> GetOrders()
        {
            var data = await _context.Orders.Include(x=>x.OrderItems).ThenInclude(x=>x.Product).Select(x=>new { 
              order=x,
              total=_context.OrderItems.Where(z => z.OrderId == x.Id).Sum(x=>x.TotalPrice),
              qty= _context.OrderItems.Where(z => z.OrderId == x.Id).Sum(x => x.Quantity),
              orderitems =_context.OrderItems.Where(z=>z.OrderId==x.Id).Select(z=> new { 
                item=z,
                product=_context.Products.Where(p=>p.Id==z.ProductId).Select(p=>p.Name).SingleOrDefault(),
                  unit = _context.Inventories.Where(q => q.ProductId == z.ProductId).Select(p => p.Unit).SingleOrDefault(),

              }).ToList()
              //userinfo=_context.AllUsers.Where(y=>y.Id==x.UserId).Select(y=> new {
              //name=y.Name,
              //contactno=y.Phone,
              //email=y.Email
               
              //}).SingleOrDefault(),
            
            }).ToListAsync();
            return data;
        }
    }
}
