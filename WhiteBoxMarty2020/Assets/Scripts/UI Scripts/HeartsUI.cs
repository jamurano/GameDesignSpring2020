using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    public GameObject heartOne;
    public GameObject heartTwo;
    public GameObject heartThree;

    public HeartData heartData;

    public void DisplayHearts()
    {
        if (heartData.currentHearts == 3)
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
        }
        
        if (heartData.currentHearts == 2)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
        }
        
        if (heartData.currentHearts == 1)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(false);
            heartThree.SetActive(true);
        }
        
        if (heartData.currentHearts == 0)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(false);
            heartThree.SetActive(false);
        }
    }
}
