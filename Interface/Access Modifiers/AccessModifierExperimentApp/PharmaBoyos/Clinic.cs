using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaBoyos
{

    internal interface MedProvider
    {
        void Apply();

    }

    public interface MedDistribution
    {
        void Distribute();

        void AddToCompanyList(string ClinicName);
    }


    public class Clinic : MedProvider
    {
        internal int staffNum { get; set; }

        private string clinName;

        public string ClinName
        {
            get { return clinName; }
            set { clinName = value; }
        }


        internal List<string> Medications { get; set; }

        public List<string> StaffNames { get; set; }

        public void Apply()
        {
            Console.WriteLine("You get a med. Take the damn med. You are, of course, free to refuse.");
        }

    }
}
