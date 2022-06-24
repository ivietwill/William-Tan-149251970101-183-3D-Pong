using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;
    public Text skorUp;
    public Text skorDown;

    public ScoreManager manager;


    // Update is called once per frame
    void Update()
    {
        skorKiri.text = ("Blue: ") + manager.leftScore.ToString();
        skorKanan.text = ("Green: ") + manager.rightScore.ToString();
        skorUp.text = ("Red: ") +manager.upScore.ToString();
        skorDown.text =("Yellow: ") +manager.downScore.ToString();
    }
}
