using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyrotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);

    }
}
