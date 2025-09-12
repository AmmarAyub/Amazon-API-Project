using AmazonAPI.Data;
using AmazonAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemReportController : ControllerBase
    {
        private readonly WestendAccountsDbContext _context1;
        

        public SystemReportController(WestendAccountsDbContext context1)
        {
            _context1 = context1;
        
        }
        [HttpPost("SQLBackup")]
        public IActionResult SQLBackup()
        {
            try
            {
                var list = _context1.Database.SqlQueryRaw<SystemsSQLBackupModel>("SystemsSQLBackup").ToList();

                var result = new
                {
                    SystemsSQLBackup = list,
                    SystemCount = list.Count,
                    Timestamp = DateTime.UtcNow
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An error occurred while retrieving invoice data" });
            }
        }
    }
}
