using UnityEngine;

public class GrabObject : MonoBehaviour
{
    public GameObject pickUpObject;
    public GameObject holdObject;

    public void PickUpObject()
    {
        pickUpObject.transform.position = holdObject.transform.position;
        pickUpObject.transform.SetParent(holdObject.transform);
    }
}
