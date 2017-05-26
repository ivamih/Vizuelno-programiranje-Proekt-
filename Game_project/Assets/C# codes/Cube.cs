using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public float paddleSpeed = 0.5f;


    private Vector3 playerPos = new Vector3(0, 1, 0);

    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -9.2f, 9.2f), 1, 0f);
        transform.position = playerPos;

    }
}