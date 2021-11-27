using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class barrasalud2 : MonoBehaviour
{
    public Image salud;
    public float hp, maxHP = 100f;


    void Start()
    {
       hp = maxHP;
    }

    public void BajarSalud(float bajada){ 
        hp = Mathf.Clamp(hp-bajada,0f, maxHP);
        salud.transform.localScale = new Vector2(hp/maxHP,1);

        if (hp==0){
            Destroy(GameObject.FindWithTag("player"));
            reiniciarjuego();
        }
    }

    public void reiniciarjuego(){
        SceneManager.LoadScene("Nivel 3");
    }
}
