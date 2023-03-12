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
    public partial class DeleteStation : Form
    {
        public DeleteStation()
        {
            InitializeComponent();
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=itproger");

            MySqlCommand command = new MySqlCommand($"SELECT nameOfStation FROM stations;", db.GetConnection());

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);
            
        foreach (DataRow row in table.Rows)
            {
                comboBox1.Items.Add(row[0].ToString());// добавление всех вариантов удаления из БД
                //row[nomer_stolbca].ToString() - к отдельной ячейке в указанной строке
            }

            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=itproger");

            MySqlCommand command = new MySqlCommand($"DELETE FROM stations WHERE nameOfStation ='{ Convert.ToString(comboBox1.SelectedItem)}';", db.GetConnection());

            adapter.SelectCommand = command;// выполение запроса


            db.openConnection();// открываем подключение к БД

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Маршрут удален");
                comboBox1.Items.Remove(comboBox1.SelectedItem);// удаление использованных
            }

            else
                MessageBox.Show("Маршут не был удаден");
            db.closeConnection();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
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
