using UnityEngine;

public class HUDController : MonoBehaviour
{
    private bool isDisplayOn;

    private void OnEnable()
    {
        RaceEventBus.Subscribe(RaceEventType.Start, DisplayHUD);
    }

    private void OnDisable()
    {
        RaceEventBus.Unsubscribe(RaceEventType.Start, DisplayHUD);
    }

    private void DisplayHUD()
    {
        isDisplayOn = true;
    }

    private void OnGUI()
    {
        if(isDisplayOn)
        {
            if(GUILayout.Button("Stop Race"))
            {
                isDisplayOn = false;
                RaceEventBus.Publish(RaceEventType.Stop);
            }
        }
    }
}
