
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<PessoaEntity>
    {


        public void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Documento).IsUnique();

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);

            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);

            builder.Property(c => c.Documento).IsRequired().HasMaxLength(100);

            builder.Property(c => c.Idade).IsRequired();

            builder.Property(c => c.Profissao).IsRequired().HasMaxLength(100);

        }
    }
}
