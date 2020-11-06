using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary
{
    public class PersonaListModel
    {
        public List<String> fNames { get; set; }

        public List<string> lNames { get; set; }

        public List<string> Prefixes { get; set; }

        public string Prefix { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
