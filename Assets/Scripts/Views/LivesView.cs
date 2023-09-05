using UnityEngine;

public class LivesView : PangElement
{
    public void InitializeHearts(int hearts)
    {
        GameObject prefab = app.model.lives.heartPrefab;

        app.model.lives.hearts = new GameObject[hearts];

        for (int i = 0; i < hearts; i++)
        {
            Vector3 pos = app.model.lives.heartsPos;
            pos += Vector3.left * (app.model.lives.heartsDistance * i);
            GameObject heart = Instantiate(prefab, pos, Quaternion.identity, transform);
            app.model.lives.hearts[i] = heart;
        }
    }

    public void PlayerHit()
    {
        // ignore when on negative health
        if (app.model.lives.lives < 0)
        {
            return;
        }

        GameObject heart = app.model.lives.hearts[app.model.lives.lives];
        SpriteRenderer sr = heart.GetComponent<SpriteRenderer>();
        sr.sprite = app.model.lives.emptyHeartSprite;
    }
}
