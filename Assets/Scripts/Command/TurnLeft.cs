using UnityEngine;

public class TurnLeft : Command
{
    private BikeController3 bikeController;

    public TurnLeft(BikeController3 bikeController)
    {
        this.bikeController = bikeController;
    }

    public override void Execute()
    {
        bikeController.Turn(BikeController3.Direction.Left);
    }
}
