using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonEscenas : MonoBehaviour {

	// Declaro las variables y todos los objetos que voy a utilizar
	public Image fundido;
     Scene m_Scene;
    string sceneName;

    //COMPRUEBO QUE HAY UN CLCIK EN EL BoxCollider2D
    void OnMouseDown()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f,1);
		this.gameObject.GetComponent<AudioSource>().Play();
	}
	//COMPRUEBO QUE el raton pasa por encima EN EL BoxCollider2D
	void OnMouseOver()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f,0.5f,0.5f,1);
	}
	//COMPRUEBO QUE el raton salio EN EL BoxCollider2D
	void OnMouseExit()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
	}
	//COMPRUEBO QUE se ha levantado el boton del click EN EL BoxCollider2D
	void OnMouseUp()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
		this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
		fundido.CrossFadeAlpha(1,0.5f,false);
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        StartCoroutine(CargoEscena(sceneName));  //CAMBIO DE ESCENA 
        //Debug.Log("name:" + sceneName);
    }

	// CORRUTINA secuenciada con wait for seconds
	IEnumerator CargoEscena(string name_escene)

	{
		yield return new WaitForSeconds (1);
        //Application.LoadLevel("Juego");

        //try
        //{
            switch (name_escene)
            {
                case "Intro":
                    SceneManager.LoadScene("Main");
                    break;
                /*case "Main":
                    SceneManager.LoadScene("Nivel_2");
                    //Debug.Log("");
                    break;
                case "Nivel_2":
                    SceneManager.LoadScene("Nivel_3");
                    break;
                case "Nivel_3":
                    SceneManager.LoadScene("Nivel_4");
                    break;
                default:
                    Debug.Log("NNN"+ name_escene);
                    break;  */                  
            }
            
        //}
        //catch (System.Exception ex)
        //{

        //    Debug.Log("Error: "+ex);
        //}
        

        //SceneManager.LoadScene("main");
    }





}











