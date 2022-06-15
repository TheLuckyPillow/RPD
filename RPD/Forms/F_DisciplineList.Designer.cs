namespace RPD
{
    partial class F_DisciplineList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DisciplineList));
            this.label_Disc_Name = new System.Windows.Forms.Label();
            this.textBox_DisciplineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_ZET = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_AcademicHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_LectionsHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SeminarsHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_HomeworkHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CreatePattern = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboBox_TeachersName = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_FormatAtest = new System.Windows.Forms.ComboBox();
            this.groupBox_Opop = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Semester = new System.Windows.Forms.ComboBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.treeView_Competencies = new System.Windows.Forms.TreeView();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Competencies = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_Discipline = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ZET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcademicHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LectionsHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SeminarsHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HomeworkHours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Opop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Disc_Name
            // 
            this.label_Disc_Name.AutoSize = true;
            this.label_Disc_Name.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Disc_Name.Location = new System.Drawing.Point(6, 13);
            this.label_Disc_Name.Name = "label_Disc_Name";
            this.label_Disc_Name.Size = new System.Drawing.Size(125, 15);
            this.label_Disc_Name.TabIndex = 1;
            this.label_Disc_Name.Text = "Название дисциплины:";
            // 
            // textBox_DisciplineName
            // 
            this.textBox_DisciplineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DisciplineName.Location = new System.Drawing.Point(9, 30);
            this.textBox_DisciplineName.Multiline = true;
            this.textBox_DisciplineName.Name = "textBox_DisciplineName";
            this.textBox_DisciplineName.Size = new System.Drawing.Size(413, 20);
            this.textBox_DisciplineName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Преподаватель";
            // 
            // numericUpDown_ZET
            // 
            this.numericUpDown_ZET.Location = new System.Drawing.Point(282, 129);
            this.numericUpDown_ZET.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_ZET.Name = "numericUpDown_ZET";
            this.numericUpDown_ZET.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown_ZET.TabIndex = 8;
            this.numericUpDown_ZET.ValueChanged += new System.EventHandler(this.numericUpDown_ZET_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ЗЕТ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_AcademicHours
            // 
            this.numericUpDown_AcademicHours.Location = new System.Drawing.Point(355, 128);
            this.numericUpDown_AcademicHours.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_AcademicHours.Name = "numericUpDown_AcademicHours";
            this.numericUpDown_AcademicHours.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown_AcademicHours.TabIndex = 10;
            this.numericUpDown_AcademicHours.ValueChanged += new System.EventHandler(this.numericUpDown_AcademicHours_ValueChanged);
            // 
            // numericUpDown_LectionsHours
            // 
            this.numericUpDown_LectionsHours.Location = new System.Drawing.Point(11, 195);
            this.numericUpDown_LectionsHours.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_LectionsHours.Name = "numericUpDown_LectionsHours";
            this.numericUpDown_LectionsHours.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_LectionsHours.TabIndex = 11;
            this.numericUpDown_LectionsHours.ValueChanged += new System.EventHandler(this.numericUpDown_LectionsHours_ValueChanged);
            // 
            // numericUpDown_SeminarsHours
            // 
            this.numericUpDown_SeminarsHours.Location = new System.Drawing.Point(82, 195);
            this.numericUpDown_SeminarsHours.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SeminarsHours.Name = "numericUpDown_SeminarsHours";
            this.numericUpDown_SeminarsHours.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_SeminarsHours.TabIndex = 12;
            this.numericUpDown_SeminarsHours.ValueChanged += new System.EventHandler(this.numericUpDown_SeminarsHours_ValueChanged);
            // 
            // numericUpDown_HomeworkHours
            // 
            this.numericUpDown_HomeworkHours.Location = new System.Drawing.Point(153, 195);
            this.numericUpDown_HomeworkHours.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_HomeworkHours.Name = "numericUpDown_HomeworkHours";
            this.numericUpDown_HomeworkHours.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_HomeworkHours.TabIndex = 13;
            this.numericUpDown_HomeworkHours.ValueChanged += new System.EventHandler(this.numericUpDown_HomeworkHours_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(357, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Академические часы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Лекции";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Семинары";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(153, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "Самос - ная работа";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_CreatePattern
            // 
            this.btn_CreatePattern.Location = new System.Drawing.Point(9, 481);
            this.btn_CreatePattern.Name = "btn_CreatePattern";
            this.btn_CreatePattern.Size = new System.Drawing.Size(138, 27);
            this.btn_CreatePattern.TabIndex = 18;
            this.btn_CreatePattern.Text = "Создать шаблон";
            this.btn_CreatePattern.UseVisualStyleBackColor = true;
            this.btn_CreatePattern.Click += new System.EventHandler(this.btn_CreatePattern_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(155, 499);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 27);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(9, 435);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 27);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboBox_TeachersName
            // 
            this.comboBox_TeachersName.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_TeachersName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeachersName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_TeachersName.FormattingEnabled = true;
            this.comboBox_TeachersName.Location = new System.Drawing.Point(9, 69);
            this.comboBox_TeachersName.Name = "comboBox_TeachersName";
            this.comboBox_TeachersName.Size = new System.Drawing.Size(413, 21);
            this.comboBox_TeachersName.TabIndex = 24;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(24, 499);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 27);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.comboBox_FormatAtest);
            this.groupBox1.Controls.Add(this.groupBox_Opop);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_Semester);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_CreatePattern);
            this.groupBox1.Controls.Add(this.comboBox_Year);
            this.groupBox1.Controls.Add(this.treeView_Competencies);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_Competencies);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_Disc_Name);
            this.groupBox1.Controls.Add(this.textBox_DisciplineName);
            this.groupBox1.Controls.Add(this.comboBox_TeachersName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_ZET);
            this.groupBox1.Controls.Add(this.numericUpDown_AcademicHours);
            this.groupBox1.Controls.Add(this.numericUpDown_LectionsHours);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_SeminarsHours);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_HomeworkHours);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 514);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // comboBox_FormatAtest
            // 
            this.comboBox_FormatAtest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FormatAtest.FormattingEnabled = true;
            this.comboBox_FormatAtest.Items.AddRange(new object[] {
            "Зачет",
            "Экзамен",
            "Дифф. зачет",
            "Курсовая работа"});
            this.comboBox_FormatAtest.Location = new System.Drawing.Point(153, 129);
            this.comboBox_FormatAtest.Name = "comboBox_FormatAtest";
            this.comboBox_FormatAtest.Size = new System.Drawing.Size(123, 21);
            this.comboBox_FormatAtest.TabIndex = 47;
            // 
            // groupBox_Opop
            // 
            this.groupBox_Opop.Controls.Add(this.radioButton1);
            this.groupBox_Opop.Controls.Add(this.label9);
            this.groupBox_Opop.Controls.Add(this.radioButton4);
            this.groupBox_Opop.Controls.Add(this.radioButton2);
            this.groupBox_Opop.Controls.Add(this.radioButton3);
            this.groupBox_Opop.Location = new System.Drawing.Point(441, 13);
            this.groupBox_Opop.Name = "groupBox_Opop";
            this.groupBox_Opop.Size = new System.Drawing.Size(395, 202);
            this.groupBox_Opop.TabIndex = 46;
            this.groupBox_Opop.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(384, 43);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "к обязательной части образовательной программы";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Место дисциплины в структуре ОПОП";
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(6, 156);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(384, 43);
            this.radioButton4.TabIndex = 44;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "к факультативным дисциплинам (модулям).";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(6, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(384, 43);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "к части образовательной программы, формируемой участниками образовательных отноше" +
    "ний, является обязательной дисциплиной (модулем);";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(6, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(384, 43);
            this.radioButton3.TabIndex = 43;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "к части образовательной программы, формируемой участниками образовательных отноше" +
    "ний, к дисциплинам (модулям) по выбору обучающихся;\r\n";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Данные введены корректно";
            // 
            // comboBox_Semester
            // 
            this.comboBox_Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Semester.FormattingEnabled = true;
            this.comboBox_Semester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_Semester.Location = new System.Drawing.Point(80, 129);
            this.comboBox_Semester.Name = "comboBox_Semester";
            this.comboBox_Semester.Size = new System.Drawing.Size(67, 21);
            this.comboBox_Semester.TabIndex = 39;
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_Year.Location = new System.Drawing.Point(9, 128);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(67, 21);
            this.comboBox_Year.TabIndex = 38;
            // 
            // treeView_Competencies
            // 
            this.treeView_Competencies.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeView_Competencies.Location = new System.Drawing.Point(442, 246);
            this.treeView_Competencies.Name = "treeView_Competencies";
            this.treeView_Competencies.Size = new System.Drawing.Size(394, 229);
            this.treeView_Competencies.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(221, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 36;
            this.label13.Text = "Контроль";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(224, 195);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Форма аттестации";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Семестр";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Курс";
            // 
            // btn_Competencies
            // 
            this.btn_Competencies.Location = new System.Drawing.Point(547, 481);
            this.btn_Competencies.Name = "btn_Competencies";
            this.btn_Competencies.Size = new System.Drawing.Size(213, 27);
            this.btn_Competencies.TabIndex = 28;
            this.btn_Competencies.Text = "Редактрировать компетенции";
            this.btn_Competencies.UseVisualStyleBackColor = true;
            this.btn_Competencies.Click += new System.EventHandler(this.btn_Competencies_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Компетенция";
            // 
            // listBox_Discipline
            // 
            this.listBox_Discipline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Discipline.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox_Discipline.FormattingEnabled = true;
            this.listBox_Discipline.Location = new System.Drawing.Point(12, 12);
            this.listBox_Discipline.Name = "listBox_Discipline";
            this.listBox_Discipline.Size = new System.Drawing.Size(292, 481);
            this.listBox_Discipline.TabIndex = 27;
            this.listBox_Discipline.SelectedIndexChanged += new System.EventHandler(this.listBox_Discipline_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 260);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(425, 169);
            this.checkedListBox1.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(312, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Дисциплины, которые предшествуют текущей дисциплине: ";
            // 
            // F_DisciplineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 539);
            this.Controls.Add(this.listBox_Discipline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_DisciplineList";
            this.Text = "Список дисциплин";
            this.Load += new System.EventHandler(this.ListDisciplines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ZET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcademicHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LectionsHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SeminarsHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HomeworkHours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Opop.ResumeLayout(false);
            this.groupBox_Opop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Disc_Name;
        private System.Windows.Forms.TextBox textBox_DisciplineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_ZET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_AcademicHours;
        private System.Windows.Forms.NumericUpDown numericUpDown_LectionsHours;
        private System.Windows.Forms.NumericUpDown numericUpDown_SeminarsHours;
        private System.Windows.Forms.NumericUpDown numericUpDown_HomeworkHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CreatePattern;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comboBox_TeachersName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Discipline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Competencies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeView_Competencies;
        private System.Windows.Forms.ComboBox comboBox_Semester;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_Opop;
        private System.Windows.Forms.ComboBox comboBox_FormatAtest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}