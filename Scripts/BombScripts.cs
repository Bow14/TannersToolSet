using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScripts : MonoBehaviour
{
    //public float speed = 5.0f;
    //private Rigidbody bombRB;

    public CarDriving playerCar;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //bombRB = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //bombRB.AddForce(Vector3.forward * speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && playerCar.hasPowerUp == false)
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            Debug.Log("Good");
        }
        else if (other.gameObject.CompareTag("Player") && playerCar.hasPowerUp)
        {
            playerCar.hasPowerUp = false;
            gameObject.SetActive(false);
            playerCar.powerUpIndictator.SetActive(false);
        }
    }
    
}
