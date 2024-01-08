using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        foreach (GameObject cube in cubes)
        {
            cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

        return cubes;
    }
}

