using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player, enemySpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método para reiniciar el juego
    public void ResetGame()
    {
        //Carga la misma escena en la que estamos
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Método para jugar otra partida
    public void AnotherLife()
    {
        //LLamamos a la corrutina desde otro método para que al ejecutarlo en el update solo se realice una vez
        StartCoroutine(AnotherLifeCo());
    }

    //Corrutina para cuando jugamos otra vida
    private IEnumerator AnotherLifeCo()
    {
        //Desactivo al jugador
        player.SetActive(false);

        enemySpawner.SetActive(false);

        //Ponemos al jugador en la posición de origen
        player.transform.position = new Vector2(0f, -3.5f);

        //Esperamos un tiempo de 2 segundos
        yield return new WaitForSeconds(2f);

        //Reactivamos al jugador
        player.SetActive(true);

        enemySpawner.SetActive(true);
    } 
}
