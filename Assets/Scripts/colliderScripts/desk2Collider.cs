using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desk2Collider : MonoBehaviour
{
    public GameObject player;
    public GameObject displayText;

    public Collider colDesk2;
    public Rigidbody RB;


    // Start is called before the first frame update
    void Start()
    {
        displayText.SetActive(false);

        colDesk2 = GetComponent<Collider>();


    }

    // Update is called once per frame
    void Update()
    {
        displayText.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        displayText.SetActive(true);
        Debug.Log("enter desk2");
    }

    private void OnCollisionExit(Collision collision)
    {
        displayText.SetActive(false);
        Debug.Log("exit desk2");
    }
}
