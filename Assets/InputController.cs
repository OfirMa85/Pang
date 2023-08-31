using System.Collections.Generic;
using UnityEngine;

public class InputController : PangElement
{
    [SerializeField] private InputModel model;

    private void Update()
    {
        CaptureInputs();
    }

    private void CaptureInputs()
    {
        // capture every item in the model dictionary
        foreach (KeyValuePair<InputAction, string> entry in model.actionStrings)
        {
            if (Input.GetButtonDown(entry.Value))
            {
                Debug.Log("Pressed \"" + entry.Value + "\"");
                model.inputActions.Add(entry.Key);
            }
            if (Input.GetButtonUp(entry.Value))
            {
                Debug.Log("Stopped pressing \"" + entry.Value + "\"");
                model.inputActions.Remove(entry.Key);
            }
        }
    }
}
