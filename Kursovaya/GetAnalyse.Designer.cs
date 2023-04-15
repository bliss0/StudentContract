namespace Kursovaya
{
    partial class GetAnalyse
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.diagramBox = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagramBox)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramBox
            // 
            chartArea1.Name = "ChartArea1";
            this.diagramBox.ChartAreas.Add(chartArea1);
            this.diagramBox.IsSoftShadows = false;
            legend1.Name = "Legend1";
            this.diagramBox.Legends.Add(legend1);
            this.diagramBox.Location = new System.Drawing.Point(50, 41);
            this.diagramBox.Name = "diagramBox";
            this.diagramBox.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Кол-во заключенных ученических договоров";
            this.diagramBox.Series.Add(series1);
            this.diagramBox.Size = new System.Drawing.Size(728, 450);
            this.diagramBox.TabIndex = 0;
            this.diagramBox.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статискика количества заключенных ученических договоров";
            // 
            // GetAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagramBox);
            this.Name = "GetAnalyse";
            this.Text = "GetAnalyse";
            ((System.ComponentModel.ISupportInitialize)(this.diagramBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart diagramBox;
        private System.Windows.Forms.Label label1;
    }
}