using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAway : MonoBehaviour
{

    public string[] names;
    public int[]    ages;
    public string[] favoriteCars;

    void Start()
    {

        names        = new string[] { "Clinton", "Robbie", "Daniel", "Thing 1", "Thing 2" };
        ages         = new int[]    { 19, 16, 11, 51, 57 };
        favoriteCars = new string[] { "Mazda 6", "Whatever he can get", "scooter", "Mazda CX-9", "Mazda Miata" };

    }

    void Update()
    {
        waitForIt();
    }

    private void waitForIt()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, names.Length);
            Debug.Log( "Name: " + names[randomIndex]
                     + " Age: " + ages[randomIndex]
                     + " Favorite Car: " + favoriteCars[randomIndex]
                     );
        }
    }
}
