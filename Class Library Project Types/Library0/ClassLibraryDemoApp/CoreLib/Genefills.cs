using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib
{
    public class Genefills
    {
        public string Hello(string prefix, string lName)
        {
            return $"Hello {prefix} {lName}";
        }

        public string Adios(string prefix, string lName)
        {
            return $"Adios, {prefix} {lName}";
        }
    }
}
