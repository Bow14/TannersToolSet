using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    //AnthonyRomrell Module  Matching game 1 code
    public ID idObj;
    public UnityEvent matchEvent, NoMatchEvent, noMatchDelyaedEvent;
    public IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDcontatinerBehavior>();
        if (tempObj == null) 
            yield break;
            
            
        var otherID = tempObj.idObj;
        
        otherID = other.GetComponent<IDcontatinerBehavior>().idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
           NoMatchEvent.Invoke();
           yield return new WaitForSeconds(0.5f);
           noMatchDelyaedEvent.Invoke();
        }
    }
}
