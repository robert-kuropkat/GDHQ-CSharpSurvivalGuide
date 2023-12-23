using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitch : MonoBehaviour
{

    public int myWeapon = 0;

    private const int noWeapon   = 0;
    private const int handGun    = 1;
    private const int knife      = 2;
    private const int machineGun = 3;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            switch (Input.inputString)
            {
                case "1":
                    myWeapon = handGun;
                    Debug.Log("You selected the handgun");
                    break;
                case "2":
                    myWeapon = knife;
                    Debug.Log("You selected the knife");
                    break;
                case "3":
                    myWeapon = machineGun;
                    Debug.Log("You selected the machine gun");
                    break;
                default:
                    myWeapon = noWeapon;
                    Debug.Log("You dropped your weapon");
                    break;
            }
        }

    }
}
