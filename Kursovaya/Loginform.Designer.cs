﻿namespace Kursovaya
{
    partial class Loginform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registrChange = new System.Windows.Forms.Label();
            this.labelPasswordAuth = new System.Windows.Forms.Label();
            this.labelLoginAuth = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.passfiend = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.registrChange);
            this.panel1.Controls.Add(this.labelPasswordAuth);
            this.panel1.Controls.Add(this.labelLoginAuth);
            this.panel1.Controls.Add(this.buttonlogin);
            this.panel1.Controls.Add(this.passfiend);
            this.panel1.Controls.Add(this.loginfield);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 358);
            this.panel1.TabIndex = 0;
            // 
            // registrChange
            // 
            this.registrChange.AutoSize = true;
            this.registrChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrChange.ForeColor = System.Drawing.Color.Black;
            this.registrChange.Location = new System.Drawing.Point(107, 314);
            this.registrChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrChange.Name = "registrChange";
            this.registrChange.Size = new System.Drawing.Size(162, 17);
            this.registrChange.TabIndex = 7;
            this.registrChange.Text = "Зарегистрироваться";
            this.registrChange.Click += new System.EventHandler(this.registrChange_Click);
            // 
            // labelPasswordAuth
            // 
            this.labelPasswordAuth.AutoSize = true;
            this.labelPasswordAuth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPasswordAuth.Location = new System.Drawing.Point(23, 183);
            this.labelPasswordAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordAuth.Name = "labelPasswordAuth";
            this.labelPasswordAuth.Size = new System.Drawing.Size(56, 16);
            this.labelPasswordAuth.TabIndex = 5;
            this.labelPasswordAuth.Text = "Пароль";
            this.labelPasswordAuth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLoginAuth
            // 
            this.labelLoginAuth.AutoSize = true;
            this.labelLoginAuth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoginAuth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLoginAuth.Location = new System.Drawing.Point(32, 149);
            this.labelLoginAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginAuth.Name = "labelLoginAuth";
            this.labelLoginAuth.Size = new System.Drawing.Size(46, 16);
            this.labelLoginAuth.TabIndex = 4;
            this.labelLoginAuth.Text = "Логин";
            this.labelLoginAuth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonlogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.ForeColor = System.Drawing.Color.Black;
            this.buttonlogin.Location = new System.Drawing.Point(91, 245);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(207, 44);
            this.buttonlogin.TabIndex = 3;
            this.buttonlogin.Text = "Войти";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.output_Click);
            // 
            // passfiend
            // 
            this.passfiend.Location = new System.Drawing.Point(91, 180);
            this.passfiend.Margin = new System.Windows.Forms.Padding(4);
            this.passfiend.Name = "passfiend";
            this.passfiend.Size = new System.Drawing.Size(207, 22);
            this.passfiend.TabIndex = 2;
            this.passfiend.UseSystemPasswordChar = true;
            // 
            // loginfield
            // 
            this.loginfield.Location = new System.Drawing.Point(91, 145);
            this.loginfield.Margin = new System.Windows.Forms.Padding(4);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(207, 22);
            this.loginfield.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 75);
            this.panel2.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(364, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(13, 16);
            this.close.TabIndex = 1;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 358);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loginform";
            this.Text = "Loginform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox passfiend;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.Label labelPasswordAuth;
        private System.Windows.Forms.Label labelLoginAuth;
        private System.Windows.Forms.Label registrChange;
    }
}