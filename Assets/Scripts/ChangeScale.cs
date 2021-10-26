using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{

    [SerializeField] private GameObject playerHumans;
    [SerializeField] private int powerUpValue = 50;
    [SerializeField] private int decreaserValue = 50;

    private int health = 0;


    private void Update()
    {
        if(health <= 0)
        {
            health = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            playerHumans.transform.localScale += new Vector3(0.07f, 0.07f, 0.07f);

            health += powerUpValue;

           
        }


        if (collision.gameObject.CompareTag("Decreaser"))
        {
            playerHumans.transform.localScale -= new Vector3(0.07f, 0.07f, 0.07f);

            health -= decreaserValue;
           
            
        }


        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

    public int ReturnHealth()
    {
        return health;
    }
}
