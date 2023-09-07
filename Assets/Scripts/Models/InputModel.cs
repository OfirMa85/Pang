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

    private void Start()
    {
        // add input listeners
        InputEvents.inputDownEvent.AddListener(InputDown);
        InputEvents.inputUpEvent.AddListener(InputUp);
    }

    // listeners
    private void InputDown(InputAction action)
    {
        inputActions.Add(action);
    }
    private void InputUp(InputAction action)
    {
        inputActions.Remove(action);
    }

    // getters
    public bool GetActionPressed(InputAction action)
    {
        return inputActions.Contains(action);
    }
    public float GetAxis(Axis axis)
    {
        return Input.GetAxisRaw(axis.ToUnityAxis())
            + app.model.mobile.movement;
    }
}
