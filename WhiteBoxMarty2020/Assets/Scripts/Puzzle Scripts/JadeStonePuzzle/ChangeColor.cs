using System;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public List<GameObject> jadeStones;

    public Color colorStart;
    public Color colorEnd;

    public void SetColor()
    {
        print("Changing Color");
        GetComponent<Renderer>().material.color = colorEnd;
    }

    public void ResetColor()
    {
        GetComponent<Renderer>().material.color = colorStart;
    }
}
