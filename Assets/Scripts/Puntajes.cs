using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntajes : MonoBehaviour {

    public int contadorPuntaje;
    public Text textoPuntaje;
    
    public GameObject popLevelUpGO;
    public PopLevelUp popLevelUpScript;

    public GameObject motorCarretera;
    public MotorCarreteras motorCarreterasScript;

    //obj especial
    public Text textoSpecial;

    void Start(){
        textoPuntaje.text = "0";
        textoSpecial.text="¡Descubre el objeto especial!";
        


    }

    void Update(){

        //untaje en texto
        textoPuntaje.text = ""+contadorPuntaje;
                
        //Si se tiene 4 puntos 
        if (contadorPuntaje == 4  && motorCarreterasScript.juegoTerminado == false)
        {
            
            motorCarreterasScript.juegoTerminado = true;
      
            ///Se activa objeto levelUp
            popLevelUpGO.SetActive(true);
            popLevelUpScript.ActivoLevelUp();
        }



    }





}  
