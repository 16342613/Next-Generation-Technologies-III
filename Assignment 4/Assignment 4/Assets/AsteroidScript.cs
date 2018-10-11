using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100)));  // Apply random force
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("CheckOutOfBounds", 0f, 0.2f);  // Check bounds 5x per second
    }

    void CheckOutOfBounds()
    {
        if ((this.transform.position.x > 31) || (this.transform.position.x < -31))
        {
            Vector3 lastKnownPosition = this.transform.position;
            this.transform.position = new Vector3(-lastKnownPosition.x, lastKnownPosition.y, lastKnownPosition.z);  // Reverse x
        }
        else if ((this.transform.position.z > 18) || (this.transform.position.z < -18))
        {
            Vector3 lastKnownPosition = this.transform.position;
            this.transform.position = new Vector3(lastKnownPosition.x, lastKnownPosition.y, -lastKnownPosition.z);  // Reverse z
        }
    }
}
