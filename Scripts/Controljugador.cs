using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controljugador : MonoBehaviour
{
   private GameObject barradesalud;

   void Start(){
       barradesalud = GameObject.Find("Barrasalud");
   }

void OnTriggerEnter2D(Collider2D collition)
    {
        if (collition.gameObject.tag == "enemi"){
           
          barradesalud.SendMessage("BajarSalud",25);
           }

           else if (collition.gameObject.tag == "trampa"){
               barradesalud.SendMessage("BajarSalud",100);
           }

        
    }
}
    

