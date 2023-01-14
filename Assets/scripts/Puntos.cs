using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public bool player1Goal;
    public GameObject GameManager;

    public void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Ball"))
        {
            if (player1Goal)
            {
                GameManager.GetComponent<GameManager>().Player1Scored();
            }
            else
            {
                GameManager.GetComponent<GameManager>().Player2Scored();
            }
        }
    }
}
