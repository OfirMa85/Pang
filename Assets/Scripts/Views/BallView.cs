using UnityEngine;

public class BallView : PangElement
{
    [SerializeField] private BallModel model;

    [SerializeField] private SpriteRenderer sprite;

    public void Initialize()
    {
        InitializeSprite();
    }

    private void InitializeSprite()
    {
        // set sprite
        if (model.scriptable.sprite == null)
        {
            Debug.LogError("Ball Sprite is not defined");
            return;
        }
        sprite.sprite = model.scriptable.sprite;
    }
}
