using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlPuntos : MonoBehaviour {

    public enum PuntoFX
    {
        Vanish,
        Fly
    }

    public PuntoFX puntoFX;
    public float speed;
    public bool startFlying;

    GameObject bebeMeter;

    void Start()
    {
        startFlying = false;

        if (puntoFX == PuntoFX.Fly)
        {
            bebeMeter = GameObject.Find("ImagePunto");
        }
    }

    void Update()
    {
        if (startFlying)
        {
            transform.position = Vector3.Lerp(transform.position, bebeMeter.transform.position, speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (puntoFX == PuntoFX.Vanish)
            {
                Destroy(gameObject);
            }
            else if (puntoFX == PuntoFX.Fly)
            {
                startFlying = true;
            }
            Puntos.instance.ConteoPuntos();


        }
    }
}
