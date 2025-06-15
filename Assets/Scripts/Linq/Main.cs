using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace DoersOfStuff.UCSSG.Linq
{
    public class Main : MonoBehaviour
    {

        [SerializeField] private int[] grades = { 100, 25, 73, 9, 70, 92, 88 };

        void Start()
        {
            foreach (int grade
                    in grades.Where(i => i > 69).OrderByDescending(i => i).Reverse()
                    )
            { Debug.Log("Passing Grade of " + grade); }
        }
    }

}
