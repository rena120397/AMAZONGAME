using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

	//public GameObject[] vidas;
	public int contadorVidas;
	public GameObject popGameOverGO;
	public PopGameOver popGameOverScript;
	public GameObject motorCarretera;
	public MotorCarreteras motorCarreterasScript;
	
	public Image menosVida;
	public Text textovisorVidas;

	// Use this for initialization
	void Start () {
		menosVida.CrossFadeAlpha(0,0,false);
		contadorVidas = 3;
		textovisorVidas.text = "Vidas  X  "+contadorVidas;
	}
	
	// Update is called once per frame
	void Update () {

		textovisorVidas.text = "Vidas  X  "+contadorVidas;

		if (contadorVidas == 0 && motorCarreterasScript.juegoTerminado == false)
		{
			
			motorCarreterasScript.juegoTerminado = true;
			

			popGameOverGO.SetActive(true);
			popGameOverScript.ActivoGameOver();
		}
	
	}


    //imagen popup de menos vida
	public void ImagenMenosVida()
	{
		if(contadorVidas >= 1)
		{
			menosVida.CrossFadeAlpha(1,0.5f,false);
			this.gameObject.GetComponent<AudioSource>().Play ();
			StartCoroutine(CierroImagenMenosVida());
		}
	}

	IEnumerator CierroImagenMenosVida()
	{
		yield return new WaitForSeconds(1);
		menosVida.CrossFadeAlpha(0,0.5f,false);

	}
}

















