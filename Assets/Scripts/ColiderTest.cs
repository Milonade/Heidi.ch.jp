using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderTest : MonoBehaviour
{
    public FloatTown floatTown;
    public void Start()
    {
        Debug.Log("Collider is disabled");
        Collider collider = GetComponent<Collider>();
        collider.enabled = false;
        //GameObject[] townObjects = GameObject.FindGameObjectsWithTag("Town");
    }

    public void ChangeLayer(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            other.gameObject.layer = 0;
            // add gravity to the object
        }

    }
    
    void OnTriggerEnter(Collider other)
    {
        ChangeLayer(other);
        //if the object layer is 0, change the gravity to true
        if (other.gameObject.layer == 0)
        {
            other.GetComponent<Rigidbody>().useGravity = true;
        }
        floatTown.Start();
    }
}





