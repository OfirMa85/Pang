using UnityEngine;

public class FireballController : PangElement
{
    [SerializeField] private FireballModel model;

    public void Start()
    {
        transform.position = app.view.player.GetPosition();
    }

    private void Update()
    {
        transform.position += model.speed * Time.deltaTime * model.direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Upper Bound") ||
            collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
