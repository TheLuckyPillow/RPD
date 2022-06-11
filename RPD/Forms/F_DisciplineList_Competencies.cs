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
    public partial class F_DisciplineList_Competencies : Form
    {
        private Serializer ser = new Serializer(); //объект класса Serialize для работы с файлом "save_competence.json"
        private List<Competence> lst = new List<Competence>(); //Список объектов класса Competence
        public Competence compToDisc = new Competence(); //компетенция, которую нужно вернуть в дисциплину

        public F_DisciplineList_Competencies()
        {
            InitializeComponent();
        }

        private void F_DisciplineList_Competencies_Load(object sender, EventArgs e)
        {
            lst = ser.Deserialize_List_competence(); //загрузка списка компетенций
            comboBox_Competence.DataSource = lst;
        }

        List<CheckedListBox> lstListboxesKnowledge;
        List<CheckedListBox> lstListboxesSkills;
        List<CheckedListBox> lstListboxesOwnerships;

        private void comboBox_Competence_SelectedIndexChanged(object sender, EventArgs e)
        {   lstListboxesKnowledge = new List<CheckedListBox>();
            lstListboxesSkills = new List<CheckedListBox>();
            lstListboxesOwnerships = new List<CheckedListBox>();

            //Удаление checkedListBox'ов из группы ZUV
            for (int i = groupBox_ZUV.Controls.Count-1; i > 2; i--)
            {
                groupBox_ZUV.Controls.RemoveAt(i);
            }
            
            compToDisc = lst[comboBox_Competence.SelectedIndex].Clone() as Competence; //выбранная комп в отдельный объект
            checkedListBox_Indicator.Items.Clear();//очистка checkedlistbox'a старых индикаторов

            //создание ЗУВ под каждый индикатор для сохранения состояния
            foreach (Indicator i in lst[comboBox_Competence.SelectedIndex].lstIndicators)
            {
                checkedListBox_Indicator.Items.Add(i);//заполнение checkedlistbox'a индикаторов из полного lst всех компетенций

                ////Создание List_CheckedListBox Знаний////
                CheckedListBox checkedListBox1 = new CheckedListBox();
                checkedListBox1.Name = "checkedListBox_Knowledge" + i.code;
                checkedListBox1.Location = new System.Drawing.Point(0,28);
                checkedListBox1.Size = new System.Drawing.Size(97, 79);
                foreach (string s in i.dictKnowledge.Keys)
                    checkedListBox1.Items.Add(s);//заполнение listbox'а знаний
                checkedListBox1.Visible = false;
                groupBox_ZUV.Controls.Add(checkedListBox1);
                lstListboxesKnowledge.Add(checkedListBox1);
                ////Создание List_CheckedListBox Умений////
                CheckedListBox checkedListBox2 = new CheckedListBox();
                checkedListBox2.Name = "checkedListBox_Skills";
                checkedListBox2.Location = new System.Drawing.Point(0, 147);
                checkedListBox2.Size = new System.Drawing.Size(97, 79);
                foreach (string s in i.dictSkills.Keys)
                    checkedListBox2.Items.Add(s);//заполнение listbox'а умений
                checkedListBox2.Visible = false;
                groupBox_ZUV.Controls.Add(checkedListBox2);
                lstListboxesSkills.Add(checkedListBox2);
                ////Создание List_CheckedListBox Владений////
                CheckedListBox checkedListBox3 = new CheckedListBox();
                checkedListBox3.Name = "checkedListBox_Ownerships";
                checkedListBox3.Location = new System.Drawing.Point(0, 263);
                checkedListBox3.Size = new System.Drawing.Size(97, 79);
                foreach (string s in i.dictOwnerships.Keys)
                    checkedListBox3.Items.Add(s);//заполнение listbox'а владений
                checkedListBox3.Visible = false;
                groupBox_ZUV.Controls.Add(checkedListBox3);
                lstListboxesOwnerships.Add(checkedListBox3);
            }//TODO проверка ну пустой лист индикаторов
        }

        private void checkedListBox_Indicator_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CheckedListBox chlb in lstListboxesKnowledge)//все листбоксы Знаний скрыть
                chlb.Visible = false;
            lstListboxesKnowledge[checkedListBox_Indicator.SelectedIndex].Visible = true;//листбокс знаний по выбранному индикатору показать
            foreach (CheckedListBox chlb in lstListboxesSkills)//Умений 
                chlb.Visible = false;
            lstListboxesSkills[checkedListBox_Indicator.SelectedIndex].Visible = true;
            foreach (CheckedListBox chlb in lstListboxesOwnerships)//Владений
                chlb.Visible = false;
            lstListboxesOwnerships[checkedListBox_Indicator.SelectedIndex].Visible = true;


            //checkedListBox_Knowledge.Items.Clear();
            //checkedListBox_Skills.Items.Clear();
            //checkedListBox_Ownerships.Items.Clear();
            ////checkedListBox_Knowledge.Items.AddRange(lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictKnowledge.Keys);
            //string s1 = lst[0].lstIndicators[1].dictKnowledge["З1 (ПК-1)-2"];
            //foreach (string s in lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictKnowledge.Keys)
            //    checkedListBox_Knowledge.Items.Add(s);//заполнение listbox'а знаний
            //foreach (string s in lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictSkills.Keys)
            //    checkedListBox_Skills.Items.Add(s);//заполнение listbox'а умений
            //foreach (string s in lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictOwnerships.Keys)
            //    checkedListBox_Ownerships.Items.Add(s);//заполнение listbox'а владений



        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Competence cOut = new Competence(lst[comboBox_Competence.SelectedIndex].codeKey, lst[comboBox_Competence.SelectedIndex].codeNumber, lst[comboBox_Competence.SelectedIndex].discription);
            cOut.lstIndicatorInicialize();

            //foreach (CheckedListBox o in checkedListBox_Indicator.CheckedItems)
            //{
            //    o.v
            //}
            int tmp = 0;
            foreach (Object o in checkedListBox_Indicator.Items)
            {
                if (checkedListBox_Indicator.GetItemCheckState(checkedListBox_Indicator.Items.IndexOf(o)) == CheckState.Checked)
                {
                    //cOut.lstIndicators.Add(lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp]);
                    cOut.lstIndicators.Add(new Indicator(lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].codeKeyComp, lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].codeNumber, lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].discription));
                    cOut.lstIndicators.Last().DictionaryInicialize_K();
                    cOut.lstIndicators.Last().DictionaryInicialize_S();
                    cOut.lstIndicators.Last().DictionaryInicialize_O();

                    string _name = "checkedListBox_Knowledge" + o.ToString();
                    foreach(Object z in (groupBox_ZUV.Controls[_name] as CheckedListBox).CheckedItems)
                    {
                        //var a = (groupBox_ZUV.Controls[_name] as CheckedListBox).CheckedItems[0].ToString();
                        cOut.lstIndicators.Last().dictKnowledge.Add(z.ToString(), lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].dictKnowledge[z.ToString()]);
                    }
                }
                tmp++;
            }

            int qq = 0;

            //cOut.lstIndicators.Add(lst[comboBox_Competence.SelectedIndex].lstIndicators[]);
            //for (int i = 0; i < checkedListBox_Indicator.Items.Count; i++)
            //{

            //    if (checkedListBox_Indicator.)
            //}
        }
    }
}
