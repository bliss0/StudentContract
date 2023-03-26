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
        String accountId;
        public MainForm(String accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            try
            {
                connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT * FROM stations", connection);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                dataGridView1.DataSource = DATA;
                connection.Close();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridView1.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void update_Click(object sender, EventArgs e)
        {
          
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            try
            {
                connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT * FROM stations", connection);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                dataGridView1.DataSource = DATA;
                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();             
            }

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
            FormStudentContract formStudentContract = new FormStudentContract(accountId);
            formStudentContract.Show();
        }

        private void getContracts_Click(object sender, EventArgs e)
        {
            InfoAboutStudentContracts infoAboutStudentContracts = new InfoAboutStudentContracts();
            infoAboutStudentContracts.Show();
        }
    }
    
    
}
