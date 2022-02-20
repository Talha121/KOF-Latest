using KOF.DTO_S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.DashboardService
{
   public  interface IDashboardService
    {
        
              Task<Dashboarddto> DashboardData();


        Task<MonthlySaleDto> MonthlySale(Datedto dto);
    }
}
