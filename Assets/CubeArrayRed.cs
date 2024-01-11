using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - When do I use For Loops in Games
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Iterate through a group of objects and turn them all red.
/// 
/// This was not an actual challenge, but rather one of 4 examples given for using a for loop.
/// I refactored this slightly so I could demonstrate both a for and foreach loop.
/// 
/// Things I discovered:
/// 
///   - Generally, I tend towards the foreach over the for loop.  However, every now and then
///     I want a for loop instead, but sometimes forget about using Array.Length rather than
///     hardcoding the loop boundary.
///
/// </remarks>
/// 


public class CubeArrayRed : MonoBehaviour
{
    public GameObject[] cubes;
    public string currentColor = "white";

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) { return; }

        switch (currentColor)
        {
            case "red":
                foreach (var cube in cubes)
                {
                    cube.GetComponent<Renderer>().material.color = Color.blue;
                    currentColor = "blue";
                }
                break;
            default:
                for (int i = 0; i < cubes.Length; i++)
                {
                    cubes[i].GetComponent<Renderer>().material.color = Color.red;
                    currentColor = "red";
                }
                break;
        }
    }
}
