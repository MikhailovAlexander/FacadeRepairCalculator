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
    public class PostgresDriver:IDriverDB
    {
        NpgsqlConnection Conn { get; set; }

        public PostgresDriver(NpgsqlConnection conn)
        {
            Conn = conn;
        }

        public void SaveUser(User user)
        {
            string query = $"INSERT INTO \"User\" (\"Id\", \"Name\", \"Passport\", \"Login\", \"HashPassword\", \"ManagerAccess\", \"SaltString\") VALUES (DEFAULT, '{user.Name}', '{user.Passport}', '{user.Login}', '{user.HashPassword}', '{user.ManagerAccess}', '{user.SaltString}');";
            NpgsqlCommand command = new NpgsqlCommand(query, Conn);
            int result=0;
            try
            {
                Conn.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Данные пользователя {user.Name} не были сохранены. " + ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
                return;
            }
            if (result == 1)
            {
                MessageBox.Show($"Данные пользователя {user.Name} сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conn.Close();
                return;
            }
        }
        public void UpdateUser(User user)
        {
            string query = $"UPDATE \"User\" SET\"Name\" = '{user.Name}', \"Passport\" = '{user.Passport}', \"Login\" = '{user.Login}', \"HashPassword\" = '{user.HashPassword}', \"ManagerAccess\" = '{user.ManagerAccess}', \"SaltString\" = '{user.SaltString}' WHERE \"Name\" = '{user.Name}';";
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
    }
}
