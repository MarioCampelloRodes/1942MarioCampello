using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Esta es la librería para poder usar los elementos de la UI

public class UIController : MonoBehaviour
{
    //Referenciamos las imágenes de las vidas
    public Image life1, life2, life3;

    // Start is called before the first frame update
    void Start()
    {
        life1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Con esto vamos a poner o quitar vidas de la UI
    }

    public void UpdateLifes(short lifes)
    {
        switch (lifes)
        {
            //En el caso en el que el jugador tenga 3 vidas
            case 3:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                break;

            case 2:
                life3.gameObject.SetActive(false);
                break;

            case 1:
                life2.gameObject.SetActive(false);
                break;

            case 0:
                life1.gameObject.SetActive(false);
                break;

            default:
                life1.gameObject.SetActive(false);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                break;
        }
    }
}
