using System.Collections.Generic;
using UnityEngine;

public class InputController : PangElement
{
    private void Update()
    {
        CaptureInputs();
    }

    private void CaptureInputs()
    {
        // capture every item in the model dictionary
        foreach (KeyValuePair<InputAction, string> entry in app.model.input.actionStrings)
        {
            if (Input.GetButtonDown(entry.Value))
            {
                InputEvents.inputDownEvent.Invoke(entry.Key);
                Debug.Log("Pressed \"" + entry.Value + "\"");
            }
            if (Input.GetButtonUp(entry.Value))
            {
                InputEvents.inputUpEvent.Invoke(entry.Key);
                Debug.Log("Stopped pressing \"" + entry.Value + "\"");
            }
        }
    }
}
