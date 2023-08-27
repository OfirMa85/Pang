public class PlayerInputController : PangElement
{
    private void Update()
    {
        app.model.player.input.UpdateInput();
    }
}
