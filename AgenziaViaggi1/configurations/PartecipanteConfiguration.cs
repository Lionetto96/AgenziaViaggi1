using AgenziaViaggi1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi1
{
    internal class PartecipanteConfiguration : IEntityTypeConfiguration<Partecipante>
    {
        public void Configure(EntityTypeBuilder<Partecipante> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Cognome).HasMaxLength(30).IsRequired();

            builder.HasMany(p => p.Gite).WithMany(p => p.Partecipanti);
        }
    }
}