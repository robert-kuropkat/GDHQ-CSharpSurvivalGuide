using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Challenge Speed Program.
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Increase and decrease the speed variable everytime the 'S' or 'A' keys are pressed.
/// If the speed exceeds 20, print a message to slow down.  If the speed is zero print
/// a message to speed up.
/// </remarks>
/// 

public class Speed : MonoBehaviour
{

    public int speed = 0;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S)) { speed++; }
        if (Input.GetKeyDown(KeyCode.A) && speed != 0) { speed--; }

        if      (speed > 20) { Debug.Log("Slow Down! "       + speed + " is too fast."); } 
        else if (speed == 0) { Debug.Log("Speed Up! "        + speed + " is too slow."); } 
        else                 { Debug.Log("Current speed is " + speed); }
    }
}
