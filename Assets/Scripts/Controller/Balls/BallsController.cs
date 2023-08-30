using System.Collections.Generic;
using UnityEngine;

public class BallsController : PangElement
{
    private readonly List<BallController> balls = new();

    private void Update()
    {
        // update balls
        foreach (BallController ball in balls)
        {
            ball.OnUpdate();
        }
    }

    private void Start()
    {
        SpawnBall(3, 1, Vector3.zero, true);
    }

    public void SpawnBall(int size, int directionSign, Vector3 position, bool isFirst)
    {
        // get model
        BallScriptable model;
        try
        {
            model = app.model.balls.scriptables[size];
        } 
        catch
        {
            Debug.LogError("Ball Scriptable is not defined");
            return;
        }

        // spawn ball
        BallController ball = new(this,
            size, directionSign, position, isFirst);
        balls.Add(ball);
    }

    public void DestroyBall(BallController ball)
    {
        // remove ball
        int index = balls.IndexOf(ball);
        if (index == -1)
        {
            return;
        }
        balls.Remove(ball);

        SplitBall(ball);
    }

    private void SplitBall(BallController ball)
    {
        // shrink ball
        int newSize = ball.scriptable.size - 1;
        if (newSize < 0)
        {
            return;
        }

        // spawn smaller balls
        SpawnBall(newSize, 1, ball.view.transform.position, false);
        SpawnBall(newSize, -1, ball.view.transform.position, false);
    }
}
