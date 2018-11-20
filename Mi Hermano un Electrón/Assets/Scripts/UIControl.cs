using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour {
    public GameObject pause;
    
	// Use this for initialization
	void Start () {
           
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void salir()
    {
        Debug.Log("Salir Del Juego");
        Application.Quit();
    }
    public void Reniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pause.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pause.SetActive(false);
        }
    }
}
