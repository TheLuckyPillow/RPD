using RPD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPD
{
    public partial class F_TeachersList : Form
    {
        private Serializer ser = new Serializer(); //объект класса Serialize для работы с файлом "save_teachers.json"
        private List<Teachers> lst = new List<Teachers>(); //Список объектов класса Teachers


        public F_TeachersList()
        {
            InitializeComponent();
        }

        private void F_TeachersList_Load(object sender, EventArgs e)
        {
            lst = ser.Deserialize_List_teachers(); //загрузка списка преподавателей
            listBox1.DataSource = lst;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            lst.Add(new Teachers(textBox_FIO.Text, textBox_Mail.Text));

            listBox1.ClearSelected();
            ser.Serialize_list_teachers(lst); //перезапись файла сохранения с новыми пар-рами
            listBox1.DataSource = null; //обновление listbox
            listBox1.DataSource = lst;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            lst[listBox1.SelectedIndex].fIO = textBox_FIO.Text;
            lst[listBox1.SelectedIndex].mail = textBox_Mail.Text; //изменение в списке характеристик из TextBox'а

            listBox1.ClearSelected();
            ser.Serialize_list_teachers(lst);//перезапись файла сохранения с новыми пар-рами
            listBox1.DataSource = null; //обновление listbox
            listBox1.DataSource = lst;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lst.RemoveAt(listBox1.SelectedIndex);

            listBox1.ClearSelected();
            ser.Serialize_list_teachers(lst);//перезапись файла сохранения с новыми пар-рами
            listBox1.DataSource = null; //обновление listbox
            listBox1.DataSource = lst;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox_Mail.Text = lst[listBox1.SelectedIndex].mail;
                textBox_FIO.Text = lst[listBox1.SelectedIndex].fIO;
            } //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
        }
    }
}
