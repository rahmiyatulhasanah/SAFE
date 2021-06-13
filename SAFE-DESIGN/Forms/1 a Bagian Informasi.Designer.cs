
namespace SAFE_DESIGN.Forms
{
    partial class _1_a_Bagian_Informasi
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
            this.tb_penanganan = new System.Windows.Forms.RichTextBox();
            this.tb_gejala = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_kondisi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kondisi)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_penanganan
            // 
            this.tb_penanganan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_penanganan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tb_penanganan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_penanganan.ForeColor = System.Drawing.Color.White;
            this.tb_penanganan.Location = new System.Drawing.Point(363, 147);
            this.tb_penanganan.Name = "tb_penanganan";
            this.tb_penanganan.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_penanganan.Size = new System.Drawing.Size(261, 271);
            this.tb_penanganan.TabIndex = 9;
            this.tb_penanganan.Text = "";
            // 
            // tb_gejala
            // 
            this.tb_gejala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_gejala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tb_gejala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_gejala.ForeColor = System.Drawing.Color.White;
            this.tb_gejala.Location = new System.Drawing.Point(34, 147);
            this.tb_gejala.Name = "tb_gejala";
            this.tb_gejala.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_gejala.Size = new System.Drawing.Size(273, 271);
            this.tb_gejala.TabIndex = 7;
            this.tb_gejala.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(444, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Penanganan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gejala";
            // 
            // pb_kondisi
            // 
            this.pb_kondisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_kondisi.Location = new System.Drawing.Point(255, 12);
            this.pb_kondisi.Name = "pb_kondisi";
            this.pb_kondisi.Size = new System.Drawing.Size(140, 98);
            this.pb_kondisi.TabIndex = 12;
            this.pb_kondisi.TabStop = false;
            // 
            // _1_a_Bagian_Informasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(650, 449);
            this.Controls.Add(this.pb_kondisi);
            this.Controls.Add(this.tb_penanganan);
            this.Controls.Add(this.tb_gejala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_1_a_Bagian_Informasi";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            ((System.ComponentModel.ISupportInitialize)(this.pb_kondisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_penanganan;
        private System.Windows.Forms.RichTextBox tb_gejala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_kondisi;
    }
}