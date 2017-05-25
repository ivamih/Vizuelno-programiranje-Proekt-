using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    public GameObject brickParticle;

    void OnCollisionEnter(Collision other)
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
/*        if (brickParticle.name == "Brick (4)")
        {
            if (GameObject.Find("Brick (7)"))
            {
                Destroy(GameObject.Find("Brick (7)"));
                GM.instance.DestroyBrick();
            }
            if (GameObject.Find("Brick (1)"))
            {
                Destroy(GameObject.Find("Brick (1)"));
                GM.instance.DestroyBrick();
            }

            if (GameObject.Find("Brick (5)"))
            {
                Destroy(GameObject.Find("Brick (5)"));
                GM.instance.DestroyBrick();
            }

            if (GameObject.Find("Brick (3)"))
            {
                Destroy(GameObject.Find("Brick (3)"));
                GM.instance.DestroyBrick();
            }
        }
        else {
        */
            GM.instance.DestroyBrick();
            Destroy(gameObject);
        //}
    }
}
