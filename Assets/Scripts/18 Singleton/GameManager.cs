using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Singleton
{
    public class GameManager : MonoSingleton<GameManager>
    {
        protected override void Init()
        {
            base.Init();
            Debug.Log("Initializing Game Manager");
        }

        public void PlayerReady(string playerName)
        {
            UIManager.Instance.DisplayPlayerReady(playerName);
            SpawnManager.Instance.SpawnEnemies();
        }
    }

}
