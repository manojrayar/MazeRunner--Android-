using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="readyexit")
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        
    }

}
