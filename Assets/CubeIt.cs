using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIt : MonoBehaviour
{
    [SerializeField] private GameObject myCube;
    [SerializeField] private int        myPoints = 0;
    [SerializeField] private bool       myAwsome = false;

    void Start()
    {
        myCube.GetComponent<Renderer>().material.color = Color.yellow;
    }

    void Update()
    {
        // UpdatePoints();
        SwitchColor();
    }

    void SwitchColor()
    {
        if (Input.anyKeyDown)
        {
            switch (Input.inputString)
            {
                case "1":
                    myCube.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case "2":
                    myCube.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case "3":
                    myCube.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case "4":
                    myCube.GetComponent<Renderer>().material.color = Color.black;
                    break;
                default:
                    myCube.GetComponent<Renderer>().material.color = Color.yellow;
                    break;
            }
        }

    }

    /// <summary>
    /// Challenge Master If-Statements P04
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
            Debug.Log(myPoints < 51 ? "My current points are " + myPoints : "You are awesome! " + myPoints);
        }

        if (myPoints > 50
           && !myAwsome) 
        { 
            Debug.Log("YOU ARE AWESOME!!!  KEEP going!!!"); 
            myAwsome = true;
            myCube.GetComponent<Renderer>().material.color = Color.green;
        }


    }


}
