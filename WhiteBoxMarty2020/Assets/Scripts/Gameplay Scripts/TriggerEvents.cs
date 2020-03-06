using UnityEngine;
using UnityEngine.Events;
public class TriggerEvents : MonoBehaviour
{
    public UnityEvent onTriggerEnterEvent;
    public UnityEvent onTriggerExitEvent;

    public void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent.Invoke();
    }

    public void OnTriggerExit(Collider other)
    {
        onTriggerExitEvent.Invoke();
    }
}
