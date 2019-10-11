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
                .HasOne(em => em.Pessoa)
                .WithMany(em => em.Emails)
                .HasForeignKey(em => em.PessoaId)
                .HasPrincipalKey(em => em.PessoaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(em => em.EnderecoEmail)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
