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
            this.button1 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteStation = new System.Windows.Forms.Button();
            this.addStation = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPasswordAuth
            // 
            this.labelPasswordAuth.AutoSize = true;
            this.labelPasswordAuth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPasswordAuth.Location = new System.Drawing.Point(17, 259);
            this.labelPasswordAuth.Name = "labelPasswordAuth";
            this.labelPasswordAuth.Size = new System.Drawing.Size(45, 13);
            this.labelPasswordAuth.TabIndex = 11;
            this.labelPasswordAuth.Text = "Пароль";
            this.labelPasswordAuth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLoginAuth
            // 
            this.labelLoginAuth.AutoSize = true;
            this.labelLoginAuth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLoginAuth.Location = new System.Drawing.Point(24, 231);
            this.labelLoginAuth.Name = "labelLoginAuth";
            this.labelLoginAuth.Size = new System.Drawing.Size(38, 13);
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
            this.buttonlogin.Location = new System.Drawing.Point(77, 305);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(138, 36);
            this.buttonlogin.TabIndex = 9;
            this.buttonlogin.Text = "Войти";
            this.buttonlogin.UseVisualStyleBackColor = false;
            // 
            // passfiend
            // 
            this.passfiend.Location = new System.Drawing.Point(68, 256);
            this.passfiend.Name = "passfiend";
            this.passfiend.Size = new System.Drawing.Size(156, 20);
            this.passfiend.TabIndex = 8;
            this.passfiend.UseSystemPasswordChar = true;
            // 
            // loginfield
            // 
            this.loginfield.Location = new System.Drawing.Point(68, 228);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(156, 20);
            this.loginfield.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.deleteStation);
            this.panel1.Controls.Add(this.addStation);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 450);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить время маршрута";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(676, 172);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 23);
            this.update.TabIndex = 4;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 371);
            this.dataGridView1.TabIndex = 3;
            // 
            // deleteStation
            // 
            this.deleteStation.Location = new System.Drawing.Point(676, 201);
            this.deleteStation.Name = "deleteStation";
            this.deleteStation.Size = new System.Drawing.Size(112, 23);
            this.deleteStation.TabIndex = 2;
            this.deleteStation.Text = "Удалить станцию";
            this.deleteStation.UseVisualStyleBackColor = true;
            this.deleteStation.Click += new System.EventHandler(this.deleteStation_Click);
            // 
            // addStation
            // 
            this.addStation.Location = new System.Drawing.Point(676, 85);
            this.addStation.Name = "addStation";
            this.addStation.Size = new System.Drawing.Size(112, 23);
            this.addStation.TabIndex = 1;
            this.addStation.Text = "Добавить станцию";
            this.addStation.UseVisualStyleBackColor = true;
            this.addStation.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 61);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(789, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(801, 61);
            this.label5.TabIndex = 0;
            this.label5.Text = "Расписание";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPasswordAuth);
            this.Controls.Add(this.labelLoginAuth);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.passfiend);
            this.Controls.Add(this.loginfield);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addStation;
        private System.Windows.Forms.Button deleteStation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
    }
}