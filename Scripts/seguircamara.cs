using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguircamara : MonoBehaviour
{
    public GameObject seguir;
    public Vector2 mincamara, maxcamara;

   
    void FixedUpdate()
    {
        float posX = seguir.transform.position.x;
        float posY = seguir.transform.position.y;

        transform.position = new Vector3(
            Mathf.Clamp (posX, mincamara.x, maxcamara.x),
            Mathf.Clamp (posY, mincamara.y, maxcamara.y),
            transform.position.z);

        }
    }

