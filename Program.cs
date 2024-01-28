using MultipleInterfaceImplementation.Repository;
using MultipleInterfaceImplementation.Repository.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IShoppingCart, ShoppingCartAmazon>();
builder.Services.AddScoped<IShoppingCart, ShoppingCartEBay>();
builder.Services.AddScoped<IShoppingCart, ShoppingCartFlipCart>();
builder.Services.AddTransient<ICommonFactoryRepo, CommonFactoryRepo>();

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
