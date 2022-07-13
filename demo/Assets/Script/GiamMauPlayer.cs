using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiamMauPlayer : MonoBehaviour
{
    public int hp = 3;
    public int wallRed = 3;
    public int wallGreen = 1;
    public int player = 5;
    public void OnCollisionEnter(Collision collision)
    {
        /*if(collision.gameObject.tag == "Enemy")
        {
           *//* Debug.Log("Enemy");*//*
            hp--;
            if(hp <= 0)
            {
                Destroy(collision.gameObject);
            }
        }*/

        /*  if (collision.gameObject.tag == "wallRed")
          {
              *//*Debug.Log("wallRed");*/
        /*Debug.Log(wallRed);*//*
        wallRed--;
        if (wallRed <= 0)
        {
            Destroy(collision.gameObject);
        }
    }*/

        /* if (collision.gameObject.tag == "wallGreen")
         {
             *//*Debug.Log("wallGreen");*//*
             wallGreen--;
             if (wallGreen <= 0)
             {
                 Destroy(collision.gameObject);
             }
         }*/

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(player);
            player--;
            if (player <= 0)
            {
                /*Destroy(collision.gameObject);*/
                Debug.Log("Player Die");
            }
        }
    }
}
