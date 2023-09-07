public class SettingsMenu : PangElement
{
    public void BackButton()
    {
        app.controller.menu.SwitchMenu(Menu.Main);
    }
}
