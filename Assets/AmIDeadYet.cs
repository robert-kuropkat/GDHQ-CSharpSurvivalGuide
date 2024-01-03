using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Challenge: Are You Alive?
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Createa program that checks to see if the player is alive still.  When you hit
/// the space bar, you should damage the player a random amount.  If the Player is
/// dead, print out "The player has died!"
/// 
/// Bonus: Disable the damage function once a player is dead.
/// 
/// Things I discovered:
///
/// </remarks>
/// 


public class AmIDeadYet : MonoBehaviour
{
    [SerializeField]
    private int  playerHealth     = 100;
    [SerializeField]
    private bool playerStillAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (  Input.GetKeyDown(KeyCode.Space)
           && playerHealth > 0 ) { playerHealth -= DoDamage(); }
        if ( playerStillAlive && playerHealth < 1 ) 
        { 
            playerStillAlive = false;
            Debug.Log("Player has died!");
        }
    }

    private int DoDamage()
    {
        return Random.Range(0, playerHealth + 1);
    }
}
