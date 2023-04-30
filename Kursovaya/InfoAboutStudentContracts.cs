using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class InfoAboutStudentContracts : Form
    {
        private List<String> FIO = new List<string>();
        private List<String> dateOfForming = new List<string>();
        public InfoAboutStudentContracts()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=91.211.52.148;port=3356;user=developer;password=SgmZ9mZ2LcVEJS8w;database=db_develop");
            try
            {
              
                connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter($"SELECT contract.ContractId, student.FIO, student.DateOfBirth, vacancy.VacancyId, vacancy.VacancyName, contract.DateOfForming, contract.Status FROM contract JOIN student ON contract.StudentId = student.StudentId join vacancy on contract.VacancyId = vacancy.VacancyId WHERE contract.Status = 'Запрос отправлен' AND DATE(contract.DateOfForming) >= '{GetDate(dateFromBox.Value)}' AND DATE(contract.DateOfForming) <= '{GetDate(dateTo.Value)}' ORDER BY contract.ContractId ASC;", connection);

                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                requests.DataSource = DATA;
                connection.Close();

                foreach (DataGridViewRow row in requests.SelectedRows)
                {
                    if (!row.IsNewRow)
                        requests.Rows.Remove(row);
                        

                }
                foreach (DataRow row in DATA.Rows) {
                    FIO.Add(row[1].ToString());
                    dateOfForming.Add(row[5].ToString());

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

        private void getExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ученические_договоры\";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (Kursovaya.ExcelHelper helper = new Kursovaya.ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine(path, "Выгрузка"+DateTime.Now.ToString("yyyy_MM_dd_HH_mm")+".xlsx")))
                        {
                         for (int i = 0; i < FIO.Count; i++)
                         {
                        helper.Set(column: "A", row: i+1, data: FIO[i]);
                        helper.Set(column: "B", row: i+1, data: dateOfForming[i]);

                        }
                        MessageBox.Show("Файл успешно сформирован и сохранен по пути: " +path);
                        helper.Save();
                        }

                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void createDiagram_Click(object sender, EventArgs e)
        {
            GetAnalyse getAnalyse = new GetAnalyse(dateOfForming);
            getAnalyse.Show();
        }

        private void InfoAboutStudentContracts_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastpoint;
        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
    }
    
    
}
