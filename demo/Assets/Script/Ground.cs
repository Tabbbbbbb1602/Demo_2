using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject block;
    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            for (int j = 0; j < 40; j++)
            {
                if (i == 0 || j == 0 || i == 39 || j == 39)
                {
                    Instantiate(block, new Vector3(i, 0, j), Quaternion.identity);
                }
            }
        }
    }
}
