using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Final.classes
{
    public class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source = LAPTOP-FMVIMO4I\SQLEXPRESS; Initial catalog = Sessia_1; Integrated Security = true");

        public bool Conected()
        {
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        internal List<AllAutohorize> GetAutohorizesAll()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Autohorizes", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AllAutohorize> alls = new List<AllAutohorize>();
            while (reader.Read())
            {
                Debug.WriteLine("2" + reader[0].ToString());
                alls.Add(new AllAutohorize
                {
                    id = Int32.Parse(reader[0].ToString()),
                    idUsers = reader[1].ToString(),
                    data = reader[2].ToString(),
                    trys = Int32.Parse(reader[3].ToString())
                });
            }
            reader.Close();
            return alls;
        }

        public bool Diconected()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        /// <summary>
        /// SELECT {} FROM users WHERE {} = '{}' 
        /// </summary>
        /// <param name="what">что вернуть</param>
        /// <param name="column">Столбец поиска</param>
        /// <param name="where">Параметр поиска</param>
        /// <returns></returns>
        public string SelectUsers(string what, string column, string where)
        {
            SqlCommand command = new SqlCommand($"SELECT {what} FROM users WHERE {column} = '{where}'", connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                var res = reader[0].ToString();
                reader.Close();
                return res;
            }

            reader.Close();

            return "";
        }

        public Users SelectUsers(string where)
        {
            SqlCommand command = new SqlCommand($"SELECT id, name, password, type FROM users WHERE login = '{where}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            Users users = new Users();
            while (reader.Read())
            {
                users.id = Int32.Parse(reader[0].ToString());
                users.name = reader[1].ToString();
                users.password = reader[2].ToString();
                users.type = Int32.Parse(reader[3].ToString());
            }

            reader.Close();

            return users;
        }

        /// <summary>
        /// Добавить авторизацию
        /// </summary>
        /// <param name="name">Логин</param>
        /// <param name="data">Время</param>
        /// <param name="trys">Попытка</param>
        /// <returns></returns>
        public bool DbAutohorize(string name, string data, int trys = 0)
        {

            SqlCommand command = new SqlCommand($"INSERT INTO Autohorizes (IdUsers, DataTime, trys) VALUES('{name}', '{data}', '{trys}')", connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Что-то куда-то вставить
        /// </summary>
        /// <param name="tablename">Имя таблицы</param>
        /// <param name="paramColumn">Параметры для таблицы</param>
        /// <param name="paramValues">Параметры что вставить</param>
        public void Insert(string tablename, string paramColumn, string paramValues)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO {tablename} ({paramColumn}) VALUES ({paramValues})", connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
