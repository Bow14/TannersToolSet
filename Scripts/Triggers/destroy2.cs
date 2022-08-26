using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy2 : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Gammer");
		if (other.gameObject.CompareTag("GameController"))
		{
			Destroy(other.gameObject);
			
			
		}

		
	}
}
