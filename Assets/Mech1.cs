﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mech1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
        }

    }
}
