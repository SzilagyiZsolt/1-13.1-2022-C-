namespace Első_Forms
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.btnSzamolj = new System.Windows.Forms.Button();
            this.btnkilép = new System.Windows.Forms.Button();
            this.Szorzó = new System.Windows.Forms.NumericUpDown();
            this.Osztó = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Eredmeny = new System.Windows.Forms.Label();
            this.Szam = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Szorzó)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Osztó)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szam)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_text.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_text.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_text.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_text.Location = new System.Drawing.Point(386, 97);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(86, 24);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.Text = "Számoló";
            this.lbl_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSzamolj
            // 
            this.btnSzamolj.Location = new System.Drawing.Point(504, 147);
            this.btnSzamolj.Name = "btnSzamolj";
            this.btnSzamolj.Size = new System.Drawing.Size(75, 23);
            this.btnSzamolj.TabIndex = 1;
            this.btnSzamolj.Text = "Számolj!";
            this.btnSzamolj.UseVisualStyleBackColor = true;
            this.btnSzamolj.Click += new System.EventHandler(this.btnSzamolj_Click);
            // 
            // btnkilép
            // 
            this.btnkilép.Location = new System.Drawing.Point(278, 147);
            this.btnkilép.Name = "btnkilép";
            this.btnkilép.Size = new System.Drawing.Size(75, 23);
            this.btnkilép.TabIndex = 2;
            this.btnkilép.Text = "Kilép";
            this.btnkilép.UseVisualStyleBackColor = true;
            this.btnkilép.Click += new System.EventHandler(this.btnkilép_Click);
            // 
            // Szorzó
            // 
            this.Szorzó.Location = new System.Drawing.Point(278, 222);
            this.Szorzó.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Szorzó.Name = "Szorzó";
            this.Szorzó.Size = new System.Drawing.Size(120, 23);
            this.Szorzó.TabIndex = 3;
            // 
            // Osztó
            // 
            this.Osztó.Location = new System.Drawing.Point(459, 222);
            this.Osztó.Name = "Osztó";
            this.Osztó.Size = new System.Drawing.Size(120, 23);
            this.Osztó.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Osztó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szorzó";
            // 
            // Eredmeny
            // 
            this.Eredmeny.Location = new System.Drawing.Point(372, 291);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(123, 15);
            this.Eredmeny.TabIndex = 8;
            this.Eredmeny.Text = " ";
            // 
            // Szam
            // 
            this.Szam.Location = new System.Drawing.Point(362, 309);
            this.Szam.Name = "Szam";
            this.Szam.Size = new System.Drawing.Size(120, 23);
            this.Szam.TabIndex = 9;
            this.Szam.Click += new System.EventHandler(this.Szam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 551);
            this.Controls.Add(this.Szam);
            this.Controls.Add(this.Eredmeny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Osztó);
            this.Controls.Add(this.Szorzó);
            this.Controls.Add(this.btnkilép);
            this.Controls.Add(this.btnSzamolj);
            this.Controls.Add(this.lbl_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Szorzó)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Osztó)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_text;
        private Button btnSzamolj;
        private Button btnkilép;
        private NumericUpDown Szorzó;
        private NumericUpDown Osztó;
        private Label label3;
        private Label label2;
        private Label Eredmeny;
        private NumericUpDown Szam;
    }
}