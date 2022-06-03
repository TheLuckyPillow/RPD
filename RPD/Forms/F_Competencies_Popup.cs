using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPD.Forms
{
    public partial class F_Competencies_Popup : Form
    {
        public F_Competencies_Popup()
        {
            InitializeComponent();
        }

        private void F_Competencies_Popup_Load(object sender, EventArgs e)
        {
            textBox_Discription.Text = "Введите содержание компетенции";
            textBox_Discription.ForeColor = Color.Gray;
        }

        private void textBox_Discription_TextChanged(object sender, EventArgs e)
        {
            textBox_Discription.Clear();
            textBox_Discription.ForeColor = Color.Black;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
