using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeArray : MonoBehaviour
{
    public GameObject[] cubes;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //foreach (var cube in cubes)
            //{
            //    cube.GetComponent<Renderer>().material.color = Color.red;
            //}
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
