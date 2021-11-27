using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dano1 : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("player")){
            Debug.Log("-50 de vida");
            //Destroy(collision.gameObject);
        }
    }

}
