using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyMusixAPI.Service.Api.Models
{
    public partial class MyMusiXContext : DbContext
    {
        public MyMusiXContext()
        {
        }

        public MyMusiXContext(DbContextOptions<MyMusiXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MusicData> MusicData { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyMusiX;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicData>(entity =>
            {
                entity.HasKey(e => e.Mid);

                entity.Property(e => e.Mid)
                    .HasColumnName("MId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtistName)
                    .HasColumnName("Artist_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Cost).HasMaxLength(50);

                entity.Property(e => e.Genere).HasMaxLength(50);

                entity.Property(e => e.MusicName)
                    .IsRequired()
                    .HasColumnName("Music_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);
            });
        }
    }
}
