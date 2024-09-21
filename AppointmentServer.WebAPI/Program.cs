using AppointmentServer.Application;
using AppointmentServer.Domain.Entities;
using AppointmentServer.Infrastructure;
using AppointmentServer.WebAPI;
using DefaultCorsPolicyNugetPackage;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//tüm endpointlere açýk, sonra deðiþtirilecek 
builder.Services.AddDefaultCors();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
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

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Helper.cs
app.CreateUser().Wait();

app.Run();
