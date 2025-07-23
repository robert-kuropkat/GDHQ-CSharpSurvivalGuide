using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.ScriptableObjects
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private List<Wave> gameWaves;
        [SerializeField] private int        currentWave = 0;



        void Start()
        {
            foreach (Wave _wave in gameWaves)
            {
                _wave.PrintWaveName();
                _wave.PrintSpawnables();
            }
            StartCoroutine(SpawnWave());
        }

        IEnumerator SpawnWave()
        {
            //yield return new WaitForSeconds(2);

            bool nextWave = true;
            while (nextWave)
            {
                GameObject nextSpawn = gameWaves[currentWave].NextSpawnable();
                if (nextSpawn == null)
                {
                    currentWave++;
                    yield return new WaitForSeconds(5);
                } else
                {
                    Instantiate(nextSpawn);
                    yield return new WaitForSeconds(2);
                }
                if (currentWave == gameWaves.Count)
                    nextWave = false;
                //break;
            }
            //yield return new WaitForSeconds(5);
        }
    }

}
