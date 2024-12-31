using Microsoft.EntityFrameworkCore;
using ApiGatewayManagementService.Data;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApiGatewayManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KiraExpressApiGatewayManagement")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Configuration.AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddHttpClient();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/users/swagger/v1/swagger.json", "User API");
        c.SwaggerEndpoint("/products/swagger/v1/swagger.json", "Product API");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseOcelot().Wait();

app.Run();
