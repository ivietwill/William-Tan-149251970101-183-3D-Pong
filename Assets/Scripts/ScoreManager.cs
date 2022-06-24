using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int upScore;
    public int downScore;

    public int maxScore;

    public BallController ball;


    //Wall
    public GameObject upWall;
    public GameObject rightWall;
    public GameObject downWall;
    public GameObject leftWall;

    public Text Ranking1;
    public Text Ranking2;
    public Text Ranking3;
    public Text Ranking4;

    public GameObject highScore;


    private int Ranking;


   

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();

        if(rightScore >= maxScore)
        {
            rightWall.SetActive(true);
            
            Ranking++;

            if (Ranking == 1)
            {
                Ranking4.text = ("Green");
            }

            else if (Ranking == 2)
            {
                Ranking3.text = ("Green");
            }

            else if (Ranking == 3)
            {
                Ranking2.text = ("Green");
            }

            else if (Ranking > 3)
            {
                Ranking1.text = ("Green");
                GameOver();
            }
        }

       

    }

    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBall();
        if(leftScore >= maxScore)
        {
            leftWall.SetActive(true);
            Ranking++;
            

            if (Ranking == 1)
            {
                Ranking4.text = ("Blue");
            }
            else if (Ranking == 2)
            {
                Ranking3.text = ("Blue");
            }
            else if (Ranking == 3)
            {
                Ranking2.text = ("Blue");
            }
            else if (Ranking == 4)
            {
                Ranking1.text = ("Blue");
                GameOver();
            }

        }

      
    }

    public void AddUpScore(int increment)
    {
        
        upScore += increment;
        ball.ResetBall();
        if(upScore >= maxScore)
        {
            upWall.SetActive(true);
            Ranking++;
          

            if (Ranking == 1)
            {
                Ranking4.text = ("Red");
            }
            else if (Ranking == 2)
            {
                Ranking3.text = ("Red");
            }
            else if (Ranking == 3)
            {
                Ranking2.text = ("Red");
            }
            else if (Ranking == 4)
            {
                Ranking1.text = ("Red");
                GameOver();
            }
        }

       
    }

    public void AddDownScore(int increment)
    {
        downScore += increment;
        ball.ResetBall();
        if(downScore >= maxScore)
        {
            downWall.SetActive(true);
            Ranking++;
            
            if (Ranking == 0)
            {

            }
            if (Ranking == 1)
            {
                Ranking4.text = ("Yellow");
            }
            else if (Ranking == 2)
            {
                Ranking3.text = ("Yellow");
            }
            else if (Ranking == 3)
            {
                Ranking2.text = ("Yellow");
            }
            else if (Ranking == 4)
            {
                Ranking1.text = ("Yellow");
                GameOver();
            }
        }

       
    }


    public void GameOver()
    {
        highScore.SetActive(true);
        //SceneManager.LoadScene("Score");
    }
    // Start is called before the first frame update
    void Start()
    {
        Ranking = 0;

        upWall.SetActive(false);
        downWall.SetActive(false);
        leftWall.SetActive(false);
        rightWall.SetActive(false);

        highScore.SetActive(false);

    }


    // Update is called once per frame
  
 
}
