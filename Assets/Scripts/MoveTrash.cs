using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrash : MonoBehaviour
{
    // Update is called once per frame
    public float speed = 0.01f; // Add a public speed variable to control the speed
    private Vector3 direction= new Vector3(1, 0, 1); // Add a public direction variable to control the direction

    void Update()
    {
        MoveTownObjects();
    }
    // get objects in the scene and make them vibrate
    public void MoveTownObjects()
    {
        // get all the objects in the scene
        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("Trash");
        
        // for each object in the scene
        foreach (GameObject trashObject in trashObjects)
        {
           direction =  new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)); // Add a random direction
            // make the object drift away
             trashObject.transform.position += direction * speed; // Use the direction and speed to move the object
        }
    }

    // if objects collide with the world sphere invert the direction
    void OnTriggerEnter(Collider other)
    {
        // if the object collides with the world sphere
        //if (other.gameObject.CompareTag("World"))
        //{
            // make the object bounce back
           // speed = Random.Range(0.01f, 0.1f);
            direction = -direction;
      //  }
    }

}
