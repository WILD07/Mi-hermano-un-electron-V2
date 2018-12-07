using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Retardo());
            //MenuGuardar.instance.Guardar();
            //Debug.Log(Retardo());
        }

    }
    IEnumerator Retardo()
    {

        yield return new WaitForSeconds(1f);
        MenuGuardar.instance.Guardar();
    }
}
