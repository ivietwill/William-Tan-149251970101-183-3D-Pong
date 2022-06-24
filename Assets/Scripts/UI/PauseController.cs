using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject pauseObj;

    public void pauseMenu()
    {
        Time.timeScale = 0;
    }

    public void resumeMenu()
    {
        Time.timeScale = 1;
        pauseObj.SetActive(false);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseObj.SetActive(true);
        }
    }
}
