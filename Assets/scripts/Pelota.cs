using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float speed = 6;
    public Rigidbody2D rb;
    
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        Launch();
    }
// Resetear la posicion de la pelota cuando se marca un punto
    public void Reset(){
        transform.position  = startPos;
        rb.velocity = Vector2.zero;
        Launch();
    }
// Este metodo es para que se encarge de lanzar la pelota a una posision derecha o izquierda de forma aleatoria
// == es un if basicamente que quiere decir si el valor es 0 tendremos el valor -1(izq) y si no 1(der) 
    public void Launch(){
        float x= Random.Range(0,2) == 0 ? -1 : 1;
        float y= Random.Range(0,2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(speed*x,speed*y);
    }
}
