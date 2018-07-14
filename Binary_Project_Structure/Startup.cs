using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Binary_Project_Structure_BLL.Services;
using Binary_Project_Structure_BLL.Interfaces;
using System.Threading;
using Ninject;
using Ninject.Activation;
using Ninject.Infrastructure.Disposal;
using AutoMapper;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;

namespace Binary_Project_Structure
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IAircraftService, AircraftService>();
            services.AddSingleton<ICrewService, CrewService>();
            services.AddSingleton<IDepartureService, DepartureService>();
            services.AddSingleton<IFlightService, FlightService>();
            services.AddSingleton<IPilotService, PilotService>();
            services.AddSingleton<IStewardessService, StewardessService>();
            services.AddSingleton<ITicketService, TicketService>();
            services.AddSingleton<ITypeAircraftService, TypeAircraftService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
