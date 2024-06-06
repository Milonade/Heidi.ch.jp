using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    // Start is called before the first frame update
    // spawn random object from the trash folder in the scene at random places
    public GameObject[] trash;

    void Start()
    {
        // for the length of the trash array
        for (int i = 0; i < trash.Length; i++)
        {
            // get a random object from the trash folder
            GameObject randomTrash = trash[Random.Range(0, trash.Length)];
            // get a random position in the scene
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            // instantiate the random object at the random position
            Instantiate(randomTrash, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
