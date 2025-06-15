using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Classes
{
    public class CustomerDatabase : MonoBehaviour
    {

        [SerializeField] public Customer[] customers = new Customer[2];

        void Start()
        {
            customers[0] = new Customer();
            customers[0].FirstName = "John";
            customers[0].LastName = "Smith";
            customers[0].Age = 35;
            customers[0].Gender = "male";
            customers[0].Occupation = "Video Game Developer";

            customers.SetValue(value: new Customer("Jane", "Smith", 33, "female", "The Boss"), index: 1);

        }


    }

}
