using System;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        // Trigger the event and test with a debug message
        triggerEvent.Invoke();
        Debug.Log("Triggered");
    }
}
