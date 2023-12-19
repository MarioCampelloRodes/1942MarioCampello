using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //La jarra de agua. Rellena el contador
    public float spawnTime;
    //El contador de tiempo entre spawns
    private float spawnCounter;

    //Referencia a la nave enemiga
    public GameObject smallEnemy;
    // Start is called before the first frame update
    void Start()
    {
        //Iniciamos el contador
        spawnCounter = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        //Si el contador de spawn no está vacío
        if(spawnCounter > 0)
        {
            spawnCounter -= Time.deltaTime;
        }
        else
        {
            SpawnEnemy();
            spawnCounter = spawnTime;
        }
    }

    public void SpawnEnemy()
    {
        //Cogemos un número aleatorio entre esos 2 valores
        float xPosition = Random.Range(-4.0f, 4.0f);
        //Hacemos aparecer una nave, en la posición del spawner y una posición aleatoria en x
        Instantiate(smallEnemy, new Vector2(xPosition, transform.position.y), smallEnemy.transform.rotation);
    }
}
