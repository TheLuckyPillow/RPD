
namespace RPD.Forms
{
    partial class F_Competencies_Popup
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
            this.textBox_codeKey = new System.Windows.Forms.TextBox();
            this.textBox_Discription = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_codeKey
            // 
            this.textBox_codeKey.Location = new System.Drawing.Point(118, 31);
            this.textBox_codeKey.Name = "textBox_codeKey";
            this.textBox_codeKey.Size = new System.Drawing.Size(100, 20);
            this.textBox_codeKey.TabIndex = 0;
            // 
            // textBox_Discription
            // 
            this.textBox_Discription.Location = new System.Drawing.Point(15, 64);
            this.textBox_Discription.Multiline = true;
            this.textBox_Discription.Name = "textBox_Discription";
            this.textBox_Discription.Size = new System.Drawing.Size(300, 100);
            this.textBox_Discription.TabIndex = 1;
            this.textBox_Discription.Click += new System.EventHandler(this.textBox_Discription_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(63, 176);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите буквенный код (ПК/УК/...)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(186, 176);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Отменить";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // F_Competencies_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 228);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.textBox_Discription);
            this.Controls.Add(this.textBox_codeKey);
            this.Name = "F_Competencies_Popup";
            this.Text = "Добавить компетенцию";
            this.Load += new System.EventHandler(this.F_Competencies_Popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_codeKey;
        private System.Windows.Forms.TextBox textBox_Discription;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
    }
}