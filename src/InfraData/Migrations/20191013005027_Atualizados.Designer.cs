﻿// <auto-generated />
using System;
using InfraData.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfraData.Migrations
{
    [DbContext(typeof(DbContextoGeral))]
    [Migration("20191013005027_Atualizados")]
    partial class Atualizados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar (160)");

                    b.Property<int>("PessoaId");

                    b.HasKey("ClienteId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmailId");

                    b.Property<int>("PessoaId");

                    b.Property<int>("TelefoneId");

                    b.HasKey("ContatoId");

                    b.HasIndex("EmailId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Emails.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnderecoEmail")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmailId");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar (15)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar (100)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("char (2)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.EnderecoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<int>("EnderecoId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("EnderecoClientes");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.EnderecoPessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnderecoId");

                    b.Property<int>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("EnderecosPessoas");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", b =>
                {
                    b.Property<int>("TelefoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Numero");

                    b.Property<int>("TelefoneTipoId");

                    b.HasKey("TelefoneId");

                    b.HasIndex("TelefoneTipoId")
                        .IsUnique();

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.TelefoneTipo", b =>
                {
                    b.Property<int>("TelefoneTipoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.HasKey("TelefoneTipoId");

                    b.ToTable("TelefoneTipo");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.Property<int>("PessoaTipoId");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("PessoaId");

                    b.HasIndex("PessoaTipoId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.PessoaTipo", b =>
                {
                    b.Property<int>("PessoaTipoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar (10)");

                    b.HasKey("PessoaTipoId");

                    b.ToTable("PessoaTipo");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Tipos.Fisica", b =>
                {
                    b.Property<int>("FisicaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .IsUnicode(true);

                    b.Property<int>("PessoaId");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("varchar (15)");

                    b.HasKey("FisicaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("FIsica");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Tipos.Juridica", b =>
                {
                    b.Property<int>("JuridicaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DataFundacao");

                    b.Property<string>("InscricaoEstadual")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar (200)");

                    b.Property<int>("PessoaId");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("Varchar (200)");

                    b.HasKey("JuridicaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Juridica");
                });

            modelBuilder.Entity("Domain.Entities.ControleEstoque.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Domain.Entities.Producao.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(100);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Domain.Entities.Producao.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CategoriaId");

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Disponivel");

                    b.Property<int>("ImpostoId");

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ImpostoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalhePedido", b =>
                {
                    b.Property<int>("DetalhePedidoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AliquotaFiscal")
                        .HasColumnName("AliquotaFiscal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(150);

                    b.Property<int>("PedidoId");

                    b.Property<decimal>("Preco")
                        .HasColumnName("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade")
                        .HasColumnName("Quantidade");

                    b.HasKey("DetalhePedidoId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("DetalhePedido");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalheVenda", b =>
                {
                    b.Property<int>("DetalheVendaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AliquotaFiscal")
                        .HasColumnName("AliquotaFiscal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(200);

                    b.Property<decimal>("Preco")
                        .HasColumnName("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProdutoId");

                    b.Property<decimal>("Quantidade")
                        .HasColumnName("Quantidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VendaId");

                    b.HasKey("DetalheVendaId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("DetalheVenda");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Imposto", b =>
                {
                    b.Property<int>("ImpostoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(100);

                    b.Property<float>("Taxa")
                        .HasColumnName("Taxa");

                    b.HasKey("ImpostoId");

                    b.ToTable("Imposto");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DateTime");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnName("Observacao")
                        .HasMaxLength(150);

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Venda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DateTime");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnName("Observacao")
                        .HasMaxLength(150);

                    b.Property<int>("PedidoId");

                    b.HasKey("VendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany("Clientes")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Contato", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Emails.Email", "Email")
                        .WithMany()
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany("Contatos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.EnderecoCliente", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.EnderecoPessoa", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos.Endereco", "Endereco")
                        .WithMany("EnderecosPessoas")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.TelefoneTipo", "TelefoneTipo")
                        .WithOne("Telefone")
                        .HasForeignKey("Domain.Entities.Cadastro.Pessoas.Contatos.Telefones.Telefone", "TelefoneTipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Pessoa", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.PessoaTipo", "PessoaTipo")
                        .WithMany("Pessoas")
                        .HasForeignKey("PessoaTipoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Tipos.Fisica", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Cadastro.Pessoas.Tipos.Juridica", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.ControleEstoque.Estoque", b =>
                {
                    b.HasOne("Domain.Entities.Producao.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Producao.Produto", b =>
                {
                    b.HasOne("Domain.Entities.Producao.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany("Produtos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Vendas.Imposto", "Imposto")
                        .WithMany("Produto")
                        .HasForeignKey("ImpostoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalhePedido", b =>
                {
                    b.HasOne("Domain.Entities.Vendas.Pedido", "Pedido")
                        .WithMany("DetalhesPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Producao.Produto", "Produto")
                        .WithMany("DetalhesPedidos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.DetalheVenda", b =>
                {
                    b.HasOne("Domain.Entities.Producao.Produto", "Produto")
                        .WithMany("DetalhesVendas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Vendas.Venda", "Venda")
                        .WithMany("DetalhesVendas")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Vendas.Venda", b =>
                {
                    b.HasOne("Domain.Entities.Cadastro.Pessoas.Clientes.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Vendas.Pedido", "Pedido")
                        .WithMany("Vendas")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
