using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacksController : PangElement
{
    private List<PlayerAttack> attacks = new();

    private void Update()
    {
        foreach (PlayerAttack attack in attacks)
        {
            attack.OnUpdate(this);
        }
    }

    public void SpawnAttack(PlayerAttack attack)
    {
        attacks.Add(attack);
        attack.OnSpawn(this);
    }

    public void DestroyAttack(PlayerAttack attack)
    {
        int index = attacks.IndexOf(attack);
        if (index == -1)
        {
            return;
        }

        attacks.Remove(attack);
    }
}
