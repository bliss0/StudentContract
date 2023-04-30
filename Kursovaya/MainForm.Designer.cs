namespace Kursovaya
{
    partial class MainForm
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
            this.labelPasswordAuth = new System.Windows.Forms.Label();
            this.labelLoginAuth = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.passfiend = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.getContracts = new System.Windows.Forms.Button();
            this.formContract = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPasswordAuth
            // 
            this.labelPasswordAuth.AutoSize = true;
            this.labelPasswordAuth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPasswordAuth.Location = new System.Drawing.Point(23, 319);
            this.labelPasswordAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordAuth.Name = "labelPasswordAuth";
            this.labelPasswordAuth.Size = new System.Drawing.Size(56, 16);
            this.labelPasswordAuth.TabIndex = 11;
            this.labelPasswordAuth.Text = "Пароль";
            this.labelPasswordAuth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLoginAuth
            // 
            this.labelLoginAuth.AutoSize = true;
            this.labelLoginAuth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLoginAuth.Location = new System.Drawing.Point(32, 284);
            this.labelLoginAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginAuth.Name = "labelLoginAuth";
            this.labelLoginAuth.Size = new System.Drawing.Size(46, 16);
            this.labelLoginAuth.TabIndex = 10;
            this.labelLoginAuth.Text = "Логин";
            this.labelLoginAuth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonlogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.ForeColor = System.Drawing.Color.Black;
            this.buttonlogin.Location = new System.Drawing.Point(103, 375);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(184, 44);
            this.buttonlogin.TabIndex = 9;
            this.buttonlogin.Text = "Войти";
            this.buttonlogin.UseVisualStyleBackColor = false;
            // 
            // passfiend
            // 
            this.passfiend.Location = new System.Drawing.Point(91, 315);
            this.passfiend.Margin = new System.Windows.Forms.Padding(4);
            this.passfiend.Name = "passfiend";
            this.passfiend.Size = new System.Drawing.Size(207, 22);
            this.passfiend.TabIndex = 8;
            this.passfiend.UseSystemPasswordChar = true;
            // 
            // loginfield
            // 
            this.loginfield.Location = new System.Drawing.Point(91, 281);
            this.loginfield.Margin = new System.Windows.Forms.Padding(4);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(207, 22);
            this.loginfield.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.getContracts);
            this.panel1.Controls.Add(this.formContract);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 554);
            this.panel1.TabIndex = 12;
            // 
            // getContracts
            // 
            this.getContracts.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.getContracts.Location = new System.Drawing.Point(579, 236);
            this.getContracts.Name = "getContracts";
            this.getContracts.Size = new System.Drawing.Size(411, 113);
            this.getContracts.TabIndex = 5;
            this.getContracts.Text = "Получение информации об ученических договорах";
            this.getContracts.UseVisualStyleBackColor = false;
            this.getContracts.Click += new System.EventHandler(this.getContracts_Click);
            // 
            // formContract
            // 
            this.formContract.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.formContract.Location = new System.Drawing.Point(85, 236);
            this.formContract.Name = "formContract";
            this.formContract.Size = new System.Drawing.Size(411, 113);
            this.formContract.TabIndex = 4;
            this.formContract.Text = "Формирование договора";
            this.formContract.UseVisualStyleBackColor = false;
            this.formContract.Click += new System.EventHandler(this.formContract_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 75);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1068, 75);
            this.label5.TabIndex = 0;
            this.label5.Text = "Личный кабинет";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(1010, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 29);
            this.panel2.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 29);
            this.label17.TabIndex = 5;
            this.label17.Text = "X";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPasswordAuth);
            this.Controls.Add(this.labelLoginAuth);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.passfiend);
            this.Controls.Add(this.loginfield);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPasswordAuth;
        private System.Windows.Forms.Label labelLoginAuth;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox passfiend;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button formContract;
        private System.Windows.Forms.Button getContracts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
    }
}