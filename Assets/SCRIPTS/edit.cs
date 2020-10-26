using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class edit : MonoBehaviour
{
    
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            collision.gameObject.transform.tag = "ready";


          
        }

    }
}

