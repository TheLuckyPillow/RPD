using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace RPD_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
           // Disciplines_form.Show();
            Close();
        }


        private void WriteDown(Discipline q)
        {
            
            string objectSerialized = JsonSerializer.Serialize(q);
            File.WriteAllText("test.json", objectSerialized);
            Console.WriteLine(objectSerialized);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            F_Competencies f_Competencies = new F_Competencies();
            f_Competencies.Show();
        }

        private void btn_TeachersList_Click_1(object sender, EventArgs e)
        {
            F_TeachersList f_Teachers = new F_TeachersList();
            f_Teachers.Show();
        }
    }

}
