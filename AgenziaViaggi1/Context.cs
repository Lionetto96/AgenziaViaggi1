using AgenziaViaggi1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi1
{
    internal class Context : DbContext
    {
        public DbSet<Gita> Gite { get; set; }
        public DbSet<Responsabile> Responsabili { get; set; }
        public DbSet<Partecipante> Partecipanti { get; set; }
        public DbSet<Itinerario> Itinerari { get; set; }
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgenziaViaggi1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Gita>(new GitaConfiguration());
            modelBuilder.ApplyConfiguration<Responsabile>(new ResponsabileConfiguration());
            modelBuilder.ApplyConfiguration<Partecipante>(new PartecipanteConfiguration());
            modelBuilder.ApplyConfiguration<Itinerario>(new ItinerarioConfiguration());
            //entità gita 
            //data partenza obbligatoria
            //modelBuilder.Entity<Gita>(g => g.Property(g => g.DataPartenza).IsRequired());
            //entità responsabile 
            //modelBuilder.Entity<Responsabile>(r => r.Property(r => r.NumeroTelefono).HasMaxLength(15));
            //relazione responsabile gita 1:n 
            //modelBuilder.Entity<Gita>(e => e.HasOne(g =>g.Responsabile ).WithMany(g => g.Gite).HasForeignKey(g => g.ResponsabileID).HasConstraintName("FkResponsabile"));
            //modelBuilder.Entity<Responsabile>(r => r.HasMany(r => r.Gite).WithOne(r => r.Responsabile).HasForeignKey(r => r.ResponsabileID));
            //// relazione itinerario gita 1:n
            //modelBuilder.Entity<Gita>(e => e.HasOne(g => g.Itinerario).WithMany(g => g.Gite).HasForeignKey(g => g.ItinerarioID).HasConstraintName("FkItinerario"));
            //modelBuilder.Entity<Itinerario>(i => i.HasMany(i => i.Gite).WithOne(i => i.Itinerario).HasForeignKey(i => i.ItinerarioID));
            //entità partecipante
            //modelBuilder.Entity<Partecipante>(p=>p.Property(p=>p.Nome).HasMaxLength(30).IsRequired());
            //modelBuilder.Entity<Partecipante>(p => p.Property(p => p.Cognome).HasMaxLength(30).IsRequired());
            ////relazione partecipante gita n:n 
            //modelBuilder.Entity<Gita>(e => e.HasMany(g => g.Partecipanti).WithMany(g => g.Gite));
            //modelBuilder.Entity<Partecipante>(p => p.HasMany(p => p.Gite).WithMany(p => p.Partecipanti));
        }
    }
}
