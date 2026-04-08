namespace StaySphere.Domain.Entities.Room;

public class Room : SoftDeleteEntity<Guid>
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsActive { get; set; }

    public int TypeId { get; set; }
    public RoomType Type { get; set; } = null!;

    public List<RoomService> Services { get; set; } = [];

    public List<RoomImage> Images { get; set; } = [];
}
