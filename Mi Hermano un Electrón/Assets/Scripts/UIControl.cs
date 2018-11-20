using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {
    public GameObject pause;
    
	// Use this for initialization
	void Start () {
        pause = GameObject.Find("Pausa");
        pause.gameObject.SetActive(false);
        //pause = GetComponent<Image>();
   
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Pause()
    {
        if (pause==false)
        {           
            pause.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(pause==true)
        {
            pause.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
