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
        public Discipline(string nameDiscipline, int zet, int academicHours, int lectionsHours, int seminarsHours, int homeworkHours)
        {
            disciplineName = nameDiscipline;
            this.teachersName = "";
            this.zet = zet;
            this.academicHours = academicHours;
            this.lectionsHours = lectionsHours;
            this.seminarsHours = seminarsHours;
            this.homeworkHours = homeworkHours;
            // TODO  сделать проверку на корректность
        }
        public Discipline(string nameDiscipline, int zet, int academicHours)
        {
            disciplineName = nameDiscipline;
            this.teachersName = "";
            this.zet = zet;
            this.academicHours = academicHours;
            // TODO  сделать проверку на корректность
        }

        public Discipline(string nameDiscipline)
        {
            disciplineName = nameDiscipline;
            this.teachersName = "";
        }
        public Discipline(string nameDiscipline, int zet, int academicHours, int lectionsHours, int seminarsHours, int homeworkHours)
        {
            disciplineName = nameDiscipline;
            this.teachersName = "";
            this.zet = zet;
            this.academicHours = academicHours;
            this.lectionsHours = lectionsHours;
            this.seminarsHours = seminarsHours;
            this.homeworkHours = homeworkHours;
            // TODO  сделать проверку на корректность
        }
        public Discipline(string nameDiscipline, int zet, int academicHours)
        {
            disciplineName = nameDiscipline;
            this.teachersName = "";
            this.zet = zet;
            this.academicHours = academicHours;
            // TODO  сделать проверку на корректность
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
