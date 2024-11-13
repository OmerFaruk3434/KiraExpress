using Microsoft.EntityFrameworkCore;
using ApiGatewayManagementService.Data;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Veritabaný baðlantýsýný yapýlandýr
builder.Services.AddDbContext<ApiGatewayManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KiraExpressApiGatewayManagement")));

// Ocelot için yapýlandýrma ekle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Configuration.AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddHttpClient();

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

// Ocelot middleware'ini en sonda kullanýn
app.UseOcelot().Wait();

app.Run();
