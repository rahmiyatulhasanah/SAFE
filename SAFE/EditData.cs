using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAFE_DESIGN
{
    public partial class EditData : Form
    {
        public static string setvaluetext1;
        public static string setvaluetext2;
        public static string setvaluetext3;
        public static string setvaluetext4;
        public static string goldar;
        public EditData()
        {
            InitializeComponent();
        }

        public void btn_ok_Click(object sender, EventArgs e)
        {
            setvaluetext1 = textBox1.Text;
            setvaluetext2 = textBox2.Text.ToString();
            setvaluetext3 = richTextBox1.Text;
            setvaluetext4 = richTextBox2.Text;
            if (radioButton1.Checked)
            {
                goldar = "A";
            }
            else if (radioButton2.Checked)
            {
                goldar = "B";
            }
            else if (radioButton3.Checked)
            {
                goldar = "AB";
            }
            else
            {
                goldar = "O";            
            }
            Close();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        { this.Close(); }

        private void button_minimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

        private void button_close_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
