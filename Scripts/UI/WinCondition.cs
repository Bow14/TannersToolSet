using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

	public GameUIManger gameManger;

	public void OnTriggerEnter(Collider other)
	{
		gameManger.GameOver();
	}
}
