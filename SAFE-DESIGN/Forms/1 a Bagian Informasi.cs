using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAFE_DESIGN.Forms
{
    public partial class _1_a_Bagian_Informasi : Form
    {
        public _1_a_Bagian_Informasi()
        { InitializeComponent(); }

        private void button_close_Click(object sender, EventArgs e)
        { this.Close(); }

        private void button_minimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

        public void informasi()
        {
            
        }
    }
}
