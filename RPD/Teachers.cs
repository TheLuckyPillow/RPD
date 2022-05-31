using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPD_1
{
    internal class Teachers
    {
        public Teachers(string fio, string mail)
        {
            this.fIO = fio;
            this.mail = mail;
        }

        public String fIO { get; set; }
        public String mail { get; set; }
        
        public override String ToString()
        { 
            return this.fIO;
        }

    }
}
