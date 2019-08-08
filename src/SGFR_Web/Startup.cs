using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGFR_Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using SimpleInjector.Lifestyles;
using Application.Applications;
using SimpleInjector;
using Application.Interfaces;
using Domain.Interfaces.Services;
using Domain.Services;
using Domain.Interfaces.Repositories;
using InfraData.Repositories;
using SimpleInjector.Integration.AspNetCore.Mvc;
using Container = SimpleInjector.Container;
using Application.Interfaces.Cadastro;
using Application.Applications.Cadastro;
using Domain.Interfaces.Services.Cadastro;
using Domain.Services.Cadastro;
using Domain.Interfaces.Repositories.Cadastro;
using InfraData.Repositories.Cadastro;
using SGFR_Web.AutoMapper;
using InfraData.Data.Context;
using Application.Interfaces.Producao;
using Application.Applications.Producao;
using Domain.Interfaces.Services.Producao;
using Domain.Services.Producao;
using Domain.Interfaces.Repositories.Producao;
using InfraData.Repositories.Producao;

namespace SGFR_Web
{
    public class Startup
    {
        private Container container = new Container();
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
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //===================SQLSERVER=======================================
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<DbContextoGeral>(options =>
            //  options.UseSqlServer(
            //      Configuration.GetConnectionString("DefaultConnection")));


            //services.AddDbContext<DbContextoGeral>(options =>
            //  options.UseSqlServer(
            //      Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            //======================Mysql===========================================
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseMySql(
                   Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<DbContextoGeral>(options =>
              options.UseMySql(
                  Configuration.GetConnectionString("DefaultConnection")));


            services.AddDbContext<DbContextoGeral>(options =>
              options.UseMySql(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());

            IntegrateSimpleInjector(services);
            services.AddAutoMapper();
            services.AddMvc();
        }

        /// <summary>
        /// https://simpleinjector.readthedocs.io/en/latest/aspnetintegration.html
        /// https://github.com/simpleinjector/SimpleInjector/blob/master/src/SimpleInjector.Integration.AspNetCore.Mvc.Core/SimpleInjectorControllerActivator.cs
        /// </summary>
        /// <param name="services"></param>
        /// 
        private void IntegrateSimpleInjector(IServiceCollection services)
        {

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(container));

            services.AddSingleton<IViewComponentActivator>(new SimpleInjectorViewComponentActivator(container));

            services.EnableSimpleInjectorCrossWiring(container);
            services.UseSimpleInjectorAspNetRequestScoping(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            InitializeContainer(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                      name: "default",
                      template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        private void InitializeContainer(IApplicationBuilder app)
        {
            //add application presentation components
            container.RegisterMvcControllers(app);
            container.RegisterMvcViewComponents(app);

            //add application services. For instance
            //================================================APPLICATION========================================================
            container.Register(typeof(InterfaceAppServiceBase<>), typeof(AppServiceBase<>).Assembly, Lifestyle.Scoped);
            container.Register<InterfaceClienteAppService, ClienteAppService>(Lifestyle.Scoped);
            container.Register<InterfaceProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);

            //================================================DOMAIN============================================================
            container.Register(typeof(InterfaceServiceBase<>), typeof(ServiceBase<>).Assembly, Lifestyle.Scoped);
            container.Register<InterfaceClienteService, ClienteService>(Lifestyle.Scoped);
            container.Register<InterfaceProdutoService, ProdutoService>(Lifestyle.Scoped);

            //===============================================INFRASTRUCTURE=====================================================
            container.Register(typeof(InterfaceRepositoryBase<>), typeof(RepositoryBase<>).Assembly, Lifestyle.Scoped);
            container.Register<InterfaceClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            container.Register<InterfaceProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);

            //allow Simple Injector to resolve services from ASP.NET Core
            container.AutoCrossWireAspNetComponents(app);
        }
    }
}
