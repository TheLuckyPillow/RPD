﻿using System;
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
        private Competence compToDisc = new Competence(); //компетенция, которую нужно вернуть в дисциплину

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
            compToDisc = lst[comboBox_Competence.SelectedIndex];
            checkedListBox_Indicator.Items.Clear();
            foreach (Indicator i in lst[comboBox_Competence.SelectedIndex].lstIndicators)
            {
                checkedListBox_Indicator.Items.Add(i);
            }//TODO проверка ну пустой лист индикаторов
        }
    }
}
