using UnityEngine;

public class ClientEventBus : MonoBehaviour
{
    private bool isButtonEnabled;

    private void Start()
    {
        gameObject.AddComponent<HUDController>();
        gameObject.AddComponent<CountdownTimer>();
        gameObject.AddComponent<BikeController2>();

        isButtonEnabled = true;
    }

    private void OnEnable()
    {
        RaceEventBus.Subscribe(RaceEventType.Stop, ReStart);
    }

    private void OnDisable()
    {
        RaceEventBus.Unsubscribe(RaceEventType.Stop, ReStart);
    }

    private void ReStart()
    {
        isButtonEnabled = true;
    }

    private void OnGUI()
    {
        if(isButtonEnabled)
        {
            if(GUILayout.Button("Start Countdown"))
            {
                isButtonEnabled = false;
                RaceEventBus.Publish(RaceEventType.CountDown);
            }
        }
    }
}
