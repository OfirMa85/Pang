using UnityEngine;

public class MainMenu : PangElement
{
    public void OnPlay()
    {
        GameStartEvent.gameStartEvent.Invoke();
        gameObject.SetActive(false);
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
