using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{

    public int speed = 0;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S)) { speed++; LogIt(); }
        if (Input.GetKeyDown(KeyCode.D) && speed != 0) { speed--; LogIt(); }
        //LogIt();
    }

    void LogIt()
    {
        if (speed > 20) { Debug.Log("Slow Down! " + speed + " is too fast."); }
        else if (speed == 0) { Debug.Log("Speed Up! " + speed + " is too slow."); }
        else { Debug.Log("Current speed is " + speed); }
    }
}
