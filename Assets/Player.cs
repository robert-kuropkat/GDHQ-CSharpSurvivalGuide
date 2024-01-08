using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Variable Challenge 1.
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Create a set of variables described in the Challenge video and print thier values.
/// I decided to create all the variables with a default value, change the value, then
/// print them out using Debug.Log().  I used the concatenation operator to merge the
/// values with text to display all the values as part of a sentance.  For the last 
/// part (hasKey), I used the ternary operator just because it's one of my favorite
/// operators.
/// 
/// </remarks>
/// 

public class Player : MonoBehaviour
{
    //
    // Variables fir Pii mtehod
    //
    public string myName     = "Robert";
    public int    myAge      = 57;
    public float  mySpeed    = 5.5f;
    public int    myHealth   = 10;
    public int    myScore    = 0;
    public bool   hasKey     = false;
    public int    myAmmo     = 3;

    //
    // Variables for UpdatePoints method
    //
    public int    myPoints   = 0;
    public bool   myAwsome   = false;

    //
    // Variables for OutputMode method call
    //
    public const int easyDifficulty   = 0;
    public const int mediumDifficulty = 1;
    public const int hardDifficulty   = 2;
    public int       currentDifficulty;

    //
    // Comment or uncomment methods calls as needed to run each challenge.
    //

    private void Start()
    {
        Pii();
        currentDifficulty = mediumDifficulty;
    }

    
    private void Update()
    {
        // UpdatePoints();
        // OutputMode();
    }

    /// <summary>
    /// Else-If Statements
    /// </summary>
    /// 
    /// <remarks>
    /// </remarks>
    ///

    private void OutputMode()
    {
        if      (currentDifficulty == easyDifficulty)   { Debug.Log("You selected EASY mode."); }
        else if (currentDifficulty == mediumDifficulty) { Debug.Log("You selected MEDIUM mode."); }
        else if (currentDifficulty == hardDifficulty)   { Debug.Log("You selected HARD mode."); }
        else                                            { Debug.Log("INVALID mode."); }
    }

    /// <summary>
    /// Variables overview
    /// </summary>

    void Pii()
    {
        //
        // Change the values of all my variables
        //
        myName    = "el Guapo";
        myAge     = 36;
        mySpeed   = 2.0f;
        myHealth  = 3;
        myScore   = 3;
        hasKey    = true;
        myAmmo    = 1;

        //
        // Print out current values of all my variables
        //
        Debug.Log( "My Name is " + myName
                 + " and my age is " + myAge + ".  "
                 + "My current stats are speed " + mySpeed + ", "
                 + "health " + myHealth + ", "
                 + "ammo count " + myAmmo + " and "
                 + "my score is " + myScore + ".  "
                 );
        Debug.Log(hasKey ? "I have the key." : "I do not have the key.");

    }

    /// <summary>
    /// Challenge Master If-Statements P01 & P02 & P03
    /// </summary>
    /// 
    /// <remarks>
    /// </remarks>
    ///

    void UpdatePoints()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myPoints += 10;
            Debug.Log( myPoints < 50 ? "My current points are " + myPoints : "You are awesome! " + myPoints);
        }

        if (   myPoints >= 50
           && !myAwsome) { Debug.Log("YOU ARE AWESOME!!!  KEEP going!!!"); myAwsome = true; }

        
    }

}
