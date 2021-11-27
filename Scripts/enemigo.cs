using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collition)
    {
        if (collition.gameObject.tag == "player"){
           
           if (transform.position.y < collition.transform.position.y){
               Destroy(gameObject);
           }
        }
    }
}
