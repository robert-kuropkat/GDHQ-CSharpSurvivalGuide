using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string myName     = "Robert";
    public int    myAge      = 57;
    public string myLocation = "Florida";
    public bool   hasKey     = false;

    public int    score;
    public float  speed      = 5.5f;

    public GameObject player;
    public Animator   anim;
    public Transform  myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myName = "Fred";

        Debug.Log("My Name is: " + myName);
        Debug.Log("My age is : " + myAge);

        Debug.Log("My x position: " + myTransform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
