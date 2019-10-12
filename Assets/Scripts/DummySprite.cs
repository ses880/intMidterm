using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummySprite : MonoBehaviour
{
    Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = Camera.main.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
    }
}
