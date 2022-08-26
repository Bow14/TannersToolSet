using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponData : GameArtData
{

    public int weaponPower = 10;
    public UnityEvent OnActivate;

    

    public void Activate()
    {
        OnActivate.Invoke();
    }

}
