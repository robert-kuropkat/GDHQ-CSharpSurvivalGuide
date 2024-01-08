using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Pass the Object Challenge.
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Change the color of a cube on demand (hitting space bar).
/// 
/// Things I discovered:
///
/// </remarks>
/// 
    
public class ColorChange : MonoBehaviour
{
    [SerializeField]
    private GameObject colorCube;
    [SerializeField]
    private Color cubeColor = Color.blue;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { ChangeColor(colorCube, cubeColor); }
    }

    private void ChangeColor(GameObject myCube, Color newColor)
    {
        myCube.GetComponent<Renderer>().material.color = newColor;
    }
}
