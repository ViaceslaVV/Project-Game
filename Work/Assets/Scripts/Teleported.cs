using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleported : MonoBehaviour
{

    void Start()
    {
        if (transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
           
            
                SceneManager.LoadScene(1);
            
        }
    }


}
