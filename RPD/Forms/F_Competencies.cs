using RPD.Classes;
using RPD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RPD
{
    public partial class F_Competencies : Form
    {
        private Serializer ser = new Serializer(); //объект класса Serialize для работы с файлом "save_competence.json"
        private List<Competence> lst = new List<Competence>(); //Список объектов класса Competence
        F_Competencies_Popup f_Competencies_Popup;

        public F_Competencies()
        {
            InitializeComponent();

        }

        private void F_Competencies_Load(object sender, EventArgs e)
        {
            lst = ser.Deserialize_List_competence(); //загрузка списка преподавателей
            listBox_Competencies.DataSource = lst;
        }

        private void btn_AddCompetencies_Click(object sender, EventArgs e)
        {
            f_Competencies_Popup = new F_Competencies_Popup();
            if (f_Competencies_Popup.ShowDialog() == DialogResult.OK)
            {
                label1.Text = f_Competencies_Popup.discription;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Competence> competences = new List<Competence>();
            List<String> indicators1 = new List<string>();
            indicators1.Add("Анализирует проблемную ситуацию заинтересованных лиц и выявленяет требования к программному обеспечению, продукту, средству, программно-аппаратному комплексу, ИС");
            indicators1.Add("Разрабатывает требования к программному обеспечению, продукту, средству, программно-аппаратному комплексу, ИС");
            indicators1.Add("Проектирует программное обеспечение согласно требованиям");
            competences.Add(new Competence("ПК1", "Способен разрабатывать требования и проектировать программное обеспечение", indicators1));
            List<String> indicators2 = new List<string>();
            indicators2.Add("Анализирует проблемную ситуацию заинтересованных лиц и выявленяет требования к программному обеспечению, продукту, средству, программно-аппаратному комплексу, ИС");
            indicators2.Add("Разрабатывает требования к программному обеспечению, продукту, средству, программно-аппаратному комплексу, ИС");
            indicators2.Add("Проектирует программное обеспечение согласно требованиям");
            competences.Add(new Competence("ПК2", "Способен осуществлять концептуальное, функциональное и логическое проектирование систем среднего и крупного масштаба и сложности", indicators2));
            int node_num = 0;
            foreach (Competence competence in competences)
            {
                treeView1.Nodes.Add(competence.discription);
                foreach (string item in competence.indicators)
                {
                    treeView1.Nodes[node_num].Nodes.Add(item);
                }
                node_num++;
            }
           
        }
    }

}
