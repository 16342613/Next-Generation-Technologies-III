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

        //Debug.Log("Value Returned: " + leftStickHorizontal.ToString("F2"));


        if (leftStickVertical > 0.1)
        {
            mAnim.SetTrigger("Walk Forward");

        }
        if (leftStickVertical < -0.1)
        {
            mAnim.SetTrigger("Walk Backward");

        }
        if (leftStickVertical < 0.1 && leftStickVertical > -0.1)
        {
            mAnim.SetTrigger("Stop Walking");
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
