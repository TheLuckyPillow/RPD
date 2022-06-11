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
        public Competence compOut = new Competence(); //компетенция, которую нужно вернуть в дисциплину

        public F_DisciplineList_Competencies()
        {
            InitializeComponent();
        }

        private void F_DisciplineList_Competencies_Load(object sender, EventArgs e)
        {
            lst = ser.Deserialize_List_competence(); //загрузка списка компетенций
            comboBox_Competence.DataSource = lst;
        }

        List<CheckedListBox> lstListboxesKnowledge; //листы для хранения листбоксов, чтобы они все были подгружены и галочки при смене индикатора не спадали
        List<CheckedListBox> lstListboxesSkills;
        List<CheckedListBox> lstListboxesOwnerships;

        List<CheckedListBox> lstListboxesSkills;
        List<CheckedListBox> lstListboxesOwnerships;

        private void comboBox_Competence_SelectedIndexChanged(object sender, EventArgs e)
        {   lstListboxesKnowledge = new List<CheckedListBox>();
            lstListboxesSkills = new List<CheckedListBox>();
            lstListboxesOwnerships = new List<CheckedListBox>();

            label_Competence.Text = lst[comboBox_Competence.SelectedIndex].discription; //вывод описания на лейбл

            //Удаление checkedListBox'ов из группы ZUV
            for (int i = groupBox_ZUV.Controls.Count-1; i > 2; i--)
                groupBox_ZUV.Controls.RemoveAt(i);
            //Очистка checkedlistbox'a старых индикаторов
            checkedListBox_Indicator.Items.Clear();

            //создание checkedListBox'ов ЗУВ под каждый индикатор для сохранения состояния галочек
            foreach (Indicator i in lst[comboBox_Competence.SelectedIndex].lstIndicators)
            {
                checkedListBox_Indicator.Items.Add(i);//заполнение checkedlistbox'a индикаторов из полного lst всех компетенций

                ////Создание List_CheckedListBox Знаний////
                CheckedListBox checkedListBox1 = new CheckedListBox();
                checkedListBox1.Name = "checkedListBox_Knowledge" + i.code; //"Класс знаний" ("checkedListBox_Knowledge" + код индикатора)
                checkedListBox1.Location = new System.Drawing.Point(0,28);
                checkedListBox1.Size = new System.Drawing.Size(97, 79);
                foreach (string s in i.dictKnowledge.Keys)
                    checkedListBox1.Items.Add(s);//заполнение listbox'а знаний
                checkedListBox1.Visible = false;
                groupBox_ZUV.Controls.Add(checkedListBox1);
                lstListboxesKnowledge.Add(checkedListBox1);
                ////Создание List_CheckedListBox Умений////
                CheckedListBox checkedListBox2 = new CheckedListBox();
                checkedListBox2.Name = "checkedListBox_Skills" + i.code; //"Класс умений"
                checkedListBox2.Location = new System.Drawing.Point(0, 147);
                checkedListBox2.Size = new System.Drawing.Size(97, 79);
                foreach (string s in i.dictSkills.Keys)
                    checkedListBox2.Items.Add(s);//заполнение listbox'а умений
                checkedListBox2.Visible = false;
                groupBox_ZUV.Controls.Add(checkedListBox2);
                lstListboxesSkills.Add(checkedListBox2);
                ////Создание List_CheckedListBox Владений////
                CheckedListBox checkedListBox3 = new CheckedListBox();
                checkedListBox3.Name = "checkedListBox_Ownerships" + i.code; //"Класс владений"
                checkedListBox3.Location = new System.Drawing.Point(0, 263);
                checkedListBox3.Size = new System.Drawing.Size(97, 79);
                foreach (string s in i.dictOwnerships.Keys)
                    checkedListBox3.Items.Add(s);//заполнение listbox'а владений
                checkedListBox3.Visible = false;
                groupBox_ZUV.Controls.Add(checkedListBox3);
                lstListboxesOwnerships.Add(checkedListBox3);
            }
        }
        private void checkedListBox_Indicator_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Indicator.Text = lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].discription;//вывод описания на лейбл

            foreach (CheckedListBox chlb in lstListboxesKnowledge)//все листбоксы Знаний скрыть
                chlb.Visible = false;
            lstListboxesKnowledge[checkedListBox_Indicator.SelectedIndex].Visible = true;//листбокс знаний по выбранному индикатору показат
            foreach (CheckedListBox chlb in lstListboxesSkills)//Умений 
                chlb.Visible = false;
            lstListboxesSkills[checkedListBox_Indicator.SelectedIndex].Visible = true;
            foreach (CheckedListBox chlb in lstListboxesOwnerships)//Владений
                chlb.Visible = false;
            lstListboxesOwnerships[checkedListBox_Indicator.SelectedIndex].Visible = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //инициализация объекта competenceOut
            compOut = new Competence(lst[comboBox_Competence.SelectedIndex].codeKey, lst[comboBox_Competence.SelectedIndex].codeNumber, lst[comboBox_Competence.SelectedIndex].discription);
            compOut.lstIndicatorInicialize();
            foreach (string s in lst[comboBox_Competence.SelectedIndex].lstIndicators[checkedListBox_Indicator.SelectedIndex].dictOwnerships.Keys)
            int tmp = 0; //счетчик, чтобы знать, на каком мы индикаторе внутри цикла
            foreach (Object i in checkedListBox_Indicator.Items) //проходимся по индикаторам
            {
                if (checkedListBox_Indicator.GetItemCheckState(checkedListBox_Indicator.Items.IndexOf(i)) == CheckState.Checked) //если инидкатор отмечен галочкой
                {
                    //добавление индикатора в competenceOut
                    compOut.lstIndicators.Add(new Indicator(lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].codeKeyComp, lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].codeNumber, lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].discription));
                    compOut.lstIndicators.Last().DictionaryInicialize_K();
                    compOut.lstIndicators.Last().DictionaryInicialize_S();
                    compOut.lstIndicators.Last().DictionaryInicialize_O();
                checkedListBox_Ownerships.Items.Add(s);//заполнение listbox'а владений
                    string knowledgeClass = "checkedListBox_Knowledge" + i.ToString();
                    foreach (Object chlbItem in (groupBox_ZUV.Controls[knowledgeClass] as CheckedListBox).CheckedItems) //проходися по Items checkedListBox'a с классом knowledgeClass
                    {
                        //добавление в словарь dictKnowledge отмеченных знаний
                        compOut.lstIndicators.Last().dictKnowledge.Add(chlbItem.ToString(), lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].dictKnowledge[chlbItem.ToString()]);
                    }
                    string skillsClass = "checkedListBox_Skills" + i.ToString();
                    foreach (Object chlbItem in (groupBox_ZUV.Controls[skillsClass] as CheckedListBox).CheckedItems) //проходися по Items checkedListBox'a с классом skillsClass
                    {
                        //добавление в словарь dictSkills отмеченных умений
                        compOut.lstIndicators.Last().dictSkills.Add(chlbItem.ToString(), lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].dictSkills[chlbItem.ToString()]);
                    }
                    string ownershipsClass = "checkedListBox_Ownerships" + i.ToString();
                    foreach (Object chlbItem in (groupBox_ZUV.Controls[ownershipsClass] as CheckedListBox).CheckedItems) //проходися по Items checkedListBox'a с классом ownershipsClass
                    {
                        //добавление в словарь dictOwnerships отмеченных владений
                        compOut.lstIndicators.Last().dictOwnerships.Add(chlbItem.ToString(), lst[comboBox_Competence.SelectedIndex].lstIndicators[tmp].dictOwnerships[chlbItem.ToString()]);
                    }
                }
                tmp++;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;


        }

        //TODO Важно! Вывод на лейбл выделения зува
    }
}
