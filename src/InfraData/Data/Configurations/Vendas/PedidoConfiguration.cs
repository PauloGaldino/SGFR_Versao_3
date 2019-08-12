using Domain.Entities.Vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Vendas
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.PedidoId);

            builder.Property(p => p.Data)
               .HasColumnType("DateTime")
               .IsRequired();

            builder.Property(p => p.Observacao)
                .HasColumnName("Observacao")
                .HasMaxLength(150)
               .IsRequired();

            builder.HasOne(v => v.Cliente)
              .WithMany(v => v.Pedidos)
              .HasForeignKey(v => v.ClienteId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

