using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    
    public int rightScore, leftScore, upScore, downScore;

    [SerializeField]
    private int maxScore;

    [SerializeField]
    private BallController ball;


    //Wall
    [SerializeField]
    public GameObject upWall, rightWall, downWall, leftWall;

    [SerializeField]
    public Text Ranking1, Ranking2, Ranking3, Ranking4;


    public GameObject highScore;


    private int Ranking;
    private int rankingup;
    private int rankingdown;
    private int rankingleft;
    private int rankingright;

    public GameObject wallleft;
    public GameObject wallright;
    public GameObject wallup;
    public GameObject walldown;

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
                rankingright++;
                Ranking4.text = ("Green");
            }

            else if (Ranking == 2)
            {
                rankingright++;
                Ranking3.text = ("Green");
            }

            else if (Ranking == 3)
            {
                rankingright++;
                Ranking2.text = ("Green");
                

                GameOver();
            }
            else if (Ranking == 4)
            {
                Ranking1.text = ("Green");
                GameOver();
            }

            if (rankingright == 0)
            {
                
                Ranking1.text = ("Green");
                
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
                rankingleft++;
                Ranking4.text = ("Blue");
            }
            else if (Ranking == 2)
            {
                rankingleft++;
                Ranking3.text = ("Blue");
            }
            else if (Ranking == 3)
            {
                rankingleft++;
                Ranking2.text = ("Blue");
                
                GameOver();
                
            }

            else if (Ranking == 4)
            {
                Ranking1.text = ("Blue");
                GameOver();
            }

            if (rankingleft == 0)
            {
                
                Ranking1.text = ("Blue");
                
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
                rankingup++;
                Ranking4.text = ("Red");
            }
            else if (Ranking == 2)
            {
                rankingup++;
                Ranking3.text = ("Red");
            }
            else if (Ranking == 3)
            {
                rankingup++;
                Ranking2.text = ("Red");
                
                GameOver();
            }

            else if (Ranking == 4)
            {
                Ranking1.text = ("Red");
                GameOver();
            }

            if (rankingup == 0) 
            {
               
                Ranking1.text = ("Red");
                
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
           
            if (Ranking == 1)
            {
                rankingdown++;
                Ranking4.text = ("Yellow");
            }
            else if (Ranking == 2)
            {
                rankingdown++;
                Ranking3.text = ("Yellow");
            }
            else if (Ranking == 3)
            {
                rankingdown++;
                Ranking2.text = ("Yellow");
                
                GameOver();
            }

            else if (Ranking == 4)
            {
                Ranking1.text = ("Yellow");
                GameOver();
            }

            if (rankingdown == 0)
            {
                Ranking1.text = ("Yellow");
               
            }
        }

       
    }


    public void GameOver()
    {
       

        StartCoroutine(waitTime());
       

        //SceneManager.LoadScene("Score");
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(1);

        Time.timeScale = 0;
        highScore.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Ranking = 0;


        upWall.SetActive(false);
        downWall.SetActive(false);
        leftWall.SetActive(false);
        rightWall.SetActive(false);

        highScore.SetActive(false);

    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        if(rankingup != 1)
        {
            Ranking1.text = ("Red");
        }

        if (rankingdown!= 1)
        {
            Ranking1.text = ("Yellow");
        }

        if (rankingright != 1)
        {
            Ranking1.text = ("Green");
        }

        if (rankingleft != 1)
        {
            Ranking1.text = ("Blue");
        }

    }

}
