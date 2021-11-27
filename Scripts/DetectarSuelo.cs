using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarSuelo : MonoBehaviour
{
   public static bool TocarSuelo;


   private void OnTriggerEnter2D(Collider2D colision)
   {
       TocarSuelo= true;
   }

    private void OnTriggerExit2D(Collider2D colision)
   {
       TocarSuelo= false;
   }
}
