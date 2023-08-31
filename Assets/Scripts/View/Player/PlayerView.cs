using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerView : PangElement
{
    [SerializeField] private PlayerAnimationView anim;
    [SerializeField] private GameObject spriteObj;

    public void MovePlayer(Vector3 movementVectorNormal)
    {
        // calculate position
        Vector3 movement = movementVectorNormal * app.model.player.speed * Time.deltaTime;
        Vector3 newPos = spriteObj.transform.position + movement;
        float newX = Mathf.Clamp(newPos.x, app.model.player.xBounds.x, app.model.player.xBounds.y);
        newPos = new Vector3(newX, newPos.y, newPos.z);

        // calculate rotation
        float yRotation = movementVectorNormal == Vector3.left ? 180 : 0;
        Quaternion newRotation = Quaternion.Euler(0f, yRotation, 0f);

        // apply
        spriteObj.transform.position = newPos;
        spriteObj.transform.rotation = newRotation;
    }

    public void ChangeAnimation(string animation)
    {
        anim.PlayAnimation(animation);
    }

    public Vector3 GetPosition()
    {
        return spriteObj.transform.position;
    }
}
