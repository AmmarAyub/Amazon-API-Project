using AmazonAPI.Data;
using AmazonAPI.Models;
using AmazonAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<TokenService>();
builder.Services.AddSingleton<IPasswordHasher<AspNetUser>, PasswordHasher<AspNetUser>>();

// Add JWT authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

// Add services to the container.
builder.Services.AddDbContext<AmazonDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AmazonConnection"),
    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null)));

builder.Services.AddDbContext<WestendAccountsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WestendAccountsConnection"),
    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null)));

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // React app URL
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials(); // If using cookies/auth
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable CORS middleware
app.UseCors("AllowReactApp");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//using AmazonAPI.Data;
//using AmazonAPI.Models;
//using AmazonAPI.Services;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.IdentityModel.Tokens;
//using System.Text;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container
//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//// Register services
//builder.Services.AddScoped<TokenService>();
//builder.Services.AddSingleton<IPasswordHasher<AspNetUser>, PasswordHasher<AspNetUser>>();

//// Configure DbContexts with SQL Server
//builder.Services.AddDbContext<AmazonDbContext>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("AmazonConnection"),
//        sqlServerOptions =>
//        {
//            sqlServerOptions.EnableRetryOnFailure(
//                maxRetryCount: 5,
//                maxRetryDelay: TimeSpan.FromSeconds(30),
//                errorNumbersToAdd: null);
//            sqlServerOptions.CommandTimeout(60); // Increase timeout if needed
//        }
//    ));

//builder.Services.AddDbContext<WestendAccountsDbContext>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("WestendAccountsConnection"),
//        sqlServerOptions =>
//        {
//            sqlServerOptions.EnableRetryOnFailure(
//                maxRetryCount: 5,
//                maxRetryDelay: TimeSpan.FromSeconds(30),
//                errorNumbersToAdd: null);
//            sqlServerOptions.CommandTimeout(60);
//        }
//    ));

//// Add JWT authentication
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//.AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration["Jwt:Issuer"],
//        ValidAudience = builder.Configuration["Jwt:Audience"],
//        IssuerSigningKey = new SymmetricSecurityKey(
//            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),
//        ClockSkew = TimeSpan.Zero // Remove default 5-minute clock skew
//    };

//    // For development - you might want to log more details
//    options.Events = new JwtBearerEvents
//    {
//        OnAuthenticationFailed = context =>
//        {
//            Console.WriteLine($"Authentication failed: {context.Exception.Message}");
//            return Task.CompletedTask;
//        },
//        OnTokenValidated = context =>
//        {
//            Console.WriteLine("Token validated successfully");
//            return Task.CompletedTask;
//        }
//    };
//});

//// Add CORS policy
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowReactApp", policy =>
//    {
//        policy.WithOrigins("http://localhost:3000") // React app URL
//              .AllowAnyMethod()
//              .AllowAnyHeader()
//              .AllowCredentials();
//    });
//});

//var app = builder.Build();

//// Configure the HTTP request pipeline
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();

//    // Enable detailed errors in development
//    app.UseDeveloperExceptionPage();
//}

//app.UseHttpsRedirection();

//// IMPORTANT: UseCors must come before UseAuthentication and UseAuthorization
//app.UseCors("AllowReactApp");

//// Authentication & Authorization middleware
//app.UseAuthentication(); // This was missing!
//app.UseAuthorization();

//app.MapControllers();

//// Optional: Add health check endpoint
//app.MapGet("/health", () => Results.Ok(new { status = "Healthy", timestamp = DateTime.UtcNow }));

//app.Run();