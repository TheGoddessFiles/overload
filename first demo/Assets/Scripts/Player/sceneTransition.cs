using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("cafe"))
        {
            SceneManager.LoadScene("cafe");
        }
        else if (collision.CompareTag("palace"))
        {
            SceneManager.LoadScene("yui palace");
        }
        else if (collision.CompareTag("home"))
        {
            SceneManager.LoadScene("home");
        }
    }
}
