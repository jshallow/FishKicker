using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegController : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//Quaternion 
			rb.AddTorque (transform.forward * 1000000);
		}
	}
}
