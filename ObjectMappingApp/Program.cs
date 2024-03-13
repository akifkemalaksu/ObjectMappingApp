using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using Microsoft.EntityFrameworkCore;
using ObjectMappingApp;
using ObjectMappingApp.Context;
using ObjectMappingApp.Services.Mapping;
using ObjectMappingApp.Services.Mapping.AutoMapper;
using System.Reflection;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MappingContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("test", () =>
{
    using var context = new MappingContext();
    var data = context.OrderItems
        .Include(x => x.Order)
            .ThenInclude(x => x.Customer)
        .Include(x => x.Order)
            .ThenInclude(x => x.Store)
        .Include(x => x.Order)
            .ThenInclude(x => x.Staff)
                .ThenInclude(x => x.Store)
        .Include(x => x.Product)
            .ThenInclude(x => x.Brand)
        .Include(x => x.Product)
            .ThenInclude(x => x.Category);


    var test = JsonSerializer.Serialize(data);


    //var config = new ManualConfig()
    //.WithOptions(ConfigOptions.DisableOptimizationsValidator)
    //.AddValidator(JitOptimizationsValidator.DontFailOnError)
    //.AddLogger(ConsoleLogger.Default)
    //.AddColumnProvider(DefaultColumnProviders.Instance);

    //BenchmarkRunner.Run<ObjectMapperBenchmark>(config);
});

app.Run();
