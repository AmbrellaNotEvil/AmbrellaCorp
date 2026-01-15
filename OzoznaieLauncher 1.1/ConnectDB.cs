using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace OzoznaieLauncher_1._1
{
    internal class ConnectDB
    {
        MySqlConnection DB = new MySqlConnection("Server=localhost;port=3306;Database=test;Uid=root;pwd=1234;"); //Свзяыванием бд с объектом

        public void ConnectToDataBase()     //Функция подключения к БД
        {
            if (DB.State == System.Data.ConnectionState.Closed);        //Проверка на статус БД
                DB.Open();                                              //Начать сеанс с БД
        }
        public void EndConnectWithDataBase()                            
        {
            if (DB.State == System.Data.ConnectionState.Open);         //Проверка на статус БД
            DB.Close();                                                 //Закрываем сеанс БД
        }
        public MySqlConnection GetServerConnection()                    //Возвращаем подключение БД
        {
            return DB;
        }



    }
}
