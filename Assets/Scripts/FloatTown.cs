using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatTown : MonoBehaviour
{
    void Start()
    {
        // after 5 seconds call the DeactivateGravity function
        // Invoke("DeactivateGravity", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        // if Town object changes layer to 6, then call the DeactivateGravity function
        if (gameObject.tag == "Town")
        {
            Invoke("DeactivateGravity", 1f);
        }
    }
    // deeactivate the gravity on the object with tag "Town"
    public void DeactivateGravity()
    {
        GameObject[] townObjects = GameObject.FindGameObjectsWithTag("Town");
        //for the length of townObjects, get a random town object from the townObjects array
        for (int i = 0; i < 2; i++)
        {
            GameObject randomTown = townObjects[i];
            randomTown.GetComponent<Rigidbody>().useGravity = false;
            randomTown.GetComponent<Rigidbody>().isKinematic = false;
            randomTown.AddComponent<BoxCollider>();
        }

    }
}
