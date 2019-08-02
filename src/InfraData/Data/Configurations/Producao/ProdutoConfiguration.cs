﻿using Domain.Entities.Producao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Producao
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.PrecoUnitario)
              .HasColumnType("decimal(18,2)")
              .IsRequired();

            builder.Property(p => p.Lote)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.DataFabricacao)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                .IsRequired();

            builder.Property(p => p.DataValidade)
               .HasColumnType("datetime")
               .HasDefaultValueSql("(getdate())")
               .IsRequired();

            builder.Property(e => e.DataCadastro)
               .IsRequired();

            builder.Property(e => e.Ativo)
               .IsRequired();
        }
    }
}