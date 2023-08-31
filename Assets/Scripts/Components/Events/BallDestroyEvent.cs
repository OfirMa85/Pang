using UnityEngine;
using UnityEngine.Events;

public class BallDestroyEvent
{
    public static UnityEvent<Vector3, int> ballDestroyEvent = new();
}
