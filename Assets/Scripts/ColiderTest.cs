using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderTest : MonoBehaviour
{
    public GameObject cube;

   void Start()
    {
        IsVisibleFrom(cube.GetComponent<Renderer>(), Camera.main);
    }


    // Update is called once per frame
    void IsVisibleFrom(Renderer cube, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        GeometryUtility.TestPlanesAABB(planes, cube.bounds);
    }

}


