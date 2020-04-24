using UnityEngine;

public class PopupBoxForward : MonoBehaviour
{
    public Transform camera;

    public void Update()
    {
        transform.LookAt(camera, Vector3.down);
    }
}
