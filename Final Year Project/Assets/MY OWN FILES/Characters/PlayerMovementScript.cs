using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    Animator mAnim;
    public float range;

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
         //   Debug.Log("Value Returned: " + leftStickHorizontal.ToString("F2")+ "HIHIHI");
        //}

        if (leftStickVertical > 0.1)
        {
            if (Input.GetKey(KeyCode.JoystickButton10))
            {
                mAnim.SetTrigger("Run Forward");
            }
            else mAnim.SetTrigger("Walk Forward");
        }
        if (leftStickVertical < -0.1)
        {
            mAnim.SetTrigger("Walk Backward");

        }
        if (leftStickVertical < 0.1 && leftStickVertical > -0.1)
        {
            mAnim.SetTrigger("Stop Walking");
        }
        if (leftStickHorizontal < -0.1)
        {
            mAnim.SetTrigger("Strafe Left");

        }

        // Walking/Looking left/right
        if (rightStickHorizontal > 0.1)
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, (rightStickHorizontal / 3) * 4);
        }
        if (rightStickHorizontal < -0.1)
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, (rightStickHorizontal / 3) * 4);
        }


    }
}
