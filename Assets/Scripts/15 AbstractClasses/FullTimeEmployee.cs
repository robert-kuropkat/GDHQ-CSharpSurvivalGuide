using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.AbstractClasses
{
    public class FullTimeEmployee : Employee
    {
        [SerializeField] private float salary = 130000.00f;

        void Start()
        {
            employeeName = "Robert";

            Debug.Log("Monthly salary for "
                     + employeeName
                     + " from "
                     + companyName
                     + " is: "
                     + CalculateMonthlySalary());
        }

        protected override float CalculateMonthlySalary() { return salary / 12; }

    }

}
