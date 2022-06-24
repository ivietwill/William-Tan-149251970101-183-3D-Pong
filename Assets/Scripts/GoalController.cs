using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public Collider ball2;
    public Collider ball3;
    public Collider ball4;
    public Collider ball5;

    public bool isRight;
    public bool isLeft;
    public bool isUp;
    public bool isDown;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider col)
    {
        //if (collision == ball || collision == ball2 || collision == ball3 || collision == ball4 || collision == ball5)
        if (col.gameObject.tag == "ball")
        {
            Debug.Log("Test");
            if (isRight)
            {
                manager.AddRightScore(1);
            }

            if (isLeft)
            {
                manager.AddLeftScore(1);
            }

            if (isUp)
            {
                manager.AddUpScore(1);
            }

            if (isDown)
            {
                manager.AddDownScore(1);
            }
        }
    }

}
