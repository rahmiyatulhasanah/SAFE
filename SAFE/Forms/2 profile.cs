using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAFE_DESIGN.Forms
{
    public partial class _2_profile : Form
    {
        public _2_profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditData form = new EditData();
            form.Show();
            savedata();
        }
        private void savedata()
        {
            textBox2.Text = EditData.setvaluetext1;
            textBox3.Text = EditData.setvaluetext2;
            textBox1.Text = EditData.goldar;
            richTextBox1.Text = EditData.setvaluetext3;
            richTextBox2.Text = EditData.setvaluetext4;
        }
    }
}
