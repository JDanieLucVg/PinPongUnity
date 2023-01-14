using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
// metodos para funcion de botones

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayerVSIA(){
        SceneManager.LoadScene("JugadorVsIA");
    }

    public void PlayerVSPlayer(){
        SceneManager.LoadScene("JugadorVSJugador");
    }
}
