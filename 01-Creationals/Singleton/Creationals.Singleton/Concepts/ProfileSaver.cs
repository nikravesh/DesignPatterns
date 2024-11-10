namespace Creationals.Singleton.Concepts;
public class ProfileSaver
{
    private static object _lockObject = new();

    private static ProfileSaver _instance;
    public static ProfileSaver Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_lockObject)
                {
                    if(_instance is null)
                        return _instance = new ProfileSaver();
                    return _instance;
                }
            }
            else
                return _instance;
        }
    }

    private ProfileSaver()
    {
    }

    public void Save()
    {
        //save user profile as a xml or json
    }

    public void Load() 
    {
        //load the xml or json and create user profile
    }
}
