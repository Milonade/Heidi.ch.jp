using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderTest : MonoBehaviour
{
    public GameObject cube;


    public void OnTriggerEnter(Collider other)

    {
        cube.GetComponent<Renderer>().material.color = Color.blue;

        if (other.gameObject.layer == 6)
        {
            other.gameObject.layer = 0;

        }

    }



}





