using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUHandleUpController : MonoBehaviour
{
    [SerializeField]
    private PowerUpManager manager;

    [SerializeField]
    private Collider2D ball;

    [SerializeField]
    private int destroy = 2;

    [SerializeField]
    private GameObject paddle1;

    [SerializeField]
    private GameObject paddle2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            //Speed Up the Ball
          
            paddle1.GetComponent<PaddleController>().ActivatePUHandleUp();
            paddle2.GetComponent<PaddleController>().ActivatePUHandleUp();
            manager.RemovePowerUp(gameObject);

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathTime());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator DeathTime()
    {
        yield return new WaitForSeconds(destroy);
        Debug.Log("Game Should be Destroyed");
        Destroy(gameObject);
    }
}
