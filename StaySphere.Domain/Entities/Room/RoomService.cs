namespace StaySphere.Domain.Entities.Room;

public class RoomService : Entity<int>
{
    public string NameTh { get; set; } = null!;
    public string NameEn { get; set; } = null!;
    public string? Icon { get; set; } = null!;
}
