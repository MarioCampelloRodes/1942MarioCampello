using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("Game");
    }

    public void ChangeScene()
    {
        //Carga la escena con ese nombre
        SceneManager.LoadScene("Game");
    }
}
