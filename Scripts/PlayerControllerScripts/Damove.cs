using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))] //makes it where you need a charactercontroller for this script
public class Damove : MonoBehaviour

{
	private Vector3 position;
	private CharacterController controller;
	public float moveSpeed = 10f;
	public float gravity = 3f;
	public float jumpSpeed = 30f;
	private int jumpCount;
	public int jumpCountMax = 2;

	public Animator anin;

	public void ChangeJumpMax()
	{
		jumpCountMax = 3;
	}
	
	
	

	public void Start()
	{
		controller = GetComponent<CharacterController>(); //grabs charactercontroller when you add this script
	}

	void Update ()
	{
		position.x = moveSpeed*Input.GetAxis("Horizontal");
		position.y -= gravity;
		if (Input.GetAxis("Horizontal")> 0)
		{
			Vector3 newScale = new Vector3(1,1,1);
			transform.localScale = newScale;
			
			anin.SetBool("IsMoving", true);
			
		}
		else if (Input.GetAxis("Horizontal")< 0)
		{
			Vector3 newScale = new Vector3(-1,1,1);
			transform.localScale = newScale;
			
			
			anin.SetBool("IsMoving", true);
		}
		else
		{
			anin.SetBool("IsMoving", false);
		}

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			moveSpeed = 20;
		}

		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			moveSpeed = 10;
		}
		
		if (controller.isGrounded)
		{
			position.y = 0;
			jumpCount = 0; //makes it where you can do multiple double jumps in one game
		}

		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax) //the restart modify
		{
			jumpCount++; //plus plus = 1
			position.y = jumpSpeed;
		}
		controller.Move(position * Time.deltaTime);

	}
}
