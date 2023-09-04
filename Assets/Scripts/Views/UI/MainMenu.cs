using UnityEngine;

public class MainMenu : PangElement
{
    public void PlayButton()
    {
        GameStartEvent.gameStartEvent.Invoke();
        gameObject.SetActive(false);
    }

    public void SettingsButton()
    {
        app.controller.menu.SwitchMenu(Menu.Settings);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
