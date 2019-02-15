using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Project
{
    public class PostgresDriver : IDriverDB
    {
        NpgsqlConnection Conn { get; set; }

        public PostgresDriver(NpgsqlConnection conn)
        {
            Conn = conn;
            //Conn.Open();
        }

        //В деструкторе закрыть соединение, в методах убрать открытие\закрытие

        public void SaveUser(User user)
        {
            //TODO: использовать связываемые переменные запроса в документации Npgsql
            string query = $"INSERT INTO \"User\" (\"Id\", \"Name\", \"Passport\", \"Login\", " +
                $"\"HashPassword\", \"ManagerAccess\", \"SaltString\") VALUES (DEFAULT, " +
                $"'{user.Name}', '{user.Passport}', '{user.Login}', '{user.HashPassword}', " +
                $"'{user.ManagerAccess}', '{user.SaltString}');";
            NpgsqlCommand command = new NpgsqlCommand(query, Conn);
            try
            {
                Conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Данные пользователя {user.Name} не были сохранены. " + ex.Message, 
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
                return;
            }
            MessageBox.Show($"Данные пользователя {user.Name} сохранены", "Сообщение", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Conn.Close();
            return;
        }
        public void UpdateUser(User user)
        {
            string query = $"UPDATE \"User\" SET\"Name\" = '{user.Name}', \"Passport\" = " +
                $"'{user.Passport}', \"Login\" = '{user.Login}', \"HashPassword\" = " +
                $"'{user.HashPassword}', \"ManagerAccess\" = '{user.ManagerAccess}', \"SaltString\" " +
                $"= '{user.SaltString}' WHERE \"Id\" = '{user.Id}';";
            NpgsqlCommand command = new NpgsqlCommand(query, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public User ReadUser(string loginInput)
        {
            string query = $"SELECT * FROM \"User\" WHERE \"Login\" = '{loginInput}';";
            NpgsqlCommand command = new NpgsqlCommand(query, Conn);
            Conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string passport = reader.GetString(2);
                string login = reader.GetString(3);
                string hashPassword = reader.GetString(4);
                bool managerAccess = reader.GetBoolean(5);
                string saltString = reader.GetString(6);
                Conn.Close();
                reader.Close();
                return new User(id, name, passport, login, hashPassword, managerAccess, saltString);
            }
            else
            {
                Conn.Close();
                reader.Close();
                throw new Exception("Пользователь с указанным логином не найден");
            }
        }
        public User[] ReadAllUsers()
        {
            //Получить список логинов, по котрым прочесть пользователей и собрать в массив, возможно пустой
            string query = "SELECT COUNT(\"Id\") FROM \"User\";";
            NpgsqlCommand command = new NpgsqlCommand(query, Conn);
            Conn.Open();
            int userNumber = 0;
            userNumber = Convert.ToInt32(command.ExecuteScalar());
            Conn.Close();
            if (userNumber > 0)
            {
                User[] allUsers = new User[userNumber];
                query = $"SELECT * FROM \"User\";";
                command = new NpgsqlCommand(query, Conn);
                Conn.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string passport = reader.GetString(2);
                        string login = reader.GetString(3);
                        string hashPassword = reader.GetString(4);
                        bool managerAccess = reader.GetBoolean(5);
                        string saltString = reader.GetString(6);
                        User user = new User(id, name, passport, login, hashPassword, managerAccess, saltString);
                        allUsers[i++] = user;
                    }
                    Conn.Close();
                    reader.Close();
                    return allUsers;
                }
                else throw new Exception("Не удалось прочитать список пользователей");
            }
            else throw new Exception("Не удалось прочитать список пользователей");
        }
    }
}
