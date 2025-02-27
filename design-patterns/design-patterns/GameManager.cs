namespace design_patterns;

public class GameManager
{
    private static GameManager instance;

    private GameManager() { }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    public void ShowMessage()
    {
        Console.WriteLine("Game Manager is working!");
    }
}
