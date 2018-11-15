using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaCarga : MonoBehaviour {

    public Transform BarraEspera;
    public Transform TextProgreso;
    public Transform TextCargando;
    public string sceneToLoad;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            TextProgreso.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
            TextCargando.gameObject.SetActive(true);
        }
        else
        {
            TextCargando.gameObject.SetActive(false);
            TextProgreso.GetComponent<Text>().text = "Listo!";
            SceneManager.LoadScene(sceneToLoad);
        }
        BarraEspera.GetComponent<Image>().fillAmount = currentAmount / 100;
	}
}
