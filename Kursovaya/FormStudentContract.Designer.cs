﻿namespace Kursovaya
{
    partial class FormStudentContract
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seriesAndNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.whoAndWhenTextBox = new System.Windows.Forms.TextBox();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.secondSurnameBox = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.TextBox();
            this.formContractButton = new System.Windows.Forms.Button();
            this.companiesBox = new System.Windows.Forms.ComboBox();
            this.vacanciesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(160, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(207, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(160, 71);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(207, 22);
            this.surnameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // seriesAndNumber
            // 
            this.seriesAndNumber.Location = new System.Drawing.Point(234, 197);
            this.seriesAndNumber.Name = "seriesAndNumber";
            this.seriesAndNumber.Size = new System.Drawing.Size(133, 22);
            this.seriesAndNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Серия и номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кем и когда выдан";
            // 
            // whoAndWhenTextBox
            // 
            this.whoAndWhenTextBox.Location = new System.Drawing.Point(233, 234);
            this.whoAndWhenTextBox.Name = "whoAndWhenTextBox";
            this.whoAndWhenTextBox.Size = new System.Drawing.Size(133, 22);
            this.whoAndWhenTextBox.TabIndex = 7;
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(233, 269);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(133, 22);
            this.adressBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адрес постоянной регистрации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата рождения";
            // 
            // secondSurnameBox
            // 
            this.secondSurnameBox.Location = new System.Drawing.Point(159, 113);
            this.secondSurnameBox.Name = "secondSurnameBox";
            this.secondSurnameBox.Size = new System.Drawing.Size(207, 22);
            this.secondSurnameBox.TabIndex = 12;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(160, 154);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(207, 22);
            this.dateOfBirth.TabIndex = 13;
            // 
            // formContractButton
            // 
            this.formContractButton.Location = new System.Drawing.Point(629, 377);
            this.formContractButton.Name = "formContractButton";
            this.formContractButton.Size = new System.Drawing.Size(140, 61);
            this.formContractButton.TabIndex = 14;
            this.formContractButton.Text = "Сформировать и отправить";
            this.formContractButton.UseVisualStyleBackColor = true;
            this.formContractButton.Click += new System.EventHandler(this.formContractButton_Click);
            // 
            // companiesBox
            // 
            this.companiesBox.FormattingEnabled = true;
            this.companiesBox.Location = new System.Drawing.Point(602, 57);
            this.companiesBox.Name = "companiesBox";
            this.companiesBox.Size = new System.Drawing.Size(167, 24);
            this.companiesBox.TabIndex = 15;
            // 
            // vacanciesBox
            // 
            this.vacanciesBox.FormattingEnabled = true;
            this.vacanciesBox.Location = new System.Drawing.Point(602, 132);
            this.vacanciesBox.Name = "vacanciesBox";
            this.vacanciesBox.Size = new System.Drawing.Size(167, 24);
            this.vacanciesBox.TabIndex = 16;
            // 
            // FormStudentContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vacanciesBox);
            this.Controls.Add(this.companiesBox);
            this.Controls.Add(this.formContractButton);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.secondSurnameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.whoAndWhenTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seriesAndNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "FormStudentContract";
            this.Text = "FormStudentContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seriesAndNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox whoAndWhenTextBox;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox secondSurnameBox;
        private System.Windows.Forms.TextBox dateOfBirth;
        private System.Windows.Forms.Button formContractButton;
        private System.Windows.Forms.ComboBox companiesBox;
        private System.Windows.Forms.ComboBox vacanciesBox;
    }
}