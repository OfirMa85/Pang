using UnityEngine;

public class BallsController : PangElement
{
    private void Start()
    {
        BallDestroyEvent.ballDestroyEvent?.AddListener(OnBallDestroy);
    }

    private void OnBallDestroy(Vector3 position, int size)
    {
        SplitBall(position , size);
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
            Debug.Log("Ball Scriptable Object is not defined correctly");
            Destroy(ball);
            return;
        }
        controller.Initialize();
        view.Initialize();
    }

    private void SplitBall(Vector3 position, int size)
    {
        // shrink ball
        int newSize = CalculateSizeAfterSplit(size);
        if (newSize < 0)
        {
            return;
        }

        // spawn smaller balls
        SpawnBall(newSize, 1, position);
        SpawnBall(newSize, -1, position);
    }
    private int CalculateSizeAfterSplit(int size)
    {
        return size - 1;
    }
}
