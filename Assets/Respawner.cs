using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    Vector3 respawnPosition;
    Vector3 heightDelta;
    Rigidbody rb;
    void Start()
    {
        respawnPosition = gameObject.transform.position;
        heightDelta = new Vector3(0, 2, 0);
        rb = GetComponent < Rigidbody > ();
    }

    // Update is called once per frame
    void Update()
    {
        respawn();
    }

    void respawn()
    {
        if (gameObject.transform.position.y<-10)
        {
            gameObject.transform.position = respawnPosition + heightDelta;
            rb.velocity = Vector3.zero;
        }
    }

}
