using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.Data.Configurations.Cadastro.Pessoas.Contatos.Emails
{
    public class EmailConfig : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasKey(em => em.EmailId);

        
            builder
                .Property(em => em.EnderecoEmail)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
