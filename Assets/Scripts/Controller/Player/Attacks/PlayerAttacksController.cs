using UnityEngine;

public class PlayerAttacksController : PangElement
{
    public void SpawnAttack()
    {
        Instantiate(app.model.player.fireballPrefab, app.model.player.attacksParent);
    }
}
