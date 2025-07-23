using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Static
{
    public class Player : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Changing Color");
                this.gameObject.GetComponent<Renderer>().material.color = NewColor.RandomColor();
            }
        }
    }

}
