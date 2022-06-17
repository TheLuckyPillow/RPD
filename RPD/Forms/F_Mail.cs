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

namespace RPD
{
    public partial class F_Mail : Form
    {
        Serializer ser = new Serializer();
        List<Discipline> lstD = new List<Discipline>();
        List<Teachers> lstT = new List<Teachers>();
        public F_Mail()
        {
            InitializeComponent();
        }
        Style s = new Style();

        private void F_Mail_Load(object sender, EventArgs e)
        {
            s.AllStyle(this.Controls);
            this.BackColor = s.back;

            lstD = ser.Deserialize_List_discipline();
            lstT = ser.Deserialize_List_teachers();

            foreach (Discipline d in lstD)
                checkedListBox2.Items.Add(d);
            foreach (Teachers t in lstT)
                checkedListBox1.Items.Add(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // проверить, что шаблон есть
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox_Mail.Text = lstT[checkedListBox1.SelectedIndex].mail;
        }

        private void btn_SaveMail_Click(object sender, EventArgs e)
        {
            lstT[checkedListBox1.SelectedIndex].mail = textBox_Mail.Text;
            ser.Serialize_list_teachers(lstT);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
