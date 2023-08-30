using UnityEngine;
using UnityEngine.Events;

public class BallDestroyEvent : PangElement
{
    public static UnityEvent<Vector3, int> ballDestroyEvent = new();
}
