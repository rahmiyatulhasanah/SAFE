
namespace SAFE
{
    partial class Em_Cond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Em_Cond));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearchCond = new System.Windows.Forms.TextBox();
            this.lblcond = new System.Windows.Forms.Label();
            this.lblcause = new System.Windows.Forms.Label();
            this.lblsymp = new System.Windows.Forms.Label();
            this.lbltreat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.lbltreat);
            this.panel1.Controls.Add(this.lblsymp);
            this.panel1.Controls.Add(this.lblcause);
            this.panel1.Controls.Add(this.lblcond);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbSearchCond);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(298, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 414);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueLT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Penyebab :";
            this.label3.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelveticaNeueLT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Penanganan :";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.lbltreat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueLT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gejala :";
            this.label4.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kondisi :";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Condition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSearchCond
            // 
            this.tbSearchCond.Location = new System.Drawing.Point(35, 28);
            this.tbSearchCond.Name = "tbSearchCond";
            this.tbSearchCond.Size = new System.Drawing.Size(247, 23);
            this.tbSearchCond.TabIndex = 0;
            this.tbSearchCond.UseWaitCursor = true;
            // 
            // lblcond
            // 
            this.lblcond.AutoSize = true;
            this.lblcond.Font = new System.Drawing.Font("HelveticaNeueLT Std Med", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcond.Location = new System.Drawing.Point(90, 99);
            this.lblcond.Name = "lblcond";
            this.lblcond.Size = new System.Drawing.Size(12, 14);
            this.lblcond.TabIndex = 6;
            this.lblcond.Text = "-";
            // 
            // lblcause
            // 
            this.lblcause.AutoSize = true;
            this.lblcause.Font = new System.Drawing.Font("HelveticaNeueLT Std Med", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcause.Location = new System.Drawing.Point(17, 137);
            this.lblcause.Name = "lblcause";
            this.lblcause.Size = new System.Drawing.Size(12, 14);
            this.lblcause.TabIndex = 7;
            this.lblcause.Text = "-";
            // 
            // lblsymp
            // 
            this.lblsymp.AutoSize = true;
            this.lblsymp.Font = new System.Drawing.Font("HelveticaNeueLT Std Med", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsymp.Location = new System.Drawing.Point(17, 199);
            this.lblsymp.Name = "lblsymp";
            this.lblsymp.Size = new System.Drawing.Size(12, 14);
            this.lblsymp.TabIndex = 8;
            this.lblsymp.Text = "-";
            // 
            // lbltreat
            // 
            this.lbltreat.AutoSize = true;
            this.lbltreat.Font = new System.Drawing.Font("HelveticaNeueLT Std Med", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltreat.Location = new System.Drawing.Point(17, 264);
            this.lbltreat.Name = "lbltreat";
            this.lbltreat.Size = new System.Drawing.Size(12, 14);
            this.lbltreat.TabIndex = 9;
            this.lbltreat.Text = "-";
            // 
            // Em_Cond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 414);
            this.Controls.Add(this.panel1);
            this.Name = "Em_Cond";
            this.Text = "How Can We Help You?";
            this.UseWaitCursor = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearchCond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcond;
        private System.Windows.Forms.Label lbltreat;
        private System.Windows.Forms.Label lblsymp;
        private System.Windows.Forms.Label lblcause;
    }
}