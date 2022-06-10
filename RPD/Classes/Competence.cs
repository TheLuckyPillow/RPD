using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPD.Classes
{
    public partial class Competence
    {
        public Competence()
        {
        }
        public Competence(string codeKey, int codeNumber, string discription)
        {
            this.codeKey = codeKey;
            this.codeNumber = codeNumber;
            this.discription = discription;

            this.code = codeKey + "-" + codeNumber.ToString();
            lstIndicators = new List<Indicator>();
        }

        public string codeKey { get; set; }
        public int codeNumber { get; set; }
        public string code { get; set; }

        public string discription { get; set; }

        public List<Indicator> lstIndicators { get; set; }

        //метод для принудительного создания листа в объекте, потому как если он создается через конструктор в итоге в него нельзя ничего добавить т.к. = NULL
        public void lstIndicatorInicialize()
        {
            lstIndicators = new List<Indicator>();
        }
        public override string ToString()
        {
            return code;
        }
    }
}
