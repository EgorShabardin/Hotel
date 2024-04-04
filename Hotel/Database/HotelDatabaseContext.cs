using Microsoft.EntityFrameworkCore;

namespace Hotel.Database;

/// <summary>
/// Класс, описывающий контекст базы данных для приложения "Отель".
/// </summary>
public partial class HotelDatabaseContext : DbContext
{
    public HotelDatabaseContext()
    {
    }

    public HotelDatabaseContext(DbContextOptions<HotelDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HotelGuests> HotelGuests { get; set; }

    public virtual DbSet<Statuses> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=../../../Database/HotelDatabase.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HotelGuests>(entity =>
        {
            entity.HasKey(e => e.GuestId);

            entity.ToTable("HotelGuestsTable");

            entity.HasOne(d => d.GuestStatusNavigation).WithMany(p => p.HotelGuestsTables)
                .HasForeignKey(d => d.GuestStatus)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Statuses>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("StatusesTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}