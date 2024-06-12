using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderTest : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        Debug.Log("Collider is disabled");
        Collider collider = GetComponent<Collider>();
        collider.enabled = false;
    }

    public void ChangeLayer(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            other.gameObject.layer = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        ChangeLayer(other);
    }
}





