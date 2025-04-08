using PersianAdminPanel.Core.Common;

namespace PersianAdminPanel.Core.Entities;

public class UserEntity : BaseEntity
{
    #region Ctor

    private UserEntity() { }

    public UserEntity(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    #endregion

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
}

// TODO: Add IdentityUser in the future