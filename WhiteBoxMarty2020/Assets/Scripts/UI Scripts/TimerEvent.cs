using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{
    public float numberOfSeconds = 3f;
    public UnityEvent timerEvent;

    public bool timerIsRunning = false;

    public void StartTimer()
    {
        //starts coroutine
        StartCoroutine(Timer());
    }

    public IEnumerator Timer()
    {
        timerIsRunning = true;
        //Waitforseconds
        yield return new WaitForSeconds(numberOfSeconds);
        //activate event
        timerEvent.Invoke();
        timerIsRunning = false;
    }
}
