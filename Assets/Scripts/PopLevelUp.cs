using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopLevelUp : MonoBehaviour
{

    // Declaro las variables y todos los objetos que voy a utilizar

    public Image BGpop;
    public Image imgPop;
    public Button botonLevelUp;
    public Text metrosRecorridos;
    public GameObject popLevelUp;
    public Image imagenFundido;
    public GameObject musicaJuego;
    public AudioClip musicaGameOver;
    public GameObject Coche;
    Scene m_Scene;
    string sceneName;




    // Use this for initialization
    void Start()
    {

        //popLevelUp.SetActive(true); //ACTIVAR EL GAMEOBJECT POPGAMEOVER AL FINALIZAR EL JUEGO

    }

    public void ActivoLevelUp()
    {
        
        botonLevelUp.gameObject.SetActive(true);
        BGpop.CrossFadeAlpha(1, 0.3f, false);
        imgPop.CrossFadeAlpha(1, 0.3f, false);
        
    }

    //funcion actual de boton-nivel
    public void NextScene()
	{
        //Nombre de la escena actual
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        
        gameObject.SetActive(false);
        
        if (sceneName=="Main"){
            SceneManager.LoadScene("Nivel_2");
        }
        if (sceneName == "Nivel_2")
        {
            SceneManager.LoadScene("Nivel_3");
        }
        if (sceneName == "Nivel_3")
        {
            SceneManager.LoadScene("Nivel_4");
        }
        if (sceneName == "Nivel_4")
        {
            SceneManager.LoadScene("Intro");
        }
        Debug.Log("Nada");

    }   
    ///Carga escenas en niveles
    // CORRUTINA secuenciada con wait for seconds
	/*IEnumerator CargoEscenaNiveles(string name_escene)

	{
        yield return new WaitForSeconds (1);
        //Application.LoadLevel("Juego");

        
        switch (name_escene)
        {
            case "Main":
                SceneManager.LoadScene("Nivel_2");
                break;
            case "Nivel_2":
                SceneManager.LoadScene("Nivel_3");
                break;
            case "Nivel_3":
                SceneManager.LoadScene("Nivel_4");
                break;
            case "Nivel_4":
                SceneManager.LoadScene("Intro");
                break;   
        }
       
    }*/

    //Carga escena de Main
    IEnumerator CargoEscena()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Main");
    }

    /*public void PasarLevel()
    {
        //cuentaAtrasScript.IniciarCuentaAtras();
        BGpop.CrossFadeAlpha(0, 0.3f, false);
        imgPop.CrossFadeAlpha(0, 0.3f, false);
        botonLevelUp.gameObject.SetActive(true);
        CargoEscena();
    }*/
}
