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
            EditData edit = new EditData();
            edit.Show();
        }
    }
}
