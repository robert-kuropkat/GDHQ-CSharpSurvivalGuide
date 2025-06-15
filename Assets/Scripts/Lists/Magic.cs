using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Lists
{
    public class Magic : MonoBehaviour
    {
        //
        // * Since the list of possible obects to create is predefined, we can use an
        //   array instead of list
        // * myObjects could have been an array also, since we know we are allowing no
        //   more than 10.  However, we use a List since we are dynamically adding and
        //   removing entries.
        //

        [SerializeField] private GameObject[]     myPrefabs    = new GameObject[3];
        [SerializeField] private List<GameObject> myObjects    = new List<GameObject>();
        [SerializeField] private bool             keepSpawning = true;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && keepSpawning)
            {
                myObjects.Add(Instantiate(myPrefabs[Random.Range(0, myPrefabs.Length)]
                             , new Vector3( Random.Range(-10f, 10f)
                                          , Random.Range(-10f, 10f)
                                          , Random.Range(  0f, 10f))
                             , Quaternion.identity)
                             );
                if (myObjects.Count == 10) { StopSpawning(); }
            }
        }

        private void StopSpawning()
        {
            keepSpawning = false;
            foreach (GameObject myObject in myObjects)
            {
                myObject.GetComponent<Renderer>().material.color = Color.green;
            }
            myObjects.Clear();
        }
    }
}
