using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField]
    Transform trans;

    // Update is called once per frame
    void Update()
    {
        transform.position = trans.position;
        
    }
}
