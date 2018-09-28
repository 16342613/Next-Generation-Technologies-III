using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public GameObject mars;
    public GameObject phobos;
    public GameObject deimos;
    public GameObject asteroid;

    // Use this for initialization
    void Start () {
        Camera.main.transform.position = new Vector3(0f, 0f, -600f);
        Camera.main.transform.LookAt(mars.transform);
        mars.GetComponent<Rigidbody>().AddTorque(new Vector3(0f, 20f, 0f));

    }
	
	// Update is called once per frame
	void Update () {
        phobos.transform.RotateAround(Vector3.zero, Vector3.up, 25 * Time.deltaTime);
        deimos.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

        float spawnPossibility = Random.Range(0.00f, 10.00f);

        if (spawnPossibility > 9.5f)
        {
                GameObject.Instantiate(asteroid);
                asteroid.transform.position = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), -100f);

        }

            // Camera controls
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Camera.main.transform.RotateAround(Vector3.zero, Vector3.up, 30*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            Camera.main.transform.RotateAround(Vector3.zero, Vector3.down, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow)) { 
            Camera.main.transform.RotateAround(Vector3.zero, Vector3.right, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            Camera.main.transform.RotateAround(Vector3.zero, Vector3.left, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space)) {
            Camera.main.transform.position = new Vector3(0f, 0f, -130f);
            Camera.main.transform.LookAt(mars.transform);
        }
    }
}
