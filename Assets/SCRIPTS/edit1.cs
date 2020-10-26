using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edit1 : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ready")
        {
            collision.gameObject.transform.tag = "readyexit";



        }

    }
}
