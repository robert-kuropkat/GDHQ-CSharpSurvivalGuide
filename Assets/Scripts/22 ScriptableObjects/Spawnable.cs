using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.ScriptableObjects
{
    [CreateAssetMenu(fileName = "spwanables.asset", menuName = "Wave/Spawnables")]
    public class Spawnable : ScriptableObject
    {
        [SerializeField] private string     _name;
        [SerializeField] private int        _speed;
        [SerializeField] private GameObject _spawnPrefab;
        public GameObject SpawnPrefab
        {
            get { return _spawnPrefab; }
            private set { _spawnPrefab = value; }
        }

        public string SpawnType { get; set; }

        public void PrintName()
        {
            Debug.Log("Item name is: " + _name + " and is of type " + SpawnType + " with a speed of: " + _speed);
        }
    }

}
