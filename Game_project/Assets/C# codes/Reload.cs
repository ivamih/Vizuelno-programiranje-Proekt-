using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    GameObject[] pauseObjects;
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnReload");
        show();
    }
    void Update()
    {

        //uses the r button reload the level
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload_();
        }

    }

    void show()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
    public void Reload_()
    {
        GM.lives = 3;
        Application.LoadLevel("Jane");
    }


}