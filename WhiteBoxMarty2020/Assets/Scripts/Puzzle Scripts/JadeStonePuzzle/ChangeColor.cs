using System;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public List<GameObject> jadeStones;

    public Color colorStart;
    public Color colorEnd;
    
    public void OnTriggerEnter(Collider other)
    {
        //if MagicBlast hits object
        //then turn into brighter color
        
    }

    public void SetColor()
    {
        GetComponent<Renderer>().material.color = colorEnd;
    }

    public void ResetColor()
    {
        GetComponent<Renderer>().material.color = colorStart;
    }
}
