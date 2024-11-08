using Microsoft.EntityFrameworkCore;
using ReviewManagementService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Veritaban� ba�lant�s�n� yap�land�r
builder.Services.AddDbContext<ReviewManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KiraExpressReviewManagement")));

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
