using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopGameOver : MonoBehaviour {

// Declaro las variables y todos los objetos que voy a utilizar

	public Image BGpop;
	public Image imgPop;
	public Button botonReiniciar;
	public GameObject popGameOverGO;
	public Image imagenFundido;
	public GameObject musicaJuego;
	public AudioClip musicaGameOver;
	public GameObject Coche;



	// Use this for initialization
	void Start () {

		//popGameOverGO.SetActive(true); //ACTIVAR EL GAMEOBJECT POPGAMEOVER AL FINALIZAR EL JUEGO
        ActivoGameOver();     //se llama al 
	}

	public void ActivoGameOver()
	{
		musicaJuego.GetComponent<AudioSource>().clip = musicaGameOver;
		musicaJuego.GetComponent<AudioSource>().Play();
		//botonReiniciar.gameObject.SetActive(true);
		BGpop.CrossFadeAlpha(1,0.3f,false);
		imgPop.CrossFadeAlpha(1,0.3f,false);
		Coche.GetComponent<AudioSource>().Stop();
	}

    //Onclick boton Reiniciar a Intro
	public void ReiniciarJuego()
	{
		//imagenFundido.CrossFadeAlpha(1,0.5f,false);
		StartCoroutine(CargoEscena());
	}

	IEnumerator CargoEscena()
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("Intro");
	}
}
