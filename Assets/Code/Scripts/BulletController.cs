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
        bulletRB.velocity = new Vector2(0f, bulletSpeed);

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
}
