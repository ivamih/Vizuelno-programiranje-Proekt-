using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death2 : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        GM2.instance.LoseLife();
        //Instantiate(brickParticle, transform.position, Quaternion.identity);
        // GM.instance.DestroyBrick();
        //Destroy(gameObject);
    }

}
