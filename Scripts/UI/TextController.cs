using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class TextController : MonoBehaviour
{

	public Text textLabel;

	// Use this for initialization
	

		// Update is called once per frame
		void UpdateText(intdata data)
		{
			textLabel.text = data.value.ToString();
		}

		private void Awake()
		{
			textLabel = GetComponent<Text>();
		}
}

internal class intdata
{
	public object value;
}
