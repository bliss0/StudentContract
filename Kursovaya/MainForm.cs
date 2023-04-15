using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void update_Click(object sender, EventArgs e)
        {
          
        }




        Point lastpoint;
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {          
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void formContract_Click(object sender, EventArgs e)
        {
            FormStudentContract formStudentContract = new FormStudentContract();
            formStudentContract.Show();
        }

        private void getContracts_Click(object sender, EventArgs e)
        {
            InfoAboutStudentContracts infoAboutStudentContracts = new InfoAboutStudentContracts();
            infoAboutStudentContracts.Show();
        }
    }
    
    
}
