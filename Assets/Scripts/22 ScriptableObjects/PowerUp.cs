using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.ScriptableObjects
{
    [CreateAssetMenu(fileName = "spwanables.asset", menuName = "Wave/Spawnables/PowerUp")]
    public class PowerUp : Spawnable
    {
        [SerializeField] private int  _boost;
        [SerializeField] private bool _storable;

        private void OnEnable()
        {
            SpawnType = "PowerUp";
        }

    }

}   
