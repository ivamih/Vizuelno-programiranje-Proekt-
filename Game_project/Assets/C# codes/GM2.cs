using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM2 : MonoBehaviour
{

    public int level = 2;
    public int lives = GM.lives;
    public int bricks = 24;
    public float resetDelay = 1f;
    public Text livesText = GM.instance.livesText;
    public Text levelText;
    public GameObject pres_r;
    public GameObject gameOver;
    public GameObject lvl;
    public GameObject youWon;
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    public GameObject ball;
    public static GM2 instance = null;

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
            Time.timeScale = 0f;
            Invoke("Finish", resetDelay);
            //level = 1;
        }

        if (bricks < 1)
        {
            youWon.SetActive(true);
            //   Time.timeScale = .25f;
            //System.Threading.Thread.Sleep(2000);
            //bricks = 24;
            Invoke("Finish", resetDelay);
        }



        if (GM.lives < 1)
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
        GM.lives--;
        livesText.text = GM.lives.ToString();
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupCube", resetDelay);
        CheckGameOver();
    }

    public void LevelUp()
    {
        //level++;
        levelText.text = "LEVEL: " + level;
        DestroyAll();
        //System.Threading.Thread.Sleep(3);
        //Instantiate(bricksPrefab, transform.position, Quaternion.identity);
        //Application.LoadLevel("Level3");
        //Invoke("Reset", resetDelay);
        //CheckGameOver();
        SetupPaddle();
    }
    private void DestroyAll()
    {
        Destroy(clonePaddle);
        DestroyBrick();
        Destroy(paddle);
        Destroy(gameObject);
        Destroy(bricksPrefab);
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
        HighScore2.score++;
        bricks--;
        CheckGameOver();
    }
    void Finish()
    {
        DestroyAll();
        pres_r.SetActive(true);
        Time.timeScale = 0;
        if (HighScore2.score > HighScore2.highscore)
            HighScore2.highscore = HighScore2.score;
        HighScore2.Reset();
    }
}