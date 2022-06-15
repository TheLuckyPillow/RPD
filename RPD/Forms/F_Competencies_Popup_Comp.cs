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
    public partial class F_Competencies_Popup_Comp : Form
    {
        public F_Competencies_Popup_Comp()
        {
            InitializeComponent();
        }

        public string discription, codeKey;
        public int codeNumber;
        private Style s = new Style();

        private void F_Competencies_Popup_Load(object sender, EventArgs e)
        {
            s.AllStyle(this.Controls);
            this.BackColor = s.back;

            textBox_Discription.Text = "Введите содержание компетенции";
            textBox_Discription.ForeColor = Color.Gray;

            textBox_codeNumber.TabIndex = 1; //TODO: найти это свойство, чтобы не было лишней строчки
        }

        //исчезание подсказки ввода
        private void textBox_Discription_Click(object sender, EventArgs e)
        {
            if (textBox_Discription.Text == "Введите содержание компетенции")
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
            this.codeKey = textBox_codeKey.Text;
            this.codeNumber = Convert.ToInt32(textBox_codeNumber.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
