using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD

/// <summary>
/// Unity C# Survival Guide - Practical Presentation Return Array
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Create a method that finds and returns an array of player object (cubes) 
/// and changes them to random colors.
/// 
/// Things I discovered:
/// 
///   - For Color(r,g,b), each of the values r, g & b, are floating point values from 0 to 1.
///     This is why Random.value works below, as it also returns a random value from 0 to 1.
///   - The function is actually Color(r,g,b,a) where alpha sets transparency.
///
/// </remarks>
/// 


public class CubeArray : MonoBehaviour
{
    [SerializeField]
    private GameObject[] playerCubes;

    void Start()
    {
        playerCubes = GetCubes();
    }

    private GameObject[] GetCubes()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Player");

        foreach ( GameObject cube in cubes)
        {
            cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

        return cubes;
    }

=======
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
>>>>>>> dcebb6cd41cf90d1e24547e9d6632094c9d0a41c
}
