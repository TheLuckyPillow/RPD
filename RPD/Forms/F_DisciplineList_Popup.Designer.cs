namespace RPD.Forms
{
    partial class F_DisciplineList_Popup
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.textBox_DisciplineName = new System.Windows.Forms.TextBox();
            this.comboBox_TeacherName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(107, 176);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(320, 176);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Отменить";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // textBox_DisciplineName
            // 
            this.textBox_DisciplineName.Location = new System.Drawing.Point(107, 43);
            this.textBox_DisciplineName.Name = "textBox_DisciplineName";
            this.textBox_DisciplineName.Size = new System.Drawing.Size(288, 20);
            this.textBox_DisciplineName.TabIndex = 3;
            // 
            // comboBox_TeacherName
            // 
            this.comboBox_TeacherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeacherName.FormattingEnabled = true;
            this.comboBox_TeacherName.Location = new System.Drawing.Point(107, 87);
            this.comboBox_TeacherName.Name = "comboBox_TeacherName";
            this.comboBox_TeacherName.Size = new System.Drawing.Size(288, 21);
            this.comboBox_TeacherName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Преподаватель:";
            // 
            // F_DisciplineList_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_TeacherName);
            this.Controls.Add(this.textBox_DisciplineName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Name = "F_DisciplineList_Popup";
            this.Text = "F_DisciplineList_Popup";
            this.Load += new System.EventHandler(this.F_DisciplineList_Popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox textBox_DisciplineName;
        private System.Windows.Forms.ComboBox comboBox_TeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}