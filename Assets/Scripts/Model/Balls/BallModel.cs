public class BallModel
{
    public float directionSign;
    public BallsController controller;

    public BallModel(float directionSign, BallsController controller)
    {
        this.directionSign = directionSign;
        this.controller = controller;
    }
}
