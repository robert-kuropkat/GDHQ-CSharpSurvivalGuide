using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Challenge: Position Matters
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Create an array of 5 different positions and use a custom method to generate a random index
/// and then use a custom method to set the position to that sub index.
/// 
/// Things I discovered:
///     - The values in the Inspector are serialized from the Inspector, not your script.  Therefore,
///       if you change default values in your script, they will not be updated in the inspector 
///       unless you select the drop down menu (3 dots) for the script componenet and select 'Reset.'
///
/// </remarks>
/// 


public class TeleportCube : MonoBehaviour
{

    [SerializeField]
    private Vector3[] cubePositions =  { new Vector3(5,5,0)
                                       , new Vector3(5,0,0)
                                       , new Vector3(0,0,5)
                                       , new Vector3(0,5,0)
                                       , new Vector3(5,5,5)
                                       };
    [SerializeField]
    private GameObject myCube;

    void            Start()       { Teleport(); }
    private void    Teleport()    { myCube.transform.position = GetPosition(); }
    private Vector3 GetPosition() { return cubePositions[GetIndex()];  }
    private int     GetIndex()    { return Random.Range(0, cubePositions.Length); }
}
