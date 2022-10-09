using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBehavoir : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsObj;

    private IEnumerator Start()
     {
         wfsObj = new WaitForSeconds(seconds);
         yield return wfsObj;
         Destroy(gameObject);
     }
}
