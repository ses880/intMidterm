using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasdControl : MonoBehaviour
{
    public float speed = 1f;
    public float turnSpeed = 3f;

    //public GameObject object1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
            transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed);
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
