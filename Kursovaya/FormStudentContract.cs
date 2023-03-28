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
    public partial class FormStudentContract : Form
    {
        String id;
        public FormStudentContract(String accountId)
        {
            InitializeComponent();
            id = accountId;
            GetInfoAboutUser();
            getCompanies();
        }

        public void GetInfoAboutUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();// таблица с данными

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `AccountId` = @accountId", db.GetConnection());// запрос

            command.Parameters.Add("@accountId", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;// установка адаптера на новый запрос
            adapter.Fill(table);// заполнение таблицы

            DataRow row = table.Rows[0];
            String FIO = row["FIO"].ToString();
            var ListFio = FIO.Split(' ');
            nameBox.Text = ListFio[0];
            surnameBox.Text = ListFio[1];
            secondSurnameBox.Text = ListFio[2];
            dateOfBirth.Text = row["DateOfBirth"].ToString().Substring(0,10);

        }
        
        private void getCompanies()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            MySqlCommand command = new MySqlCommand("SELECT CompanyName FROM company;", db.GetConnection());

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                companiesBox.Items.Add(row[0].ToString());// добавление всех вариантов удаления из БД
            }

        }

        private void getVacancies(String company)
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            MySqlCommand command = new MySqlCommand("SELECT VacancyName FROM vacancy WHERE ;", db.GetConnection());

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                vacanciesBox.Items.Add(row[0].ToString());// добавление всех вариантов удаления из БД
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formContractButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();// таблица с данными

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

            MySqlCommand command = new MySqlCommand("INSERT INTO `personaldata` (`Series`, `Number`, `WhoAndWhen`,`Adress`) VALUES (@series, @number, @whoAndWhen, @adress);" +
                    "SELECT @@identity;" +
                    "UPDATE `student` SET `PersonalDataId`=@@identity WHERE `AccountId`=@accountId", db.GetConnection());// запрос

            var seriesAndNum = seriesAndNumber.Text.Split(' ');

            command.Parameters.Add("@series", MySqlDbType.VarChar).Value = seriesAndNum[0];
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = seriesAndNum[1];
            command.Parameters.Add("@whoAndWhen", MySqlDbType.VarChar).Value = whoAndWhenTextBox.Text;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adressBox.Text;
            command.Parameters.Add("@accountId", MySqlDbType.VarChar).Value = id;

            db.openConnection();// открываем подключение к БД

            if (command.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Договор был сформирован и отправлен на почту предприятия");

            }
            else
                MessageBox.Show("Ошибка формирования договора");
            db.closeConnection();

        }
    }
}
