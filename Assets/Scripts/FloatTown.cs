using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatTown : MonoBehaviour
{
        public TakePicture takePicture;
        public ColiderTest coliderTest;
        public int i=0;

   public void Start()
    {
         // if Town object changes layer to 6, then call the DeactivateGravity function
        if (gameObject.tag == "Town")
        {
            Invoke("DeactivateGravity", 5f);
             i++;
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    // deeactivate the gravity on the object with tag "Town"
    public void DeactivateGravity()
    {
        GameObject[] townObjects = GameObject.FindGameObjectsWithTag("Town");

        //for the length of townObjects, get a random town object from the townObjects array
        if (i < townObjects.Length)
        {
            GameObject randomTown = townObjects[i];
            randomTown.GetComponent<Rigidbody>().useGravity = false;
            randomTown.GetComponent<Rigidbody>().isKinematic = false;
            // if ther's no box collider add one
            if (randomTown.GetComponent<BoxCollider>() == null)
            {
                randomTown.AddComponent<BoxCollider>();
            }
        }

    }
}
