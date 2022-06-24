using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField]
    private Collider ball;

    [SerializeField]
    private float magnitude;


    private void OnTriggerEnter(Collider colSpeed)
    {
        if (colSpeed.gameObject.tag == "ball")
        {
           
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
