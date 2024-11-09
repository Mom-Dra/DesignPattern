using UnityEngine;

public class BikeTurnState : MonoBehaviour, IBikeState
{
    private Vector3 turnDirection;
    private BikeController bikeController;

    public void Handle(BikeController bikeController)
    {
        if (!bikeController)
            this.bikeController = bikeController;

        turnDirection.x = (float)bikeController.CurrentTurnDirection;

        if(bikeController.CurrentSpeed > 0)
        {
            transform.Translate(turnDirection * bikeController.turnDistance);
        }
    }
}