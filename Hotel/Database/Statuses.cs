using System.Collections.Generic;

namespace Hotel.Database;

/// <summary>
/// Класс, описывающий статусы постояльцев отеля.
/// </summary>
public partial class Statuses
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<HotelGuests> HotelGuestsTables { get; set; } = new List<HotelGuests>();
}