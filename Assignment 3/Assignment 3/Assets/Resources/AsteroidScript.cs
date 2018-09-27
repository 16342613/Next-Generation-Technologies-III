using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().AddTorque(new Vector3(0f, 10f, 0f));
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 200f, 0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
