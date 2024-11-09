using UnityEngine;

public class BikeStopState : MonoBehaviour, IBikeState
{
    private BikeController bikeController;

    public void Handle(BikeController bikeController)
    {
        if (!bikeController)
            this.bikeController = bikeController;

        this.bikeController.CurrentSpeed = bikeController.maxSpeed;
    }

    private void Update()
    {
        if (bikeController)
        {
            if (bikeController.CurrentSpeed > 0)
            {
                bikeController.transform.Translate(Vector3.forward * (bikeController.CurrentSpeed * Time.deltaTime));
            }
        }
    }
}