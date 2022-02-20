using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.DTO_S
{
    public class Dashboarddto
    {

        public int todayOrders { get; set; }

        public int TotalOrders { get; set; }

        public int TodaySale { get; set; }
        public int TotalSale { get; set; }

        public int TodayProfit { get; set; }
        public int totalProfit { get; set; }
    }
}
