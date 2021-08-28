using AutoMapper;
using Hangfire;
using Hangfire.MemoryStorage;
using InventoryManagement.Data;
using InventoryManagement.Reporting.Interfaces;
using InventoryManagement.Reporting.Reports;
using InventoryManagement.Repository.Interfaces;
using InventoryManagement.Repository.Repositories;
using InventoryManagement.Service.Interfaces;
using InventoryManagement.Service.Services;
using InventoryManagement.Web.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromHours(10);//You can set Time   
            });
            services.AddHttpContextAccessor();

            var builder = services.AddMvc()
                            .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                            .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddDbContextPool<ApplicationDbContext>(options => options.UseMySql(Configuration.GetConnectionString("DbConnectionString")));

            services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
            services.AddTransient(typeof(IUserService), typeof(UserService));

            services.AddTransient(typeof(IUserRoleRepository), typeof(UserRoleRepository));
            services.AddTransient(typeof(IUserRoleService), typeof(UserRoleService));

            services.AddTransient(typeof(IProductRepository), typeof(ProductRepository));
            services.AddTransient(typeof(IProdutService), typeof(ProductService));

            services.AddTransient(typeof(IEmailService), typeof(SendGridEmailService));
            services.AddTransient(typeof(IInventoryReports), typeof(InventoryReports));

            services.AddHangfire(config =>
                config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseDefaultTypeSerializer()
                .UseMemoryStorage());

            services.AddHangfireServer();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IBackgroundJobClient backgroundJobClient,
            IRecurringJobManager recurringJobManager, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseExceptionHandler("/Error");
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();

            InventoryManagemetHttpContext.Services = app.ApplicationServices;

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseHangfireDashboard();
        }
    }
}
