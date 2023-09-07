using UnityEngine;

public class MobileController : PangElement
{
    public void OnAttackDown()
    {
        InputEvents.inputDownEvent.Invoke(InputAction.Attack);
    }

    public void OnAttackUp()
    {
        InputEvents.inputUpEvent.Invoke(InputAction.Attack);
    }

    public void OnArrowDown(int direction)
    {
        app.model.mobile.movement = direction;
    }

    public void OnArrowUp(int direction)
    {
        if (app.model.mobile.movement != direction)
        {
            return;
        }
        app.model.mobile.movement = 0;
    }

    public void OnPauseClick()
    {
        InputEvents.inputDownEvent.Invoke(InputAction.Pause);
    }
}
