using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public Transform platform;
    
    public void OnTriggerEnter(Collider other)
    {
        //when player enters trigger, parents with the platform
        //to keep from falling off of platform
        other.transform.SetParent(platform);
        // Transform.parent = other.transform;
    }

    public void OnTriggerExit(Collider other)
    {
        //when player isn't touching trigger, they are no longer connected 
            other.transform.SetParent(null); 
            //transform.parent = null;
    }
}
