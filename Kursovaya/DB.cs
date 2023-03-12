using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    class DB
    {
        // данные о соединении
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=itproger"); // данные берутся с локального сервера при подключении mysql
                                                                                                              // БД к какой коннектим          

        public void openConnection () // открытие подключения
        {
            if (connection.State == System.Data.ConnectionState.Closed)// если состояние соединения == выключено, то включаем
                connection.Open();
        }

        public void closeConnection() // закрытие подключения
        {
            if (connection.State == System.Data.ConnectionState.Open)// если состояние соединения == вкл, то выключаем
                connection.Close();
        }

        public MySqlConnection GetConnection()// получаем это самое соединение
        {
            return connection;
        }
    }

}
