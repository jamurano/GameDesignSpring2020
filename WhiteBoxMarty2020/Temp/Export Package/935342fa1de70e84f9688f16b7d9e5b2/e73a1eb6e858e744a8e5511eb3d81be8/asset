using UnityEngine;
using UnityEngine.Events;

public class TriggerBehaviours : MonoBehaviour
    {
        public UnityEvent triggerEnterEvent;
    
        private void OnTriggerEnter(Collider other)
        {
            triggerEnterEvent.Invoke();
        }
}