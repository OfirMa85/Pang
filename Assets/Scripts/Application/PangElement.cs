using UnityEngine;

public class PangElement : MonoBehaviour
{
    [HideInInspector]
    public PangApplication app;

    private void Awake()
    {
        app = GameObject.FindObjectOfType<PangApplication>();
    }
}
