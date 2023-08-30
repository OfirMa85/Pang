using UnityEngine;

public class FireballController : PlayerAttack
{
    private FireballModel model;
    private FireballView view;

    private readonly GameObject prefab;

    public FireballController(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public override void OnSpawn(PlayerAttacksController controller)
    {
        GameObject obj = MonoBehaviour.Instantiate(prefab, controller.app.model.player.attacksParent);
        view = obj.GetComponent<FireballView>();
        model = new();

        view.OnSpawn(this);
    }
    public override void OnUpdate(PlayerAttacksController controller)
    {
        view.Move(model.speed, model.direction);
    }
}
