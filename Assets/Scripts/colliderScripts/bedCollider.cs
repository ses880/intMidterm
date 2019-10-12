using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedCollider : MonoBehaviour
{
    public GameObject player;
    public GameObject displayText;
    public GameObject imageTest;

    public Collider colBed;
    public Rigidbody RB;


    // Start is called before the first frame update
    void Start()
    {
        displayText.SetActive(false);

        colBed = GetComponent<Collider>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            //displayText.SetActive(true);
            imageTest.SetActive(true);
            Debug.Log("enter bed");


        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //displayText.SetActive(false);
            imageTest.SetActive(false);
            Debug.Log("exit bed");

        }
    }
}
