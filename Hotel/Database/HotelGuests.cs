namespace Hotel.Database;

/// <summary>
/// Класс, описывающий постояльца отеля.
/// </summary>
public partial class HotelGuests
{
    public int GuestId { get; set; }

    public string GuestName { get; set; } = null!;

    public string GuestSurname { get; set; } = null!;

    public string GuestPatronymic { get; set; } = null!;

    public byte[] GuestPhoto { get; set; } = null!;

    public int GuestStatus { get; set; }

    public string GuestCheckInDate { get; set; } = null!;

    public string GuestCheckOutDate { get; set; } = null!;

    public string GuestBirthday { get; set; } = null!;

    public int IsTravelingWithAnimals { get; set; }

    public virtual Statuses GuestStatusNavigation { get; set; } = null!;
}