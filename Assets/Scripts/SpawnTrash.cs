using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpawnTrash : MonoBehaviour
{
    // Start is called before the first frame update
    // spawn random object from the trash folder in the scene at random places
    public GameObject[] trash;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
            SpawnTrashObjects();
        }
    }
    void SpawnTrashObjects()
    {
        // get a random object from the trash folder
        GameObject randomTrash = trash[Random.Range(0, trash.Length)];
        // get a random position in the scene
        Vector3 randomPosition = new Vector3(Random.Range(-20, 20), Random.Range(1, 5), Random.Range(-20, 20));
        // get a random proportionate scale for the object
        float randomScaleValue = Random.Range(1f, 10f);
        Vector3 randomScale = new Vector3(randomScaleValue, randomScaleValue, randomScaleValue);
        // instantiate the random object at the random position with the random scale and set active to false
        GameObject trashObject = Instantiate(randomTrash, randomPosition, Quaternion.identity);
        trashObject.transform.localScale = randomScale;
        //}
    }

}
