using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    #region Private
    [Header("Manager")]

    [SerializeField]
    private PowerUpManager manager;

    [SerializeField]
    private Collider2D ball;

    [SerializeField]
    private float magnitude;

    [SerializeField]
    private int destroy = 10;

    #endregion

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            //Speed Up the Ball
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
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
        Destroy(gameObject);
    }
}
