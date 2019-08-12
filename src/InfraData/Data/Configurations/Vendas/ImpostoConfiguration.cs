using Domain.Entities.Vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Vendas
{
    public class ImpostoConfiguration : IEntityTypeConfiguration<Imposto>
    {
        public void Configure(EntityTypeBuilder<Imposto> builder)
        {
            builder.HasKey(i => i.ImpostoId);

            builder.Property(c => c.Descricao)
              .HasMaxLength(100)
              .HasColumnName("Descricao")
              .IsRequired();

            builder.Property(v => v.Taxa)
                .HasColumnName("Taxa")
                .IsRequired();
        }
    }
}
