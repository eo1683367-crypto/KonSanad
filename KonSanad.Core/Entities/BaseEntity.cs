using System.ComponentModel.DataAnnotations;

public abstract class BaseEntity<TKey>
{
    [Key]
    public required TKey Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public string Status { get; set; } = string.Empty;

    public bool IsDeleted { get; set; }

    [Timestamp]
    public byte[]? RowVersion { get; set; }

    public void SetCreated() => CreatedAt = DateTime.UtcNow;
    public void SetUpdated() => UpdatedAt = DateTime.UtcNow;
    public void MarkDeleted() => IsDeleted = true;

    //s
}
