using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary
{
    public class MethodGenerators
    {
            public string Hello(string prefix, string lName)
            {
                return $"Hello {prefix} {lName}";
            }

            public string Adios(string prefix, string lName)
            {
                return $"We look forward to your next visit, {prefix} {lName}";
            }
    }
}
