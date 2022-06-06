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

namespace RPD
{
    public partial class F_DisciplineList : Form
    {
        private Serializer ser = new Serializer(); //объект класса Serialize для работы с файлом "Save"
        private List<Discipline> lst;
        //= new List<Discipline>(); //Список объектов класса дисциплин
      

        public F_DisciplineList()
        {
            InitializeComponent();
        }

        private void ListDisciplines_Load(object sender, EventArgs e)
        {

            lst = ser.Deserialize_List_discipline(); //загрузка списка дисциплин из файла ""save_discipline.json"
            listBox_Discipline.ClearSelected();
            listBox_Discipline.DataSource = lst;

            List<Teachers> teachers = new List<Teachers>(ser.Deserialize_List_teachers()); //Считывание списка преподавателей для комбобокса в поле редактирование
            comboBox_TeachersName.DataSource = teachers;

            listBox_Discipline.ClearSelected();
            groupBox1.Visible = false; //Скрытие панели настроек
        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            F_DisciplineList_Popup f_DisciplineList_Popup = new F_DisciplineList_Popup();

            if (f_DisciplineList_Popup.ShowDialog() == DialogResult.OK)
            {
                lst.Add(new Discipline(f_DisciplineList_Popup.disciplineName, f_DisciplineList_Popup.teacherName));
                listBox_Discipline.ClearSelected();
                ser.Serialize_list_discipline(lst); //перезапись файла сохранения с новыми пар-рами
                listBox_Discipline.DataSource = null; //обновление listbox
                listBox_Discipline.DataSource = lst;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            lst[listBox_Discipline.SelectedIndex].disciplineName = textBox_DisciplineName.Text;
            lst[listBox_Discipline.SelectedIndex].teachersName = comboBox_TeachersName.Text; //изменение полей дисциплин из TextBox'а
            
            lst[listBox_Discipline.SelectedIndex].zet = Convert.ToInt32(numericUpDown_ZET.Value);
            lst[listBox_Discipline.SelectedIndex].academicHours = Convert.ToInt32(numericUpDown_AcademicHours.Value);
            lst[listBox_Discipline.SelectedIndex].lectionsHours = Convert.ToInt32(numericUpDown_LectionsHours.Value);
            lst[listBox_Discipline.SelectedIndex].seminarsHours = Convert.ToInt32(numericUpDown_SeminarsHours.Value);
            lst[listBox_Discipline.SelectedIndex].homeworkHours = Convert.ToInt32(numericUpDown_HomeworkHours.Value);


            listBox_Discipline.ClearSelected();
            ser.Serialize_list_discipline(lst);//перезапись файла сохранения с новыми пар-рами
            listBox_Discipline.DataSource = null; //обновление listbox
            listBox_Discipline.DataSource = lst;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lst.RemoveAt(listBox_Discipline.SelectedIndex);
            listBox_Discipline.ClearSelected();

            ser.Serialize_list_discipline(lst);//перезапись файла сохранения с новыми пар-рами
            listBox_Discipline.DataSource = null; //обновление listbox
            listBox_Discipline.DataSource = lst;
        }

        private void listBox_Discipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox_Discipline.SelectedIndex != -1)
            {
                groupBox1.Visible = true;
                textBox_DisciplineName.Text = lst[listBox_Discipline.SelectedIndex].disciplineName;
                comboBox_TeachersName.Text = lst[listBox_Discipline.SelectedIndex].teachersName;

                numericUpDown_ZET.Value = lst[listBox_Discipline.SelectedIndex].zet;
                numericUpDown_AcademicHours.Value = lst[listBox_Discipline.SelectedIndex].academicHours;
                numericUpDown_LectionsHours.Value = lst[listBox_Discipline.SelectedIndex].lectionsHours;
                numericUpDown_SeminarsHours.Value = lst[listBox_Discipline.SelectedIndex].seminarsHours;
                numericUpDown_HomeworkHours.Value = lst[listBox_Discipline.SelectedIndex].homeworkHours;

            } //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
        }

        private void numericUpDown_ZET_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_AcademicHours.Value = numericUpDown_ZET.Value * 36; // завести константу и хранить в файле 
        }

        private void numericUpDown_LectionsHours_ValueChanged(object sender, EventArgs e)
        {
            if (!check())
            {
                ((NumericUpDown)sender).BackColor = Color.Red;
                label7.Text = "Рекомендуемое значение: " + (numericUpDown_AcademicHours.Value - numericUpDown_SeminarsHours.Value - numericUpDown_HomeworkHours.Value);
            }
        }

        private void numericUpDown_SeminarsHours_ValueChanged(object sender, EventArgs e)
        {
            // TODO numeric проверка
        }

        private void numericUpDown_HomeworkHours_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool check()
        {
            if (numericUpDown_AcademicHours.Value != numericUpDown_ZET.Value * 36)
            {
                // 
                return false;
            }
            else if (numericUpDown_LectionsHours.Value + numericUpDown_SeminarsHours.Value + numericUpDown_HomeworkHours.Value != numericUpDown_AcademicHours.Value)
            {
                // 
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void numericUpDown_AcademicHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
