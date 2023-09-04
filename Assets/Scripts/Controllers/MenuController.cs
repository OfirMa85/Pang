using UnityEngine;

public class MenuController : PangElement
{
    public void SwitchMenu(Menu menu)
    {
        // check for valid menu index
        int childCount = app.view.menu.transform.childCount;
        if (childCount - 1 < (int)menu)
        {
            Debug.LogError("Missing menu with index of " + (int)menu);
            return;
        }

        // toggle the menus
        for (int i = 0; i < childCount; i++)
        {
            bool toggle = (int)menu == i;
            app.view.menu.ToggleMenu(i, toggle);
        }
    }
}
