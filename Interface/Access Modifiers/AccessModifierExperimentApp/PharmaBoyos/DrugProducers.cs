using System;
using System.Collections.Generic;

namespace PharmaBoyos
{
    internal class DrugProducers : MedDistribution
    {
        public List<string> StaffNames { get; set; }

        private List<string> DrugsAvailable { get; set; }

        private List<string> ClinicList { get; set; }

        public void AddToCompanyList(string ClinName)
        {
            ClinicList.Add(ClinName);
        }

        public void Distribute()
        {
            throw new NotImplementedException();
        }

        internal virtual void ProduceDrig() 
        {
            Console.WriteLine("Here we produce a drug and add it to the drug list");
        }
    }
}
