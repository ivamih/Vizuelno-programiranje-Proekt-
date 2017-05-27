﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

//    public static GameObject go_score;

    //public static GameObject go_highscore;

    public static int score;
    public static int highscore;

    public Text text;
    public Text text_s;
    

    void Start()
    {
        //text = GetComponent<Text>();
        //text_s = GetComponent<Text>();
        score = 0;
        text_s.text = "SCORE:0";
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        text.text = highscore.ToString();
    }

    public void Update()
    {
       // text_s.text = "SCORE:" + score;
        if (score > highscore)
        {
            highscore = score;
        }
        text.text = "HIGH SCORE:" + highscore;

        PlayerPrefs.SetInt("highscore", highscore);
        
    }


    public static void Reset()
    {
        score = 0;
    }
}
 
