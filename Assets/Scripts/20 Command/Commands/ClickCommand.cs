using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Command
{
    public class ClickCommand : ICommand
    {
        private GameObject _cube;
        private Color      _color;
        private Color      _previousColor;

        public ClickCommand(GameObject cube, Color color)
        {
            this._cube  = cube;
            this._color = color;
        }

        public void Execute()
        {
            this._previousColor = this._cube.GetComponent<MeshRenderer>().material.color;
            Debug.Log("color being set: " + this._color + " for cube: " + this._cube.name);
            this._cube.GetComponent<MeshRenderer>().material.color = this._color;
        }

        public void UnDo()
        {
            Debug.Log("color being set: " + this._previousColor + " for cube: " + this._cube.name);
            this._cube.GetComponent<MeshRenderer>().material.color = this._previousColor;
        }

    }

}
