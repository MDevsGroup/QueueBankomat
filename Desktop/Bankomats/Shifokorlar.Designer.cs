﻿namespace Desktop.Bankomats
{
    partial class Shifokorlar
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
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            level = new Label();
            Ism = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            count = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(level);
            guna2Panel1.Controls.Add(Ism);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(5, 5);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(498, 58);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.Click += guna2Panel1_Click;
            // 
            // level
            // 
            level.AutoSize = true;
            level.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            level.Location = new Point(179, 35);
            level.Name = "level";
            level.Size = new Size(47, 21);
            level.TabIndex = 3;
            level.Text = "kasbi";
            level.Click += guna2Panel1_Click;
            // 
            // Ism
            // 
            Ism.AutoSize = true;
            Ism.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ism.Location = new Point(163, 7);
            Ism.Name = "Ism";
            Ism.Size = new Size(117, 25);
            Ism.TabIndex = 2;
            Ism.Text = "Ism familiya";
            Ism.Click += guna2Panel1_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(count);
            guna2Panel2.Controls.Add(guna2HtmlLabel1);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.FillColor = Color.PaleGreen;
            guna2Panel2.Location = new Point(503, 5);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(236, 58);
            guna2Panel2.TabIndex = 1;
            guna2Panel2.Click += guna2Panel1_Click;
            // 
            // count
            // 
            count.AutoSize = true;
            count.BackColor = Color.Transparent;
            count.Location = new Point(100, 32);
            count.Name = "count";
            count.Size = new Size(38, 15);
            count.TabIndex = 1;
            count.Text = "label1";
            count.Click += guna2Panel1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(78, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(80, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Kutmoqda";
            guna2HtmlLabel1.Click += guna2Panel1_Click;
            // 
            // Shifokorlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Name = "Shifokorlar";
            Padding = new Padding(20);
            Size = new Size(744, 68);
            Load += Shifokorlar_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label level;
        private Label Ism;
        private Guna.UI2.WinForms.Guna2Button countBtn;
        private Label count;
    }
}
