using Domain.Entities.Vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Vendas
{
    public class DetalheVendaConfiguration : IEntityTypeConfiguration<DetalheVenda>
    {
        public void Configure(EntityTypeBuilder<DetalheVenda> builder)
        {
            builder.HasKey(v => v.DetalheVendaId);

            builder.Property(v => v.Descricao)
               .HasColumnName("Descricao")
               .HasMaxLength(200)
               .IsRequired();

            builder.Property(v => v.Preco)
                .HasColumnName("Preco")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(v => v.AliquotaFiscal)
              .HasColumnName("AliquotaFiscal")
              .HasColumnType("decimal(18,2)")
              .IsRequired();

            builder.Property(v => v.Quantidade)
                .HasColumnName("Quantidade")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            //Venda -->
            builder.HasOne(x => x.Venda)
                       .WithMany(x => x.DetalhesVendas)
                       .HasForeignKey(x => x.VendaId)
                       .OnDelete(DeleteBehavior.Restrict);

            //Produto<--
            builder.HasOne(x => x.Produto)
                       .WithMany(x => x.DetalhesVendas)
                       .HasForeignKey(x => x.ProdutoId)
                       .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
