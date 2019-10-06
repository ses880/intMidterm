using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatyScript : MonoBehaviour
{
    public float myRayDistance = 1.6f;

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, Vector3.down);

        

        Debug.DrawRay(myRay.origin, myRay.direction * myRayDistance, Color.black);

        if (Physics.Raycast(myRay, myRayDistance))
        {
            print("ground touch");
        }

        else
        {
            print("airborne");
            transform.Rotate(0, .1f, 0);
            transform.Translate(0f, 0f, 1 * Time.deltaTime);
        }

       /* if(this.transform.position.y >= 4)
        {
            transform.Translate(0f, -.5f, 0f);
        }
        else if(this.transform.position.y <= 5)
        {
            transform.Translate(0f, .5f, 0f);
        }
        */

    }
}
