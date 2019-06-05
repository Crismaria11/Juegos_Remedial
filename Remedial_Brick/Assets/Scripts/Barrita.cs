using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrita : MonoBehaviour
{
    float velocidad = 10f;
    float noPasarDerecha = 5.07f;
    float noPasarIzquierda = -5.1f;
    public Manager juego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (juego.finDeJuego)
        {
            return;
        }

        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontal * Time.deltaTime * velocidad);

        if(transform.position.x > noPasarDerecha)
        {
            transform.position = new Vector2(noPasarDerecha, transform.position.y);
        }

        if (transform.position.x < noPasarIzquierda)
        {
            transform.position = new Vector2(noPasarIzquierda, transform.position.y);
        }
    }
}
