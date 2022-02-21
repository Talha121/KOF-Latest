using KOF.Context;
using KOF.DTO_S;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.DashboardService
{
    public class DashboardService : IDashboardService
    {
        private readonly ApplicationDbContext _context;
        public DashboardService(ApplicationDbContext contextt)
        {
    
            _context = contextt;
        }
        public async  Task<Dashboarddto> DashboardData()
        {
         
            Dashboarddto data = new Dashboarddto();
            var orders = _context.Orders.ToList();
            data.todayOrders = orders.Where(x=>Convert.ToDateTime(x.CreatedOn).Date==DateTime.Now.Date).Count();
            data.TotalOrders= orders.Count();

            var totalordersitems = await _context.OrderItems.ToListAsync();
            data.TotalSale = totalordersitems.Where(x=>x.Order.OrderStatus== "Completed").Sum(x => x.TotalPrice);
            data.TodaySale = totalordersitems.Where(x => Convert.ToDateTime(x.CreatedOn).Date == DateTime.Now.Date&&x.Order.OrderStatus == "Completed").Sum(x => x.TotalPrice);
            var totalpurchaseprice = totalordersitems.Where(x => x.Order.OrderStatus == "Completed").Sum(x => x.TotalCost);
            var todaypurchaseprice = totalordersitems.Where(x => Convert.ToDateTime(x.CreatedOn).Date == DateTime.Now.Date&&x.Order.OrderStatus == "Completed").Sum(x => x.TotalCost);
            data.TodayProfit =data.TodaySale- todaypurchaseprice;
            data.totalProfit = data.TotalSale - totalpurchaseprice;
         
            return data;
        }

        public async Task<MonthlySaleDto> MonthlySale(Datedto dto)
        {
            MonthlySaleDto data = new MonthlySaleDto();
            var items =  _context.OrderItems.Where(x => x.Order.OrderStatus == "Completed").ToList();
            var orders = _context.Orders.Where(x => x.OrderStatus == "Completed").ToList();
            data.Orders = orders.Where(x=>Convert.ToDateTime(x.CreatedOn).Date>=dto.FromDate.Date&& Convert.ToDateTime(x.CreatedOn).Date<=dto.ToDate).Count();
            var dateitems = items.Where(x => Convert.ToDateTime(x.CreatedOn).Date >= dto.FromDate.Date && Convert.ToDateTime(x.CreatedOn).Date <= dto.ToDate);
            data.Sale = dateitems.Sum(x => x.TotalPrice);
           var totalunitprice = dateitems.Sum(x => x.TotalCost);
            data.Profit = data.Sale - totalunitprice;

            return data;

        }


    }
}
