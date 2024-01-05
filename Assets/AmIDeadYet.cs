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
    private int playerHealth = 100;

    void Update()
    {
        if (  PlayerStillAlive()
           && AttackSuccessful() ) { DoDamage(); }
    }

    private bool PlayerStillAlive() { return playerHealth > 0; }

    private bool AttackSuccessful() { return Input.GetKeyDown(KeyCode.Space); }

    private void DoDamage()
    {
        playerHealth -= CalculateDamage();
        if ( !PlayerStillAlive() ) { PublishObituary(); }
    }

    private int  CalculateDamage()  { return Random.Range(0, playerHealth + 1); }

    private void PublishObituary()  { Debug.Log("Player has died!"); }
}
