
using ApartmentManagement.Domain.Models;
using ApartmentManagement.Infrastructure.Context;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using ApartmentManagement.Application.Interfaces;
using ApartmentManagement.Application.Profiles;
using ApartmentManagement.Application.Services;
using ApartmentManagement.Domain.Interfaces;
using ApartmentManagement.Infrastructure;
using ApartmentManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Profile = ApartmentManagement.Application.Profiles.Profile;

namespace ApartmentManagement.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterApartmentManagement(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApartmentDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("Default"))
            .UseLazyLoadingProxies());

            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
           .AddEntityFrameworkStores<ApartmentDbContext>();

            services.AddScoped<IUnitofWork, UnitofWork>();
            services.AddScoped<IHousingService, HousingService>();
            services.AddScoped<IHousingTypeRepository, HousingTypeRepository>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();

            services.AddHttpClient<ICreditCardService, CreditCardService>(options => {
                options.BaseAddress = new Uri(configuration["CreditCard:Url"]);
            });


            var mappingConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.AddProfile(new Profile());

            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
