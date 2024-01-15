using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using GeekShopping.ProductAPI.Model.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
/*
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection,
    new MySqlServerVersion(new Version(5, 0, 35))));*/

var connection = builder.Configuration["SQLConnection:SQLConnectionString"];

builder.Services.AddDbContext<MySQLContext>(
        options => options.UseSqlServer("Server=DESKTOP-71URVSU\\SQLEXPRESS;Database=geek_shopping_product_api;Uid=Bonapjhjhjarte;Password=1010;"));
        


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
