using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public float Radius = 10;
    public GameObject gameObject;

    void Start()
    {
        int i = 0;
        for ( ; ; )
        {
            int x = Random.Range(-10, 10);
            int z = Random.Range(-10, 10);
            if ((x*x + z*z) <= Radius*Radius)
            {
                i = i + 1;
                Instantiate(gameObject, new Vector3(x, 0, z), Quaternion.identity);
                if (i > 9) break;
            }
        }
    }
}
