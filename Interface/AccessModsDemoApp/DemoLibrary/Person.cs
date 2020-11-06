using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "sensitive data";
        }
    }


    public class Person
    {

        protected string formerLName = "";



        public string fName { get; private set; }

        public string lName { get; private set; }


        private string _ssn;

        public string SSN
        {
            get { return $"***-**-{ _ssn.Substring(_ssn.Length - 4) }"; }
            set { _ssn = value; }
        }


        public void ChangeLastName(string newLName)
        {
            formerLName = lName;

            lName = newLName;
        }

        public void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void SavePerson()
        {
            //saves person to db once connection has been authenticated and authorized
            DataAccess doorway = new DataAccess();
            string connect = doorway.GetConnectionString();


        }
    }

    public class Employee : Person
    {
        public string GetFormerLName()
        {
            return formerLName;
        }
    }

    public class Manager : Employee
    {
        public string GetAllNames() 
        {
            return $"{fName} {lName}, nee {formerLName}";
        }
    }
}
