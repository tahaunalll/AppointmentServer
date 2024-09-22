using AppointmentServer.Application;
using AppointmentServer.Domain.Entities;
using AppointmentServer.Infrastructure;
using AppointmentServer.WebAPI;
using DefaultCorsPolicyNugetPackage;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//t�m endpointlere a��k, sonra de�i�tirilecek 
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

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

//Helper.cs
app.CreateUser().Wait();

app.Run();
