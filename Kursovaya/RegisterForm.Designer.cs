namespace Kursovaya
{
    partial class RegisterForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.lalebLogin = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.buttonregister = new System.Windows.Forms.Button();
            this.passwordFiend = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lalebLogin);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.userSurnameField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.buttonregister);
            this.panel1.Controls.Add(this.passwordFiend);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 321);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(45, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lalebLogin
            // 
            this.lalebLogin.AutoSize = true;
            this.lalebLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lalebLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lalebLogin.Location = new System.Drawing.Point(52, 168);
            this.lalebLogin.Name = "lalebLogin";
            this.lalebLogin.Size = new System.Drawing.Size(38, 13);
            this.lalebLogin.TabIndex = 8;
            this.lalebLogin.Text = "Логин";
            this.lalebLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelSurname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSurname.Location = new System.Drawing.Point(34, 142);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "Фамилия";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(61, 116);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userSurnameField
            // 
            this.userSurnameField.Location = new System.Drawing.Point(96, 139);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(156, 20);
            this.userSurnameField.TabIndex = 5;
            this.userSurnameField.UseSystemPasswordChar = true;
            // 
            // userNameField
            // 
            this.userNameField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.userNameField.Location = new System.Drawing.Point(96, 113);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(156, 20);
            this.userNameField.TabIndex = 4;
            this.userNameField.UseSystemPasswordChar = true;
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonregister.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.buttonregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonregister.Location = new System.Drawing.Point(64, 252);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(215, 32);
            this.buttonregister.TabIndex = 3;
            this.buttonregister.Text = "Зарегистрироваться";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // passwordFiend
            // 
            this.passwordFiend.Location = new System.Drawing.Point(96, 191);
            this.passwordFiend.Name = "passwordFiend";
            this.passwordFiend.Size = new System.Drawing.Size(156, 20);
            this.passwordFiend.TabIndex = 2;
            this.passwordFiend.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(96, 165);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(156, 20);
            this.loginField.TabIndex = 1;
            this.loginField.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 61);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(311, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "<-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(329, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(12, 13);
            this.close.TabIndex = 1;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.TextBox passwordFiend;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lalebLogin;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label label2;
    }
}