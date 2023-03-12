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
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=itproger");

            MySqlCommand command = new MySqlCommand($"SELECT nameOfStation FROM stations;", db.GetConnection());

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                boxStations.Items.Add(row[0].ToString());// добавление всех вариантов удаления из БД
                //row[nomer_stolbca].ToString() - к отдельной ячейке в указанной строке
            }


        }

        private void delete_Click(object sender, EventArgs e)
        {
            DB db = new DB();// создание запроса в ДБ

            DataTable table = new DataTable();// таблица

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=itproger");// соединение

            MySqlCommand command = new MySqlCommand($"UPDATE stations SET `{Convert.ToString(boxRoads.SelectedItem)}` = @time WHERE nameOfStation = '{Convert.ToString(boxStations.SelectedItem)}';", db.GetConnection());// запрос 

            
            string timing;

            // корректная корректировка времени

            if (hours.Value < 10)
            {
                if (minutes.Value < 10)
                    timing = "0" + Convert.ToString(hours.Value) + "0" + Convert.ToString(minutes.Value) + "00";
                else timing = "0" + Convert.ToString(hours.Value) + Convert.ToString(minutes.Value) + "00";
            }
            else
            {
                if (minutes.Value < 10)
                    timing = Convert.ToString(hours.Value) + "0" + Convert.ToString(minutes.Value) + "00";
                else timing = Convert.ToString(hours.Value) + Convert.ToString(minutes.Value) + "00";

            }

            command.Parameters.Add("time", MySqlDbType.VarChar).Value = timing;// параметры запроса

            adapter.SelectCommand = command;// выполение запроса


            db.openConnection();// открываем подключение к БД

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация была успешно добавлена");

            }
            else
                MessageBox.Show("Информация не была добавлена");
            db.closeConnection();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastpoint;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
           
            lastpoint = new Point(e.X, e.Y);
        }
    

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Left)
             {
                      this.Left += e.X - lastpoint.X;
                      this.Top += e.Y - lastpoint.Y;
             }
        }
    }
}
