using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


public class Carga1 : MonoBehaviour {

    
    public string sceneToLoad;
    
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Retardo());
    }
    IEnumerator Retardo()
    {
        yield return new WaitForSeconds(40f);        
        SceneManager.LoadScene(sceneToLoad);
    }
}
