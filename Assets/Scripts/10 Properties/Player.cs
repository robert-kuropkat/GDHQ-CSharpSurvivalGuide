using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Properties
{
    public class Player : MonoBehaviour
    {

        [SerializeField] private string playerName = "Joe Smith";
        public string PlayerName
        {
            get { return playerName; }
            private set { playerName = value; }
        }

        public float PlayerSpeed { get; set; } = 1.0f;

        void Start()
        {
            Debug.Log("Player name is: " + PlayerName + " and their speed is: " + PlayerSpeed);
            PlayerName = "John Smith";
            PlayerSpeed = 2.0f;
            Debug.Log("Player name is: " + PlayerName + " and their speed is: " + PlayerSpeed);
            PlayerName = "Jane Smith";
            PlayerSpeed = 4.0f;
            Debug.Log("Player name is: " + PlayerName + " and their speed is: " + PlayerSpeed);
        }

    }

}
