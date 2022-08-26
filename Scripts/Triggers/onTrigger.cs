using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
public class onTrigger : MonoBehaviour
{

    public UnityEvent triggerEvent, triggerExitEvent;
    public UnityEvent triggerEnterEvent;

    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
    
}
