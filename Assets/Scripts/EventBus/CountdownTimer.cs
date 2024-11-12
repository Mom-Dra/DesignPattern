using System.Collections;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    private float currentTime;
    private float duration = 3f;

    private void OnEnable()
    {
        RaceEventBus.Subscribe(RaceEventType.CountDown, StartTimer);
    }

    private void OnDisable()
    {
        RaceEventBus.Unsubscribe(RaceEventType.CountDown, StartTimer);
    }

    private void StartTimer()
    {
        StartCoroutine(CountDown());
    }
    private IEnumerator CountDown()
    {
        Debug.Log("CountDown");

        currentTime = duration;

        while (currentTime > 0f)
        {
            Debug.Log(currentTime);

            currentTime -= Time.deltaTime;
            yield return null;
        }

        Debug.Log(" RaceEventBus.Publish(RaceEventType.Start);");

        RaceEventBus.Publish(RaceEventType.Start);
    }

    private void OnGUI()
    {
        GUI.color = Color.blue;

        Debug.Log($"CountDown: {currentTime}");
        GUI.Label(new Rect(125, 0, 100, 20), $"CountDown: {currentTime}");
    }
}
