﻿namespace proyectoFinal.presentacion
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menu2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuVertical.SuspendLayout();
            this.menu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuVertical.Controls.Add(this.button3);
            this.menuVertical.Controls.Add(this.button2);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(263, 661);
            this.menuVertical.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.Red;
            this.menu2.Controls.Add(this.pictureBox1);
            this.menu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu2.Location = new System.Drawing.Point(263, 0);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(831, 58);
            this.menu2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(263, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 603);
            this.panel1.TabIndex = 2;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "principal";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuVertical.ResumeLayout(false);
            this.menu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuVertical;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel menu2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}