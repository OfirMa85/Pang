using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballView : PangElement
{
    PlayerAttack attack;
    public void OnSpawn(PlayerAttack attack)
    {
        this.attack = attack;
        transform.position = app.view.player.spriteObj.transform.position;
    }

    public void Move(float speed, Vector3 direction)
    {
        transform.position += speed * Time.deltaTime * direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Upper Bound") || collision.gameObject.CompareTag("Ball"))
        {
            if (attack == null)
            {
                return;
            }
            app.controller.player.attacks.DestroyAttack(attack);
            Destroy(gameObject);
        }
    }
}
