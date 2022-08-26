using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSystem : MonoBehaviour
{
// Coding from this youtube video https://www.youtube.com/watch?v=1kMh5NajC_U
	public GameObject player;
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.LookAt(player.transform);//This means it has to look at the player to move forward
		transform.position += transform.forward * 4f * Time.deltaTime; //This code means to have the transform of the enemy to move forward by 1f
	}
	
}
