using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour, ITakeDame
{
    public int player = 3;

    public void takeDame(int dame)
    {
        player -= dame;
        Debug.Log(player);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "butllet")
        {
            takeDame(1);
            if(player <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

}
