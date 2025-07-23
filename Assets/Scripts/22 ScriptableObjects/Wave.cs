using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace DoersOfStuff.UCSSG.ScriptableObjects
{

    [CreateAssetMenu(fileName = "waves.asset", menuName = "Wave/NewWave")]
    public class Wave : ScriptableObject
    {
        [SerializeField] private List<Spawnable> _spawnables;
        [SerializeField] private int             waveOrder;
        [SerializeField] private int             _spawnIndex = 0;

        private void OnEnable()
        {
            _spawnIndex = 0;
        }

        public void PrintSpawnables()
        {
            foreach (Spawnable _spawn in _spawnables)
                _spawn.PrintName();
        }

        public void PrintWaveName()
        {
            Debug.Log("Wave " + waveOrder + " is starting");
        }

        public GameObject NextSpawnable()
        {
            Debug.Log("SpawnIndex: " + _spawnIndex + " Spawnable Count: " + _spawnables.Count);
            if (_spawnIndex == _spawnables.Count)
                return null;
            return _spawnables[_spawnIndex++].SpawnPrefab;
        }
    }

}
