using Creationals.Builder.Concepts.ConcreteClasses;
using Creationals.Builder.Concepts.Directors;
using Creationals.Builder.Concepts.Products;

namespace Creationals.Builder.Concepts;
internal class Client
{
    public Client()
    {
        UserProfileCreator userProfileCreator = new UserProfileCreator();
        UserProfileConcrete userProfile = new UserProfileConcrete();

        userProfileCreator.PrepareUserProfile(userProfile);
        UserProfile profile = userProfile.Build();
    }
}
