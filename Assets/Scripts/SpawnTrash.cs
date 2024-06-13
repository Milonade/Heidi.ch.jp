using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpawnTrash : MonoBehaviour
{
    // Start is called before the first frame update
    // spawn hiden random object from the trash folder in the scene at random places
    public GameObject[] trash;


    void Start()
    {
        Invoke("SpawnTrashObjects", 1f);
    }

    void SpawnTrashObjects()
    {
        // for the length of the trash array
        for (int i = 0; i < trash.Length; i++)
        {
            // get a random object from the trash folder
            GameObject randomTrash = trash[Random.Range(0, trash.Length)];
            // get a random position in the scene
            Vector3 randomPosition = new Vector3(Random.Range(-3, 250), Random.Range(5, 15), Random.Range(-5, 240));
            // get a random proportionate scale for the object
            float randomScaleValue = Random.Range(5f, 30f);
            Vector3 randomScale = new Vector3(randomScaleValue, randomScaleValue, randomScaleValue);
            // set layer of the object and all its children to 6
            randomTrash.layer = 6;  
            // set tag of the object to "Trash"
            randomTrash.tag = "Trash";     
            // instantiate the random object at the random position with the random scale and set active to false
            GameObject trashObject = Instantiate(randomTrash, randomPosition, Quaternion.identity);
            trashObject.transform.localScale = randomScale;
            // make it a rigidebody with gravity sett to false
            trashObject.AddComponent<Rigidbody>().useGravity = false; 
            //add a colider and make it a trigger
            trashObject.AddComponent<BoxCollider>().isTrigger = false;
            // add is kinematic true
            trashObject.GetComponent<Rigidbody>().isKinematic = true;
            // add script float to the object
            trashObject.AddComponent<Float>();
           

            
        }

    }

    
}
