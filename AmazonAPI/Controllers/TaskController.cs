using AmazonAPI.Data;
using AmazonAPI.Models;
using AmazonAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly WestendAccountsDbContext _context1;
        private readonly TokenService _tokenService;
        private readonly IPasswordHasher<AspNetUser> _passwordHasher;

        public TaskController(
           WestendAccountsDbContext context,
           TokenService tokenService,
           IPasswordHasher<AspNetUser> passwordHasher)
        {
            _context1 = context;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }

        [HttpGet("TaskResponsibilities")]
        public async Task<IActionResult> GetTaskResponsibilities()
        {
            try
            {
                var taskresponsibilityuser = await _context1.ResponsibilityUsers.ToListAsync();
                var tasresponsibility = taskresponsibilityuser.Select(x => x.TaskResponsibility);
                tasresponsibility = await _context1.TaskResponsibilities.ToListAsync();
                var employees = taskresponsibilityuser.Select(x => x.Employee);
                employees = await _context1.Employees.ToListAsync();
                return Ok(taskresponsibilityuser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = "Error retrieving TaskResponsibility",
                    details = ex.Message
                });
            }
        }
    }
}
