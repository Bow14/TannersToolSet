using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActualTrigger : MonoBehaviour
{

	public UnityEvent triggerEvent, triggerexit;
	public UnityEvent triggerEnterEvent;

	// Use this for initialization
	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public void OnTriggerEnter(Collider other)
	{
		triggerEvent.Invoke();
		triggerEnterEvent.Invoke();
	}

	public void OnTriggerExit(Collider other)
	{
		triggerexit.Invoke();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
