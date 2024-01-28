using System.Reflection;
using Core.DotNet.AggregatesModel.AuthAggregate;
using Core.DotNet.AggregatesModel.ExceptionAggregate;
using Core.DotNet.Extensions.DependencyInjection;
using Core.DotNet.Extensions.Middlewares;
using Core.DotNet.Middlewares;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using SIAPolicyService.API.Extensions;
using SIAPolicyService.Infrastructure.Configurations;
using SIAPolicyService.Infrastructure.DbContexts;

var allowOrigins = "*";
var builder = WebApplication.CreateBuilder(args);
var environmentOptions = builder.Services.AddCustomOptions<EnvironmentOptions>(builder.Configuration);

builder.Services.AddCustomConfigurations(environmentOptions);

builder.Services.AddHttpClient();

builder.Services.AddHttpContextAccessor();

builder.Services.AddCors(options =>
{
    options.AddPolicy(allowOrigins,
        builder =>
        {
            builder.WithOrigins(allowOrigins)
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddCustomAppInsightsService(builder.Configuration, Assembly.GetExecutingAssembly().GetName().Version.ToString(3));

builder.Services.AddControllers()
    .AddResponseJsonOptions()
    .AddFluentValidation();

builder.Services.AddHealthChecks();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new OpenApiInfo { Title = "Core SIAPolicy API", Version = "v1" });
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseHsts();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseErrorHandling(new ErrorHandlingOptions("core.siapolicy.service"));

app.UseRequestCulture();

app.UseRouting();

app.UseCors(allowOrigins);

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHealthChecks("/health/ready", new HealthCheckOptions()).AllowAnonymous();
    endpoints.MapHealthChecks("/health/live", new HealthCheckOptions { Predicate = _ => false }).AllowAnonymous();
});

app.Run();