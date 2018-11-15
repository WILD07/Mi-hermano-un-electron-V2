using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject Instrucciones;
	
    public void jugar()
    {
        SceneManager.LoadScene("PantallaCarga");
    }
    public void salir()
    {
        Debug.Log("Salir Del Juego");
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ClicInstrucciones()
    {
        Instrucciones.SetActive(true);
    }
}
