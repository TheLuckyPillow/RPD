using RPD.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RPD
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_DisciplineList_Click(object sender, EventArgs e)
        {
            F_DisciplineList f_DisciplineList = new F_DisciplineList();
            f_DisciplineList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Mail f_Mail = new F_Mail();
            f_Mail.Show();
        }

        private void btn_TeachersList_Click_1(object sender, EventArgs e)
        {
            F_TeachersList f_Teachers = new F_TeachersList();
            f_Teachers.Show();
        }

        private void btn_CompetenciesList_Click(object sender, EventArgs e)
        {
            F_Competencies f_Competencies = new F_Competencies();
            f_Competencies.Show();
        }

       
        private List<Discipline> lst = new List<Discipline>();
        private Serializer ser = new Serializer();
        private void button3_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("test.xml");
            XElement dataSet = xdoc.Element("Документ");
            foreach (XElement itemDataSet in dataSet.Elements("ПланыСтроки"))
            {
                string disciplineName = itemDataSet.Attribute("Дисциплина").Value;
                int zet = 0;
                int academicHours = 0;
                if (itemDataSet.Attribute("ЗЕТфакт") != null)
                    zet = Convert.ToInt32(itemDataSet.Attribute("ЗЕТфакт").Value);
                if (itemDataSet.Attribute("ЧасовПоПлану") != null)
                    academicHours = Convert.ToInt32(itemDataSet.Attribute("ЧасовПоПлану").Value);
                lst.Add(new Discipline(disciplineName, zet, academicHours));
            }
            ser.Serialize_list_discipline(lst); //перезапись файла сохранения с новыми пар-рами
        }
    }
}
