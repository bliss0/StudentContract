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
            dateOfBirth.Text = row["DateOfBirth"].ToString();

        }

        private void FormStudentContract_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
