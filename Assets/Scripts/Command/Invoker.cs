using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    private bool isRecording;
    private bool isReplaying;
    private float replayTime;
    private float recordingTime;

    private SortedList<float, Command> recordedCommands = new SortedList<float, Command>();

    public void ExecuteCommand(Command command)
    {
        command.Execute();

        if (isRecording)
            recordedCommands.Add(recordingTime, command);

        Debug.Log($"Recorded Time: {recordingTime}");
        Debug.Log($"Recorded Command: {command}");
    }

    public void Record()
    {
        recordingTime = 0f;
        isRecording = true;
    }

    public void Replay()
    {
        replayTime = 0f;
        isReplaying = true;

        if (recordedCommands.Count <= 0)
            Debug.LogError("No commands to replay!");

        recordedCommands.Reverse();
    }

    private void FixedUpdate()
    {
        if (isRecording)
            recordingTime += Time.fixedDeltaTime;

        if(isReplaying)
        {
            replayTime += Time.deltaTime;

            if(recordedCommands.Any())
            {
                if(Mathf.Approximately(replayTime, recordedCommands.Keys[0]))
                {
                    Debug.Log($"Replay Time: {replayTime}");
                    Debug.Log($"Replay Command: {recordedCommands.Values[0]}");

                    recordedCommands.Values[0].Execute();
                    recordedCommands.RemoveAt(0);
                }
            }
            else
            {
                isReplaying = false;
            }
        }
    }
}
