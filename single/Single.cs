namespace single;

public class Single
{
    private static Single instance;
    
    private Single()
    {
        instance = new Single();
    }
    
    public static Single GetInstance()
    {
        if (instance == null)
        {
            instance = new Single();
        }
        return instance;
    }
}