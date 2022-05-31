using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPD_1
{
    class Discipline
    {
        public Discipline(string nameDiscipline, string teachersName)
        {
            this.disciplineName = nameDiscipline;
            this.teachersName = teachersName;
        }

        public String disciplineName { get; set; }
        public String teachersName { get; set; }
        //public int zet { get; set; }
        //public int academicHours { get; set; }
        //public int lectionsHours { get; set; }
        //public int seminarsHours { get; set; }
        //public int homeworkHours { get; set; }


        public override String ToString()
        {
            return this.disciplineName;
        }

    }
}
