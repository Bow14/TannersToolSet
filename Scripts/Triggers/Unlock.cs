using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour {
    //tutorial on how to use doors with keys aka my gems
    //https://www.youtube.com/watch?v=MIt0PJHMN5Y&t=0s credit goes to Code monkey with this tutorial

    [SerializeField] private KeyType keyType; //Serilaize field is used when you want your private variable to show up in editior

    public enum  KeyType
    {
    Red,
    Blue,
    Purple,
        
    }

    public KeyType GetUnlockType()
    {
        return GetUnlockType();
    }

    public Key.KeyType GetKeyType()
    {
        return GetKeyType();
    }
}
