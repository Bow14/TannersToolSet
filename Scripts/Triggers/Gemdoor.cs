using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemdoor : MonoBehaviour
{
    //tutorial on how to use doors with keys aka my gems
    //https://www.youtube.com/watch?v=MIt0PJHMN5Y&t=0s credit goes to Code monkey with this tutorial
    [SerializeField] private Key.KeyType keyType; //Serilaize field is used when you want your private variable to show up in editior

    public enum  KeyType
    {
        Red,
        Blue,
        Purple,
        
    }
    

    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor()
    {
        gameObject.SetActive(false);
    }
}
