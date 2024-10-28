using Creationals.Builder.Concepts.Products;

namespace Creationals.Builder.Concepts.Builders;
public interface IUserProfileBuilder
{
    IUserProfileBuilder BuildPersonalityInfo(string firstName,string lastName,string email);
    IUserProfileBuilder BuildAddress(string city, string address, string zipCode);
    IUserProfileBuilder BuildCellPhone(string cellPhonNO);

    UserProfile Build();
}
