using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePicture : MonoBehaviour
{
    //public GameObject cube;
    public ColiderTest coliderTest;

    void Start()
    {
        // Find the ColliderTest component on the GameObject
        coliderTest = FindObjectOfType<ColiderTest>();
    }

    // i want to change the color of the cube when two other cubes collides
    void OnTriggerEnter(Collider other)
    {

        if (coliderTest != null)
        {
            coliderTest.GetComponent<Collider>().enabled = true;
            coliderTest.ChangeLayer(other);

            StartCoroutine(DisableColliderAfterDelay(coliderTest.gameObject, 0.3f));
        }
    }

    IEnumerator DisableColliderAfterDelay(GameObject target, float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Check if the target still exists and disable its collider
        if (target != null)
        {
            Collider collider = target.GetComponent<Collider>();
            if (collider != null)
            {
                collider.enabled = false;
            }
        }

    }
}