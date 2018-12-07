using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuGuardar : MonoBehaviour {

    public Vector3 PosPlayer;
    
    public static MenuGuardar instance;
    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PosPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;

    }
        
    public void Guardar()
    {
        SysGuardar.Guardar_Posicion(PosPlayer);        
    }
    public void Cargar()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = SysGuardar.Cargar_Posicion();
        SaveLoad.Load();        
    } 
}
