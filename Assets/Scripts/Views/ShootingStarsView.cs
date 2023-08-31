using System.Collections;
using UnityEngine;

public class ShootingStarsView : MonoBehaviour
{
    [SerializeField] private Vector2 delayRange;

    [SerializeField] private Rect bounds;
    [SerializeField] private Color gizmoColor;
    [SerializeField] private bool drawGizmo;

    [SerializeField] private GameObject prefab;

    private void Start()
    {
        StartCoroutine(EmitStars());
    }

    private IEnumerator EmitStars()
    {
        float delay = Random.Range(delayRange.x, delayRange.y);
        yield return new WaitForSeconds(delay);
        SpawnShootingStar();
        StartCoroutine(EmitStars());
    }

    private void SpawnShootingStar()
    {
        float x = Random.Range(bounds.xMin, bounds.xMax);
        float y = Random.Range(bounds.yMin, bounds.yMax);
        float z = transform.position.z;
        Vector3 pos = new Vector3(x, y, z);
        Quaternion rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));

        Instantiate(prefab, pos, rotation, transform);
    }

    private void OnDrawGizmos()
    {
        if (!drawGizmo)
        {
            return;
        }

        Gizmos.color = gizmoColor;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
