using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject player1;
    public GameObject playerGoal;

    public GameObject player2;
    public GameObject player2Goal;

    public Text marcadorPlayer1;
    public Text marcadorPlayer2;

    private int player1Score;
    private int player2Score;
// inteligencia
    public bool IAGame;
    // metodo para aumentar en el marcador
    public void Player1Scored(){
        player1Score ++;
        marcadorPlayer1.text = player1Score.ToString();
        checkWin();
        ResetPosition();
    }
    public void Player2Scored(){
        player2Score ++;
        marcadorPlayer2.text = player2Score.ToString();
        checkWin();
        ResetPosition();
    }
// condicion para ganar el juego
    public int vicScore = 2;
// creacion de metodo para verificar si el marcador ha sido punteado a 6
    public void checkWin(){
        if (player1Score >= vicScore)
        {
            SceneManager.LoadScene("VictoriaJug2");
        }
        if (player2Score >= vicScore)
        {
            SceneManager.LoadScene("VictoriaJug1");
        }
    }

// reseteo de elementos raqueta y pelota
    private void ResetPosition(){
    if (IAGame)
    {
    ball.GetComponent<Pelota>().Reset();
    player2.GetComponent<Players>().Reset();
    }
    else
    {
    ball.GetComponent<Pelota>().Reset();
    player1.GetComponent<Players>().Reset();
    player2.GetComponent<Players>().Reset();
    }
    }
}
