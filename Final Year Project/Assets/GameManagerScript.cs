using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public GameObject mars;

	// Use this for initialization
	void Start () {
        Camera.main.transform.position = new Vector3(50f, 50f, 50f);
        Camera.main.transform.LookAt(mars.transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
