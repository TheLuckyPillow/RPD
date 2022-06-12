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
        private List<Teachers> lst_teachers = new List<Teachers>();
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
            // Указываем номер столбца (таблицы Excel) из которого будут считываться данные.
            int count = Convert.ToInt32(ObjWorkSheet.Cells[1, 1].value) + 2;
            //count = 5; 
            for (int i = 2; i < count; i++)
            {
                lst_teachers.Add(new Teachers(ObjWorkSheet.Cells[i, 2].value, ObjWorkSheet.Cells[i, 3].value));
            }
            ser.Serialize_list_teachers(lst_teachers);
            //string t = ObjWorkSheet.Cells[2, 2].value;

            //label_test.Text = ObjWorkSheet.Cells[2, 2].value;
            // Range usedColumn = ObjWorkSheet.UsedRange.Columns[numCol];
            //System.Array myvalues = (System.Array)usedColumn.Cells.Value2;
            //string[] strArray = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();

            // Выходим из программы Excel.
            // TODO исправить: Excel не закрывается!
            excelApp.Quit();
           
        }

        private void btn_DisciplineLoad_Click(object sender, EventArgs e)
        {
            //----------------------- список дисциплин из plx файла программы-------------------------------------
            XDocument xdoc = XDocument.Load("test.xml");//TODO проверка на файл exist
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
