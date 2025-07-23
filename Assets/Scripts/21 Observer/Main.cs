using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DoersOfStuff.UCSSG.Observer
{
    public class Main : MonoBehaviour
    {
        public  static event Action onTurnRed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                onTurnRed?.Invoke();
        }
    }

}
