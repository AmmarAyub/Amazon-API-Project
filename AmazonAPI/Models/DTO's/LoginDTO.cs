namespace AmazonAPI.Models.DTO_s
{
        public class LoginRequestDTO
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public class LoginResponseDTO
        {
            public string UserId { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Token { get; set; }
            public string FullName { get; set; }
            public string CompanyName { get; set; }
            public bool UserStatus { get; set; }
        }
 }
