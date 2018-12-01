using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlat : MonoBehaviour {

    public Vector3 posStart;
    public Vector3 posFinal;
    public float duracion = 1;
    private float lerp = 0;
    // Use this for initialization
    void Start()
    {
        transform.localPosition = posStart;
    }

    // Update is called once per frame
    void Update()
    {
        lerp = Mathf.PingPong(Time.time, duracion) / duracion;
        transform.localPosition = Vector3.Lerp(posStart, posFinal, lerp);
    }
}
