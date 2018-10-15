using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    Animator mAnim;


    // Use this for initialization
    void Start()
    {
        mAnim = GameObject.FindWithTag("Player").GetComponent<Animator>();
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

        // Walking/Looking left/right
        if (rightStickHorizontal > 0.15)
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, (rightStickHorizontal / 3) * 4);
        }
        if (rightStickHorizontal < -0.15)
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, (rightStickHorizontal / 3) * 4);

        } 


        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                mAnim.SetTrigger("Run Forward");
            }
            else mAnim.SetTrigger("Walk Forward");
        }
        if (!Input.anyKeyDown)
        {
            mAnim.SetTrigger("Stop Walking");

        }


    }
}
