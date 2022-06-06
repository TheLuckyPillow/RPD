using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPD.Classes
{
    class Indicator
    {
        public Indicator()
        {
        }
        public Indicator(string codeKeyCompetention, int codeNumber, string discription)
        {
            this.codeKeyComp = codeKeyCompetention;
            this.codeNumber = codeNumber;
            code = "И(" + codeKeyComp + ")-" + codeNumber;
            this.discription = discription;

            dictKnowledge = new Dictionary<string, string>();
            dictSkills = new Dictionary<string, string>();
            dictOwnerships = new Dictionary<string, string>();
        }

        public string codeKeyComp { get; set; }
        public int codeNumber { get; set; }
        public string code { get; set; }

        public string discription  {get; set; }

        public Dictionary<string, string> dictKnowledge { get; set; }
        public Dictionary<string, string> dictSkills { get; set; }
        public Dictionary<string, string> dictOwnerships { get; set; }

        public void DictionaryInicialize_K()
        {
            dictKnowledge = new Dictionary<string, string>();
        }
        public void DictionaryInicialize_S()
        {
            dictSkills = new Dictionary<string, string>();
        }
        public void DictionaryInicialize_O()
        {
            dictOwnerships = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            return code;
        }
    }
}
