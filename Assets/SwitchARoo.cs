using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - 40_Challenge Master Switch Statements P01
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Using an if-else-elseif statement, "award" points based on a key press
/// (Q, W or E).  Then, using a switch statement, print out the number of
/// points awarded.
/// 
/// Things I discovered:
/// 
///   - More of a reminder, but switch statements can only evaluate a single 
///     variable.  The case statements can check for an exact value (as below)
///     or they can use the other common, relational (comparison) operators 
///     such as <= as well as the logical operators and, not and or.
///     Since the Input.GetKeyDown(KeyCode.<>) only returns a bool, it cannot
///     be used in a switch statment directly.
///   - NOTE:  See WeaponsSwitch.cs for an alternative approach
///
/// </remarks>
/// 



public class SwitchARoo : MonoBehaviour
{
    public int points;

    void Update()
    {
        if      (Input.GetKeyDown(KeyCode.Q)) { points = 50; }
        else if (Input.GetKeyDown(KeyCode.W)) { points = 100; }
        else if (Input.GetKeyDown(KeyCode.E)) { points = 0; }

        switch (points)
        {
            case 50:
                Debug.Log("You have 50 points.");
                break;
            case 100:
                Debug.Log("You have 100 points.");
                break;
            default:
                Debug.Log("You need 50 or 100 points");
                break;
        }
    }
}
