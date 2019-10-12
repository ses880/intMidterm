using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasdControl : MonoBehaviour
{
    public float speed = 1f;
    public float turnSpeed = 3f;
    public float movement = 10f;
    public Rigidbody RB;

    //public GameObject object1;

    // Start is called before the first frame update
    void Start()
    {
       RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        
  
    
        /* 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, turnSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -turnSpeed, 0);
        }
        */
        
        if (Input.GetKey(KeyCode.D))
        {
             //transform.Translate(speed, 0, 0);
            RB.AddForce(transform.right * movement, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            RB.AddForce(-transform.right * movement, ForceMode.Impulse);
        }
        

        if (Input.GetKey(KeyCode.W))
        {
            RB.AddForce(transform.forward * movement, ForceMode.Impulse); 
        }

        
        if (Input.GetKey(KeyCode.S))
        {
            RB.AddForce(-transform.forward * movement, ForceMode.Impulse);
        }
        
    }

   /* public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "object" && Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("found an object!");
        }

        if (collision.gameObject.tag == "treasure" && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("found the treasure!");
        }
    }
    */
}
