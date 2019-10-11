using Domain.Entities.Cadastro.Pessoas.Tipos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Cadastro.Pessoas.Tipos
{
    public class FisicaConfig : IEntityTypeConfiguration<Fisica>
    {
        public void Configure(EntityTypeBuilder<Fisica> builder)
        {
            builder.HasKey(f => f.FisicaId);

            builder.Property(f => f.Cpf)
                .HasColumnType("varchar(15)")
                .IsUnicode()
                .IsRequired();

            builder.Property(f => f.Rg)
                .HasColumnType("varchar (15)")
                .IsRequired();

        }
    }
}