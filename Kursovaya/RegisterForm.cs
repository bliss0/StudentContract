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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
          
        }

      
        private void close_Click(object sender, EventArgs e)// кнопка закрытия 
        {
            Application.Exit();
        }

       

        private void buttonregister_Click(object sender, EventArgs e)// регистрация
        {
            Regex nameCheck = new Regex(".*[А-яЁёA-z].*");// условия для ввода корректного имени 
            Match match = nameCheck.Match(userNameField.Text);// проверка на совпадение имени
            if (!match.Success)
            {
                MessageBox.Show("Некорректное имя!");
                return;
            }

            Regex surnameCheck = new Regex(".*[А-яЁёA-z].*");// условия для ввода корректной фамилии 
            Match match1 = surnameCheck.Match(userSurnameField.Text);// проверка на совпадение фамилии
            if (!match1.Success)
            {
                MessageBox.Show("Некорректная фамилия !");
                return;
            }

            
            if(isUserExist())// проверка на существование пользователя
                return;
            

            DB db = new DB();// подключение к БД
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login,@pass, @name, @surname)",db.GetConnection());// запрос в БД

            //запись значений из полей в формах в БД
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordFiend.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();// открываем подключение к БД

            if (command.ExecuteNonQuery() == 1) // проверка выполнения запроса
                 MessageBox.Show("Аккаунт был создан");
            else
                 MessageBox.Show("Аккаунт не был создан");
            db.closeConnection();
        
        }

        public Boolean isUserExist()// существование пользователя
            {
           
            DB db = new DB();// подключение к БД

            DataTable table = new DataTable();// таблица с данными

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL ", db.GetConnection());// запрос

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text; // установка параметров для маски

            adapter.SelectCommand = command;// установка адаптера на новый запрос
            adapter.Fill(table);// заполнение таблицы

            if (table.Rows.Count > 0)// проверка выполнения запроса
            {
                MessageBox.Show("Такой логин уже есть введите другой");
                return true;
            }
            else
            
                return false;
            
        }

        
      
        Point lastpoint;
        
        private void label1_MouseDown(object sender, MouseEventArgs e)// перемещение приложения
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)// перемещение приложения
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void label2_Click(object sender, EventArgs e) // открытие новой формы
        {
            this.Hide();
            Loginform loginform = new Loginform();
            loginform.Show();
        }
    }
}
