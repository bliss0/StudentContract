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
            if (dates.Count > 0)
            {
                diagramBox.Series[0].Points.AddXY(1, Convert.ToDouble(dates.Count)) ;
            }




        }
    }
}
