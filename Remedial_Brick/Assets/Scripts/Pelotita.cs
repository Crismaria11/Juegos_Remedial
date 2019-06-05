using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotita : MonoBehaviour
{
    public float velocidad = 10f;
    public Rigidbody2D rb;
    public bool encima;
    public Transform barra;
    public Manager juego;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(juego.finDeJuego)
        {
            return;
        }

        if (!encima)
        {
            transform.position = barra.position;
        }

        if(Input.GetButtonDown("Jump") && !encima)
        {
            encima = true;
            rb.AddForce(Vector2.up * 500);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ladrillo"))
        {
            juego.VerPuntuacion(collision.gameObject.GetComponent<Ladrillo>().puntos);

            Destroy(collision.gameObject);


        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Piso"))
        {
            rb.velocity = Vector2.zero;

            encima = false;

            juego.VerVidas (-1);
        }
    }
}
