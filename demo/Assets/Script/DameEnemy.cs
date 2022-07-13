using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameEnemy : MonoBehaviour
{
    public int enemy = 1;

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            /*Debug.Log("Enemy");*/
            enemy--;
            if (enemy <= 0)
            {
                Debug.Log("huy");
                Destroy(collision.gameObject);
            }
        }
    }
}
