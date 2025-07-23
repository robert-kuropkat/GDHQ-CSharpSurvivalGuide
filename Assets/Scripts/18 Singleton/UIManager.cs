using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Singleton
{
    public class UIManager : MonoSingleton<UIManager>
    {
        protected override void Init()
        {
            base.Init();
            Debug.Log("Initializing UI Manager");
        }

        public void DisplayPlayerReady(string playerName)
        {
            Debug.Log("Ready " + playerName);
        }
    }

}
