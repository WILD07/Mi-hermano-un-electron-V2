using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    //Animator ani;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //ani = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        
        float movVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(speed, movVertical*8, 0);
        rb.AddForce(movimiento * speed);        
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
    /*void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.tag);
        if (other.gameObject.CompareTag("Positron"))
        {
            ani.SetBool("Muerte", true);
            //Destroy(other.gameObject);
            Debug.Log("activado" + ani);
        }
    }*/
}
