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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)// кнопка закрытия 
        {
            Application.Exit();
        }
 
    
       
       
       

        private void output_Click(object sender, EventArgs e)// логинимся
        {
            String loginuser = loginfield.Text;// логин
            String passuser = passfiend.Text;// пароль

            DB db = new DB();// подключение к БД

            DataTable table = new DataTable();// таблица с данными

            
            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password`=@uP",db.GetConnection());// запрос

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginuser;// определение маски
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passuser;// определение маски

            adapter.SelectCommand = command;// выдаем запрос адаптеру
            adapter.Fill(table);// заполняем таблицу

            if (table.Rows.Count > 0)// если в таблицу хоть 1 столбец, то мы вошли правильно
            {             
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Ошибка входа!!!!");
        }

         Point lastpoint;// точка отвечающая за ластпоинт
        private void label1_MouseDown(object sender, MouseEventArgs e)// метод для перемещения таблицы 
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)// метод для перемещения таблицы 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

       
        private void registrChange_Click(object sender, EventArgs e)// открытие новой формы при нажатии на кнопу зарегистрироваться
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
