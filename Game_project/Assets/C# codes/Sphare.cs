using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphare : MonoBehaviour {

    public float ballInitialVelocity = 500f;


    private Rigidbody rb;
    private bool ballInPlay;

    void Awake()
    {

        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
        }
    }
}
