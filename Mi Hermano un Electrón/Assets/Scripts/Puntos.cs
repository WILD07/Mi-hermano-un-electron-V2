﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntos : MonoBehaviour {

    public Text txtPunto;

    public int conteoPuntos;

    public static Puntos instance;    
    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ConteoPuntos()
    {
        
        conteoPuntos++;         

        txtPunto.text = "X " + conteoPuntos;
    }
}
