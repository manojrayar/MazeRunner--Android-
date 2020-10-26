using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    
    [SerializeField]
    Vector3 v3;
    [SerializeField]
    KeyCode keypositive;

    [SerializeField]
    KeyCode keynegative;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keypositive))
            GetComponent<Rigidbody>().velocity += v3;
        if (Input.GetKey(keynegative))
            GetComponent<Rigidbody>().velocity -= v3;

        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "box")
        {

            other.gameObject.SetActive(false);


            if (other.gameObject.tag == "box1")
                other.gameObject.SetActive(false);
        }
    }
}
