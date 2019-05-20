namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QR_Data : DbContext
    {
        public QR_Data()
            : base("name=QR_Data")
        {
        }

        public virtual DbSet<qrData> qrData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<qrData>()
                .Property(e => e.EAB)
                .IsUnicode(false);

            modelBuilder.Entity<qrData>()
                .Property(e => e.Local)
                .IsUnicode(false);

            modelBuilder.Entity<qrData>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<qrData>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<qrData>()
                .Property(e => e.Med)
                .IsUnicode(false);

            modelBuilder.Entity<qrData>()
                .Property(e => e.Pos)
                .IsUnicode(false);
        }
    }
}
