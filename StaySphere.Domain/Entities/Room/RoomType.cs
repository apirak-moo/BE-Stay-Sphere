namespace StaySphere.Domain.Entities.Room;

public class RoomType : Entity<int>
{
    public string NameTh { get; set; } = null!;
    public string NameEn { get; set; } = null!;
    public bool IsActive { get; set; }
}
