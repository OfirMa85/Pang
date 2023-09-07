using UnityEngine;

public class BallsController : PangElement
{
    private void Start()
    {
        BallDestroyEvent.ballDestroyEvent?.AddListener(OnBallDestroy);
    }

    private void OnBallDestroy(Vector3 position, BallScriptable scriptable)
    {
        int newBalls = SplitBall(position, scriptable) ? 1 : -1;
        app.model.balls.activeBalls += newBalls;
        CheckLevelComplete();
    }

    private void CheckLevelComplete()
    {
        if (app.model.balls.activeBalls <= 0)
        {
            app.view.levelComplete.StartAnimation();
        }
    }

    public void SpawnBall(BallScriptable scriptable, int directionSign, Vector3 position)
    {
        GameObject prefab = app.model.balls.prefab;
        Transform parent = app.model.balls.parent;
        GameObject ball = Instantiate(prefab, position, Quaternion.identity, parent);

        // update ball model
        BallModel model = ball.GetComponent<BallModel>();
        model.scriptable = scriptable;
        model.directionSign = directionSign;
    }

    private bool SplitBall(Vector3 position, BallScriptable scriptable)
    {
        // get next ball
        BallScriptable newScriptable = scriptable.next;
        if (newScriptable == null)
        {
            return false;
        }

        // spawn smaller balls
        SpawnBall(newScriptable, 1, position);
        SpawnBall(newScriptable, -1, position);

        return true;
    }
}
