using Domain.Entities.Cadastro.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Cadastro.Pessoas
{
    public class PessoaTipoConfig : IEntityTypeConfiguration<PessoaTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaTipo> builder)
        {
            builder.HasKey(pt => pt.PessoaTipoId);

            builder.Property(pt => pt.Descricao)
                .HasColumnType("varchar (10)")
                .IsRequired();
        }
    }
}
