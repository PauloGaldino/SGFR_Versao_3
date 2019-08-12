using Domain.Entities.Vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Vendas
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {

            builder.HasKey(v => v.VendaId);

            builder.Property(v => v.Data)
               .HasColumnType("DateTime")
               .IsRequired();

            builder.Property(v => v.Observacao)
                .HasColumnName("Observacao")
                .HasMaxLength(150)
               .IsRequired();

            builder.HasOne(v =>v.Cliente)
                .WithMany(v =>v.Vendas)
                .HasForeignKey(v =>v.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
