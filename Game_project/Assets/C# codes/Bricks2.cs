using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks2 : MonoBehaviour {


    public GameObject brickParticle;

    void OnCollisionEnter(Collision other)
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        GM2.instance.DestroyBrick();
        Destroy(gameObject);
    }
}
