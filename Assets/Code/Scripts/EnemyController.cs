using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Referencia al rigidbody de la nave enemiga
    public Rigidbody2D rb;

    //Referencia a las balas enemigas
    public GameObject enemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        //La nave se mueve hacia abajo, cogemos un número aleatorio para la velocidad
        float speed = Random.Range(1.5f, 3.0f);

        rb.velocity = new Vector2(0f, -speed);

        //Disparamos balas
        InvokeRepeating("Shoot", 0.5f, 1f); //Invoke Repeating(nombre del método, tiempo hasta la primera vez, cada cuanto se repite)

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

    public void Shoot()
    {
        Instantiate(enemyBullet, new Vector2(transform.position.x,transform.position.y -0.1f), enemyBullet.transform.rotation);
    }
    
}
