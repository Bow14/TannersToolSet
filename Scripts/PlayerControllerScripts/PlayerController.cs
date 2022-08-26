using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    public float turningSpeed = 5.0f;
    
    private Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       playerMovements();

        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.Rotate((Vector3.left * turningSpeed * verticalInput * Time.deltaTime));
    }

    void playerMovements()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");  
        
        playerRB.AddForce(Vector3.forward* speed * verticalInput);
        playerRB.AddForce(Vector3.right * speed * turningSpeed * horizontalInput);
    }
}
