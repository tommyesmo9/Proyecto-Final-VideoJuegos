using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausaaaa : MonoBehaviour
{
 
 bool activar;
 Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled=false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown("escape")){
            activar = !activar;
            canvas.enabled=activar;
            Time.timeScale= (activar) ? 0 : 1f;
        }
    }
}
