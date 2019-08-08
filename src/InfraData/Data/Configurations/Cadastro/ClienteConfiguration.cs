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


            builder.Property(p => p.Nome)
                .HasColumnType("varchar (160)")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(e => e.DataCadastro)
               .IsRequired();

            builder.Property(e => e.Ativo)
               .IsRequired();
        }
    }
}
