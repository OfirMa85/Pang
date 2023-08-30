using UnityEngine;

public class BallController
{
    public BallScriptable scriptable;
    public BallModel model;
    public BallView view;

    public BallController(BallsController controller, int size, int directionSign, Vector3 position, bool isFirst)
    {
        // initialize variables
        scriptable = controller.app.model.balls.scriptables[size];
        model = new(directionSign, controller);

        GameObject prefab = controller.app.model.balls.prefab;

        // spawn ball
        GameObject obj = MonoBehaviour.Instantiate(prefab, position, Quaternion.identity, controller.app.model.balls.parent);

        // update ball view
        view = obj.GetComponent<BallView>();
        view.OnSpawn(this);
        if (!isFirst)
        {
            view.Boost();
        }
    }

    public void OnUpdate()
    {
        view.Move();
    }
}
