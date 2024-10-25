using Creationals.Builder.Concepts.Builders;
using Creationals.Builder.Concepts.Products;

namespace Creationals.Builder.Concepts.ConcreteClasses;
public class UserProfileConcrete : IUserProfileBuilder
{
    private UserProfile _profile;

    public UserProfileConcrete()
    {
        _profile = new UserProfile();
    }

    public void SetAddress(string city, string address, string zipCode)
    {
        _profile.City = city;
        _profile.Address = address;
        _profile.ZipCode = zipCode;
    }

    public void SetCellPhone(string cellPhonNO)
    {
        _profile.CellPhone = cellPhonNO;
    }

    public void SetPersonalityInfo(string firstName, string lastName, string email)
    {
        _profile.FirstName = firstName;
        _profile.LastName = lastName;
        _profile.Email = email;
    }

    public UserProfile GetUserProfile() =>
        new()
        {
            FirstName = _profile.FirstName,
            LastName = _profile.LastName,
            Email = _profile.Email,
            CellPhone = _profile.CellPhone,
            Address = _profile.Address,
            City = _profile.City,
            ZipCode = _profile.ZipCode
        };
}
