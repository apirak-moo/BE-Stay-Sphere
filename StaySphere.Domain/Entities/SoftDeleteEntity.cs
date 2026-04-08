namespace StaySphere.Domain.Entities;

public abstract class SoftDeleteEntity<T> : AuditEntity<T>
{
    public DateTime? DeletedAt { get; set; }
    public string? DeletedBy { get; set; }
}
