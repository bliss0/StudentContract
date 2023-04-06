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
        MySqlConnection connection = new MySqlConnection("server=91.211.52.148;port=3356;user=developer;password=SgmZ9mZ2LcVEJS8w;database=db_develop"); // данные берутся с локального сервера при подключении mysql
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
