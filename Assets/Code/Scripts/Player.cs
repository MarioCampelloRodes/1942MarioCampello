using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variable para la velocidad del avión
    public float shipSpeed = 5.0f;

    public string verticalAxe;
    public string horizontalAxe;

    //Referencia al RigidBody
    public Rigidbody2D rb;

    Vector2 direction;

    //Referencia a la bala
    public GameObject bullet;

    //Referencia al punto de disparo del avión
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxis(verticalAxe);
        float horizontalMovement = Input.GetAxis(horizontalAxe);

        direction = new Vector2(horizontalMovement, verticalMovement).normalized;
        
        rb.velocity = direction * shipSpeed;

        //Si pulsamos para disparar una bala
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Crear un objeto es crear una instancia, que es una unidad de algo
            //Le pasamos el objeto que queremos que aparezca, en la posición y rotación deseadas
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        }
    }
}
