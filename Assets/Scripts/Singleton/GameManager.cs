using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime sessionStartTime;
    private DateTime sessionEndTime;

    void Start()
    {
        // Todo:
        // - �÷��̾� ���̺� �ε�
        // - ���̺갡 ������ �÷��̾ ��� ������ �����̷����Ѵ�
        // - �鿣�带 ȣ���ϰ� ���� ç������ ������ ��´�

        sessionStartTime = DateTime.Now;
        Debug.Log("Game session start: @: " + DateTime.Now.ToString());
    }

    private void OnApplicationQuit()
    {
        sessionEndTime = DateTime.Now;

        TimeSpan timeDifference = sessionEndTime.Subtract(sessionStartTime);

        Debug.Log("Game session ended @ " + DateTime.Now.ToString());
        Debug.Log("Game session lasted: " + timeDifference.ToString());
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
