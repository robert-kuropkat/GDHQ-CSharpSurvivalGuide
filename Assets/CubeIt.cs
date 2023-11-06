using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIt : MonoBehaviour
{
    [SerializeField] private GameObject myCube;
    [SerializeField] private int        myPoints = 0;
    [SerializeField] private bool       myAwsome = false;

    // Start is called before the first frame update
    void Start()
    {
        myCube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePoints();
    }

    void UpdatePoints()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myPoints += 10;
            Debug.Log(myPoints < 51 ? "My current points is " + myPoints : "You are awesome! " + myPoints);
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
