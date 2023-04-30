namespace Kursovaya
{
    partial class InfoAboutStudentContracts
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
            this.requests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateFromBox = new System.Windows.Forms.DateTimePicker();
            this.getExcel = new System.Windows.Forms.Button();
            this.createDiagram = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requests)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // requests
            // 
            this.requests.BackgroundColor = System.Drawing.Color.White;
            this.requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requests.Location = new System.Drawing.Point(13, 179);
            this.requests.Margin = new System.Windows.Forms.Padding(4);
            this.requests.Name = "requests";
            this.requests.RowHeadersWidth = 51;
            this.requests.Size = new System.Drawing.Size(723, 328);
            this.requests.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выберите период для просмотра оформленных ученических договоров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "с";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(281, 122);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 22);
            this.dateTo.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(639, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 30;
            this.button1.Text = "Получить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateFromBox
            // 
            this.dateFromBox.Location = new System.Drawing.Point(46, 122);
            this.dateFromBox.Name = "dateFromBox";
            this.dateFromBox.Size = new System.Drawing.Size(200, 22);
            this.dateFromBox.TabIndex = 33;
            // 
            // getExcel
            // 
            this.getExcel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.getExcel.Location = new System.Drawing.Point(751, 613);
            this.getExcel.Name = "getExcel";
            this.getExcel.Size = new System.Drawing.Size(180, 50);
            this.getExcel.TabIndex = 34;
            this.getExcel.Text = "Получить excel файл";
            this.getExcel.UseVisualStyleBackColor = false;
            this.getExcel.Click += new System.EventHandler(this.getExcel_Click);
            // 
            // createDiagram
            // 
            this.createDiagram.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.createDiagram.Location = new System.Drawing.Point(966, 613);
            this.createDiagram.Name = "createDiagram";
            this.createDiagram.Size = new System.Drawing.Size(191, 50);
            this.createDiagram.TabIndex = 35;
            this.createDiagram.Text = "Построить диаграмму";
            this.createDiagram.UseVisualStyleBackColor = false;
            this.createDiagram.Click += new System.EventHandler(this.createDiagram_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 85);
            this.panel1.TabIndex = 36;
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
            this.label5.Size = new System.Drawing.Size(1193, 85);
            this.label5.TabIndex = 1;
            this.label5.Text = "Получение информации об ученисеских договорах";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(1135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 29);
            this.panel2.TabIndex = 7;
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
            // InfoAboutStudentContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createDiagram);
            this.Controls.Add(this.getExcel);
            this.Controls.Add(this.dateFromBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoAboutStudentContracts";
            this.Text = "InfoAboutStudentContracts";
            this.Load += new System.EventHandler(this.InfoAboutStudentContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateFromBox;
        private System.Windows.Forms.Button getExcel;
        private System.Windows.Forms.Button createDiagram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
    }
}