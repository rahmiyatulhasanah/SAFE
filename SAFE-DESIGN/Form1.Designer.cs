
namespace SAFE_DESIGN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_emcalls = new System.Windows.Forms.Button();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_minimize
            // 
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Image = global::SAFE_DESIGN.Properties.Resources.minimize_button;
            this.button_minimize.Location = new System.Drawing.Point(661, 13);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(23, 21);
            this.button_minimize.TabIndex = 3;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_close
            // 
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Image = global::SAFE_DESIGN.Properties.Resources.close_button;
            this.button_close.Location = new System.Drawing.Point(690, 13);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(23, 21);
            this.button_close.TabIndex = 4;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_home.Location = new System.Drawing.Point(19, 13);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(69, 28);
            this.btn_home.TabIndex = 5;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_profile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_profile.Location = new System.Drawing.Point(124, 13);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(69, 28);
            this.btn_profile.TabIndex = 6;
            this.btn_profile.Text = "Profile";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_emcalls
            // 
            this.btn_emcalls.FlatAppearance.BorderSize = 0;
            this.btn_emcalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emcalls.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_emcalls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_emcalls.Location = new System.Drawing.Point(218, 13);
            this.btn_emcalls.Name = "btn_emcalls";
            this.btn_emcalls.Size = new System.Drawing.Size(151, 28);
            this.btn_emcalls.TabIndex = 7;
            this.btn_emcalls.Text = "Emergency Calls";
            this.btn_emcalls.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_emcalls.UseVisualStyleBackColor = true;
            this.btn_emcalls.Click += new System.EventHandler(this.btn_emcalls_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 67);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(727, 461);
            this.panelDesktopPanel.TabIndex = 8;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btn_home);
            this.panelMenu.Controls.Add(this.btn_profile);
            this.panelMenu.Controls.Add(this.button_close);
            this.panelMenu.Controls.Add(this.button_minimize);
            this.panelMenu.Controls.Add(this.btn_emcalls);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(727, 48);
            this.panelMenu.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(727, 528);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktopPanel);
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_emcalls;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panelMenu;
    }
}

