using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.AbstractClasses
{
    public class PartTimeEmployee : Employee
    {
        [SerializeField] private float hourlyRate = 15.76f;
        [SerializeField] private float hoursWorked = 32;

        void Start()
        {
            employeeName = "Daniel";

            Debug.Log("Monthly salary for "
                     + employeeName
                     + " from "
                     + companyName
                     + " is: "
                     + CalculateMonthlySalary());
        }

        protected override float CalculateMonthlySalary() { return hourlyRate * hoursWorked * 4; }

    }

}
