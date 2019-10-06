using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deskColliderScript : MonoBehaviour
{
    public GameObject player;
    public GameObject displayText;

    public Collider colDesk;
    public Rigidbody RB;

    
    // Start is called before the first frame update
    void Start()
    {
        displayText.SetActive(false);

        colDesk = GetComponent<Collider>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        displayText.SetActive(true);
        Debug.Log("enter");
    }

    private void OnCollisionExit(Collision collision)
    {
        displayText.SetActive(false);
        Debug.Log("exit");
    }
}
