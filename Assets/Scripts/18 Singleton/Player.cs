using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Singleton
{
    public class Player : MonoBehaviour
    {
        void Start()
        {
            GameManager.Instance.PlayerReady("Player 1");
        }

    }

}
