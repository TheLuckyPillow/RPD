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
    public partial class F_Competencies_Popup_Ind : Form
    {
        public F_Competencies_Popup_Ind()
        {
            InitializeComponent();
        }

        public string discription;
        public int codeNumber;

        private void F_Competencies_Popup_Ind_Load(object sender, EventArgs e)
        {
            textBox_Discription.Text = "Введите содержание индикатора";
            textBox_Discription.ForeColor = Color.Gray;
        }
        
        //исчезание подсказки ввода
        private void textBox_Discription_Click(object sender, EventArgs e)
        {
            if (textBox_Discription.Text == "Введите содержание индикатора")
            {
                textBox_Discription.Clear();
                textBox_Discription.ForeColor = Color.Black;
            }
        }

        //правило для ввода для codeNumber только цифр
        private void textBox_codeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number))
                e.Handled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.discription = textBox_Discription.Text;
            this.codeNumber = Convert.ToInt32(textBox_codeNumber.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
