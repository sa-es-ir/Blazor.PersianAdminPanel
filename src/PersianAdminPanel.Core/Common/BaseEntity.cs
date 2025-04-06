namespace PersianAdminPanel.Core.Common;

public abstract class BaseEntity<TKey>
{
    public TKey Id { get; private set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
