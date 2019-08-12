using Domain.Entities.Producao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Producao
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {

            builder.HasKey(c => c.CategoriaId);
                


            builder.Property(c => c.Descricao)
                .HasMaxLength(100)
                .HasColumnName("Descricao")
                .IsRequired();

            //Um para muitos
            builder.HasMany(c => c.Produtos)
                .WithOne(c => c.Categoria)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
