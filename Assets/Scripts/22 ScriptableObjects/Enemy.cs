using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.ScriptableObjects
{
    [CreateAssetMenu(fileName = "spwanables.asset", menuName = "Wave/Spawnables/Enemy")]
    public class Enemy : Spawnable
    {
        [SerializeField] private int    health;

        private void OnEnable()
        {
            SpawnType = "Enemy";
        }

    }

}
