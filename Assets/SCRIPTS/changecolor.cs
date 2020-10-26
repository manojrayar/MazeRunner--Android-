using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "box")
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            if(col.gameObject.tag=="box1")
            rend.sharedMaterial = material[2];
        }
    }

}
