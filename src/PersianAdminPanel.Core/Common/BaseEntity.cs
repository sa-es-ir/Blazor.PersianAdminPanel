﻿namespace PersianAdminPanel.Core.Common;

public abstract class BaseEntity : IEntity
{
    public long Id { get; protected set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
