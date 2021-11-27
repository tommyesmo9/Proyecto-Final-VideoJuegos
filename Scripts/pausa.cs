using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{





   public void reiniciarnivel(){
   
    
    SceneManager.LoadScene("Nivel 1");
    Time.timeScale= 1f;
   }
   public void regresarmenu(){
        
       
        SceneManager.LoadScene("SampleScene");
        Time.timeScale= 1f;
   }
   public void salirjuego(){

       Application.Quit();
   }
}
