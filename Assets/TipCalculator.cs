﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity C# Survival Guide - Tip Calculator Challenge.
/// </summary>
/// 
/// <remarks>
/// Instantiated By: 
/// Attached To: Main Camera
/// 
/// Calculate the total bill based on a tip percentage.  For this one I allowed
/// the bill to be updated (not done in the challenge).  I also made both the 
/// total tip amount and the total amount local variables since they are 
/// calculated.
/// 
/// Things I discovered:
///    - Variables with a Decimal datatype are not visible in the Inspector.
///      This is a Unity design decision.  Only floats and ints can be 
///      serialized.
///    - Because Unity uses floats, Mathf is the preferred Math function over 
///      Math.
///    - Mathf.Round rounds to the nearest integer.  There is no way to make 
///      Mathf round to a specific decimal place.  To get around this, first
///      multiply your value by 100 (aka. move the decimal two places to the
///      right), pass that value to Mathf.Round() then divide that result by
///      100 (aka. move the decimal back 2 places to the left) and viola!
///      Note: this won't change the formatting, ie. print trailing zeros. 
/// 
/// </remarks>
/// 

public class TipCalculator : MonoBehaviour
{

    public float myBill        = 40;
    public float tipPercentage = 20;


    void Start()
    {
        float totalTip    = myBill * tipPercentage / 100;
        float totalAmount = myBill + totalTip;

        Debug.Log( "Your bill is: $" + myBill + ". "
                 + "Your tip is: $" + Mathf.Round(totalTip*100)/100
                 + " (based on " + tipPercentage + "%) "
                 + "bringing your total ammount to $" + Mathf.Round(totalAmount*100)/100 + "."
                 );
    }

}
