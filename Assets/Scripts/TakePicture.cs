using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePicture : MonoBehaviour
{
    public GameObject cube;
    public ColiderTest coliderTest;


    void Start()
    {
        // Find the ColliderTest component on the GameObject
        coliderTest = FindObjectOfType<ColiderTest>();
    }

    // i want to change the color of the cube when two other cubes collides
    void OnTriggerEnter(Collider other)
    {
        {
            coliderTest.OnTriggerEnter(other);

        }
    }

}
