using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Para cambiar entre escena
public class AudioManager : MonoBehaviour
{
    //Arrays para los sonidos y la música
    public AudioClip[] sfx, music;

    // Start is called before the first frame update
    void Start()
    {
        PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic()
    {
        //Si estamos en el menu principal, reproducimos la primera música del array
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            //Reproducimos la primera música del array
            music[0].Play();
        }

        if (SceneManager.GetActiveScene().name == "Game")
        {
            //Reproducimos la primera música del array
            music[1].Play();
        }
    }
}
