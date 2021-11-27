using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambionivel3 : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collition)
    {
        if (collition.gameObject.tag == "player"){
           
         SceneManager.LoadScene("Nivel 3");
           }

        
    }
}
