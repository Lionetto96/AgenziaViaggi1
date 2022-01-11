using AgenziaViaggi1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi1
{
    internal class GitaConfiguration : IEntityTypeConfiguration<Gita>
    {
        public void Configure(EntityTypeBuilder<Gita> builder)
        {
            builder.Property(g => g.DataPartenza).IsRequired();
            builder.HasOne(g => g.Responsabile).WithMany(g=>g.Gite).HasForeignKey(r => r.ResponsabileID).HasConstraintName("FkResponsabile");
            builder.HasOne(g => g.Itinerario).WithMany(g => g.Gite).HasForeignKey(g => g.ItinerarioID).HasConstraintName("FkItinerario");
            builder.HasMany(g => g.Partecipanti).WithMany(g => g.Gite);
        }
    }
}