using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform playerTransform;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
