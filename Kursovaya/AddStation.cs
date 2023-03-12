using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class AddStation : Form
    {
       
        public AddStation()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)// кнопка закрытия
        {
            this.Close();
           
        }

        
        private void add_Click(object sender, EventArgs e)// добавление в БД маршрута
        {
            DB db = new DB();// создание запроса в ДБ

            DataTable table = new DataTable();// таблица

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=itproger");// соединение

            MySqlCommand command = new MySqlCommand($"INSERT INTO `stations` (`nameOfStation`, `{Convert.ToString(road.SelectedItem)}`) VALUES(@nameOfS, @time)", db.GetConnection());// запрос 

            Regex nameCheck = new Regex(".*[А-яЁё].*");// условия для ввода корректного имени 
            Match match = nameCheck.Match(station.Text);// проверка на совпадение имени
            if (!match.Success)
            {
                MessageBox.Show("Некорректное название станции !!");
                return;
            }

            command.Parameters.Add("nameOfS", MySqlDbType.VarChar).Value = station.Text;

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
                 timing = Convert.ToString(hours.Value)+"0" + Convert.ToString(minutes.Value) +"00";
                else timing = Convert.ToString(hours.Value) + Convert.ToString(minutes.Value) +"00";

            }

            command.Parameters.Add("time", MySqlDbType.VarChar).Value = timing;// параметры запроса

            adapter.SelectCommand = command;// выполение запроса
            

            db.openConnection();// открываем подключение к БД

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Станция была успешно добавлена");
               
            }
            else
                MessageBox.Show("Станция не была добавлен");
            db.closeConnection();

        }

        Point lastpoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
