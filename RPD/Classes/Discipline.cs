using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPD.Classes
{
    class Discipline
    {
        public Discipline()
        {
        }

        public Discipline(string nameDiscipline, string teachersName)
        {
            disciplineName = nameDiscipline;
            this.teachersName = teachersName;
        }
        public Discipline(string nameDiscipline)
        {
            disciplineName = nameDiscipline;
            this.teachersName = "";
        }

        public string disciplineName { get; set; }
        public string teachersName { get; set; }
        public int zet { get; set; }
        public int academicHours { get; set; }
        public int lectionsHours { get; set; }
        public int seminarsHours { get; set; }
        public int homeworkHours { get; set; }


        public override string ToString()
        {
            return disciplineName;
        }

    }
}
