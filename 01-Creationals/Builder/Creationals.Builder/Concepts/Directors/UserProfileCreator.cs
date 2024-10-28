using Creationals.Builder.Concepts.Builders;

namespace Creationals.Builder.Concepts.Directors;
public class UserProfileCreator
{
    public void PrepareUserProfile(IUserProfileBuilder userProfileBuilder,bool isAdmin)
    {
        userProfileBuilder
            .BuildPersonalityInfo("Alireza", "Nikravesh", "a.z.nikravesh@gmail.com")
            .BuildCellPhone("0123456789")
            .BuildAddress("City", "Address", "ZipCode")
            .BuildIsAdmin(isAdmin);
    }
}
