using UnityEngine;

public class TurnRight : Command
{
    private BikeController3 bikeController;

    public TurnRight(BikeController3 bikeController)
    {
        this.bikeController = bikeController;
    }

    public override void Execute()
    {
        bikeController.Turn(BikeController3.Direction.Right);
    }
}
