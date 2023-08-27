using UnityEngine;

public class PangElement : MonoBehaviour
{
    // gives access to the application instance
    public PangApplication app;

    private void Awake()
    {
        app = GameObject.FindObjectOfType<PangApplication>();
    }
}
