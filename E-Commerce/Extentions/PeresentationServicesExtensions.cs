using Services.Abstractions;
using Services;
using E_Commerce.Factoris;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Extentions
{
    public static class  PeresentationServicesExtensions
    {
        public static IServiceCollection AddPersentationServices(this IServiceCollection Services)
        {
            Services.AddControllers().AddApplicationPart(typeof(Persentation.AssemblyReference).Assembly);
            Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = ApiResponseFactory.CustomValidationErrors;

            });
			Services.AddCors(options =>
            {
                options.AddPolicy("CORSPolicy", builder =>
                {
                    builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithOrigins("http://localhost:4200");
                });
            });

            return Services;
        }
    }
}
