using Microsoft.AspNetCore.Identity;
using PersianAdminPanel.Core.Common;

namespace PersianAdminPanel.Core.Identity.Entities;

public sealed class AppUser : IdentityUser<Guid>, IEntity
{
    #region Ctor

    public AppUser(string firstName, string lastName, string userName, string? phoneNumber, string? email)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber) && string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException("Enter PhoneNumber or Email");

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        PhoneNumber = phoneNumber;
        Email = email;
        IsActive = true;
    }

    #endregion

    #region Properties

    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
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