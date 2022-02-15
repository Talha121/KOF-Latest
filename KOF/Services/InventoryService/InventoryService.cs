using KOF.Context;
using KOF.Models;
using KOF.Services.GenericService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.InventoryService
{
    public class InventoryService: GenericRepository<Inventory>, IInventoryService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public InventoryService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor) : base(context)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> addtocart(int inventoryid, int productid, int Qty, int userid,string unit)
        {
            var price = 0;
            var inv = _context.Inventories.Where(x=>x.Id==inventoryid).SingleOrDefault();
            var cart = new List<Cart>();
          
           var cartinfo=  _session.GetString("mycart");
          
            if (cartinfo != null)
            {
                var mysession = JsonConvert.DeserializeObject<IEnumerable<Cart>>(cartinfo).ToList();
                var sdata = mysession.Where(x => x.inventoryId == inventoryid).FirstOrDefault();
                if (sdata != null)
                {
                    if(sdata.unit==unit)
                    {
                        sdata.Quantity = sdata.Quantity + Qty;
                        sdata.TotalPrice = sdata.Quantity * sdata.PerUnitPrice;
                        var rs = mysession.Where(x => x.inventoryId == inventoryid).FirstOrDefault();

                        mysession.Remove(rs);
                        mysession.Add(sdata);
                        var str = JsonConvert.SerializeObject(mysession);
                        _session.SetString("mycart", str);
                    }
                    else
                    {
                        if (unit == "1/2 Kg")
                        {
                            price = (inv.PricePerUnit / 2);
                        }
                        else
                        {
                            price = inv.PricePerUnit;
                        }
                        Cart obj = new Cart
                        {
                            ProductId = productid,
                            unit = unit,
                            inventoryId = inventoryid,
                            Quantity = Qty,
                            PerUnitPrice = price,
                            TotalPrice = price * Qty

                        };
                        mysession.Add(obj);
                        var str = JsonConvert.SerializeObject(mysession);
                        _session.SetString("mycart", str);
                    }
                 
                }
                else
                {
                    if (unit == "1/2 Kg")
                    {
                        price = (inv.PricePerUnit / 2);
                    }
                    else
                    {
                        price = inv.PricePerUnit;
                    }
                    Cart obj = new Cart
                    {
                        ProductId = productid,
                        unit = unit,
                        inventoryId = inventoryid,
                        Quantity = Qty,
                        PerUnitPrice = price,
                        TotalPrice = price * Qty

                    };                  
                    mysession.Add(obj);
                    var str = JsonConvert.SerializeObject(mysession);
                    _session.SetString("mycart", str);
                }
            

            }
            else
            {
                if (unit == "1/2 Kg")
                {
                    price = (inv.PricePerUnit / 2);
                }
                else
                {
                    price = inv.PricePerUnit;
                }
                Cart obj = new Cart
                {
                    ProductId = productid,
                    unit = unit,
                    inventoryId = inventoryid,
                    Quantity = Qty,
                    PerUnitPrice = price,
                    TotalPrice = price * Qty
                };
                cart.Add(obj);
                var str = JsonConvert.SerializeObject(cart);
                _session.SetString("mycart", str);
            }

            return productid;
        }

        public async Task<object> CategorywiseInventory(int id)
        {
            var data = await _context.Inventories.Where(a => a.Status == true).Select(a =>new  { 
                 invinfo=a,
                 productinfo=a.Product,
                 categoryinfo=a.Product.Category

            }).ToListAsync();
            return data;
        }

        public  async Task<object> GetInventory()
        {
            var data = await _context.Inventories.Select(x=> new { 
                  inventory=x,
                  suppliername=x.Supplier.Name,
                  productinfo=_context.Products.Where(y=>y.Id==x.ProductId).Select(y=> new {
                  name=y.Name,
                  categoryname=y.Category.Name,
                  
                  }).SingleOrDefault(),
                 

            }).ToListAsync();

            return data;
        }

        public async Task<int> removecart(int id)
        {
         
           
                var cartinfo = _session.GetString("mycart");

            if (cartinfo != null)
            {
                var mysession = JsonConvert.DeserializeObject<IEnumerable<Cart>>(cartinfo).ToList();
                var sdata = mysession.Where(x => x.inventoryId == id).FirstOrDefault();
                if (sdata != null)
                {

                    mysession.Remove(sdata);

                    var str = JsonConvert.SerializeObject(mysession);
                    _session.SetString("mycart", str);
                };


            }
            return 0;

        }

        public async Task<string> Savemessange(ContactUs contact)
        {
            await _context.ContactUs.AddAsync(contact);
            await _context.SaveChangesAsync();
            return "Success";
        }
    }
}
