using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person someone = new Person();

            someone.SavePerson();

            Console.ReadLine();
        }
    }

    public class ModifiedDataAccess : DataAccess
    {

        //Allows access to data that is protected internal beacuse this method is public.
        public void AccessUnsecuredConnectionInfo()
        {
            GetConnectionString();
        }
    } 


    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();

            data.AccessUnsecuredConnectionInfo();

            formerLName = "Way";
        } 
    }
}
