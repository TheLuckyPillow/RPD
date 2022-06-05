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


        F_Competencies_Popup_Comp f_Competencies_Popup; //TODO переместить в btn_AddComp...

        public F_Competencies()
        {
            InitializeComponent();
        }

        private void F_Competencies_Load(object sender, EventArgs e)
        {
            lst = ser.Deserialize_List_competence(); //загрузка списка преподавателей
            listBox_Competencies.DataSource = lst;

            listBox_Competencies.ClearSelected();
        }
        public void update()
        {

        }
        // ------------------------------------------- К О М П Е Т Е Н Ц И И -------------------------------------------------------
        private void listBox_Competencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
            if (listBox_Competencies.SelectedIndex != -1)
            {
                label_competence.Text = lst[listBox_Competencies.SelectedIndex].discription; //показать описание комп

                listBox_Indicators.DataSource = lst[listBox_Competencies.SelectedIndex].lstIndicators; //показать список индикаторов этой комп
                listBox_Indicators.ClearSelected();

                textBox_CompetenceEdit.Visible = false; //ексепшн До применения редактирования, попытаться кликнуть на другую компетенцию
                btn_SaveCompetence.Visible = false;
            }
            else
            {
                label_competence.Text = "";
                listBox_Indicators.DataSource = null; //не выделена комп — нет индикаторов
            }
        }

        private void btn_AddCompetencies_Click(object sender, EventArgs e)
        {
            f_Competencies_Popup = new F_Competencies_Popup_Comp();
            
            if (f_Competencies_Popup.ShowDialog() == DialogResult.OK) //открытие диалогового окна для добавления
            {
                Competence c = new Competence(f_Competencies_Popup.codeKey, f_Competencies_Popup.codeNumber, f_Competencies_Popup.discription);
                lst.Add(c);
                ser.Serialize_list_competence(lst);
                listBox_Competencies.DataSource = null;
                listBox_Competencies.DataSource = lst;
            }
        }

        private void btn_DeleteCompetencies_Click(object sender, EventArgs e)
        {
            if (listBox_Competencies.SelectedIndex != -1)
            {
                lst.RemoveAt(listBox_Competencies.SelectedIndex);

                listBox_Competencies.ClearSelected();
                //перезапись файла сохранения и обновление листа
                ser.Serialize_list_competence(lst);
                listBox_Competencies.DataSource = null; 
                listBox_Competencies.DataSource = lst;
            }    
        }

        private void btn_EditCompetence_Click(object sender, EventArgs e)
        {
            if (listBox_Competencies.SelectedIndex != -1)
            {
                textBox_CompetenceEdit.Visible = true;
                btn_SaveCompetence.Visible = true;
                textBox_CompetenceEdit.Text = lst[listBox_Competencies.SelectedIndex].discription; //показать в текстбоксе редактироавния имеющийся текст
            }
        }
        private void btn_SaveCompetence_Click(object sender, EventArgs e)
        {
            lst[listBox_Competencies.SelectedIndex].discription = textBox_CompetenceEdit.Text;
            ser.Serialize_list_competence(lst);

            textBox_CompetenceEdit.Visible = false;
            btn_SaveCompetence.Visible = false;

            listBox_Competencies.ClearSelected();
        }

        // ------------------------------------------- И Н Д И К А Т О Р Ы -------------------------------------------------------
        private void listBox_Indicators_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
            if (listBox_Indicators.SelectedIndex != -1)
            {
                label_Indicator.Text = lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].discription; //показать описание инд

                listBox_Knowledge.Items.Clear(); //Очистка лисбокса знаний дабы не плодить дублирующие строчки
                listBox_Knowledge.Items.AddRange(lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictKnowledge.Keys.ToArray()); //заполняет листбокс знаний массивом Keys из Dictionary
                listBox_Skills.Items.Clear(); //то же для умений
                listBox_Skills.Items.AddRange(lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictSkills.Keys.ToArray());
                listBox_Ownerships.Items.Clear(); //то же для владений
                listBox_Ownerships.Items.AddRange(lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictOwnerships.Keys.ToArray());

                textBox_IndicatorEdit.Visible = false; //ексепшн До применения редактирования, попытаться кликнуть на другой индикатор
                btn_SaveIndicator.Visible = false;
            }
            else
            {
                label_Indicator.Text = "";
                listBox_Knowledge.Items.Clear(); //не выделен индикатор - нет Знаний
                listBox_Skills.Items.Clear();//нет умений
                listBox_Ownerships.Items.Clear();//и нет владений
            }
        }

        private void btn_AddIndicators_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбрана компетенция
            if (listBox_Competencies.SelectedIndex != -1)
            {
                F_Competencies_Popup_Ind f_Competencies_Popup_Ind = new F_Competencies_Popup_Ind(); //открытие диалогового окна для добавления
                if (f_Competencies_Popup_Ind.ShowDialog() == DialogResult.OK)
                {
                    //создание объекта индикатора из ShowDialog //Indicator(string codeKeyCompetention, int codeNumber, string discription)
                    Indicator i = new Indicator(lst[listBox_Competencies.SelectedIndex].code, f_Competencies_Popup_Ind.codeNumber, f_Competencies_Popup_Ind.discription); 
                    
                    //если в объекте компетенции список индикаторов еще пустует, то создать его
                    if(lst[listBox_Competencies.SelectedIndex].lstIndicators == null)
                        lst[listBox_Competencies.SelectedIndex].lstIndicatorInicialize();

                    lst[listBox_Competencies.SelectedIndex].lstIndicators.Add(i); //добавить индикатор в список индикаторов объекта компетенций
   
                    //перезапись, сохранение и обновление
                    ser.Serialize_list_competence(lst);
                    listBox_Indicators.DataSource = null;
                    listBox_Indicators.DataSource = lst[listBox_Competencies.SelectedIndex].lstIndicators;
                }
            }
        }

        private void btn_DeleteIndicators_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбрана компетенция
            if (listBox_Competencies.SelectedIndex != -1)
            {
                lst[listBox_Competencies.SelectedIndex].lstIndicators.RemoveAt(listBox_Indicators.SelectedIndex);

                listBox_Indicators.ClearSelected();

                //перезапись файла сохранения и обновление листа
                ser.Serialize_list_competence(lst);
                listBox_Competencies.DataSource = null;
                listBox_Competencies.DataSource = lst;
            }
        }

        private void btn_EditIndicator_Click(object sender, EventArgs e)
        {
            if (listBox_Competencies.SelectedIndex != -1)
            {
                textBox_IndicatorEdit.Visible = true;
                btn_SaveIndicator.Visible = true;

                textBox_IndicatorEdit.Text = lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].discription; //показать в текстбоксе редактироавния имеющийся текст
            } //TODO может быть подгружать в текст бокс редактирования текст из лейбла, ведь туда он тоже уже подгружен (если изменить эту строчку, то и в компетенциях тоже)
        }

        private void btn_SaveIndicator_Click(object sender, EventArgs e)
        {
            lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].discription = textBox_IndicatorEdit.Text;
            ser.Serialize_list_competence(lst);

            textBox_CompetenceEdit.Visible = false;
            btn_SaveCompetence.Visible = false;

            listBox_Competencies.ClearSelected();
        }

        // ------------------------------------------- З Н А Н И Я -------------------------------------------------------
        private void listBox_Knowledge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
            if (listBox_Knowledge.SelectedIndex != -1)
            {
                label_Knowledge.Text = lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictKnowledge[listBox_Knowledge.Text]; //показать описание инд

                textBox_KnowledgeEdit.Visible = false; //ексепшн До применения редактирования, попытаться кликнуть на другое Знание
                btn_SaveKnowledge.Visible = false;
            }
            else
            {
                label_Knowledge.Text = "";
            }
        }

        private void btn_AddKnowledge_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбран индикатор
            if (listBox_Indicators.SelectedIndex != -1)
            {
                F_Competencies_Popup_Ind f_Competencies_Popup = new F_Competencies_Popup_Ind(); //открытие диалогового окна для добавления
                if (f_Competencies_Popup.ShowDialog() == DialogResult.OK)
                {

                    //если в объекте индикаторов словаль знаний еще пустует, то создать его
                    if (lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictKnowledge == null)
                        lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].DictionaryInicialize_K();

                    //TODO обработать ошибку "элемент с тем же ключем уже добавлен"
                    string codeKnowledge = "З" + f_Competencies_Popup.codeNumber.ToString() + " " + lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].code.Remove(0, 1); //полный код знания
                    lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictKnowledge.Add(codeKnowledge, f_Competencies_Popup.discription); //добавление в словарь нового знания

                    listBox_Knowledge.Items.Add(codeKnowledge);

                    ser.Serialize_list_competence(lst);
                    listBox_Knowledge.ClearSelected();
                }
            }
        }

        private void btn_DeleteKnowledge_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбрано знание
            if (listBox_Knowledge.SelectedIndex != -1)
            {
                lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictKnowledge.Remove(listBox_Knowledge.SelectedItem.ToString());//удаление из словаря элемента с ключом как у выделения листбокса

                listBox_Knowledge.Items.Clear(); //Очистка лисбокса знаний дабы не плодить дублирующие строчки
                listBox_Knowledge.Items.AddRange(lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictKnowledge.Keys.ToArray()); //заполняет листбокс знаний массивом Keys из Dictionary

                listBox_Knowledge.ClearSelected();
                label_Knowledge.Text = "";

                //перезапись файла сохранения и обновление листа
                ser.Serialize_list_competence(lst);
            }
        }
        bool isEditK = false;
        private void btn_EditKnowledge_Click(object sender, EventArgs e)
        {
            //скрытие окна редактирование == отмена редактирования
            if (textBox_KnowledgeEdit.Visible == true && isEditK == true)
            {
                textBox_KnowledgeEdit.Visible = false;
                btn_SaveKnowledge.Visible = false;
                isEditK = false;
            }
            //редактирование, если выбрано что редактировать
            else if (listBox_Knowledge.SelectedIndex != -1 && isEditK == false)
            {
                textBox_KnowledgeEdit.Text = label_Knowledge.Text;
                textBox_KnowledgeEdit.Visible = true;
                btn_SaveKnowledge.Visible = true;
                isEditK = true;
            }
        }

        private void btn_SaveKnowledge_Click(object sender, EventArgs e)
        {
            lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictKnowledge[listBox_Knowledge.SelectedItem.ToString()] = textBox_KnowledgeEdit.Text;
            ser.Serialize_list_competence(lst);
            textBox_KnowledgeEdit.Visible = false;
            btn_SaveKnowledge.Visible = false;

            listBox_Knowledge.ClearSelected();
        }

        // ------------------------------------------- У М Е Н И Я -------------------------------------------------------
        private void listBox_Skills_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
            if (listBox_Skills.SelectedIndex != -1)
            {
                label_Skills.Text = lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictSkills[listBox_Skills.Text]; //показать описание инд

                textBox_SkillsEdit.Visible = false; //ексепшн До применения редактирования, попытаться кликнуть на другое Умение
                btn_SaveSkills.Visible = false;
            }
            else
            {
                label_Skills.Text = "";
            }
        }

        private void btn_AddSkills_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбран индикатор
            if (listBox_Indicators.SelectedIndex != -1)
            {
                F_Competencies_Popup_Ind f_Competencies_Popup = new F_Competencies_Popup_Ind(); //открытие диалогового окна для добавления
                if (f_Competencies_Popup.ShowDialog() == DialogResult.OK)
                {
                    //если в объекте индикаторов словаль умений еще пустует, то создать его
                    if (lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictSkills == null)
                        lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].DictionaryInicialize_S();

                    string codeSkills = "У" + f_Competencies_Popup.codeNumber.ToString() + " " + lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].code.Remove(0, 1); //полный код уменя
                    lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictSkills.Add(codeSkills, f_Competencies_Popup.discription); //добавление в словарь нового умений

                    listBox_Skills.Items.Add(codeSkills);

                    ser.Serialize_list_competence(lst);
                    listBox_Skills.ClearSelected();
                }
            }
        }

        private void btn_DeleteSkills_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбрано умение
            if (listBox_Skills.SelectedIndex != -1)
            {
                lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictSkills.Remove(listBox_Skills.SelectedItem.ToString());//удаление из словаря элемента с ключом как у выделения листбокса

                listBox_Skills.Items.Clear(); //Очистка лисбокса умений дабы не плодить дублирующие строчки
                listBox_Skills.Items.AddRange(lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictSkills.Keys.ToArray()); //заполняет листбокс умений массивом Keys из Dictionary

                listBox_Skills.ClearSelected();
                label_Skills.Text = "";

                //перезапись файла сохранения и обновление листа
                ser.Serialize_list_competence(lst);
            }
        }

        bool isEditS = false;
        private void btn_EditSkills_Click(object sender, EventArgs e)
        {
            //скрытие окна редактирование == отмена редактирования
            if (textBox_SkillsEdit.Visible == true && isEditS == true)
            {
                textBox_SkillsEdit.Visible = false;
                btn_SaveSkills.Visible = false;
                isEditS = false;
            }
            //редактирование, если выбрано что редактировать
            else if (listBox_Skills.SelectedIndex != -1 && isEditS == false)
            {
                textBox_SkillsEdit.Text = label_Skills.Text;
                textBox_SkillsEdit.Visible = true;
                btn_SaveSkills.Visible = true;
                isEditS = true;
            }
        }

        private void btn_SaveSkills_Click(object sender, EventArgs e)
        {
            lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictSkills[listBox_Skills.SelectedItem.ToString()] = textBox_SkillsEdit.Text;
            ser.Serialize_list_competence(lst);
            textBox_SkillsEdit.Visible = false;
            btn_SaveSkills.Visible = false;

            listBox_Skills.ClearSelected();
        }

        // ------------------------------------------- В Л А Д Е Н И Я -------------------------------------------------------
        private void listBox_Ownerships_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если элемент не выделен, срабатывает SelectedIndexChanged, пытаясь использовать элемент, который не выделен
            if (listBox_Ownerships.SelectedIndex != -1)
            {
                label_Ownerships.Text = lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictOwnerships[listBox_Ownerships.Text]; //показать описание инд

                textBox_OwnershipsEdit.Visible = false; //ексепшн До применения редактирования, попытаться кликнуть на другое Умение
                btn_SaveOwnerships.Visible = false;
            }
            else
            {
                label_Ownerships.Text = "";
            }
        }

        private void btn_AddOwnerships_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбран индикатор
            if (listBox_Indicators.SelectedIndex != -1)
            {
                F_Competencies_Popup_Ind f_Competencies_Popup = new F_Competencies_Popup_Ind(); //открытие диалогового окна для добавления
                if (f_Competencies_Popup.ShowDialog() == DialogResult.OK)
                {
                    //если в объекте индикаторов словаль владений еще пустует, то создать его
                    if (lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictOwnerships == null)
                        lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].DictionaryInicialize_O();

                    string codeOwnerships = "В" + f_Competencies_Popup.codeNumber.ToString() + " " + lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].code.Remove(0, 1); //полный код владений
                    lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictOwnerships.Add(codeOwnerships, f_Competencies_Popup.discription); //добавление в словарь нового владения

                    listBox_Ownerships.Items.Add(codeOwnerships);

                    ser.Serialize_list_competence(lst);
                    listBox_Ownerships.ClearSelected();
                }
            }
        }

        private void btn_DeleteOwnerships_Click(object sender, EventArgs e)
        {
            //проверка на то, что выбрано Владение
            if (listBox_Ownerships.SelectedIndex != -1)
            {
                lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictOwnerships.Remove(listBox_Ownerships.SelectedItem.ToString());//удаление из словаря элемента с ключом как у выделения листбокса

                listBox_Ownerships.Items.Clear(); //Очистка лисбокса умений дабы не плодить дублирующие строчки
                listBox_Ownerships.Items.AddRange(lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictOwnerships.Keys.ToArray()); //заполняет листбокс умений массивом Keys из Dictionary

                listBox_Ownerships.ClearSelected();
                label_Ownerships.Text = "";

                //перезапись файла сохранения и обновление листа
                ser.Serialize_list_competence(lst);
            }
        }

        bool isEditO = false;

        private void btn_EditOwnerships_Click(object sender, EventArgs e)
        {
            //скрытие окна редактирование == отмена редактирования
            if (textBox_OwnershipsEdit.Visible == true && isEditO == true)
            {
                textBox_OwnershipsEdit.Visible = false;
                btn_SaveOwnerships.Visible = false;
                isEditO = false;
            }
            //редактирование, если выбрано что редактировать
            else if (listBox_Ownerships.SelectedIndex != -1 && isEditO == false)
            {
                textBox_OwnershipsEdit.Text = label_Ownerships.Text;
                textBox_OwnershipsEdit.Visible = true;
                btn_SaveOwnerships.Visible = true;
                isEditO = true;
            }
        }

        private void btn_SaveOwnerships_Click(object sender, EventArgs e)
        {
            lst[listBox_Competencies.SelectedIndex].lstIndicators[listBox_Indicators.SelectedIndex].dictOwnerships[listBox_Ownerships.SelectedItem.ToString()] = textBox_OwnershipsEdit.Text;
            ser.Serialize_list_competence(lst);
            textBox_OwnershipsEdit.Visible = false;
            btn_SaveOwnerships.Visible = false;

            listBox_Ownerships.ClearSelected();
        }
    }

}
