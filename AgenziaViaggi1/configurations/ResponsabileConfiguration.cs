using AgenziaViaggi1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi1
{
    internal class ResponsabileConfiguration : IEntityTypeConfiguration<Responsabile>
    {
        public void Configure(EntityTypeBuilder<Responsabile> builder)
        {
            builder.Property(r => r.NumeroTelefono).HasMaxLength(15);
            builder.HasMany(r => r.Gite).WithOne(r => r.Responsabile).HasForeignKey(r => r.ResponsabileID);
        }
    }
}