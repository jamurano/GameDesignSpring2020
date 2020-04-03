using System.Collections.Generic;
using UnityEngine;

public class OpacityTrigger : MonoBehaviour
{
    public List<GameObject> objects;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject obj in objects)
            {
                obj.GetComponent<Renderer>().material = obj.GetComponent<OpacityShaders>().transparentMat;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject obj in objects)
            {
                obj.GetComponent<Renderer>().material = obj.GetComponent<OpacityShaders>().mat;
            }
        }
    }
}
