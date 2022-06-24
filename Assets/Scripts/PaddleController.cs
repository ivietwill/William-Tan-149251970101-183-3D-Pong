using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    #region Private
    [Header("Paddle Settings")]

    [SerializeField]
    private KeyCode upKey;

    [SerializeField]
    private KeyCode downKey;

    [SerializeField]
    private KeyCode rightKey;

    [SerializeField]
    private KeyCode leftKey;

    [SerializeField]
    private float timesUp;

    [SerializeField]
    private int scale = 4;

    [SerializeField]
    private int speed;

    [SerializeField]
    private int TimesSpeed = 2 ;


    private Rigidbody rig;

    

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {

        if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }

        else if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }

        else if(Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }

        else if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        //Debug.Log("Test :" + movement);
        rig.velocity = movement;
    }




    //Adding Scale Up for Paddle, Collide with Ball
    public void ActivatePUScaleUp()
    {
        this.gameObject.transform.localScale += new Vector3(0,scale, 0);
        StartCoroutine(NormalScale());
    }

    public void ActivatePUHandleUp()
    {
        speed = TimesSpeed * speed;
        StartCoroutine(NormalSpeed());
    }

    IEnumerator NormalScale()
    {
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(timesUp);
        Debug.Log("Test");
        this.gameObject.transform.localScale -= new Vector3(0, scale, 0);
    }

    IEnumerator NormalSpeed()
    {
        yield return new WaitForSeconds(timesUp);
        Debug.Log("Speed Abis");
        speed = speed / TimesSpeed;
    }


}
