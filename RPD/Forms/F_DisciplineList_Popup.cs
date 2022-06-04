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
    public partial class F_DisciplineList_Popup : Form
    {
        public F_DisciplineList_Popup()
        {
            InitializeComponent();
        }

        public string disciplineName, teacherName;


        private void F_DisciplineList_Popup_Load(object sender, EventArgs e)
        {
            Serializer ser = new Serializer();
            List<Teachers> teachers = new List<Teachers>(ser.Deserialize_List_teachers());

            comboBox_TeacherName.DataSource = teachers;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            disciplineName = textBox_DisciplineName.Text;
            teacherName = comboBox_TeacherName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
