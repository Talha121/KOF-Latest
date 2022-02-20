using KOF.DTO_S;
using KOF.Services.DashboardService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _DashboardService;
        public DashboardController(IDashboardService DashboardService)
        {
            _DashboardService = DashboardService;
        }
        [HttpGet("DashboardData")]
        public async Task<IActionResult> DashboardData()
        {
            try
            {
                var data = await _DashboardService.DashboardData();
                return Ok(data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost("MonthlySale")]
        public async Task<IActionResult> MonthlySale( Datedto dto)
        {
            try
            {
                var data = await _DashboardService.MonthlySale(dto);
                return Ok(data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
 
    }
}
