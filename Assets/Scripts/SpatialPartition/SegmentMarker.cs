using UnityEngine;

public class SegmentMarker : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BikeController3>())
            Destroy(transform.parent.gameObject);
    }
}
