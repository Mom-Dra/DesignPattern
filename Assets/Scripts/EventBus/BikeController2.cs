using UnityEngine;

public class BikeController2 : MonoBehaviour
{
    private string status;

    private void OnEnable()
    {
        RaceEventBus.Subscribe(RaceEventType.Start, StartBike);
        RaceEventBus.Subscribe(RaceEventType.Stop, StopBike);
    }

    private void OnDisable()
    {
        RaceEventBus.Unsubscribe(RaceEventType.Start, StartBike);
        RaceEventBus.Unsubscribe(RaceEventType.Stop, StopBike);
    }

    private void StartBike()
    {
        status = "Started";
    }

    private void StopBike()
    {
        status = "Stopped";
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(10, 60, 200, 20), "BIKE STATUS: " + status);
    }
}
