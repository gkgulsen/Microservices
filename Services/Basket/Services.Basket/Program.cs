using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Logging;
using Services.Basket.Consumers.Events;
using Services.Basket.Services;
using Services.Basket.Settings;
using Shared.Services;
using System.IdentityModel.Tokens.Jwt;

var builder = WebApplication.CreateBuilder(args);

IdentityModelEventSource.ShowPII = true;
// Add services to the container.

//builder.Services.AddMassTransit(x =>
//{

//   x.AddConsumer<CourseNameChangedEventConsumer>();
//   // Default Port : 5672
//   x.UsingRabbitMq((context, cfg) =>
//   {
//       cfg.Host(builder.Configuration["RabbitMQUrl"], "/", host =>
//       {
//          host.Username("guest");
//          host.Password("guest");
//       });

//       cfg.ReceiveEndpoint("course-name-changed-event-order-service", e =>
//       {
//           e.ConfigureConsumer<CourseNameChangedEventConsumer>(context);
//       });
//   });
//});


var requiredAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("sub");
builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new AuthorizeFilter(requiredAuthorizePolicy));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.Authority = builder.Configuration.GetSection("IdentityServerURL").Value;
    options.Audience = "resource_basket";
    options.RequireHttpsMetadata = false;
});



builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ISharedIdentityService, SharedIdentityService>();
builder.Services.AddScoped<IBasketService, BasketService>();
builder.Services.Configure<RedisSettings>(builder.Configuration.GetSection("RedisSettings"));
builder.Services.AddSingleton<IRedisSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<RedisSettings>>().Value;
});

builder.Services.AddSingleton<RedisService>(sp =>
{
    var redisSettings = sp.GetRequiredService<IOptions<RedisSettings>>().Value;

    var redis = new RedisService(redisSettings.Host, redisSettings.Port);

    redis.Connect();

    return redis;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
