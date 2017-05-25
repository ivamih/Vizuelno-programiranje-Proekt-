using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        GM.instance.LoseLife();
    }
}