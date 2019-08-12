using Domain.Entities.Cadastro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Cadastro
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);


            builder.Property(c => c.Nome)
                .HasColumnType("varchar (160)")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.DataCadastro)
               .IsRequired();

            builder.Property(c=> c.Ativo)
               .IsRequired();

            //muitos para um
            builder.HasMany(c => c.Pedidos)
                .WithOne(c => c.Cliente)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasMany(c => c.Vendas)
                .WithOne(c => c.Cliente)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
