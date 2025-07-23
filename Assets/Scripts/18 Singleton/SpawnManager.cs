using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Singleton
{
    public class SpawnManager : MonoSingleton<SpawnManager>
    {
        protected override void Init()
        {
            base.Init();
            Debug.Log("Initializing Spawn Manager");
        }

        public void SpawnEnemies()
        {
            Debug.Log("Spawning Enemies now");
        }
    }

}
