using Microsoft.Office.Interop.Excel;
using RPD.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace RPD
{
    public partial class FormMain : Form
    {
        Classes.Style s = new Classes.Style();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            s.AllStyle(this.Controls);
            this.BackColor = s.back;
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
        private List<Teachers> lst_teachers = new List<Teachers>();
        private List<Competence> lst_competences = new List<Competence>();
        private Serializer ser = new Serializer();
        private void button3_Click(object sender, EventArgs e)
        {


            //----------------------- список преподавателей из .xls файла программы-------------------------------------
            // TODO исправить на относительный путь
            // TODO заполнение исходными данными вынести на отдельную форму или кнопки
            string pathToFile = "D:\\music\\RPD (2)\\RPD\\RPD\\Resources\\teachers.xlsx";
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook ObjWorkBook = excelApp.Workbooks.Open(pathToFile);
                //, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];
            int count = Convert.ToInt32(ObjWorkSheet.Cells[1, 1].value) + 2;
            for (int i = 2; i < count; i++)
            {
                lst_teachers.Add(new Teachers(ObjWorkSheet.Cells[i, 2].value, ObjWorkSheet.Cells[i, 3].value));
            }
            ser.Serialize_list_teachers(lst_teachers);
            // Выходим из программы Excel.
            // TODO исправить: Excel не закрывается!
            excelApp.Quit();
           
        }

        private void btn_DisciplineLoad_Click(object sender, EventArgs e)
        {
            //----------------------- список дисциплин из plx файла программы-------------------------------------
            XDocument xdoc = XDocument.Load("../../Resources/test.xml");//TODO проверка на файл exist
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

        private void button1_Click(object sender, EventArgs e)
        {
            string pathToFile = "C:\\Users\\Таня\\Desktop\\RPD\\RPD\\Resources\\matritsa.xlsx";
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook ObjWorkBook = excelApp.Workbooks.Open(pathToFile);
            //, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];
            String comp_code = "УК";
            Competence competence = null;
            Indicator indicator = null;
            // номер компетнции
            int comp_codeNumber = 1;
            int i = 1;
            // пока есть данные
            while(ObjWorkSheet.Cells[i, 1].value != null)
            {
                // если компетенции нет, значит нужно добавить к предыдущей
                var a = ObjWorkSheet.Cells[i, 2].value;
                while (a == null && ObjWorkSheet.Cells[i, 1].value != null)
                {
                    if (ObjWorkSheet.Cells[i, 3].value != null)
                    {
                        indicator = new Indicator(competence.code, Convert.ToInt32(ObjWorkSheet.Cells[i, 3].value), ObjWorkSheet.Cells[i, 4].value);
                        this.add_zuv(indicator, ObjWorkSheet.Cells[i, 5].value.ToString());
                    }
                    bool f = true;
                    while (ObjWorkSheet.Cells[i, 3].value == null && ObjWorkSheet.Cells[i, 1].value != null)
                    {
                        this.add_zuv(indicator, ObjWorkSheet.Cells[i, 5].value.ToString());
                        i++;
                        f = false;
                    }
                    if (ObjWorkSheet.Cells[i, 3].value != null && indicator != null) competence.lstIndicators.Add(indicator);
                    if (f) i++;
                    else f = true;
                    a = ObjWorkSheet.Cells[i, 2].value;
                }
                if (a != null && competence != null)
                {
                    lst_competences.Add(competence);
                    competence = null;
                    comp_codeNumber++;
                }
                if (ObjWorkSheet.Cells[i, 1].value == null)
                {
                    break;
                }
                competence = new Competence(comp_code, comp_codeNumber, ObjWorkSheet.Cells[i, 2].value);
                indicator = new Indicator(competence.code, Convert.ToInt32(ObjWorkSheet.Cells[i, 3].value), ObjWorkSheet.Cells[i, 4].value);
                this.add_zuv(indicator, ObjWorkSheet.Cells[i, 5].value.ToString());
                competence.lstIndicators.Add(indicator);
                //indicator = null;
                i++;
                
                
           }
            excelApp.Quit();
            ser.Serialize_list_competence(lst_competences);
            
            

        }
        // добавить ЗУВ
        private void add_zuv(Indicator indicator, string zuv_value)
        {
            string num = zuv_value.ToString()[0].ToString();
            char a = zuv_value.ToString()[3];
             string _code = a.ToString().ToUpper() + num + indicator.code;
            if (a == 'З')
            {
                indicator.dictKnowledge.Add(_code, zuv_value);
            }
            else if (a == 'У')
            {
                indicator.dictSkills.Add(_code, zuv_value);
            }
            else if (a == 'В')
            {
                indicator.dictOwnerships.Add(_code, zuv_value);
            }
        }
    }
}
