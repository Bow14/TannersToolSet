using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class DataPlayer : GameArtData
{
	public UnityAction<GameObject> instanceAction; 
	
	public List<WeaponData> weapons;
	public Powerups health;
	public UnityEvent onRunEvent;

	public ClothesData pants;
	public ClothesData shirt;
	public ClothesData boots;
	public void InstancePlayer()
	{
		var  newPlayer = Instantiate(prefab);
		var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
		newSprite.color = color;
		newSprite.sprite = sprite;
		instanceAction(newPlayer);

	}

	public void Run()
	{
		onRunEvent.Invoke();
	}
}

