using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Observer
{
    public class Cube : MonoBehaviour
    {
        private Material _mat;

        private void Awake()
        {
            _mat = GetComponent<MeshRenderer>().material;
        }

        private void OnEnable()
        {
            Main.onTurnRed += Main_onTurnRed;
        }

        private void Main_onTurnRed()
        {
            _mat.color = Color.red;
            //GetComponent<MeshRenderer>().material.color = Color.red;
        }

        private void OnDisable()
        {
            Main.onTurnRed -= Main_onTurnRed;
        }
    }

}
