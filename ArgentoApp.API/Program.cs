using ArgentoApp.Business.Abstract;
using ArgentoApp.Business.Concrete;
using ArgentoApp.Data;
using ArgentoApp.Data.Abstact;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Data.Concrete.Repositories;
using ArgentoApp.Shared.Helpers;
using ArgentoApp.Shared.Helpers.Abstract;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore; 
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

//<<<Repositories>>>
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICartItemRepository, CartItemRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();


//<<<Services>>>>
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICartItemService, CartItemService>();
builder.Services.AddScoped<IOrderService, OrderService>();


//<<<ImageHelper>>>>
builder.Services.AddScoped<IImageHelper, ImageHelper>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
