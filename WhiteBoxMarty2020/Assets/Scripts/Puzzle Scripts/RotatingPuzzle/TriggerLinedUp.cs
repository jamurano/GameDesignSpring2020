using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLinedUp : MonoBehaviour
{
    public bool isLinedUp = false;
    public void OnTriggerEnter(Collider other)
    {
        isLinedUp = true;
    }

    public void OnTriggerExit(Collider other)
    {
        isLinedUp = false;
    }
}
