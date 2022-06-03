using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPD.Classes
{
    internal class Competence
    {
        public Competence(string codeKey, int codeNumber, string discription)
        {
            this.codeKey = codeKey;
            this.codeNumber = codeNumber;
            this.discription = discription;
        }

        public string codeKey;
        public int codeNumber;

        public string discription;



        public string id;
        public string text;
        public Dictionary<String, String> indicators;
        public Dictionary<String, String> knows;
        public Dictionary<String, String> skills;
        public Dictionary<String, String> vladenia;
    }
}
