using Domain.Entities.Cadastro;
using Domain.Entities.Producao;
using Domain.Entities.Vendas;
using InfraData.Data.Configurations.Cadastro;
using InfraData.Data.Configurations.Producao;
using InfraData.Data.Configurations.Vendas;
using InfraData.Repositories.Vendas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using VendaConfiguration = InfraData.Data.Configurations.Vendas.VendaConfiguration;

namespace InfraData.Data.Context
{

    public class DbContextoGeral : DbContext
    {

        public DbContextoGeral(DbContextOptions<DbContextoGeral> options) : base(options){}
        public DbContextoGeral() { }

        public DbSet<Imposto> Imposto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetalhePedido> DetalhesPedidos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<DetalheVenda> DetalhesVendass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imposto>().ToTable("Imposto");

            modelBuilder.Entity<Categoria>().ToTable("Categoria");

            modelBuilder.Entity<Cliente>().ToTable("Cliente");

            modelBuilder.Entity<Produto>().ToTable("Produto");

            modelBuilder.Entity<Venda>().ToTable("Venda");
            modelBuilder.Entity<DetalheVenda>().ToTable("DetalheVenda");

            modelBuilder.Entity<Pedido>().ToTable("Pedido");
            modelBuilder.Entity<DetalhePedido>().ToTable("DetalhePedido");

            modelBuilder.ApplyConfiguration(new ImpostoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());

            modelBuilder.ApplyConfiguration(new VendaConfiguration());
            modelBuilder.ApplyConfiguration(new DetalheVendaConfiguration());

            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new DetalhePedidoConfiguration());

            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(GetStringConectionConfig());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
           // string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SG_Fabrica; Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            string strCon = "Data Source = localhost;database=SG_Refrigerante;user=root;password=admin";
            return strCon;
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }


            }
            return base.SaveChanges();
        }
    }
}