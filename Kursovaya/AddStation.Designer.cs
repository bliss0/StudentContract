namespace Kursovaya
{
    partial class AddStation
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
            this.registrChange = new System.Windows.Forms.Label();
            this.labelPasswordAuth = new System.Windows.Forms.Label();
            this.labelLoginAuth = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.passfiend = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.road = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.hours = new System.Windows.Forms.NumericUpDown();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.station = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).BeginInit();
            this.SuspendLayout();
            // 
            // registrChange
            // 
            this.registrChange.AutoSize = true;
            this.registrChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrChange.ForeColor = System.Drawing.Color.White;
            this.registrChange.Location = new System.Drawing.Point(80, 346);
            this.registrChange.Name = "registrChange";
            this.registrChange.Size = new System.Drawing.Size(131, 13);
            this.registrChange.TabIndex = 14;
            this.registrChange.Text = "Зарегистрироваться";
            // 
            // labelPasswordAuth
            // 
            this.labelPasswordAuth.AutoSize = true;
            this.labelPasswordAuth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPasswordAuth.Location = new System.Drawing.Point(17, 240);
            this.labelPasswordAuth.Name = "labelPasswordAuth";
            this.labelPasswordAuth.Size = new System.Drawing.Size(45, 13);
            this.labelPasswordAuth.TabIndex = 13;
            this.labelPasswordAuth.Text = "Пароль";
            this.labelPasswordAuth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLoginAuth
            // 
            this.labelLoginAuth.AutoSize = true;
            this.labelLoginAuth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLoginAuth.Location = new System.Drawing.Point(24, 212);
            this.labelLoginAuth.Name = "labelLoginAuth";
            this.labelLoginAuth.Size = new System.Drawing.Size(38, 13);
            this.labelLoginAuth.TabIndex = 12;
            this.labelLoginAuth.Text = "Логин";
            this.labelLoginAuth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonlogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.ForeColor = System.Drawing.Color.Black;
            this.buttonlogin.Location = new System.Drawing.Point(77, 286);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(138, 36);
            this.buttonlogin.TabIndex = 11;
            this.buttonlogin.Text = "Войти";
            this.buttonlogin.UseVisualStyleBackColor = false;
            // 
            // passfiend
            // 
            this.passfiend.Location = new System.Drawing.Point(68, 237);
            this.passfiend.Name = "passfiend";
            this.passfiend.Size = new System.Drawing.Size(156, 20);
            this.passfiend.TabIndex = 10;
            this.passfiend.UseSystemPasswordChar = true;
            // 
            // loginfield
            // 
            this.loginfield.Location = new System.Drawing.Point(68, 209);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(156, 20);
            this.loginfield.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 61);
            this.panel2.TabIndex = 8;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(268, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(12, 13);
            this.close.TabIndex = 1;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление станции";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.road);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minutes);
            this.panel1.Controls.Add(this.hours);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.station);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 280);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите маршрут";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // road
            // 
            this.road.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.road.FormattingEnabled = true;
            this.road.Items.AddRange(new object[] {
            "6800",
            "6902",
            "6380",
            "6802",
            "6806",
            "6222",
            "Экспресс \"Рэкс\""});
            this.road.Location = new System.Drawing.Point(74, 98);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(121, 21);
            this.road.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время остановки на этой станции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(204, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "мин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ч";
            // 
            // minutes
            // 
            this.minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.minutes.Location = new System.Drawing.Point(149, 164);
            this.minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(49, 20);
            this.minutes.TabIndex = 6;
            // 
            // hours
            // 
            this.hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hours.Location = new System.Drawing.Point(68, 164);
            this.hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(49, 20);
            this.hours.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(74, 238);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(138, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить станцию";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите название станции";
            // 
            // station
            // 
            this.station.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.station.Location = new System.Drawing.Point(68, 45);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(147, 20);
            this.station.TabIndex = 2;
            // 
            // AddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registrChange);
            this.Controls.Add(this.labelPasswordAuth);
            this.Controls.Add(this.labelLoginAuth);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.passfiend);
            this.Controls.Add(this.loginfield);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStation";
            this.Text = "AddStation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrChange;
        private System.Windows.Forms.Label labelPasswordAuth;
        private System.Windows.Forms.Label labelLoginAuth;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox passfiend;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox station;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.NumericUpDown hours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox road;
    }
}