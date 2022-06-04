using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPD.Classes
{
    internal class Teachers
    {
        public Teachers()
        {

        }
        public Teachers(string fio, string mail)
        {
            fIO = fio;
            this.mail = mail;
        }

        public string fIO { get; set; }
        public string mail { get; set; }

        public override string ToString()
        {
            return fIO;
        }

    }
}
