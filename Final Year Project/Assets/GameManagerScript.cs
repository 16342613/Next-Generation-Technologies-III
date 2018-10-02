using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public GameObject mars;

	// Use this for initialization
	void Start () {
        Camera.main.transform.position = new Vector3(90f, 6f, 60f);
        Camera.main.transform.LookAt(mars.transform);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 0.5f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Camera.main.transform.RotateAround(Vector3.zero, Vector3.down, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Camera.main.transform.RotateAround(Vector3.zero, Vector3.right, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Camera.main.transform.RotateAround(Vector3.zero, Vector3.left, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Camera.main.transform.position = new Vector3(0f, 0f, -130f);
            Camera.main.transform.LookAt(mars.transform);
        }
    }
}
