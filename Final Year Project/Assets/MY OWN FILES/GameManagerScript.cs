﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        QualitySettings.vSyncCount = 1;  // Enable vsync
        
        Camera.main.fieldOfView = 45f;

    }
}
