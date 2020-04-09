using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoBehaviours : MonoBehaviour
{
    public float holdTime = 0.1f;
    public UnityEvent awakeEvent, startEvent, onEnableEvent, onDisableEvent, quitEvent, destroyEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }
    
    private void OnDisable()
    {
        onDisableEvent.Invoke();
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }

    private void OnApplicationQuit()
    {
        quitEvent.Invoke();
    }
}
