using UnityEngine;
using UnityEngine.Events;

public class BoolEvents : MonoBehaviour
{
    public bool condition = false;

    public UnityEvent trueEvent;
    public UnityEvent falseEvent;

    public void RunEvent()
    {
        if (condition == true)
        {
            trueEvent.Invoke();
        }

        else
        {
            falseEvent.Invoke();
        }
    }

    public void ToggleCondition()
    {
        condition = !condition;
    }
}
