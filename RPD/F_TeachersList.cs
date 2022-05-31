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
    public partial class F_TeachersList : Form
    {
        private Serializer ser = new Serializer();
        private List<Teachers> lst = new List<Teachers>();


        public F_TeachersList()
        {
            InitializeComponent();
        }

        private void F_TeachersList_Load(object sender, EventArgs e)
        {
            //lst = ser.Deserialize_teachers(); //записываем в список объектов Discipline все что уже есть в файле

            //foreach (Teachers t in lst)
            //{
            //    listBox1.Items.Add(t.fIO);
            //}
            lst = ser.Deserialize_List_teachers();
            listBox1.DataSource = lst;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            lst.Add(new Teachers(textBox_FIO.Text, textBox_Mail.Text));
            //lst.Add(new Teachers(textBox_FIO.Text, textBox_Mail.Text));
            ser.Serialize_list_teachers(lst);
           
            //listBox1.Items.Add(lst.Last().fIO);
            //ser.Serialize(lst.Last());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Mail.Text = lst[listBox1.SelectedIndex].mail;
            textBox_FIO.Text = lst[listBox1.SelectedIndex].fIO;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst[listBox1.SelectedIndex].fIO = textBox_FIO.Text;
            lst[listBox1.SelectedIndex].mail = textBox_Mail.Text;
            ser.Serialize_list_teachers(lst);
            //listBox1.; как обновить?

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lst.RemoveAt(listBox1.SelectedIndex);
            ser.Serialize_list_teachers(lst);

        }

        //private void btn_delete_Click(object sender, EventArgs e)
        //{
        //    checkedListBox.ClearSelected();

        //    Stack<int> stack = new Stack<int>(); //индексы которые нужно удалить

        //    //List<int> deleted_indexes_tmp = new List<int>();
        //    for (int i = checkedListBox.Items.Count - 1; i >= 0; i--)
        //    {
        //        if (checkedListBox.GetItemChecked(i))
        //        {
        //            checkedListBox.Items.RemoveAt(i);
        //            stack.Push(i);
        ////        }
        ////    }

        //    var deleted_indexes_tmp = new Stack<int>(stack);

        //    while (deleted_indexes_tmp.Count > 0)
        //    {

        //        lst.RemoveAt(deleted_indexes_tmp.Pop());
        //    }

        //    ser.Update(lst);
        //}
    }
}
