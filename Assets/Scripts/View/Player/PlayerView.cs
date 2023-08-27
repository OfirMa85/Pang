using UnityEngine;

public class PlayerView : PangElement
{
    public PlayerAnimationView anim;
    public void MovePlayer(Vector3 movementVectorNormal)
    {
        // calculate needed movement and rotation
        Vector3 movement = movementVectorNormal * app.model.player.speed * Time.deltaTime;
        float yRotation = movementVectorNormal == Vector3.left ? 180 : 0;
        Quaternion rotation = Quaternion.Euler(0f, yRotation, 0f);

        transform.position += movement;
        transform.rotation = rotation;
    }
}
