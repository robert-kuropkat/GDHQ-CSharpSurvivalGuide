using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Lists
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private List<string> playerNames = new List<string>();

        void Start()
        {
            playerNames.Add("Joe");
            playerNames.Add("John");
            playerNames.Add("Jane");

            PrintPlayerNames();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerNames.RemoveAt(Random.Range(0, playerNames.Count));
                Debug.Log("Remove a player");
                PrintPlayerNames();
            }
        }

        private void PrintPlayerNames()
        {
            foreach (string playerName in playerNames)
            {
                Debug.Log("Player Name: " + playerName);
            }
        }
    }

}
