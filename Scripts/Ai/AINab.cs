using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AINab : MonoBehaviour
{


	private NavMeshAgent agent;
	public Vector3Data location;

	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		agent.destination = location.value;
		
	}
}
