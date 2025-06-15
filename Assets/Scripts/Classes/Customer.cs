using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.Classes
{
    [System.Serializable]
    public class Customer
    {
        //[SerializeField] public string FirstName { get; set; }
        //[SerializeField] public string LastName { get; set; }
        //[SerializeField] public int Age { get; set; }
        //[SerializeField] public string Gender { get; set; }
        //[SerializeField] public string Occupation { get; set; }

        public string FirstName;
        public string LastName;
        public int Age;
        public string Gender;
        public string Occupation;

        public Customer() { }
        public Customer(string firstname, string lastname, int age, string gender, string occupation)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.Gender = gender;
            this.Occupation = occupation;
        }
    }

}

