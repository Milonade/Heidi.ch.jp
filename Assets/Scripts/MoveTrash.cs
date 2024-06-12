using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrash : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        MoveTownObjects();
    }
    // get objects in the scene and make them vibrate
    public void MoveTownObjects()
    {
        // get all the objects in the scene
        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("Town");
        
        // for each object in the scene
        foreach (GameObject trashObject in trashObjects)
        {
            // make the object drift away
            trashObject.transform.position += new Vector3(0, 0, 0.01f);
        }
    }

    // if objects collide with the world sphere invert the direction
    void OnTriggerEnter(Collider other)
    {
        // if the object collides with the world sphere
        //if (other.gameObject.CompareTag("World"))
        //{
            // make the object bounce back
            other.gameObject.transform.position -= new Vector3(0, 0, 0.1f);
      //  }
    }

}
