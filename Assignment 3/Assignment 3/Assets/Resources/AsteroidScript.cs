using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().AddTorque(new Vector3(0f, 10f, 0f));
        this.GetComponent<Rigidbody>().AddForce(new Vector3(2000f, 0f, 0f));
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 viewportPosition = Camera.main.WorldToViewportPoint(this.transform.position);

        if ((viewportPosition.x < 0) || (viewportPosition.x > 1) || (viewportPosition.y < 0) || (viewportPosition.y > 1)) {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter(Collision collision) {
        if ((collision.gameObject.name == "mars") || (collision.gameObject.name == "phobos") || (collision.gameObject.name == "deimos")) {
            Destroy(gameObject);
        }
    }

}
