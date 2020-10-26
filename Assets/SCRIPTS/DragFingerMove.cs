using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerMove : MonoBehaviour
{
    public Vector3 touchPosition;
    private Rigidbody rb;
    private Vector3 direction;
    private float moveSpeed = 10f;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
          
            rb.velocity = new Vector3(direction.x,direction.z) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector3.zero;
        }
    }
}

