// Entry Point

// Asl�nda bir konsol uygulamas�, ama bilgisayarda local bir
// http sunucusu aya�a kald�r�r.
using Business.Abstract;
using Business.Concrete;
using Business.Validation;
using DataAccess.Absract;
using DataAccess.Concrete;
using FluentValidation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Service Lifetime
builder.Services.AddScoped<IProductRepository, InMemoryProductRepository>();
builder.Services.AddScoped<IProductService, ProductManager>();

// TODO: Business'dan extension ile �a��rmak
builder.Services.AddValidatorsFromAssemblyContaining<AddProductRequestValidator>();

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
