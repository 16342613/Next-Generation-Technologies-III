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
        if (Input.GetKeyDown(KeyCode.W))
        {
            mAnim.SetTrigger("Walk Forward");

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            mAnim.SetTrigger("Stop Walking Forward");

        }

        // Walking/Looking right
        if (Input.GetKey(KeyCode.D))
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, 50 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GameObject.FindWithTag("Player").transform.Rotate(Vector3.up, -50 * Time.deltaTime);
        }

    }
}
