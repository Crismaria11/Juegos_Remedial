using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotita : MonoBehaviour
{
    public float velocidad = 10f;
    public Rigidbody2D rb;
    bool encima;
    public Transform barra;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * 250);
    }

    // Update is called once per frame
    void Update()
    {
        if(!encima)
        {

        }
    }


    public void Reinicio()
    {
        transform.position = new Vector3(-0.07f, -3.52f, 0.90625f);
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * velocidad;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Piso"))
        {

        }
    }
}
