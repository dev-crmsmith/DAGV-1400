using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour1 : MonoBehaviour
{
    public UnityEvent triggerEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
}
