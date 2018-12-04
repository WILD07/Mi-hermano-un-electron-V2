using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour {

    public string Scena;    
    public AudioSource ElecSound;
    public GameObject Fade;
    public GameObject Creditos;
    public GameObject Control;
    public GameObject Elec;
    public GameObject Skull;
    float movVertical;
    public float speed;
    public float velocidad = 1f;
    private Rigidbody rb;    
    Animator ani;   

    private void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        Control.SetActive(true);
        speed = 1;
        velocidad = 4;
    }
    private void FixedUpdate()
    {
        movVertical = CrossPlatformInputManager.GetAxis("Vertical");
        GetComponent<Rigidbody>().velocity = new Vector3(velocidad, movVertical * 8,0);        
        //Vector3 movimiento = new Vector3(speed, movVertical*8, 0);
        //rb.AddForce(movimiento * speed);        
    }
    /*public float maxVelocity=3;
    Vector3 contantForc;
    Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (rb.velocity.x <= maxVelocity)
        {
            rb.AddForce(0.02f, 0f, 0f,ForceMode.Acceleration);
        }
        else
        { 
            //no hacer nada :v
            //rb.
        }
        Debug.Log(rb.velocity.x);
	}*/
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.tag);
        if (other.gameObject.CompareTag("Positron"))
        {
            
            //Vector3 movimiento = new Vector3(0, 0, 0);
            velocidad = 0;
            speed = 0;            
            ani.SetBool("Muerte", true);
            Elec.SetActive(true);
            ElecSound.Play();
            //Destroy(other.gameObject);
            //Debug.Log("activado" + ani);
            StartCoroutine(Retardo());
        }
        if (other.gameObject.CompareTag("AgujeroN"))
        {            
            velocidad = 0;
            speed = 0;
            ani.SetBool("Torn", true);            
            StartCoroutine(Retardo());
        }
        if (other.gameObject.CompareTag("GasVenesnoso"))
        {
            velocidad = 0;
            speed = 0;
            Skull.SetActive(true);
            StartCoroutine(Retardo());
        }
        if (other.gameObject.CompareTag("Punto"))
        {
            velocidad += 0.2f;
            //Debug.Log(velocidad);
        }
        if (other.gameObject.CompareTag("PuntoLlegada1"))
        {
            StartCoroutine(Retardo2());
        }
        if (other.gameObject.CompareTag("Fin"))
        {
            velocidad = 0;
            speed = 0;
            Control.SetActive(false);
            Creditos.SetActive(true);
        }

    }   
    IEnumerator Retardo()
    {
        yield return new WaitForSeconds(1f);
        Fade.SetActive(true);
        yield return new WaitForSeconds(1.2f);        
        SceneManager.LoadScene(Scena);
    }
    IEnumerator Retardo2()
    {
        velocidad = 0;
        Fade.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("PantallaCarga2");
    }
}
