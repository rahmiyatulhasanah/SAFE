using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAFE_DESIGN.Forms
{
    public partial class _1_home : Form
    {
        public Button currentButton;
        public Form activeForm;

        public _1_home()
        {
            InitializeComponent();
        }

        public void informations()
        {

        }

        public void showForms()
        {
            Form form = new Forms._1_a_Bagian_Informasi();
            form.Show();
        }
        private void btn_jantung_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_asma_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_keracunan_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_mimisan_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_keseleo_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_tulang_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_luka_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_tenggelam_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_bakar_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_lecet_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_tersedak_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_kejang_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_stroke_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_muntah_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_shock_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_sengatan_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_pingsan_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_hipotermia_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btn_panas_Click(object sender, EventArgs e)
        {
            showForms();
        }
    }
}
