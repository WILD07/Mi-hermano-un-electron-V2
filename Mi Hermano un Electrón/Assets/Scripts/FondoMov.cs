using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FondoMov : MonoBehaviour {

    public float fondoVelocidad = 0.02f;
    public RawImage Fondo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Parallaxx();
	}
    void Parallaxx()
    {
        float velocidadFinal = fondoVelocidad * Time.deltaTime;

        Fondo.uvRect = new Rect(Fondo.uvRect.x + velocidadFinal * 2, 0f, 1f, 1f);

    }
}
