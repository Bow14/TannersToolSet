using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

	public Transform playerTransform;

	public Vector3 cameraFollow;

	public float glideFunction = 1f;

	// Use this for initialization
	void Start ()
	{
		cameraFollow = transform.position - playerTransform.position;

	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 newPos = playerTransform.position + cameraFollow;

		transform.position = Vector3.Slerp(transform.position, newPos, glideFunction);
	}
}
