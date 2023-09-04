using UnityEngine;

public class PauseModel : PangElement
{
    public int pauseStack = 0;

    public bool isPauseScreenOn = false;

    public bool IsPaused()
    {
        return pauseStack > 0;
    }
}
