using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePicture : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    // i want to change the color of the cube when two other cubes collides
    void OnTriggerEnter(Collider other)
    {
        //if (collision.gameObject.name == "Cube1" && collision.gameObject.name == "Cube2")
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
            Invoke("SpawnSphere", 1.5f);

        }
    }

    void SpawnSphere()
    {
        sphere.SetActive(true);

    }

}
