using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour {

   // public GameObject brickParticle;
    void OnTriggerEnter(Collider col)
    {
        GM.instance.LoseLife();
        //Instantiate(brickParticle, transform.position, Quaternion.identity);
       // GM.instance.DestroyBrick();
        //Destroy(gameObject);
    }
    
}