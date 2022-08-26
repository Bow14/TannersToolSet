using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemholder : MonoBehaviour
    //tutorial on how to use doors with keys aka my gems
    //https://www.youtube.com/watch?v=MIt0PJHMN5Y&t=0s credit goes to Code monkey with this tutorial
{
    private List<Key.KeyType> keyList;

    private void Awake()
    {
        keyList = new List<Key.KeyType>();
       
    }

    public void AddKey(Key.KeyType keyType)
    {
        Debug.Log("GemFound"+ keyType);
        keyList.Add(keyType);
    }

    public void RemoveKey(Key.KeyType keyType)
    {
        keyList.Remove(keyType);
    }

    public bool ContainKey(Key.KeyType keyType)
    {
        return keyList.Contains(keyType); //Allows the function to return to value
    }

    private void OnTriggerEnter(Collider other)
    {
        Unlock unlock = GetComponent<Unlock>();
        if (unlock != null)
        {
            AddKey(unlock.GetKeyType());
            Destroy(unlock.gameObject);
        }

        Gemdoor gemDoor = GetComponent<Gemdoor>();
        if (gemDoor != null)
        {
            if (ContainKey(gemDoor.GetKeyType()))
            {
                gemDoor.OpenDoor();
                RemoveKey(gemDoor.GetKeyType());
            }

            
        }
    }
}


public class Key
{
    public class KeyType
    {
        
    }
}
