using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPD.Classes;

namespace RPD.Forms
{
    public partial class F_DisciplineList_Competencies : Form
    {
        private Serializer ser = new Serializer(); //объект класса Serialize для работы с файлом "save_competence.json"
        private List<Competence> lst = new List<Competence>(); //Список объектов класса Competence
        public Competence compToDisc = new Competence(); //компетенция, которую нужно вернуть в дисциплину

        public F_DisciplineList_Competencies()
        {
            InitializeComponent();
        }

        private void F_DisciplineList_Competencies_Load(object sender, EventArgs e)
        {
            lst = ser.Deserialize_List_competence(); //загрузка списка компетенций
            comboBox_Competence.DataSource = lst;
        }

        private void comboBox_Competence_SelectedIndexChanged(object sender, EventArgs e)
        {
            compToDisc = lst[comboBox_Competence.SelectedIndex]; //выбранная комп в отдельный объект
            //foreach (Indicator i in compToDisc.lstIndicators)
            //{
            //    i.dictKnowledge.Clear();
            //    i.dictSkills.Clear();
            //    i.dictOwnerships.Clear();
            //} //очистка словарей ЗУВ всех индикаторов в объекте выбранной комп
            checkedListBox_Indicator.Items.Clear();
            foreach (Indicator i in lst[comboBox_Competence.SelectedIndex].lstIndicators)
            {
                checkedListBox_Indicator.Items.Add(i);//заполнение индикаторов из полного lst всех компетенций
            }//TODO проверка ну пустой лист индикаторов
        }

        private void checkedListBox_Indicator_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox_Knowledge.Items.Clear();
            checkedListBox_Skills.Items.Clear();
            checkedListBox_Ownerships.Items.Clear();
            //checkedListBox_Knowledge.Items.AddRange(lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictKnowledge.Keys);
            string s1 = lst[0].lstIndicators[1].dictKnowledge["З1 (ПК-1)-2"];
            foreach (string s in lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictKnowledge.Keys)
                checkedListBox_Knowledge.Items.Add(s);//заполнение listbox'а знаний
            foreach (string s in lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictSkills.Keys)
                checkedListBox_Skills.Items.Add(s);//заполнение listbox'а умений
            foreach (string s in lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictOwnerships.Keys)
                checkedListBox_Ownerships.Items.Add(s);//заполнение listbox'а владений



        }
    }
}
