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
        
