using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckKeys();
        CheckOutOfBounds();
    }

    void CheckOutOfBounds() {
        if ((this.transform.position.x > 50) || (this.transform.position.x < -50))
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

    void CheckKeys() {
        if(Input.GetKey(KeyCode.RightArrow)) {
            this.transform.Rotate(Vector3.up, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.down, Space.World);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 3, 0));
        }
    }
}
