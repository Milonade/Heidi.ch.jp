using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderTest : MonoBehaviour
{
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
            other.GetComponent<Rigidbody>().useGravity = false;
        }
    }
    //add a raycaster in the middle of the collider
    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1))
        {
            Debug.Log("Raycast hit: " + hit.collider.gameObject.name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        ChangeLayer(other);
    }
}





