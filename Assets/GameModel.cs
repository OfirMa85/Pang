using UnityEngine;

public class GameModel : PangElement
{
    public static int pauseStack = 0;

    public static bool IsPaused()
    {
        return pauseStack > 0;
    }
}
