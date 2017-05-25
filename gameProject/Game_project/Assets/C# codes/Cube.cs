using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public float paddleSpeed = 1f;


    private Vector3 playerPos = new Vector3(0, 1, 0);

    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 9f), 1, 0f);
        transform.position = playerPos;

    }
}