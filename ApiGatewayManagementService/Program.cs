using Microsoft.EntityFrameworkCore;
using ApiGatewayManagementService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Veritabaný baðlantýsýný yapýlandýr
builder.Services.AddDbContext<ApiGatewayManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KiraExpressApiGatewayManagement")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
