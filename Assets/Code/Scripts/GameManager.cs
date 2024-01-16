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

    //M�todo para reiniciar el juego
    public void ResetGame()
    {
        //Carga la misma escena en la que estamos
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //M�todo para jugar otra partida
    public void AnotherLife()
    {
        //LLamamos a la corrutina desde otro m�todo para que al ejecutarlo en el update solo se realice una vez
        StartCoroutine(AnotherLifeCo());
    }

    //Corrutina para cuando jugamos otra vida
    private IEnumerator AnotherLifeCo()
    {
        //Desactivo al jugador
        player.SetActive(false);

        enemySpawner.SetActive(false);

        //Ponemos al jugador en la posici�n de origen
        player.transform.position = new Vector2(0f, -3.5f);

        //Esperamos un tiempo de 2 segundos
        yield return new WaitForSeconds(2f);

        //Reactivamos al jugador
        player.SetActive(true);

        enemySpawner.SetActive(true);
    } 
}
