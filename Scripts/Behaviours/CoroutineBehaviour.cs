
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    //Followed Anthony Romrell class lecture
    //Coroutines are just a monobehaviour never call coroutines in a update
    //update is terrible because it never stops running
    //Coroutines can start and can stop

    //Ienumerator is a coroutine and can stop anytime

    //Fastest code is the code that never runs


    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    public bool canRun;
    
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    //Taking the new objects and putting it for once so your not filling in a bunch of memory
    // with new update constantly 

    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

    public void Start()
    {
       startEvent.Invoke();
       wfsObj = new WaitForSeconds(seconds);
       wffuObj = new WaitForFixedUpdate();

    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }

    private IEnumerator Counting()
    {
       
        //Void start cannot be yielded
        //If you don't yield a while loop it will crash
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {  
            
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
            
        }
        endCountEvent.Invoke();

    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }
    
}
