using Domain.Entities.Cadastro;
using Domain.Entities.Producao;
using InfraData.Data.Configurations.Cadastro;
using InfraData.Data.Configurations.Producao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace InfraData.Data.Context
{

    public class DbContextoGeral : DbContext
    {
      
        public DbContextoGeral(DbContextOptions<DbContextoGeral> options) : base(options)
        {

        }
        public DbContextoGeral() { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");

            modelBuilder.Entity<Produto>().ToTable("Produto");


            modelBuilder.ApplyConfiguration(new ClienteConfiguration());


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
            //string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SG_Fsbrica_Versao2; Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
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