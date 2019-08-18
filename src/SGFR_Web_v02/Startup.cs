using Application.Applications;
using Application.Applications.Cadastro;
using Application.Applications.Producao;
using Application.Applications.Vendas;
using Application.Interfaces;
using Application.Interfaces.Cadastro;
using Application.Interfaces.Producao;
using Application.Interfaces.Vendas;
using AutoMapper;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Cadastro;
using Domain.Interfaces.Repositories.Producao;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services;
using Domain.Interfaces.Services.Cadastro;
using Domain.Interfaces.Services.Producao;
using Domain.Interfaces.Services.Vendas;
using Domain.Services;
using Domain.Services.Cadastro;
using Domain.Services.Producao;
using Domain.Services.Vendas;
using InfraData.Data.Context;
using InfraData.Repositories;
using InfraData.Repositories.Cadastro;
using InfraData.Repositories.Producao;
using InfraData.Repositories.Vendas;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGFR_Web_v02.AutoMapper;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;

namespace SGFR_Web_v02
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
          
            services.AddDbContext<DbContextoGeral>(options =>
              options.UseMySql(
                  Configuration.GetConnectionString("DefaultConnection")));


            services.AddDbContext<DbContextoGeral>(options =>
              options.UseMySql(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<DbContextoGeral>();
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
            container.Register<InterfaceCategoriaAppService, CategoriaAppService>(Lifestyle.Scoped);
            container.Register<InterfaceClienteAppService, ClienteAppService>(Lifestyle.Scoped);
            container.Register<InterfaceProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);
            container.Register<InterfaceImpostoAppService, ImpostoAppService>(Lifestyle.Scoped);

            //================================================DOMAIN============================================================
            container.Register(typeof(InterfaceServiceBase<>), typeof(ServiceBase<>).Assembly, Lifestyle.Scoped);
            container.Register<InterfaceCategoriaService, CategoriaService>(Lifestyle.Scoped);
            container.Register<InterfaceClienteService, ClienteService>(Lifestyle.Scoped);
            container.Register<InterfaceProdutoService, ProdutoService>(Lifestyle.Scoped);
            container.Register<InterfaceImpostoService, ImpostoService>(Lifestyle.Scoped);

            //===============================================INFRASTRUCTURE=====================================================
            container.Register(typeof(InterfaceRepositoryBase<>), typeof(RepositoryBase<>).Assembly, Lifestyle.Scoped);
            container.Register<InterfaceCategoriaRepository, CategoriaRepository>(Lifestyle.Scoped);
            container.Register<InterfaceClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            container.Register<InterfaceProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);
            container.Register<InterfaceImpostoRepository, ImpostoRepository>(Lifestyle.Scoped);

            //allow Simple Injector to resolve services from ASP.NET Core
            container.AutoCrossWireAspNetComponents(app);
        }
    }
}
