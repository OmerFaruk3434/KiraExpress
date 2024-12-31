using Microsoft.EntityFrameworkCore;
using UserManagementService.Data; // DbContext sýnýfýnýn bulunduðu namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Veritabaný baðlantýsýný yapýlandýr
builder.Services.AddDbContext<UserManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KiraExpressIdentityManagement")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        c =>
        {
            c.SwaggerEndpoint("/users/swagger/v1/swagger.json", "User API");
        });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();