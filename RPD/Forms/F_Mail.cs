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
        public F_Mail()
        {
            InitializeComponent();
        }
        Style s = new Style();

        private void F_Mail_Load(object sender, EventArgs e)
        {
            s.AllStyle(this.Controls);
            this.BackColor = s.back;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // проверить, что шаблон есть
        }
    }
}
