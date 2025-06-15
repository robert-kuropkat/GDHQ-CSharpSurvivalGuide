using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.AbstractClasses
{
    public abstract class Employee : MonoBehaviour
    {
        [SerializeField] protected static string companyName = "Doers of Stuff";
        [SerializeField] protected string employeeName;

        protected abstract float CalculateMonthlySalary();
    }

}
