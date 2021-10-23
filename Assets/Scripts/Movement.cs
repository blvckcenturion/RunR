using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
         float moveVertical = Input.GetAxis ("Vertical");
 
         Vector3 movement = new Vector3(moveHorizontal, speed, moveVertical);
 
         rb.AddForce (movement * speed);
    }
}
