using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public GameObject block;
    void Start()
    {
        for (int i = 10; i < 20; i++)
        {
            for (int j = 10; j < 20; j++)
            {
                if (i == 10 || j == 10 || i == 19 || j == 19)
                {
                    Instantiate(block, new Vector3(i, 0, j), Quaternion.identity);
                }
            }
        }

        for (int i = 30; i < 39; i++)
        {
            for (int j = 30; j < 39; j++)
            {
                if (i == 30 || j == 30 || i == 36 || j == 34)
                {
                    Instantiate(block, new Vector3(i, 0, j), Quaternion.identity);
                }
            }
        }
    }
}
