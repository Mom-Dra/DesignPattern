using UnityEditor;
using UnityEngine;

public class BikeController3 : MonoBehaviour
{
    public enum Direction
    {
        Left = -1,
        Right = 1
    }

    private bool isTurboOn;
    private float distance = 1f;

    public void ToggleTurbo()
    {
        isTurboOn = !isTurboOn;
        Debug.Log($"Turbo Active: {isTurboOn}");
    }

    public void Turn(Direction direction)
    {
        switch (direction)
        {
            case Direction.Left:
                transform.Translate(Vector3.left * distance);
                break;
            case Direction.Right:
                transform.Translate(Vector3.right * distance);
                break;
        }
    }

    public void ResetPosition()
    {
        transform.position = Vector3.zero;
    }
}
