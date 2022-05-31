namespace RPD_1
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
            this.label_Disc_Name = new System.Windows.Forms.Label();
            this.button_DisciplineAdd = new System.Windows.Forms.Button();
            this.textBox_DisciplineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_teachers = new System.Windows.Forms.ComboBox();
            this.button_SaveZET = new System.Windows.Forms.Button();
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ZET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcademicHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LectionsHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SeminarsHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HomeworkHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Disc_Name
            // 
            this.label_Disc_Name.AutoSize = true;
            this.label_Disc_Name.Location = new System.Drawing.Point(380, 31);
            this.label_Disc_Name.Name = "label_Disc_Name";
            this.label_Disc_Name.Size = new System.Drawing.Size(125, 13);
            this.label_Disc_Name.TabIndex = 1;
            this.label_Disc_Name.Text = "Название дисциплины:";
            // 
            // button_DisciplineAdd
            // 
            this.button_DisciplineAdd.Location = new System.Drawing.Point(143, 607);
            this.button_DisciplineAdd.Name = "button_DisciplineAdd";
            this.button_DisciplineAdd.Size = new System.Drawing.Size(139, 23);
            this.button_DisciplineAdd.TabIndex = 2;
            this.button_DisciplineAdd.Text = "Добавить";
            this.button_DisciplineAdd.UseVisualStyleBackColor = true;
            this.button_DisciplineAdd.Click += new System.EventHandler(this.button_DisciplineAdd_Click);
            // 
            // textBox_DisciplineName
            // 
            this.textBox_DisciplineName.Location = new System.Drawing.Point(383, 48);
            this.textBox_DisciplineName.Multiline = true;
            this.textBox_DisciplineName.Name = "textBox_DisciplineName";
            this.textBox_DisciplineName.Size = new System.Drawing.Size(392, 20);
            this.textBox_DisciplineName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Преподаватель";
            // 
            // comboBox_teachers
            // 
            this.comboBox_teachers.FormattingEnabled = true;
            this.comboBox_teachers.Items.AddRange(new object[] {
            "Беднякова Татьяна Михайловна",
            "Савватеева Татьяна Петровна",
            "Махалкина Татьяна Олеговна"});
            this.comboBox_teachers.Location = new System.Drawing.Point(383, 87);
            this.comboBox_teachers.Name = "comboBox_teachers";
            this.comboBox_teachers.Size = new System.Drawing.Size(392, 21);
            this.comboBox_teachers.TabIndex = 6;
            // 
            // button_SaveZET
            // 
            this.button_SaveZET.Location = new System.Drawing.Point(438, 248);
            this.button_SaveZET.Name = "button_SaveZET";
            this.button_SaveZET.Size = new System.Drawing.Size(232, 23);
            this.button_SaveZET.TabIndex = 7;
            this.button_SaveZET.Text = "Сохранить";
            this.button_SaveZET.UseVisualStyleBackColor = true;
            this.button_SaveZET.Click += new System.EventHandler(this.button_SaveZET_Click);
            // 
            // numericUpDown_ZET
            // 
            this.numericUpDown_ZET.Location = new System.Drawing.Point(373, 191);
            this.numericUpDown_ZET.Name = "numericUpDown_ZET";
            this.numericUpDown_ZET.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_ZET.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ЗЕТ";
            // 
            // numericUpDown_AcademicHours
            // 
            this.numericUpDown_AcademicHours.Location = new System.Drawing.Point(454, 191);
            this.numericUpDown_AcademicHours.Name = "numericUpDown_AcademicHours";
            this.numericUpDown_AcademicHours.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_AcademicHours.TabIndex = 10;
            // 
            // numericUpDown_LectionsHours
            // 
            this.numericUpDown_LectionsHours.Location = new System.Drawing.Point(535, 191);
            this.numericUpDown_LectionsHours.Name = "numericUpDown_LectionsHours";
            this.numericUpDown_LectionsHours.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_LectionsHours.TabIndex = 11;
            // 
            // numericUpDown_SeminarsHours
            // 
            this.numericUpDown_SeminarsHours.Location = new System.Drawing.Point(613, 191);
            this.numericUpDown_SeminarsHours.Name = "numericUpDown_SeminarsHours";
            this.numericUpDown_SeminarsHours.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_SeminarsHours.TabIndex = 12;
            // 
            // numericUpDown_HomeworkHours
            // 
            this.numericUpDown_HomeworkHours.Location = new System.Drawing.Point(691, 191);
            this.numericUpDown_HomeworkHours.Name = "numericUpDown_HomeworkHours";
            this.numericUpDown_HomeworkHours.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_HomeworkHours.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(465, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Академические часы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Лекции";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Семинары";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(676, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 49);
            this.label6.TabIndex = 17;
            this.label6.Text = "Самостоятельная работа обучающегося";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "создать шаблон";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(297, 589);
            this.checkedListBox.TabIndex = 19;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(12, 607);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(125, 23);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "Удалить выбранные";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // F_DisciplineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_HomeworkHours);
            this.Controls.Add(this.numericUpDown_SeminarsHours);
            this.Controls.Add(this.numericUpDown_LectionsHours);
            this.Controls.Add(this.numericUpDown_AcademicHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_ZET);
            this.Controls.Add(this.button_SaveZET);
            this.Controls.Add(this.comboBox_teachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_DisciplineName);
            this.Controls.Add(this.button_DisciplineAdd);
            this.Controls.Add(this.label_Disc_Name);
            this.Name = "F_DisciplineList";
            this.Text = "Список дисциплин";
            this.Load += new System.EventHandler(this.ListDisciplines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ZET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcademicHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LectionsHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SeminarsHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HomeworkHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Disc_Name;
        private System.Windows.Forms.Button button_DisciplineAdd;
        private System.Windows.Forms.TextBox textBox_DisciplineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_teachers;
        private System.Windows.Forms.Button button_SaveZET;
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
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button button_Delete;
    }
}