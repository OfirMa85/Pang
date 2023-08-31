using System.Linq;
using UnityEditor;
using UnityEngine;

public class DrawChildGizmos : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        if (!Selection.gameObjects.Any(c => c.transform.IsChildOf(transform)))
        {
            return;
        }
        foreach (Transform child in transform)
        {
            Gizmos.DrawIcon(child.position, "");
        }
    }
}
