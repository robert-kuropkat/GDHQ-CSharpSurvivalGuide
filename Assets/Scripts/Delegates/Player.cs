using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Delegates
{
    public class Player : MonoBehaviour
    {
        private void Start()     { Main.onKeySpace += Teleport; }
        private void OnDisable() { Main.onKeySpace -= Teleport; }
        private Vector3 localPosition = new Vector3(7,7,7);

        //
        // probable race condition with same check in Main.cs
        //

        private void Update()    
        { 
            if (Input.GetKeyDown(KeyCode.Space)) 
            { 
                Main.newPosition = new Vector3( Random.Range(-10f,10f)
                                              , Random.Range(-6f,6f)
                                              , 0
                                              ); 
            } 
        }

        private void Teleport(Vector3 newPosition) { this.gameObject.transform.position = localPosition; }

    }

}
