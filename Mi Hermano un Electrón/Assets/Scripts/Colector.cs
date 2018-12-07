using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colector : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.tag);
        if (other.gameObject.CompareTag("Punto"))
        {
            Destroy(other.gameObject);
        }
    }
}
