using Creationals.Builder.Concepts.Builders;

namespace Creationals.Builder.Concepts.Directors;
public class UserProfileCreator
{
    public void PrepareUserProfile(IUserProfileBuilder userProfileBuilder)
    {
        userProfileBuilder.SetPersonalityInfo("Alireza","Nikravesh","a.z.nikravesh@gmail.com");
        userProfileBuilder.SetCellPhone("0123456789");
        userProfileBuilder.SetAddress("City", "Address", "ZipCode");
    }
}
