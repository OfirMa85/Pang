using UnityEngine;

public class PlayerAttack
{
    public virtual void OnSpawn(PlayerAttacksController controller) { }
    public virtual void OnDestroyed(PlayerAttacksController controller) { }
    public virtual void OnUpdate(PlayerAttacksController controller) { }
}
