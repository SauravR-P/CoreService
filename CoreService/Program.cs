using CoreService.MQ;
using CoreService.Repository;
using CoreService.Service;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.ObjectPool;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRabbit(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IRabbitManager, RabbitManager>();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDbCrudOperations, DbCrudOperations>();
builder.Services.AddControllers();
builder.Services.AddMvc();
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

//app.UseMvc();

app.Run();

public static class RabbitServiceCollectionExtensions
{
    public static IServiceCollection AddRabbit(this IServiceCollection services, IConfiguration configuration)
    {
        var rabbitConfig = configuration.GetSection("rabbit");
        services.Configure<RabbitMQOptions>(rabbitConfig);

        services.AddScoped<ObjectPoolProvider, DefaultObjectPoolProvider>();
        services.AddScoped<IPooledObjectPolicy<IModel>, RabbitModelPooledObjectPolicy>();
        services.AddScoped<IRabbitManager, RabbitManager>();

        return services;

        //var queueSettings = configuration.GetSection("rabbit");
        //services.AddMassTransit(config => {

        //    config.UsingRabbitMq((ctx, cfg) =>
        //    {
        //        //cfg.Host("amqp://<username>:<password>@<hostname>:<port>/");
        //        cfg.Host(queueSettings.HostName, queueSettings.Port, queueSettings.VirtualHost,
        //         h => {
        //             h.Username(queueSettings.UserName);
        //             h.Password(queueSettings.Password);
        //         });
        //        cfg.ExchangeType = ExchangeType.Direct;
        //    });

        //    //var queueSettings = queueSettingsSection.Get<QueueSettings>();
    }
}

