using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanVaChamVoiDat : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "butllet")
        {
            Destroy(collision.gameObject);
        }
    }
}
