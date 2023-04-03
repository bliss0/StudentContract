using MySql.Data.MySqlClient;
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
    public partial class InfoAboutStudentContracts : Form
    {
        public InfoAboutStudentContracts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");
            try
            {
              
                connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter($"SELECT contract.ContractId, student.FIO, student.DateOfBirth, vacancy.VacancyId, vacancy.VacancyName, contract.DateOfForming, contract.Status FROM contract JOIN student ON contract.StudentId = student.StudentId join vacancy on contract.VacancyId = vacancy.VacancyId WHERE contract.Status = 'Запрос отправлен' AND DATE(contract.DateOfForming) >= '{GetDate(dateFromBox.Value)}' AND DATE(contract.DateOfForming) <= '{GetDate(dateTo.Value)}';", connection);

                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                requests.DataSource = DATA;
                connection.Close();

                foreach (DataGridViewRow row in requests.SelectedRows)
                {
                    if (!row.IsNewRow)
                        requests.Rows.Remove(row);

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
        public String GetDate(DateTime date)
        {
            var dateForming = date.ToString().Substring(0, 10).Split('.');
            return dateForming[2] + '-' + dateForming[1] + '-' + dateForming[0];
        }
    }
    
}
