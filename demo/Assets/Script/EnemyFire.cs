using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public int player = 10;
    public int wallRed = 3;
    public int wallGreen = 1;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wallRed")
        {
            wallRed--;
            if (wallRed <= 0)
            {
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.tag == "wallGreen")
        {
            Debug.Log("wallGreen");
            Debug.Log(wallRed);
            wallGreen--;
            if (wallGreen <= 0)
            {
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(player);
            Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }

    }
}
