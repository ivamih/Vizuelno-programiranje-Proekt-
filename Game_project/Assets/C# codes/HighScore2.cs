using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore2 : MonoBehaviour {

    public static int score = 0;
    public static int highscore = 0;

    public Text text;
    public Text text_s;


    void Start()
    {
        //text = GetComponent<Text>();
        //text_s = GetComponent<Text>();
        //score = 0;
        text_s.text = "SCORE:" + score;
        //highscore = PlayerPrefs.GetInt("highscore", highscore);
        text.text = "HIGH SCORE:" + highscore;
    }

    public void Update()
    {
        text_s.text = "SCORE:" + score;
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
