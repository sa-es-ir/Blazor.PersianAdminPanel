using PersianAdminPanel.Core.Common;

namespace PersianAdminPanel.Core.Entities;

public class UserEntity : BaseEntity<Guid>
{
    #region Ctor

    private UserEntity() { }

    public UserEntity(string firstName, string laseName, string email)
    {
        FirstName = firstName;
        LaseName = laseName;
        Email = email;
    }

    #endregion

    public string FirstName { get; private set; }
    public string LaseName { get; private set; }
    public string Email { get; private set; }
}

// TODO: Add IdentityUser in the future