using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public GameObject house;
    // Use this for initialization
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
    float mainSpeed = 10.0f; //regular speed
    float shiftAdd = 25.0f; //multiplied by how long shift is held.  Basically running
    float maxShift = 100.0f; //Maximum speed when holdin gshift
    float camSens = 0.25f; //How sensitive it with mouse
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    private float totalRun = 1.0f;


    void Start () {
        Camera.main.transform.position = new Vector3(90f, 56f, 60f);
        Camera.main.transform.LookAt(house.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.fieldOfView = 45f;

        float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
        float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
        Camera.main.transform.localRotation = Quaternion.Euler(new Vector4(-0.5f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));


        Vector3 p = GetBaseInput();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            totalRun += Time.deltaTime;
            p = p * totalRun * shiftAdd;
            p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
            p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
            p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
        }
        else
        {
            totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
            p = p * mainSpeed;
        }

        p = p * Time.deltaTime;
        Vector3 newPosition = transform.position;
        if (Input.GetKey(KeyCode.Space))
        { //If player wants to move on X and Z axis only
            Camera.main.transform.Translate(p);
            newPosition.x = transform.position.x;
            newPosition.z = transform.position.z;
            Camera.main.transform.position = newPosition;
        }
        else
        {
            Camera.main.transform.Translate(p);
        }
        //float height = (Mathf.Cos(Time.time*2)/8)+5;
        //Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, height, Camera.main.transform.position.z);
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, 51.8f, Camera.main.transform.position.z);
    }

    private Vector3 GetBaseInput()
    { //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }
        return p_Velocity;
    }


}
