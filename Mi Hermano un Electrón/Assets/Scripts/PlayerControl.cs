using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour {

    public float maxVelocity=3;
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
            rb.
        }
        Debug.Log(rb.velocity.x);
	}
}
