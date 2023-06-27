using Microsoft.EntityFrameworkCore;
using Shop.Application.Interfaces;
using Shop.Application.Services;
using Shop.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ShopDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ShopConnection")));//For connection
builder.Services.AddScoped<IProduct, ProductService>();//
builder.Services.AddScoped<ICategory, CategoryService>();//
builder.Services.AddScoped<IVendor, VendorService>();//

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
