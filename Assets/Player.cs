using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string myName     = "Robert";
    public int    myAge      = 57;
    public string myLocation = "Florida";

    // Start is called before the first frame update
    void Start()
    {
        myName = "Fred";

        Debug.Log("My Name is: " + myName);
        Debug.Log("My age is : " + myAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
