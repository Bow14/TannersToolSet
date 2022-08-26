using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class CollisionTransparent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnMouseDown()
	{
		Event.Invoke();
	}


	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
		
	}

	
}
