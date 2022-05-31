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
            lst = ser.Deserialize(); //записываем в список объектов Discipline все что уже есть в файле

            foreach (Discipline disc in lst)
            {
                checkedListBox.Items.Add(disc.nameDiscipline);
            } // заполняем листбоксы
        }


        private void button_DisciplineAdd_Click(object sender, EventArgs e)
        {
            //if(lst.Exists(x => x.nameDiscipline == textBox_DisciplineName.Text))

            Discipline d = new Discipline(textBox_DisciplineName.Text, comboBox_teachers.Text);
            ser.Serialize(d);
            lst.Add(d);
            checkedListBox.Items.Add(d.nameDiscipline);
        } // добвление новой дисциплины с названиемм и преподавателем за ней

        private void button_SaveZET_Click(object sender, EventArgs e)
        {
            lst[checkedListBox.SelectedIndex].zet = Convert.ToInt32(numericUpDown_ZET.Value);
            lst[checkedListBox.SelectedIndex].academicHours = Convert.ToInt32(numericUpDown_AcademicHours.Value);
            lst[checkedListBox.SelectedIndex].lectionsHours = Convert.ToInt32(numericUpDown_LectionsHours.Value);
            lst[checkedListBox.SelectedIndex].seminarsHours = Convert.ToInt32(numericUpDown_SeminarsHours.Value);
            lst[checkedListBox.SelectedIndex].homeworkHours = Convert.ToInt32(numericUpDown_HomeworkHours.Value);
            
            ser.Update(lst);
        } //сохраняем значение академических часов в выбранной дисциплине

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox.SelectedIndex > 0)
            {
                numericUpDown_ZET.Value = lst[checkedListBox.SelectedIndex].zet;
                numericUpDown_AcademicHours.Value = lst[checkedListBox.SelectedIndex].academicHours;
                numericUpDown_LectionsHours.Value = lst[checkedListBox.SelectedIndex].lectionsHours;
                numericUpDown_SeminarsHours.Value = lst[checkedListBox.SelectedIndex].seminarsHours;
                numericUpDown_HomeworkHours.Value = lst[checkedListBox.SelectedIndex].homeworkHours;
            }

        } //заполняем поля относительно выбранной дисциплины в listbox

        private void button_Delete_Click(object sender, EventArgs e)
        {
            checkedListBox.ClearSelected();

            Stack<int> stack = new Stack<int>(); //индексы которые нужно удалить

            //List<int> deleted_indexes_tmp = new List<int>();
            for (int i = checkedListBox.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedListBox.Items.RemoveAt(i);
                    stack.Push(i);
                }
            }

            var deleted_indexes_tmp = new Stack<int>(stack);

            while (deleted_indexes_tmp.Count > 0)
            {

                lst.RemoveAt(deleted_indexes_tmp.Pop());
            }

            ser.Update(lst);

        }// удаляем выбранные дисциплины
    }
}
