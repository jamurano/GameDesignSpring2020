using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public List <GameObject> objsToSpawn;

    public void InstantiateObj()
    {
        foreach (GameObject obj in objsToSpawn)
        {
            Instantiate(obj, transform.position, transform.rotation);
        }
    }
}
