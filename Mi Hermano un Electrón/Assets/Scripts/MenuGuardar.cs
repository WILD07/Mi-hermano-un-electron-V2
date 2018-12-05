using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuGuardar : MonoBehaviour {

    public Vector3 PosPlayer;
    public Text puntosTexto;
    Point datos;
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
        datos = new Point(Puntos.instance.conteoPuntos);
        SaveLoad.Save(datos);
    }
    public void Cargar()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = SysGuardar.Cargar_Posicion();
        SaveLoad.Load();
        foreach (Point aux in SaveLoad.savedGames)
        {
            puntosTexto.text = "X" + aux.puntos;
        }
    } 
}
