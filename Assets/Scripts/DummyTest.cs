using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyTest : MonoBehaviour
{
    //Start is called before the first frame update
    Transform player;

    int layerMask = 1 << 8;

    public Sprite[] GremlinFaces;

    SpriteRenderer SR;

    Vector3 Lookdirection;

    CharacterController mover;

    bool aggro = false;

    void Start()
    {
        mover = GetComponent<CharacterController>();
        SR = GetComponentInChildren<SpriteRenderer>();
        player = Camera.main.transform;
        Lookdirection = new Vector3(player.position.x, transform.position.y, player.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        SpriteAssigner();

        if (this.gameObject.name == "Gremlin")
        {
            if (Vector3.Distance(transform.position, player.position) < 2f || aggro)
            {
                LookAtPlayer();
            }

            if (Vector3.Distance(transform.position, player.position) > .5f)
            {
                if (aggro)
                {
                    mover.Move(transform.forward * Time.deltaTime * 0.6f);
                }
            }
        }
        else
        {
        }

        //Debug.Log(Vector3.Distance(transform.position, player.position));
    }

    void SpriteAssigner()
    {
        RaycastHit fronthit;
        RaycastHit backhit;
        RaycastHit lefthit;
        RaycastHit righthit;

        RaycastHit frontrighthit;
        RaycastHit frontlefthit;
        RaycastHit backlefthit;
        RaycastHit backrighthit;

        Physics.Raycast(transform.position, transform.forward, out fronthit, Mathf.Infinity, layerMask);
        Physics.Raycast(transform.position, -transform.forward, out backhit, Mathf.Infinity, layerMask);
        Physics.Raycast(transform.position, -transform.right, out lefthit, Mathf.Infinity, layerMask);
        Physics.Raycast(transform.position, transform.right, out righthit, Mathf.Infinity, layerMask);

        Physics.Raycast(transform.position, transform.forward + transform.right, out frontrighthit, Mathf.Infinity, layerMask);
        Physics.Raycast(transform.position, transform.forward - transform.right, out frontlefthit, Mathf.Infinity, layerMask);
        Physics.Raycast(transform.position, -transform.forward - transform.right, out backlefthit, Mathf.Infinity, layerMask);
        Physics.Raycast(transform.position, -transform.forward + transform.right, out backrighthit, Mathf.Infinity, layerMask);



        if (fronthit.collider != null)
        {
            Debug.Log("Player is to my: FRONT");
            SR.sprite = GremlinFaces[0];
            if (fronthit.distance < 2)
            {
                aggro = true;
            }
        }

        if (righthit.collider != null)
        {
            //Debug.Log("Player is to my: RIGHT");
            SR.sprite = GremlinFaces[6];
        }

        if (lefthit.collider != null)
        {
            //Debug.Log("Player is to my: LEFT");
            SR.sprite = GremlinFaces[2];
        }

        if (backhit.collider != null)
        {
            //Debug.Log("Player is to my: BACK");
            SR.sprite = GremlinFaces[4];
        }

        if (frontrighthit.collider != null)
        {
            //Debug.Log("Player is to my: FRONT-RIGHT");
            SR.sprite = GremlinFaces[7];
        }

        if (frontlefthit.collider != null)
        {
            //Debug.Log("Player is to my: FRONT-LEFT");
            SR.sprite = GremlinFaces[1];
        }

        if (backlefthit.collider != null)
        {
            //Debug.Log("Player is to my: BACK-LEFT");
            SR.sprite = GremlinFaces[3];
        }

        if (backrighthit.collider != null)
        {
            //Debug.Log("Player is to my: BACK-RIGHT");
            SR.sprite = GremlinFaces[5];
        }

    }

    void LookAtPlayer()
    {
        Lookdirection = Vector3.Lerp(Lookdirection, new Vector3(player.position.x, transform.position.y, player.position.z), Time.deltaTime * 5);

        transform.LookAt(Lookdirection);
    }
}
