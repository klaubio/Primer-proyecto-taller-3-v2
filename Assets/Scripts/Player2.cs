using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public float fuerzaGolpe;
    public Vector2 direccionImpulso;
    public Rigidbody2D rb2d;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("GolpeP1"))
        {
            if(collision.transform.position.x < transform.position.x)
                direccionImpulso.x = 1;
            else 
                direccionImpulso.x = -1;
           rb2d.AddForce(direccionImpulso * fuerzaGolpe, ForceMode2D.Impulse);
        }
    }

}
