using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{
    public int interactCounter = 0;

    public UnityEvent firstRingEvent;
    public UnityEvent SecondRingEvent;
    public UnityEvent ThirdRingEvent;
    public UnityEvent resetEvent;

    public UnityEvent winEvent;

    public GameObject firstRing;
    public GameObject secondRing;
    public GameObject thirdRing;
    
    
    public void OnInteract()
    {
        if (interactCounter == 0)
        {
            firstRingEvent.Invoke();
            //do something
        }

        if (interactCounter == 1)
        {
            SecondRingEvent.Invoke();
            //do something
        }

        if (interactCounter == 2)
        {
            ThirdRingEvent.Invoke();
            //do something
        }

        interactCounter++;
        if (interactCounter == 3)
        {
            if (firstRing.GetComponent<TriggerLinedUp>().isLinedUp == true && 
                secondRing.GetComponent<TriggerLinedUp>().isLinedUp == true && 
                thirdRing.GetComponent<TriggerLinedUp>().isLinedUp == true)
            {
                winEvent.Invoke();
            }

            else
            {
                //reset counter
                interactCounter = 0;
                resetEvent.Invoke();
            }

        }
    }
}
