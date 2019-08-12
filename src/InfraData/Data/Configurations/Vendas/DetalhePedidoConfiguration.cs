using Domain.Entities.Vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Vendas
{
    public class DetalhePedidoConfiguration : IEntityTypeConfiguration<DetalhePedido>
    {
        public void Configure(EntityTypeBuilder<DetalhePedido> builder)
        {
            builder.HasKey(v => v.DetalhePedidoId);

            builder.Property(p => p.Descricao)
                .HasMaxLength(150)
                .HasColumnName("Descricao")
                .IsRequired();

            builder.Property(v => v.Preco)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("Preco")
                .IsRequired();

            builder.Property(v => v.AliquotaFiscal)
               .HasColumnType("decimal(18,2)")
               .HasColumnName("AliquotaFiscal")
               .IsRequired();

            builder.Property(v => v.Quantidade)
               .HasColumnName("Quantidade")
               .IsRequired();

            //Pedido -->
            builder.HasOne(x => x.Pedido)
               .WithMany(x => x.DetalhesPedidos)
               .HasForeignKey(x => x.PedidoId)
               .OnDelete(DeleteBehavior.Restrict);

            //Produto<--
            builder.HasOne(x => x.Produto)
                .WithMany(x => x.DetalhesPedidos)
                .HasForeignKey(x => x.ProdutoId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
