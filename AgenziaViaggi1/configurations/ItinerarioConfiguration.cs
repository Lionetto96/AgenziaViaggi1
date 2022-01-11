using AgenziaViaggi1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi1
{
    internal class ItinerarioConfiguration : IEntityTypeConfiguration<Itinerario>
    {
        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.HasMany(i => i.Gite).WithOne(i => i.Itinerario).HasForeignKey(i => i.ItinerarioID);
        }
    }
}