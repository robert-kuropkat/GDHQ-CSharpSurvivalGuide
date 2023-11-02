using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Variable Challenge 2.
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Create a set of variables described in the Challenge video and print thier values.
/// This is basically te same as Variable Challenge 1 except you needed to research
/// the data type for the image icon.  No actual image was provided at this time.
/// 
/// </remarks>
/// 

public class Item : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;
    public int    attackStrenght;

    void Start()
    {
        itemName        = "Pouch of Stuff";
        itemDescription = "a pouch containing a great deal of stuff";
        attackStrenght  = 0;

        Debug.Log("Item: " + itemName + ",  "
                 + itemDescription
                 + " and has an Attack Strength of " + attackStrenght + "."
                 );
    }

}
