using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopDeDoop : MonoBehaviour
{
    public int apples = 0;
    public int mySpeed = 0;
    public int MaxSpeed;

    void Start()
    {
        MaxSpeed = Random.Range(60, 121);
        //LoopCounting();
        //DoLooping();
        //ForLooping();
        //StartCoroutine(AddApples());
        StartCoroutine(AccelerateToMaxSpeed());

    }

    private void LoopCounting()
    {
        for (int i = 0; i <= 30; i++)
        {
            if      (i <= 10)                          { Debug.Log(i); }
            else if (i > 10 && i <= 20 && i % 2 == 0 ) { Debug.Log(i); }
            else if (i > 20 && i <= 30 && i % 2 != 0 ) { Debug.Log(i); }
        }
    }
    private void DoLooping()
    {
        do
        {
            apples++;
        } while (apples < 0);
    }
    private void ForLooping()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("May name is Robert.");
        }
        Debug.Log("Loop is finished");

        for (int i = 0; i <= 100; i += 2)
        {
            Debug.Log(i + " is an even number.");
        }

        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 != 0) { Debug.Log(i + " is an odd number."); }
        }

        for (int i = 0; i <= 100; i++)
        {
            Debug.Log(i);
            if (i == 50) { break; }
        }


    }

    IEnumerator AccelerateToMaxSpeed()
    {
        while (mySpeed != MaxSpeed)
        {
            if (mySpeed < MaxSpeed) { mySpeed += 5; }
            if (mySpeed > MaxSpeed) { mySpeed = MaxSpeed; }
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Out of Loop.  My Speed = " + mySpeed);
    }

    IEnumerator AddApples()
    {
        for (int i = 0; i<100;i++)
        {
            apples++;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
