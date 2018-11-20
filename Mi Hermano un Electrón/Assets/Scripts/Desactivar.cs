using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar : MonoBehaviour {
    public new Collider collider;
    public GameObject Puerta;   

    // Use this for initialization
    void Start()
    {
        Puerta = GameObject.Find("Puerta");        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Puerta.SetActive(false);
        }
    }
}
