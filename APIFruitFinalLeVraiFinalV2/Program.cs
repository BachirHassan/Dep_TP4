using WebApplication2.Data.Context;
using WebApplication2.MiddleWare;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Configuration;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FruitContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Default");
    //options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    options.UseSqlServer(connectionString);
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{*/
    app.UseSwagger();
    app.UseSwaggerUI();
/*}*/

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseMiddleware<ApiKeyMiddleware>();

app.MapControllers();

app.Run();
