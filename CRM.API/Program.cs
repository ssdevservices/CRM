using CRM.Domain.Repository;
using CRM.Infrastructure.Context;
using CRM.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using CRM.Application.Query.GetAllCustomers;
using CRM.Domain.Models;
using CRM.Application.Query.GetCustomerById;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CRMDbContext>((provider, options) =>
{
    var config = provider.GetService<IConfiguration>();

    var connStr = config.GetConnectionString("CRMDb");

    options.UseSqlServer(connStr);
});


//configure repositories
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

//configure request handlers
builder.Services.AddScoped<IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>, GetAllCustomersQueryHandler>();
builder.Services.AddScoped<IRequestHandler<GetCustomerByIdQuery, Customer>, GetCustomerByIdQueryHandler>();



builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

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
