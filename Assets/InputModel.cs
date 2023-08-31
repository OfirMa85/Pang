using System.Collections.Generic;
using UnityEngine;

public class InputModel : PangElement
{
    // input strings
    public Dictionary<InputAction, string> actionStrings = new()
    {
        {
            InputAction.Attack, "Attack"
        },
        {
            InputAction.Pause, "Pause"
        }
    };

    // stores input actions
    public readonly HashSet<InputAction> inputActions = new();

    public bool GetActionPressed(InputAction action)
    {
        return inputActions.Contains(action);
    }

    public float GetAxis(Axis axis)
    {
        return Input.GetAxisRaw(axis.ToUnityAxis());
    }
}
