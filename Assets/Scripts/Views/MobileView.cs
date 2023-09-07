using UnityEngine;

public class MobileView : PangElement
{
    private void Awake()
    {
        if (SystemInfo.deviceType != DeviceType.Handheld)
        {
            Destroy(gameObject);
        }
    }
}
