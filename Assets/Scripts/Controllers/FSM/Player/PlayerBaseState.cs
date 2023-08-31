public class PlayerBaseState
{
    public virtual void OnEnter(PlayerStateController player) { }
    public virtual void OnUpdate(PlayerStateController player) { }
    public virtual void OnHurt(PlayerStateController player) { }
    public virtual void OnExit(PlayerStateController player) { }
    public virtual void OnAnimationEnd(PlayerStateController player) { }
}
