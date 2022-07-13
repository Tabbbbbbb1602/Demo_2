using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject block;
    void Start()
    {
        for (int i = 2; i < 8; i++)
        {
            for (int j = 2; j < 8; j++)
            {
                if (i == 3 || j == 6 || i == 8 || j == 6)
                {
                    Instantiate(block, new Vector3(i, 0, j), Quaternion.identity);
                }
            }
        }

        for (int i = 20; i < 30; i++)
        {
            for (int j = 20; j < 30; j++)
            {
                if (i == 21 || j == 24 || i == 27 || j == 30)
                {
                    Instantiate(block, new Vector3(i, 0, j), Quaternion.identity);
                }
            }
        }
    }
}
