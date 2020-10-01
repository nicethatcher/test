using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material[] material;
    public Renderer rend;
    public int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        // по клику ЛКМ
        if (Input.GetMouseButtonDown(0))
        {
            if (i > 0)
            {
                rend.sharedMaterial = material[2];
            }
            else
            {
                rend.sharedMaterial = material[0];
            };
            i = 0 - i;
        }
    }
}
