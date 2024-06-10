using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpawnTrash : MonoBehaviour
{
    // Start is called before the first frame update
    // spawn hiden random object from the trash folder in the scene at random places
    public GameObject[] trash;
    public GameObject cube;


    void Start()
    {
        Invoke("SpawnTrashObjects", 2f);
    }

    void SpawnTrashObjects()
    {
        // for the length of the trash array
        for (int i = 0; i < trash.Length; i++)
        {
            // get a random object from the trash folder
            GameObject randomTrash = trash[Random.Range(0, trash.Length)];
            // get a random position in the scene
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), Random.Range(1, 3), Random.Range(-10, 10));
            // get a random proportionate scale for the object
            float randomScaleValue = Random.Range(10f, 150f);
            Vector3 randomScale = new Vector3(randomScaleValue, randomScaleValue, randomScaleValue);
            // set layer of the object and all its children to 6
            randomTrash.layer = 6;
            // instantiate the random object at the random position with the random scale and set active to false
            GameObject trashObject = Instantiate(randomTrash, randomPosition, Quaternion.identity);
            trashObject.transform.localScale = randomScale;
            trashObject.SetActive(true);
        }

    }

    // When collide the object becomes visible
    void OnTriggerEnter(Collider other)
    {
        //if (collision.gameObject.name == "Cube1" && collision.gameObject.name == "Cube2")
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
            ShowTrash();

        }
    }
    void ShowTrash()
    {
        // Find the camera named CameraCamera
        Camera CameraCamera = GameObject.Find("CameraCamera").GetComponent<Camera>();
        // Loop through all trash objects
        foreach (GameObject trashObject in trash)
        {
            // Create a ray that goes from the camera's position to the trash object
            Ray ray = new Ray(CameraCamera.transform.position, trashObject.transform.position - CameraCamera.transform.position);

            // Check if the ray hits anything
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // If the ray hits the trash object, make it visible by changing its layer to 0
                if (hit.collider.gameObject == trashObject)
                {
                    trashObject.layer = 0;
                }
                
            }
        }
    }
}
