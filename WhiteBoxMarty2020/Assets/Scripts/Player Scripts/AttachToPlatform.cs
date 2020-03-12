using UnityEngine;

public class AttachToPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Platform")
        {
            transform.SetParent(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Platform")
        {
            transform.parent = null;
        }
    }
}
