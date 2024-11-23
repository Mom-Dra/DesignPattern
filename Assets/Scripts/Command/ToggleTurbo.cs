using Unity.VisualScripting;
using UnityEngine;

public class ToggleTurbo : Command
{
    private BikeController3 bikeController;

    public ToggleTurbo(BikeController3 bikeController)
    {
        this.bikeController = bikeController;
    }

    public override void Execute()
    {
        bikeController.ToggleTurbo();
    }
}
