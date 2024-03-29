﻿using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.EnderecoId);

            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar (200)")
                .IsRequired();

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar (100)");

            builder.Property(e => e.CEP)
                .HasColumnType("varchar (15)")
                .IsRequired();

            builder.Property(e => e.Bairro)
                .HasColumnType("varchar (200)")
                .IsRequired();


            builder.Property(e => e.Cidade)
                .HasColumnType("varchar (200)")
                .IsRequired();


            builder.Property(e => e.Estado)
                .HasColumnType("char (2)")
                .IsRequired();

        }
    }
}