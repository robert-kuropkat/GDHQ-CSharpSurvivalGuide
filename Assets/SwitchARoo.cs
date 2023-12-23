using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
