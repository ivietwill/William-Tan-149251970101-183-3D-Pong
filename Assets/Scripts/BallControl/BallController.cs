using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
#region private

    [Header("Movement")]

    [SerializeField]
    private Vector3 speed;

    //[SerializeField]
    //private float speeds = 5f;

    
    private Vector3 resetPosition;

    [SerializeField]
    private float waitTime = 1;

    [SerializeField]
    private float multiply = 10;

    private Rigidbody rig;

    #endregion

    [SerializeField]
    private Transform[] spawnLocation;


    [SerializeField]
    private SphereCollider ball;


    //public GameObject ball;

    //Test Lerp
    [SerializeField]
    public Transform target;





    // Start is called before the first frame update
    void Start()
    {
        //SpawnBola();
        //spawnLocation = GameObject.FindGameObjectsWithTag("SpawnPoint");
        StartCoroutine(WaitTime());

        //StartCoroutine(DieTime());
        
       

        //transform.localPosition = speed;

        //rig.MovePosition(rig.transform.forward + speed * Time.deltaTime);


        //rig.velocity = speed;

    }

    private void Update()
    {
       
    }

    public void Moving()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed * multiply;
    }

    public void Die()
    {
        Destroy(ball);
    }

    IEnumerator WaitTime()
    {
        yield return new  WaitForSeconds(waitTime);

        Moving();
    }


    // Update is called once per frame
    //void Update()
    //{

    //    //rig.velocity = speed;
    //    //GetComponent<Transform>();
    //    //Vector3 pos = transform.position;
    //    //Transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);
    //    // transform.Translate (speed * Time.deltaTime);
    //}

    //Reset Ball
    public void ResetBall()
    {
        SpawnBola();
     
       
    }

    public void SpawnBola()
    {

        int spawn = Random.Range(0, spawnLocation.Length);
        //GameObject.Instantiate(ball, spawnLocation[spawn].transform.position, Quaternion.identity);
        ball.transform.position = spawnLocation[spawn].position;


    }


    IEnumerator tes()
    {
        yield return new WaitForSeconds(3);
    }


    //Movement Rigidbody
    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }


}
