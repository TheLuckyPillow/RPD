namespace RPD
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_DisciplineList = new System.Windows.Forms.Button();
            this.btn_TeachersList = new System.Windows.Forms.Button();
            this.btn_CompetenciesList = new System.Windows.Forms.Button();
            this.label_test = new System.Windows.Forms.Label();
            this.btn_DisciplineLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сделать рассылку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Загрузить список преподавателей";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_DisciplineList
            // 
            this.btn_DisciplineList.Location = new System.Drawing.Point(12, 12);
            this.btn_DisciplineList.Name = "btn_DisciplineList";
            this.btn_DisciplineList.Size = new System.Drawing.Size(144, 23);
            this.btn_DisciplineList.TabIndex = 9;
            this.btn_DisciplineList.Text = "Cписок дисциплин";
            this.btn_DisciplineList.UseVisualStyleBackColor = true;
            this.btn_DisciplineList.Click += new System.EventHandler(this.btn_DisciplineList_Click);
            // 
            // btn_TeachersList
            // 
            this.btn_TeachersList.Location = new System.Drawing.Point(12, 41);
            this.btn_TeachersList.Name = "btn_TeachersList";
            this.btn_TeachersList.Size = new System.Drawing.Size(144, 23);
            this.btn_TeachersList.TabIndex = 10;
            this.btn_TeachersList.Text = "Список преподавателей";
            this.btn_TeachersList.UseVisualStyleBackColor = true;
            this.btn_TeachersList.Click += new System.EventHandler(this.btn_TeachersList_Click_1);
            // 
            // btn_CompetenciesList
            // 
            this.btn_CompetenciesList.Location = new System.Drawing.Point(12, 70);
            this.btn_CompetenciesList.Name = "btn_CompetenciesList";
            this.btn_CompetenciesList.Size = new System.Drawing.Size(144, 23);
            this.btn_CompetenciesList.TabIndex = 11;
            this.btn_CompetenciesList.Text = "Список компетенций";
            this.btn_CompetenciesList.UseVisualStyleBackColor = true;
            this.btn_CompetenciesList.Click += new System.EventHandler(this.btn_CompetenciesList_Click);
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Location = new System.Drawing.Point(508, 392);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(35, 13);
            this.label_test.TabIndex = 12;
            this.label_test.Text = "label1";
            // 
            // btn_DisciplineLoad
            // 
            this.btn_DisciplineLoad.Location = new System.Drawing.Point(184, 392);
            this.btn_DisciplineLoad.Name = "btn_DisciplineLoad";
            this.btn_DisciplineLoad.Size = new System.Drawing.Size(166, 46);
            this.btn_DisciplineLoad.TabIndex = 13;
            this.btn_DisciplineLoad.Text = "Загрузить дисциплины из учебного плана";
            this.btn_DisciplineLoad.UseVisualStyleBackColor = true;
            this.btn_DisciplineLoad.Click += new System.EventHandler(this.btn_DisciplineLoad_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DisciplineLoad);
            this.Controls.Add(this.label_test);
            this.Controls.Add(this.btn_CompetenciesList);
            this.Controls.Add(this.btn_TeachersList);
            this.Controls.Add(this.btn_DisciplineList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "FormMain";
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_DisciplineList;
        private System.Windows.Forms.Button btn_TeachersList;
        private System.Windows.Forms.Button btn_CompetenciesList;
        private System.Windows.Forms.Label label_test;
        private System.Windows.Forms.Button btn_DisciplineLoad;
    }
}

