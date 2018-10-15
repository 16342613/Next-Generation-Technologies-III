using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public int currentGameLevel;
    public GameObject asteroid;
    public GameObject spaceship;

    // Use this for initialization
    void Start()
    {
        // Set camera position
        Camera.main.transform.position = new Vector3(0f, 30f, 0f);
        Camera.main.transform.LookAt(Vector3.zero);
        CreatePlayerSpaceship();
        StartGameLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGameLevel()
    {
<<<<<<< HEAD
        Vector3 vToW = Camera.main.ViewportToWorldPoint(new Vector3((float)0.9, (float)0.9, 0));
=======
>>>>>>> parent of 9c1e256... update
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

    void CreatePlayerSpaceship()
    {
        GameObject.Instantiate(spaceship);
        spaceship.transform.position = Vector3.zero;
    }
}
