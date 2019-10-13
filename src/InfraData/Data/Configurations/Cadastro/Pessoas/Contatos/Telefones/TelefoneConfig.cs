using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneConfig : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(t => t.TelefoneId);

            builder.Property(t => t.Numero)
                .HasColumnType("varchar(30)")
                .IsRequired();
        }
    }
}
