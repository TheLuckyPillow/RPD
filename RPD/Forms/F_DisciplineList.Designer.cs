﻿namespace RPD
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboBox_TeachersName = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_Discipline = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ZET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcademicHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LectionsHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SeminarsHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HomeworkHours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Disc_Name
            // 
            this.label_Disc_Name.AutoSize = true;
            this.label_Disc_Name.Location = new System.Drawing.Point(6, 24);
            this.label_Disc_Name.Name = "label_Disc_Name";
            this.label_Disc_Name.Size = new System.Drawing.Size(125, 13);
            this.label_Disc_Name.TabIndex = 1;
            this.label_Disc_Name.Text = "Название дисциплины:";
            // 
            // textBox_DisciplineName
            // 
            this.textBox_DisciplineName.Location = new System.Drawing.Point(9, 41);
            this.textBox_DisciplineName.Multiline = true;
            this.textBox_DisciplineName.Name = "textBox_DisciplineName";
            this.textBox_DisciplineName.Size = new System.Drawing.Size(392, 20);
            this.textBox_DisciplineName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Преподаватель";
            // 
            // numericUpDown_ZET
            // 
            this.numericUpDown_ZET.Location = new System.Drawing.Point(-1, 176);
            this.numericUpDown_ZET.Name = "numericUpDown_ZET";
            this.numericUpDown_ZET.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_ZET.TabIndex = 8;
            this.numericUpDown_ZET.ValueChanged += new System.EventHandler(this.numericUpDown_ZET_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ЗЕТ";
            // 
            // numericUpDown_AcademicHours
            // 
            this.numericUpDown_AcademicHours.Location = new System.Drawing.Point(80, 176);
            this.numericUpDown_AcademicHours.Name = "numericUpDown_AcademicHours";
            this.numericUpDown_AcademicHours.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_AcademicHours.TabIndex = 10;
            this.numericUpDown_AcademicHours.ValueChanged += new System.EventHandler(this.numericUpDown_AcademicHours_ValueChanged);
            // 
            // numericUpDown_LectionsHours
            // 
            this.numericUpDown_LectionsHours.Location = new System.Drawing.Point(161, 176);
            this.numericUpDown_LectionsHours.Name = "numericUpDown_LectionsHours";
            this.numericUpDown_LectionsHours.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_LectionsHours.TabIndex = 11;
            this.numericUpDown_LectionsHours.ValueChanged += new System.EventHandler(this.numericUpDown_LectionsHours_ValueChanged);
            // 
            // numericUpDown_SeminarsHours
            // 
            this.numericUpDown_SeminarsHours.Location = new System.Drawing.Point(239, 176);
            this.numericUpDown_SeminarsHours.Name = "numericUpDown_SeminarsHours";
            this.numericUpDown_SeminarsHours.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_SeminarsHours.TabIndex = 12;
            this.numericUpDown_SeminarsHours.ValueChanged += new System.EventHandler(this.numericUpDown_SeminarsHours_ValueChanged);
            // 
            // numericUpDown_HomeworkHours
            // 
            this.numericUpDown_HomeworkHours.Location = new System.Drawing.Point(317, 176);
            this.numericUpDown_HomeworkHours.Name = "numericUpDown_HomeworkHours";
            this.numericUpDown_HomeworkHours.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_HomeworkHours.TabIndex = 13;
            this.numericUpDown_HomeworkHours.ValueChanged += new System.EventHandler(this.numericUpDown_HomeworkHours_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(91, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Академические часы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Лекции";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Семинары";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(302, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 49);
            this.label6.TabIndex = 17;
            this.label6.Text = "Самостоятельная работа обучающегося";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "создать шаблон";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(143, 568);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 23);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(359, 323);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(125, 23);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboBox_TeachersName
            // 
            this.comboBox_TeachersName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeachersName.FormattingEnabled = true;
            this.comboBox_TeachersName.Items.AddRange(new object[] {
            "Беднякова Татьяна Михайловна",
            "Савватеева Татьяна Петровна",
            "Махалкина Татьяна Олеговна"});
            this.comboBox_TeachersName.Location = new System.Drawing.Point(9, 80);
            this.comboBox_TeachersName.Name = "comboBox_TeachersName";
            this.comboBox_TeachersName.Size = new System.Drawing.Size(392, 21);
            this.comboBox_TeachersName.TabIndex = 24;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 568);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 23);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_Disc_Name);
            this.groupBox1.Controls.Add(this.textBox_DisciplineName);
            this.groupBox1.Controls.Add(this.comboBox_TeachersName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_ZET);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_AcademicHours);
            this.groupBox1.Controls.Add(this.numericUpDown_LectionsHours);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_SeminarsHours);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_HomeworkHours);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(360, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 295);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "label7";
            // 
            // listBox_Discipline
            // 
            this.listBox_Discipline.FormattingEnabled = true;
            this.listBox_Discipline.Location = new System.Drawing.Point(12, 12);
            this.listBox_Discipline.Name = "listBox_Discipline";
            this.listBox_Discipline.Size = new System.Drawing.Size(292, 537);
            this.listBox_Discipline.TabIndex = 27;
            this.listBox_Discipline.SelectedIndexChanged += new System.EventHandler(this.listBox_Discipline_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Компетенция";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(440, 378);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 97);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // F_DisciplineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox_Discipline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comboBox_TeachersName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Discipline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}