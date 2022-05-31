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
        public Discipline(string nameDiscipline, string teacher)
        {
            this.nameDiscipline = nameDiscipline;
            this.teacher = teacher;
        }

        public String nameDiscipline { get; set; }
        public String teacher { get; set; }
        public int zet { get; set; }
        public int academicHours { get; set; }
        public int lectionsHours { get; set; }
        public int seminarsHours { get; set; }
        public int homeworkHours { get; set; }


    }
}
