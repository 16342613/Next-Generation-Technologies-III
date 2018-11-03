using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    Animator mAnim;
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis


    // Use this for initialization
    void Start()
    {
        mAnim = GameObject.FindWithTag("Player").GetComponent<Animator>();
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Walking forward
        float leftStickHorizontal = Input.GetAxisRaw("LeftJoyStickHorizontal");
        float leftStickVertical = Input.GetAxisRaw("LeftJoyStickVertical");
        float rightStickHorizontal = Input.GetAxisRaw("RightJoyStickHorizontal");
        float rightStickVertical = Input.GetAxisRaw("RightJoyStickVertical");

       // if (Input.GetKey(KeyCode.JoystickButton10))
        //{
           //Debug.Log("Value Returned: " + leftStickHorizontal.ToString("F2"));
        //}
/*
        if (leftStickVertical > 0.15 && leftStickHorizontal < 0.15)
        {
            if (Input.GetKey(KeyCode.JoystickButton10))
            {
                mAnim.SetTrigger("Run Forward");
            }
            else mAnim.SetTrigger("Walk Forward");
        }
        if (leftStickVertical < -0.15 && leftStickHorizontal < 0.15)
        {
            mAnim.SetTrigger("Walk Backward");

        }
        if (leftStickVertical < 0.15 && leftStickVertical > -0.15)
        {
            mAnim.SetTrigger("Stop Walking");
        }
        if (leftStickHorizontal < -0.15)
        {
            //mAnim.SetTrigger("Strafe Left");
        }
        if(leftStickHorizontal > 0.15)
        {
            mAnim.SetTrigger("Strafe Right");
            Debug.Log("HERE!");
        }
*/
        // Walking/Looking left/right
        if (rightStickHorizontal > 0.15)
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, (rightStickHorizontal / 3) * 4);
        }
        if (rightStickHorizontal < -0.15)
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, (rightStickHorizontal / 3) * 4);
        }

        checkKeys();
        checkLook();
        Debug.Log(Input.GetAxis("Mouse X"));
    }

<<<<<<< HEAD
    void checkKeys()
    {
        if (Input.GetButton("Forward"))
        {
            mAnim.SetTrigger("Walk Forward");
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            mAnim.SetTrigger("Run Forward");
        }
        else if (Input.GetButton("Backward"))
        {
            mAnim.SetTrigger("Walk Backward");
        }
        else if (Input.GetButton("Left"))
        {
            mAnim.SetTrigger("Strafe Left");
        }
        else if (Input.GetButton("Right"))
        {
            mAnim.SetTrigger("Strafe Right");
        }
        else
        {
            mAnim.SetTrigger("Stop Walking");
        }
    }
=======

        
        
>>>>>>> 479fa23938f2636579b4266a2919d8eecf25f896

    void checkLook()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
    }
}
