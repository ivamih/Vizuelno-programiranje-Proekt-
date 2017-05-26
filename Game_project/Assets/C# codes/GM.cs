using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

    public int level = 1;
    public static int lives = 3;
    public int bricks = 18;
    public float resetDelay = 1f;
    public Text livesText;
    public Text levelText;
    public GameObject pres_r;
    public GameObject gameOver;
    public GameObject lvl;
    public GameObject youWon;
    public GameObject bricksPrefab;
    // public GameObject bricksPrefab2;
    public GameObject paddle;
    public GameObject deathParticles;
    public GameObject ball;
    public static GM instance = null;


    private GameObject clonePaddle;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Setup();

    }

    public void Setup()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }

    void CheckGameOver()
    {

        if (level == 3)
        {
            youWon.SetActive(true);
            pres_r.SetActive(true);
           // Time.timeScale = 0f;
            Invoke("Finish", resetDelay);
            //level = 1;
        }

        if (bricks < 1)
        {
            //lvl.SetActive(true);
          //  youWon.SetActive(true);
            
            bricks = 24;
            //LevelUp();

            LevelUp();

        }



        if (lives < 1)
        {
            gameOver.SetActive(true);
            //pres_r.SetActive(true);
            //Time.timeScale = .25f;
            Invoke("Finish", resetDelay);
        }

    }

    void Reset()
    {

        Time.timeScale = 1f;
        Application.LoadLevel(Application.loadedLevel);

    }

    public void LoseLife()
    {
        lives--;
        livesText.text = lives.ToString();
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupCube", resetDelay);
        CheckGameOver();
    }

    public void LevelUp()
    {
        //level++;
        //levelText.text = "LEVEL: " + level;
        Application.LoadLevel("Level2");
        //Instantiate(bricksPrefab2, transform.position, Quaternion.identity);
        //Invoke("Reset", resetDelay);
        //CheckGameOver();
        // SetupPaddle();
    }
    private void DestroyAll()
    {
        Destroy(clonePaddle);
       // DestroyBrick();
        Destroy(paddle);
       // Destroy(gameObject);
       // Destroy(bricksPrefab);
        Destroy(ball);
    }
    void SetupPaddle()
    {
        clonePaddle = Instantiate(ball, transform.position, Quaternion.identity) as GameObject;
    }
    void SetupCube()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void DestroyBrick()
    {
        bricks--;
        HighScore.score++;
        HighScore2.score++;

        CheckGameOver();
    }
    void Finish()
    {
        DestroyAll();
        pres_r.SetActive(true);
        if(HighScore.score > HighScore.highscore)
            HighScore.highscore = HighScore.score;
        HighScore.Reset();
        HighScore2.Reset();
    }
}
