using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Float : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // after 5 seconds call the DeactivateGravity function
        Invoke("DeactivateGravity", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // deeactivate the gravity on the object with tag "Town"
    public void DeactivateGravity()
    {
        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("Town");
        foreach (GameObject trashObject in trashObjects)
        {
            trashObject.GetComponent<Rigidbody>().useGravity = false;
           
            
        }
    }
}