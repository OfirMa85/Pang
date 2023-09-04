using UnityEngine;

public class BallsController : PangElement
{
    private void Start()
    {
        BallDestroyEvent.ballDestroyEvent?.AddListener(OnBallDestroy);
    }

    private void OnBallDestroy(Vector3 position, BallScriptable scriptable)
    {
        SplitBall(position, scriptable);
        CheckLevelComplete();
    }

    private void CheckLevelComplete()
    {
        if (app.model.balls.parent.transform.childCount - 1 == 0)
        {
            app.view.levelComplete.StartAnimation();
        }
    }

    public void SpawnBall(int size, int directionSign, Vector3 position)
    {
        GameObject ball = Instantiate(app.model.balls.prefab, position, Quaternion.identity,app.model.balls.parent);

        BallController controller = ball.GetComponent<BallController>();
        BallModel model = ball.GetComponent<BallModel>();
        BallView view = ball.GetComponent<BallView>();

        // initialize ball components
        try
        {
            model.Initialize(app.model.balls.scriptables[size], directionSign);
        }
        catch
        {
            Debug.LogError("Ball Scriptable Object is not defined correctly");
            Destroy(ball);
            return;
        }
        controller.Initialize();
        view.Initialize();
    }

    private void SplitBall(Vector3 position, BallScriptable scriptable)
    {
        // get next ball
        BallScriptable newScriptable = scriptable.next;
        if (newScriptable == null)
        {
            return;
        }

        // spawn smaller balls
        SpawnBall(newScriptable.size, 1, position);
        SpawnBall(newScriptable.size, -1, position);
    }
    private int CalculateSizeAfterSplit(int size)
    {
        return size - 1;
    }
}
