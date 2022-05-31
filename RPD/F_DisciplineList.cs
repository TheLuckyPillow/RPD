using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPD_1
{
    public partial class F_DisciplineList : Form
    {
        private Serializer ser = new Serializer(); //объект класса Serialize для работы с файлом "Save"
        private List<Discipline> lst = new List<Discipline>(); //Список объектов класса дисциплин



        public F_DisciplineList()
        {
            InitializeComponent();
        }

        private void ListDisciplines_Load(object sender, EventArgs e)
        {

            //lst = ser.Deserialize_List_discipline(); //загрузка списка дисциплин из файла ""save_discipline.json"
            //listBox_Discipline.DataSource = lst;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            lst.Add(new Discipline(textBox_DisciplineName.Text, comboBox_TeachersName.Text));
            listBox_Discipline.ClearSelected();
            ser.Serialize_list_discipline(lst); //перезапись файла сохранения с новыми пар-рами
            listBox_Discipline.DataSource = null; //обновление listbox
            listBox_Discipline.DataSource = lst;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            lst[listBox_Discipline.SelectedIndex].disciplineName = textBox_DisciplineName.Text;
            lst[listBox_Discipline.SelectedIndex].teachersName = comboBox_TeachersName.Text; //изменение в списке характеристик из TextBox'а

            listBox_Discipline.ClearSelected();
            ser.Serialize_list_discipline(lst);//перезапись файла сохранения с новыми пар-рами
            listBox_Discipline.DataSource = null; //обновление listbox
            listBox_Discipline.DataSource = lst;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            listBox_Discipline.ClearSelected();
            ser.Serialize_list_discipline(lst);//перезапись файла сохранения с новыми пар-рами
            listBox_Discipline.DataSource = null; //обновление listbox
            listBox_Discipline.DataSource = lst;
        }

        private void listBox_Discipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Discipline.SelectedIndex != -1)
            {
                textBox_DisciplineName.Text = lst[listBox_Discipline.SelectedIndex].disciplineName;
                comboBox_TeachersName.Text = lst[listBox_Discipline.SelectedIndex].teachersName;
            } //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
        }
    }
}
