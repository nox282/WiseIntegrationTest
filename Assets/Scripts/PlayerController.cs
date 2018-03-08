using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    Rigidbody rb;

    Vector3 C_RIGHT = new Vector3( 1,  0,  0);
    Vector3 C_LEFT  = new Vector3(-1,  0,  0);
    Vector3 C_UP    = new Vector3( 0,  0,  1);
    Vector3 C_DOWN  = new Vector3( 0,  0, -1);

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.AddForce(C_UP * speed);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            rb.AddForce(C_DOWN * speed);
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            rb.AddForce(C_RIGHT * speed);
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            rb.AddForce(C_LEFT * speed);
        }
    }
}
