using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankControl : MonoBehaviour
{
    public Rigidbody RB;

    public Vector2 inputVector;

    public float thrustSpeed = 10;
    public float torqueSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");

        inputVector.y = Input.GetAxis("Vertical");


    }

    private void FixedUpdate()
    {
        //RB.AddForce(transform.forward * inputVector.y * thrustSpeed, ForceMode.Impulse);
        //transform.forward = new Vector3(0, 0, 1);
        RB.AddTorque(transform.up * inputVector.x * torqueSpeed, ForceMode.Impulse);

    }
}
