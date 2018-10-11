using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public int currentGameLevel;
    public GameObject asteroid;

    // Use this for initialization
    void Start()
    {
        Camera.main.transform.position = new Vector3(0f, 30f, 0f);
        Camera.main.transform.LookAt(Vector3.zero);
        StartGameLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGameLevel()
    {
        Vector3 vToW = Camera.main.ViewportToWorldPoint(new Vector3((float)0.9, (float)0.9, 0));
        Debug.Log(vToW.y);
        // Spawn 2 asteroids on each edge
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                GameObject.Instantiate(asteroid);
                if (i == 0)
                {
                    asteroid.transform.position = new Vector3(Random.Range(-28, 28), 0, 15);
                }
                else if (i == 1)
                {
                    asteroid.transform.position = new Vector3(28, 0, Random.Range(-15, 15));
                }
                else if (i == 2)
                {
                    asteroid.transform.position = new Vector3(Random.Range(-28, 28), 0, -15);
                }
                else if (i == 3)
                {
                    asteroid.transform.position = new Vector3(-28, 0, Random.Range(-15, 15));
                }
            }
        }
    }
}
