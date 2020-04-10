using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    public GameObject heartOne;
    public GameObject heartTwo;
    public GameObject heartThree;
    public GameObject heartFour;
    public GameObject heartFive;

    public HeartData heartData;

    public void DisplayHearts()
    {
        if (heartData.currentHearts == 5)
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
            heartFour.SetActive(true);
            heartFive.SetActive(true);
        }
        
        if (heartData.currentHearts == 4)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
            heartFour.SetActive(true);
            heartFive.SetActive(true);
        }
        
        if (heartData.currentHearts == 3)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(false);
            heartThree.SetActive(true);
            heartFour.SetActive(true);
            heartFive.SetActive(true);
        }
        
        if (heartData.currentHearts == 2)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(false);
            heartThree.SetActive(false);
            heartFour.SetActive(true);
            heartFive.SetActive(true);
        }
        
        if (heartData.currentHearts == 1)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(false);
            heartThree.SetActive(false);
            heartFour.SetActive(false);
            heartFive.SetActive(true);
        }
        
        if (heartData.currentHearts == 0)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(false);
            heartThree.SetActive(false);
            heartFour.SetActive(false);
            heartFive.SetActive(false);
        }
    }
}
