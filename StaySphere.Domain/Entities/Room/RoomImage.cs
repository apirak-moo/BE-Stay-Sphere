namespace StaySphere.Domain.Entities.Room;

public class RoomImage : Entity<Guid>
{
    public string Url { get; set; } = null!;

    public Guid RoomId { get; set; }
    public Room Room { get; set; } = null!;
}
