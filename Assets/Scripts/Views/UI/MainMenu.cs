using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : PangElement
{
    public void SettingsButton()
    {
        app.controller.menu.SwitchMenu(Menu.Settings);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
