using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject electron;
    public Vector2 mincampos, maxcampos;
    public float smoothTime;
    private Vector2 velocity;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float posX = Mathf.SmoothDamp(transform.position.x, electron.transform.position.x, ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, electron.transform.position.y, ref velocity.y, smoothTime);

        transform.position = new Vector3(Mathf.Clamp(posX, mincampos.x, maxcampos.x), Mathf.Clamp(posY, mincampos.y, maxcampos.y), transform.position.z);
    }
}
