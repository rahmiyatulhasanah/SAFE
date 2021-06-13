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

        public Label lblkon;
        public _1_home()
        {
            InitializeComponent();
            lblkon = lblmudah;
        }

        public void showForms()
        {
            _1_a_Bagian_Informasi form = new _1_a_Bagian_Informasi(lblmudah.Text);
            form.Show();
        }
        private void btn_jantung_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Serangan jantung";
            showForms();
        }

        private void btn_asma_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Asma";
            showForms();
        }

        private void btn_keracunan_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Keracunan";
            showForms();
        }

        private void btn_mimisan_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Mimisan";
            showForms();
        }

        private void btn_keseleo_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Keseleo";
            showForms();
        }

        private void btn_tulang_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Patah tulang";
            showForms();
        }

        private void btn_luka_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Luka";
            showForms();
        }

        private void btn_tenggelam_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Tenggelam";
            showForms();
        }

        private void btn_bakar_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Luka bakar";
            showForms();
        }

        private void btn_lecet_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Luka lecet";
            showForms();
        }

        private void btn_tersedak_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Tersedak";
            showForms();
        }

        private void btn_kejang_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Kejang/Epilepsi";
            showForms();
        }

        private void btn_stroke_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Stroke";
            showForms();
        }

        private void btn_muntah_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Muntah";
            showForms();
        }

        private void btn_shock_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Syok";
            showForms();
        }

        private void btn_sengatan_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Sengatan/gigitan";
            showForms();
        }

        private void btn_pingsan_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Pingsan";
            showForms();
        }

        private void btn_hipotermia_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Hipotermia";
            showForms();
        }

        private void btn_panas_Click(object sender, EventArgs e)
        {
            lblmudah.Text = "Sengatan panas";
            showForms();
        }
    }
}
