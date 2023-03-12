namespace Kursovaya
{
    partial class AddInfo
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
            this.boxStations = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxRoads = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.hours = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minutes);
            this.panel1.Controls.Add(this.hours);
            this.panel1.Controls.Add(this.boxRoads);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.boxStations);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 341);
            this.panel1.TabIndex = 19;
            // 
            // boxStations
            // 
            this.boxStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boxStations.FormattingEnabled = true;
            this.boxStations.Location = new System.Drawing.Point(67, 108);
            this.boxStations.Name = "boxStations";
            this.boxStations.Size = new System.Drawing.Size(138, 21);
            this.boxStations.TabIndex = 21;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(67, 305);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(138, 23);
            this.delete.TabIndex = 20;
            this.delete.Text = "Добавить информацию";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 60);
            this.label1.TabIndex = 18;
            this.label1.Text = "Добавление станции";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(278, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(12, 13);
            this.close.TabIndex = 17;
            this.close.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Выерите станцию";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(81, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Выберите маршрут";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxRoads
            // 
            this.boxRoads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boxRoads.FormattingEnabled = true;
            this.boxRoads.Items.AddRange(new object[] {
            "6800",
            "6902",
            "6380",
            "6802",
            "6806",
            "6222",
            "Экспресс \"Рэкс\""});
            this.boxRoads.Location = new System.Drawing.Point(67, 171);
            this.boxRoads.Name = "boxRoads";
            this.boxRoads.Size = new System.Drawing.Size(138, 21);
            this.boxRoads.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Время остановки на этой станции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(211, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "мин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "ч";
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(156, 248);
            this.minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(49, 20);
            this.minutes.TabIndex = 27;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(75, 248);
            this.hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(49, 20);
            this.hours.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Location = new System.Drawing.Point(278, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "x";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 341);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddInfo";
            this.Text = "AddInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox boxStations;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxRoads;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.NumericUpDown hours;
        private System.Windows.Forms.Label label7;
    }
}