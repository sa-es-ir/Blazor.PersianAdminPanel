using Microsoft.AspNetCore.Identity;
using PersianAdminPanel.Core.Common;

namespace PersianAdminPanel.Core.Identity.Entities;

public sealed class AppRole : IdentityRole<Guid>, IEntity
{
    #region Ctor

    public AppRole(string name, string displayName)
    {
        Id = Guid.NewGuid();
        Name = name;
        DisplayName = displayName;
    }

    #endregion

    #region Properties

    public string DisplayName { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    #endregion

    #region Methods

    public void UpdateIsActiveStatus(bool newStatus)
    {
        IsActive = newStatus;
    }

    #endregion
}
