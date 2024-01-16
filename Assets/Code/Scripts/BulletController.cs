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
        

        //Destruir�a el objeto al que est� asociado este c�digo en 2 segundos
        //Destroy(gameObject, 2f); es una manera de hacerlo
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //M�todo de Unity que hace una acci�n cuando se deja de ver por la c�mara
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //M�todo para saber cuando la bala se choca contra algo
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
