using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _0831dbtest
{
    public partial class mylessondbContext : DbContext
    {
        public mylessondbContext()
        {
        }

        public mylessondbContext(DbContextOptions<mylessondbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ManagerTable> ManagerTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:mylessondb.database.windows.net,1433;Initial Catalog=mylessondb;Persist Security Info=False;User ID=kanitama;Password=F@123123123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ManagerTable>(entity =>
            {
                entity.HasKey(e => e.Mid);

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.Mcountry)
                    .HasColumnName("mcountry")
                    .HasMaxLength(50);

                entity.Property(e => e.Mname)
                    .HasColumnName("mname")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mphone).HasColumnName("mphone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
