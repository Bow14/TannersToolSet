using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{
    public Vector3 left;
    public Vector3 right;
    public Rigidbody playerRB;
    public Vector3 forward;
    public Vector3 backward;

    public GameObject powerUpIndictator;
    public bool hasPowerUp = false;


    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRB.AddRelativeForce(forward, ForceMode.Force);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRB.AddRelativeForce(backward, ForceMode.Force);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.AddRelativeTorque(left, ForceMode.Acceleration);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.AddRelativeTorque(right, ForceMode.Acceleration);
        }

        powerUpIndictator.transform.position = transform.position + new Vector3(0, 0, 0);
        powerUpIndictator.transform.rotation = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            powerUpIndictator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            Debug.Log("You have interacted with me");
        }
        
    }

//    IEnumerator PowerUpIndicator()
//    {
//        powerUpInd.gameObject.SetActive(false);
//    }
    


//    private void OnCollisionEnter(Collision other)
//    {
//        GameObject.Find("Player");
//    }
}
