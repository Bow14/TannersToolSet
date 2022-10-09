using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDcontatinerBehavior : MonoBehaviour
{
    //    //AnthonyRomrell Module  Matching game 1 code

    public ID idObj;

    public UnityEvent startEvent;
    public void Start()
    {
        startEvent.Invoke();
    }
}
