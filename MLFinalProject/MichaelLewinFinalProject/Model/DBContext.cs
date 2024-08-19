using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MichaelLewinFinalProject.Model
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    ConfigurationManager.ConnectionStrings["Music"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Albums>(entity =>
            {
                entity.HasKey(e => e.AlbumId)
                    .HasName("PK__albums__B0E1DDB2FB5FFE6E");

                entity.Property(e => e.AlbumGenre).IsUnicode(false);

                entity.Property(e => e.AlbumRecordLabel).IsUnicode(false);

                entity.Property(e => e.AlbumTitle).IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__albums__artist_i__267ABA7A");
            });

            modelBuilder.Entity<Artists>(entity =>
            {
                entity.HasKey(e => e.ArtistId)
                    .HasName("PK__artists__6CD040011E03161C");

                entity.Property(e => e.BirthName).IsUnicode(false);

                entity.Property(e => e.Hometown).IsUnicode(false);

                entity.Property(e => e.StageName).IsUnicode(false);
            });

            modelBuilder.Entity<Songs>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("PK__songs__A535AE1C965918DB");

                entity.Property(e => e.SongTitle).IsUnicode(false);

                entity.Property(e => e.SongWriter).IsUnicode(false);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK__songs__album_id__2A4B4B5E");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__songs__artist_id__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
