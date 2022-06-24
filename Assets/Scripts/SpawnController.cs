using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField]
    private int spawnInterval;

    private float timer;

    [SerializeField]
    private GameObject[] spawnLocation;

    [SerializeField]
    public SphereCollider ball;


    //[SerializeField]
    //private int ballCount = 5;

    //private int maxBall = 1;

    private void Start()
    {
        spawnLocation = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            addBall();
            timer -= spawnInterval;
        }

    }

    void addBall()
    {
        int spawn = Random.Range(0, spawnLocation.Length);
        GameObject.Instantiate(ball, spawnLocation[spawn].transform.position, Quaternion.identity);

    
        //int spawn = Random.Range(0, spawnLocation.Length);
        //transform.position = spawnLocation[spawn].position;
    }
}
