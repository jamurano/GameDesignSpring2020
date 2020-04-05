using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIndicator : MonoBehaviour
{
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

    public void StartColorChanger()
    {
        StartCoroutine(ColorChanger());
    }

    public IEnumerator ColorChanger()
    {
        SetColor();
        yield return new WaitForSeconds(.5f);
        ResetColor();
    }
}
