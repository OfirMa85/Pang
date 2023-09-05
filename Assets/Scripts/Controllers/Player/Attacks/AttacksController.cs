public class AttacksController : PangElement
{
    public void SpawnAttack()
    {
        Instantiate(app.model.player.fireballPrefab, app.model.player.attacksParent);
    }
}
