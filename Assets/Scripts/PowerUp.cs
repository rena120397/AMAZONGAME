using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    
    // Referencia a objeto Puntaje
    public GameObject PuntajesGO;
    public Puntajes puntajesScript;

    void Start()
    {
         
        PuntajesGO = GameObject.Find("Puntajes");
        puntajesScript = PuntajesGO.GetComponent<Puntajes>();
    }

    void OnTriggerEnter2D(Collider2D cInfo)
    {
        //Si entra un objeto al objeto tronco
        if (cInfo.gameObject.tag == "Coche")
        {
            /*///Aumenta tiempo
            cronometroScript.tiempo += 1;
            cronometroScript.ImagenMasTiempo();//imagen flotante
            gameObject.SetActive(false);*/


            ///Suma puntaje
            puntajesScript.contadorPuntaje += 2;
            gameObject.SetActive(false);

        }
    }
}
