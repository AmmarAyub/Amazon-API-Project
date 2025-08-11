using AmazonAPI.Data;
using AmazonAPI.Models;
using AmazonAPI.Models.DTO_s;
using AmazonAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly WestendAccountsDbContext _context1;
        private readonly TokenService _tokenService;
        private readonly IPasswordHasher<AspNetUser> _passwordHasher;

        public AuthController(
            WestendAccountsDbContext context,
            TokenService tokenService,
            IPasswordHasher<AspNetUser> passwordHasher)
        {
            _context1 = context;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }

        [HttpPost("login")]
        [Consumes("application/json")] // Explicitly expect JSON
        public async Task<ActionResult<LoginResponseDTO>> Login(LoginRequestDTO loginRequest)
        {
            var user = await _context1.AspNetUsers
                .FirstOrDefaultAsync(u => u.UserName == loginRequest.UserName);

            if (user == null)
            {
                return Unauthorized("Invalid username");
            }

            // Verify password - since you have both PasswordHash and NudePassword
            var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(
                user,
                user.PasswordHash ?? string.Empty,
                loginRequest.Password);

            // Fallback to plain text check if hashed password fails (not recommended for production)
            if (passwordVerificationResult == PasswordVerificationResult.Failed &&
                user.NudePassword != loginRequest.Password)
            {
                return Unauthorized("Invalid password");
            }

            if (user.UserStatus==true)
            {
                return Unauthorized("User account is disabled");
            }

            var token = _tokenService.CreateToken(user);

            return new LoginResponseDTO
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Token = token,
                FullName = user.FullName,
                CompanyName = user.CompanyName,
                UserStatus = user.UserStatus
            };
        }

        // In AuthController.cs
        [HttpPost("register")]
        public async Task<ActionResult<LoginResponseDTO>> Register(LoginRequestDTO registerRequest)
        {
            if (await _context1.AspNetUsers.AnyAsync(u => u.UserName == registerRequest.UserName))
            {
                return BadRequest("Username already exists");
            }

            var user = new AspNetUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = registerRequest.UserName,
                Email = registerRequest.UserName, // or separate email field
                EmailConfirmed = true,
                UserStatus = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            // Hash the password
            user.PasswordHash = _passwordHasher.HashPassword(user, registerRequest.Password);

            // Avoid storing nude password in production
            // user.NudePassword = registerRequest.Password; 

            _context1.AspNetUsers.Add(user);
            await _context1.SaveChangesAsync();

            var token = _tokenService.CreateToken(user);

            return new LoginResponseDTO
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Token = token,
                UserStatus = user.UserStatus
            };
        }
    }
}
