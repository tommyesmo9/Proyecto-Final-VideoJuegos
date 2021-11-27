using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dano : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("player")){
            Debug.Log("-15 de vida");
            //Destroy(collision.gameObject);
        }
    }

}
