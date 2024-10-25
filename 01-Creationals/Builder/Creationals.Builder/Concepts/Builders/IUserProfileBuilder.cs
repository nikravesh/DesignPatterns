namespace Creationals.Builder.Concepts.Builders;
public interface IUserProfileBuilder
{
    void SetPersonalityInfo(string firstName,string lastName,string email);
    void SetAddress(string city, string address, string zipCode);
    void SetCellPhone(string cellPhonNO);
}
