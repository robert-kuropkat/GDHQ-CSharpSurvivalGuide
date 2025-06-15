using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Delegates
{
    public class Main : MonoBehaviour
    {
        public delegate void  Teleport(Vector3 newPosition);
        public static   event Teleport onKeySpace;
        public static         Vector3  newPosition = new Vector3(5,2,0);

        private void Update() 
        { 
            if (  Input.GetKeyDown(KeyCode.Space)
               && onKeySpace != null 
               ) 
            { 
                onKeySpace(newPosition); 
            } 
        }
    }

}
