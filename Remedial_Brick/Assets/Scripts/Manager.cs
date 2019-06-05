using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int vidas;
    public int  puntuacion;
    public Text TxtVidas;
    public Text TxtPuntuacion;
    public bool finDeJuego;
    // Start is called before the first frame update
    void Start()
    {
        TxtPuntuacion.text = "Puntuacion: " + puntuacion;
        TxtVidas.text = "Vidas: " + vidas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VerVidas(int UpdateVidas)
    {
        vidas += UpdateVidas;

        if(vidas <= 0)
        {
            vidas = 0;
        }

        TxtVidas.text = "Vidas: " + vidas;
    }

    public void VerPuntuacion(int UpdatePuntuacion)
    {
        puntuacion += UpdatePuntuacion;

        TxtPuntuacion.text = "Puntuacion: " + puntuacion;
    }

    void FinDeJuego()
    {
        finDeJuego = true;
    }
}
