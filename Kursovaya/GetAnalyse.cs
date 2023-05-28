using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class GetAnalyse : Form
    {
        public GetAnalyse(List<String> dates)
        {
            InitializeComponent();
            List<String> contractsFor2022 = new List<String>();
            List<String> contractsFor2023 = new List<String>();
            List<String> contractsFor2024 = new List<String>();

            if (dates.Count > 0)
            {   for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i].Contains("2023"))
                    {
                        contractsFor2023.Add(dates[i]);

                    }
                    else
                    {
                        if (dates[i].Contains("2024"))
                        {
                            contractsFor2024.Add(dates[i]);

                        }
                        else
                        {
                            if (dates[i].Contains("2022"))
                            {
                                contractsFor2022.Add(dates[i]);

                            }
                        }
                    }
                    
                    

                }
                if (contractsFor2022.Count > 0) { diagramBox.Series[0].Points.AddXY("2022", Convert.ToDouble(contractsFor2022.Count)); }
                if (contractsFor2023.Count > 0) { diagramBox.Series[0].Points.AddXY("2023", Convert.ToDouble(contractsFor2023.Count)); }
                if (contractsFor2024.Count > 0) { diagramBox.Series[0].Points.AddXY("2024", Convert.ToDouble(contractsFor2024.Count)); }
                
                
            }




        }

        private void GetAnalyse_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastpoint;

        private void label14_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label14_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
    }
}
