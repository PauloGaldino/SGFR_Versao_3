using Application.Applications;
using Application.Applications.Cadastro.Pessoas;
using Application.Applications.Cadastro.Pessoas.Clientes;
using Application.Applications.Cadastro.Pessoas.Contatos;
using Application.Applications.Cadastro.Pessoas.Contatos.Emails;
using Application.Applications.Cadastro.Pessoas.Contatos.Enderecos;
using Application.Applications.Cadastro.Pessoas.Contatos.Telefones;
using Application.Applications.Cadastro.Pessoas.Tipos;
using Application.Applications.ControleEstoque;
using Application.Applications.Producao;
using Application.Applications.Vendas;
using Application.Interfaces;
using Application.Interfaces.Cadastro;
using Application.Interfaces.Cadastro.Pessoas;
using Application.Interfaces.Cadastro.Pessoas.Contatos;
using Application.Interfaces.Cadastro.Pessoas.Contatos.Emails;
using Application.Interfaces.Cadastro.Pessoas.Contatos.Enderecos;
using Application.Interfaces.Cadastro.Pessoas.Contatos.Telefones;
using Application.Interfaces.Cadastro.Pessoas.Tipos;
using Application.Interfaces.ControleEstoque;
using Application.Interfaces.Producao;
using Application.Interfaces.Vendas;
using AutoMapper;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Cadastro.Pessoas;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Clientes;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Emails;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Repositories.ControleEstoque;
using Domain.Interfaces.Repositories.Producao;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services;
using Domain.Interfaces.Services.Cadastro.Pessoas;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Emails;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Services.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Services.ControleEstoque;
using Domain.Interfaces.Services.Producao;
using Domain.Interfaces.Services.Vendas;
using Domain.Services;
using Domain.Services.Cadastro.Pessoas;
using Domain.Services.Cadastro.Pessoas.Clientes;
using Domain.Services.Cadastro.Pessoas.Contatos;
using Domain.Services.Cadastro.Pessoas.Contatos.Emails;
using Domain.Services.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Services.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Services.Cadastro.Pessoas.Tipos;
using Domain.Services.ControleEstoque;
using Domain.Services.Producao;
using Domain.Services.Vendas;
using InfraData.Data.Context;
using InfraData.Repositories;
using InfraData.Repositories.Cadastro.Pessoas;
using InfraData.Repositories.Cadastro.Pessoas.Clientes;
using InfraData.Repositories.Cadastro.Pessoas.Contatos;
using InfraData.Repositories.Cadastro.Pessoas.Contatos.Emails;
using InfraData.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using InfraData.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using InfraData.Repositories.Cadastro.Pessoas.Tipo;
using InfraData.Repositories.ControleEstoque;
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
using SGFR_Web.AutoMapper;
using SGFR_Web.Data;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;
using System.ComponentModel;
using Container = SimpleInjector.Container;

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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<DbContextoGeral>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));


            services.AddDbContext<DbContextoGeral>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //======================Mysql===========================================
            //services.AddDbContext<ApplicationDbContext>(options =>
            //   options.UseMySql(
            //       Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<DbContextoGeral>(options =>
            //  options.UseMySql(
            //      Configuration.GetConnectionString("DefaultConnection")));


            //services.AddDbContext<DbContextoGeral>(options =>
            //  options.UseMySql(
            //      Configuration.GetConnectionString("DefaultConnection")));

            //================Fim Mysql=========================================

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

            #region Application      
            //add application services. For instance
            //====================================================APPLICATION========================================================
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>).Assembly, Lifestyle.Scoped);
            //===============================Pessoa=================================================
            container.Register<IPessoaAppService, PessoaAppService>(Lifestyle.Scoped);
            container.Register<IPessoaTipoAppService, PessoaTipoAppService>(Lifestyle.Scoped);
            //==============================Tipos===================================================
            container.Register<IFisicaAppService, FisicaAppService>(Lifestyle.Scoped);
            container.Register<IJuridicaAppService, JuridicaAppService>(Lifestyle.Scoped);
            //==============================Clientes================================================
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);

            //==============================Contatos================================================
            container.Register<IContatoAppService, ContatoAppService>(Lifestyle.Scoped);

            //===============================CONTATOS/EMAILS========================================
            //=============================Emails===================================================
            container.Register<IEmailAppService, EmailAppService>(Lifestyle.Scoped);
            //==============================Endereços===============================================
            container.Register<IEnderecoAppService, EnderecoAppService>(Lifestyle.Scoped);
            container.Register<IEnderecoClienteAppService, EnderecoClienteAppService>(Lifestyle.Scoped);
            container.Register<IEnderecoPessoaAppService, EnderecoPessoaAppService>(Lifestyle.Scoped);
            //=============================Telefones================================================
            container.Register<ITelefoneAppService, TelefoneAppService>(Lifestyle.Scoped);
            container.Register<ITelefoneTipoAppService, TelefoneTipoAppService>(Lifestyle.Scoped);

            //============================Compras===================================================
            //============================ControleEstoque===========================================
            container.Register<IEstoqueAppService, EstoqueAppService>(Lifestyle.Scoped);
            //============================Produção==================================================
            container.Register<ICategoriaAppService, CategoriaAppService>(Lifestyle.Scoped);
            container.Register<IProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);
            //============================Vendas====================================================
            container.Register<IDetalhePedidoAppService, DetalhePedidoAppService>(Lifestyle.Scoped);
            container.Register<IDetalheVendaAppService, DetalheVendaAppService>(Lifestyle.Scoped);
            container.Register<IImpostoAppService, ImpostoAppService>(Lifestyle.Scoped);
            container.Register<IPedidoAppService, PedidoAppService>(Lifestyle.Scoped);
            container.Register<IVendaAppService, VendaAppService>(Lifestyle.Scoped);

            #endregion

            #region Domain
            //================================================DOMAIN===================================================================
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>).Assembly, Lifestyle.Scoped);

            //==========================Pessoas==========================================================
            container.Register<IPessoaService, PessoaService>(Lifestyle.Scoped);
            container.Register<IPessoaTipoService, PessoaTipoService>(Lifestyle.Scoped);
            //==========================Tipos============================================================
            container.Register<IFisicaService, FisicaService>(Lifestyle.Scoped);
            container.Register<IJuridicaService, JuridicaService>(Lifestyle.Scoped);
            //==========================Clientes=========================================================
            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);

            //=========================Contatos==========================================================
            container.Register<IContatoService, ContatoService>(Lifestyle.Scoped);

            //============================CONTATOS/EMAILS================================================
            //==========================Emails===========================================================
            container.Register<IEmailService, EmailService>(Lifestyle.Scoped);
            //==========================Endereços========================================================
            container.Register<IEnderecoService, EnderecoService>(Lifestyle.Scoped);
            container.Register<IEnderecoPessoaService, EnderecoPessoaService>(Lifestyle.Scoped);
            container.Register<IEnderecoClienteService, EnderecoClienteService>(Lifestyle.Scoped);
            //==========================Telefone=========================================================
            container.Register<ITelefoneService, TelefoneService>(Lifestyle.Scoped);
            container.Register<ITelefoneTipoService, TelefoneTipoService>(Lifestyle.Scoped);

            //==========================Compras==========================================================

            //==========================ControleEstoque==================================================
            container.Register<IEstoqueService, EstoqueService>(Lifestyle.Scoped);
            //==========================Produção=========================================================
            container.Register<ICategoriaService, CategoriaService>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);

            //==========================Vendas===========================================================
            container.Register<IDetalhePedidoService, DetalhePedidoService>(Lifestyle.Scoped);
            container.Register<IDetalheVendaService, DetalheVendaService>(Lifestyle.Scoped);
            container.Register<IImpostoService, ImpostoService>(Lifestyle.Scoped);
            container.Register<IPedidoService, PedidoService>(Lifestyle.Scoped);
            container.Register<IVendaService, VendaService>(Lifestyle.Scoped);

            #endregion

            #region Infrastructure
            //===============================================INFRASTRUCTURE==============================================================
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>).Assembly, Lifestyle.Scoped);
            //==========================Pessoas==========================================================
            container.Register<IPessoaRepository, PessoaRepository>(Lifestyle.Scoped);
            container.Register<IPessoaTipoRepository, PessoaTipoRepository>(Lifestyle.Scoped);
            //==========================Tipos============================================================
            container.Register<IJuridicaRepository, JuridicaRepository>(Lifestyle.Scoped);
            container.Register<IFisicaRepository, FisicaRepository>(Lifestyle.Scoped);
            //==========================Clientes=========================================================
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);

            //==========================Contatos=========================================================
            container.Register<IContatoRepository, ContatoRepository>(Lifestyle.Scoped);

            //=============================CONTATOS/EMAILS===============================================
            //==========================Emails===========================================================
            container.Register<IEmailRepository, EmailRepository>(Lifestyle.Scoped);
            //==========================Endereços========================================================
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoClienteRepository, EnderecoClienteRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoPessoaRepository, EnderecoPessoaRepository>(Lifestyle.Scoped);
            //==========================Telefone=========================================================
            container.Register<ITelefoneRepository, TelefoneRepository>(Lifestyle.Scoped);
            container.Register<ITelefoneTipoRepository, TelefoneTipoRepository>(Lifestyle.Scoped);
            //==========================Compras==========================================================
            //==========================ControleEstoque==================================================
            container.Register<IEstoqueRepository, EstoqueRepository>(Lifestyle.Scoped);
            //==========================Produção========================================================= 
            container.Register<ICategoriaRepository, CategoriaRepository>(Lifestyle.Scoped);
            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);
            //==========================Vendas===========================================================
            container.Register<IDetalhePedidoRepository, DetalhePedidoRepository>(Lifestyle.Scoped);
            container.Register<IDetalheVendaRepository, DetalheVendaRepository>(Lifestyle.Scoped);
            container.Register<IImpostoRepository, ImpostoRepository>(Lifestyle.Scoped);
            container.Register<IPedidoRepository, PedidoRepository>(Lifestyle.Scoped);
            container.Register<IVendaRepository, VendaRepository>(Lifestyle.Scoped);

            #endregion
            //allow Simple Injector to resolve services from ASP.NET Core
            container.AutoCrossWireAspNetComponents(app);
        }
    }
}

