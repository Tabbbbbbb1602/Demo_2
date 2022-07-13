using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public int enemy = 2;

    public void takeDame(int dame)
    {
        enemy -= dame;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "butllet")
        {
            takeDame(1);
            if (enemy <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
