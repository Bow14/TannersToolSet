using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class intDataForPlayer : ScriptableObject
{

	public int value = 0;
 
 	public void Reset()
 	{
 		value = 0;
 	}
 
 	public void updateValue(int number)
 	{
 		value += number;
 	}
 }
