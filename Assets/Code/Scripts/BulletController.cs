using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 7f;

    //Referencia al RB de la bala
    public Rigidbody2D bulletRB;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Bullet"))
        {
            bulletRB.velocity = new Vector2(0f, bulletSpeed);
        }
        if (gameObject.CompareTag("EnemyBullet"))
        {
            bulletRB.velocity = new Vector2(0f, -0.5f * bulletSpeed);
        }
        

        //Destruiría el objeto al que está asociado este código en 2 segundos
        //Destroy(gameObject, 2f); es una manera de hacerlo
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Método de Unity que hace una acción cuando se deja de ver por la cámara
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //Método para saber cuando la bala se choca contra algo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Si el objeto contra el que colisionamos es una bala o una bala enemiga
        if(collision.gameObject.CompareTag("Bullet") || collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
