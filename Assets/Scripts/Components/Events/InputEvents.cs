using UnityEngine.Events;

public class InputEvents
{
    public static UnityEvent<InputAction> inputDownEvent = new();
    public static UnityEvent<InputAction> inputUpEvent = new();
}
