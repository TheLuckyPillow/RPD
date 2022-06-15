using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace RPD.Classes
{
    internal class Style
    {
        public Color fColWhite, fColBlack, fColGrey, back, backTwo, btnColPurp, btnColBlue;
        public Font f10, f8;

        public Style()
        {
            this.f8 = new Font("Segoe UI Emoji|", 8);
            this.f10 = new Font("Segoe UI Emoji|", 10);
            
            this.fColWhite = Color.FromArgb(255,225,225,225);
            this.fColBlack = Color.FromArgb(255,0,0,0);
            this.fColGrey = Color.FromArgb(255, 135, 135, 135);
            this.back = Color.FromArgb(255, 18, 18, 18);
            this.backTwo = Color.FromArgb(255, 29, 29, 29);
            this.btnColPurp = Color.FromArgb(255, 195, 143, 255);
            this.btnColBlue = Color.FromArgb(255, 49, 106, 197);
        }

        public void AllStyle(Control.ControlCollection ctrl)
        {
            foreach (Object item in ctrl)
            {
                
                switch (item)
                {

                    case Label l:
                        l.Font = f8;
                        l.ForeColor = fColGrey;
                        break;
                    case ListBox lb:
                        lb.Font = f10;
                        lb.ForeColor = fColWhite;
                        lb.BackColor = backTwo;
                        lb.BorderStyle = BorderStyle.None;
                        break;
                    case Button b:
                        b.Font = f10;
                        b.ForeColor = Color.White;
                        b.BackColor = btnColBlue;
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderSize = 0;
                        b.TextAlign = ContentAlignment.MiddleCenter;
                        break;
                    case ComboBox cb:
                        cb.Font = f10;
                        cb.ForeColor = fColWhite;
                        cb.BackColor = backTwo;
                        cb.FlatStyle = FlatStyle.Flat;
                        break;
                    case TextBox tb:
                        tb.Font = f10;
                        tb.ForeColor = fColWhite;
                        tb.BackColor = backTwo;
                        tb.BorderStyle = BorderStyle.FixedSingle;
                        break;
                    case NumericUpDown nud:
                        nud.Font = f10;
                        nud.ForeColor = fColWhite;
                        nud.BackColor = backTwo;
                        nud.BorderStyle = BorderStyle.FixedSingle;
                        
                        break;
                    case TreeView tv:
                        tv.Font = f10;
                        tv.ForeColor = fColWhite;
                        tv.BackColor = backTwo;
                        break;
                    case RadioButton rb:
                        rb.Font = f10;
                        rb.ForeColor = fColWhite;
                        break;

                }



            }
        }
    }
}
