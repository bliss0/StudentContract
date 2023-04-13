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
            ((System.ComponentModel.ISupportInitialize)(this.requests)).BeginInit();
            this.SuspendLayout();
            // 
            // requests
            // 
            this.requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requests.Location = new System.Drawing.Point(24, 102);
            this.requests.Margin = new System.Windows.Forms.Padding(4);
            this.requests.Name = "requests";
            this.requests.RowHeadersWidth = 51;
            this.requests.Size = new System.Drawing.Size(723, 328);
            this.requests.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выберите период для просмотра оформленных ученических договоров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "с";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(292, 45);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 22);
            this.dateTo.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 30;
            this.button1.Text = "Получить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateFromBox
            // 
            this.dateFromBox.Location = new System.Drawing.Point(57, 45);
            this.dateFromBox.Name = "dateFromBox";
            this.dateFromBox.Size = new System.Drawing.Size(200, 22);
            this.dateFromBox.TabIndex = 33;
            // 
            // getExcel
            // 
            this.getExcel.Location = new System.Drawing.Point(689, 539);
            this.getExcel.Name = "getExcel";
            this.getExcel.Size = new System.Drawing.Size(180, 50);
            this.getExcel.TabIndex = 34;
            this.getExcel.Text = "Получить excel файл";
            this.getExcel.UseVisualStyleBackColor = true;
            // 
            // createDiagram
            // 
            this.createDiagram.Location = new System.Drawing.Point(918, 539);
            this.createDiagram.Name = "createDiagram";
            this.createDiagram.Size = new System.Drawing.Size(191, 50);
            this.createDiagram.TabIndex = 35;
            this.createDiagram.Text = "Построить диаграмму";
            this.createDiagram.UseVisualStyleBackColor = true;
            // 
            // InfoAboutStudentContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 618);
            this.Controls.Add(this.createDiagram);
            this.Controls.Add(this.getExcel);
            this.Controls.Add(this.dateFromBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requests);
            this.Name = "InfoAboutStudentContracts";
            this.Text = "InfoAboutStudentContracts";
            ((System.ComponentModel.ISupportInitialize)(this.requests)).EndInit();
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
    }
}