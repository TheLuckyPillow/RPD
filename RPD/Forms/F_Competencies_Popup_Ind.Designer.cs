
namespace RPD.Forms
{
    partial class F_Competencies_Popup_Ind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Competencies_Popup_Ind));
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_codeNumber = new System.Windows.Forms.TextBox();
            this.textBox_Discription = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(11, 201);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порядковый номер:";
            // 
            // textBox_codeNumber
            // 
            this.textBox_codeNumber.Location = new System.Drawing.Point(148, 46);
            this.textBox_codeNumber.Name = "textBox_codeNumber";
            this.textBox_codeNumber.Size = new System.Drawing.Size(60, 20);
            this.textBox_codeNumber.TabIndex = 2;
            this.textBox_codeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codeNumber_KeyPress);
            // 
            // textBox_Discription
            // 
            this.textBox_Discription.Location = new System.Drawing.Point(11, 89);
            this.textBox_Discription.Multiline = true;
            this.textBox_Discription.Name = "textBox_Discription";
            this.textBox_Discription.Size = new System.Drawing.Size(300, 100);
            this.textBox_Discription.TabIndex = 3;
            this.textBox_Discription.Click += new System.EventHandler(this.textBox_Discription_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(203, 201);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Отменить";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // F_Competencies_Popup_Ind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 245);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.textBox_Discription);
            this.Controls.Add(this.textBox_codeNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Competencies_Popup_Ind";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.F_Competencies_Popup_Ind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_codeNumber;
        private System.Windows.Forms.TextBox textBox_Discription;
        private System.Windows.Forms.Button btn_Cancel;
    }
}