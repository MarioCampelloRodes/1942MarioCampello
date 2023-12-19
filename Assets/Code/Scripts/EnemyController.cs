using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Referencia al rigidbody de la nave enemiga
    public Rigidbody2D rb;

    public float enemySpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //La nave se mueve
        rb.velocity = Vector2.down * enemySpeed; //Vector2.down == new Vector2(0f, -1f)

        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método que detecta cuando un objeto se mete dentro de la nave enemiga
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si es una bala
        if(collision.CompareTag("Bullet"))
        {
            //Destruimos la bala
            Destroy(collision.gameObject);
            //Destruimos la nave
            Destroy(gameObject);
        }
    }
    
}
