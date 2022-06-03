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
using System.Drawing.Drawing2D;

namespace RPD
{
    public partial class F_Competencies : Form
    {
        private Serializer ser = new Serializer(); //объект класса Serialize для работы с файлом "save_competence.json"
        private List<Competence> lst = new List<Competence>(); //Список объектов класса Competence
        F_Competencies_Popup f_Competencies_Popup;

        public F_Competencies()
        {
            InitializeComponent();

        }

        private void F_Competencies_Load(object sender, EventArgs e)
        {
            lst = ser.Deserialize_List_competence(); //загрузка списка преподавателей
            listBox_Competencies.DataSource = lst;
        }

        private void btn_AddCompetencies_Click(object sender, EventArgs e)
        {
            f_Competencies_Popup = new F_Competencies_Popup();
            f_Competencies_Popup.ShowDialog();
            
        }
    }

}
