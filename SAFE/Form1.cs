using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFE_DESIGN
{
    public partial class Form1 : Form
    {
        public Button currentButton;
        public Form activeForm;
        private PictureBox currentPicB;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        { this.Close(); }

        private void button_minimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

        
        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender )
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, 
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        public void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        public void OpenChildForm (Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } 

        #region Button
        private void btn_home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms._1_home(), sender);

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms._2_profile(), sender);
        }

        private void btn_emcalls_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms._3_Emergency_Calls(), sender);
        }

        private void SAFE_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frontSafe(), sender);
        }
        #endregion
    }
}
