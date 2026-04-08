namespace StaySphere.Domain.Entities;

public abstract class AuditEntity<T> : Entity<T>
{
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; } 
    public DateTime? UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
}
