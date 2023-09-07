using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerView : PangElement
{
    public PlayerAnimationView anim;

    [SerializeField] private GameObject spriteObj;

    private void Start()
    {
        GameEvents.gameLostEvent.AddListener(OnGameEnded);
        GameEvents.gameWonEvent.AddListener(OnGameEnded);
    }

    public void MovePlayer(Vector3 movementVectorNormal)
    {
        // calculate position
        Vector3 movement = app.model.player.speed * Time.deltaTime * movementVectorNormal;
        Vector3 newPos = spriteObj.transform.position + movement;
        float newX = Mathf.Clamp(newPos.x, app.model.player.xBounds.x, app.model.player.xBounds.y);
        newPos = new Vector3(newX, newPos.y, newPos.z);

        // calculate rotation
        float yRotation = movementVectorNormal == Vector3.left ? 180 : 0;
        Quaternion newRotation = Quaternion.Euler(0f, yRotation, 0f);

        spriteObj.transform.SetPositionAndRotation(newPos, newRotation);
    }

    public Vector3 GetPosition()
    {
        return spriteObj.transform.position;
    }

    public void OnGameEnded()
    {
        Destroy(gameObject);
    }
}
