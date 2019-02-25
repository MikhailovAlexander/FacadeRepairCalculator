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
            Conn.Open();
        }

        ~PostgresDriver()
        {
            Conn.Close();
        }

        public void CreateUser(User user)
        {
            string query = $"INSERT INTO application_user (id, name, passport, login, " +
                $"hash_password, manager_access, salt_string) VALUES (DEFAULT, @name, @passport," +
                $"@login, @hash_password, @manager_access, @salt_string);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@passport", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@login", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@hash_password", 
                                                       NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@manager_access", 
                                                       NpgsqlTypes.NpgsqlDbType.Boolean));
            cmd.Parameters.Add(new NpgsqlParameter("@salt_string", 
                                                       NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Prepare();
            cmd.Parameters[0].Value = user.Name;
            cmd.Parameters[1].Value = user.Passport;
            cmd.Parameters[2].Value = user.Login;
            cmd.Parameters[3].Value = user.HashPassword;
            cmd.Parameters[4].Value = user.ManagerAccess;
            cmd.Parameters[5].Value = user.SaltString;
            cmd.ExecuteNonQuery();
        }

        public void UpdateUser(User user)
        {
            string query = $"UPDATE application_user SET name = @name, passport = @passport," +
                $"login = @login, hash_password = @hash_password, manager_access = @manager_access," +
                $"salt_string = @salt_string WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@passport",NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@login", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@hash_password",
                                                       NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@manager_access",
                                                       NpgsqlTypes.NpgsqlDbType.Boolean));
            cmd.Parameters.Add(new NpgsqlParameter("@salt_string",
                                                       NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = user.Name;
            cmd.Parameters[1].Value = user.Passport;
            cmd.Parameters[2].Value = user.Login;
            cmd.Parameters[3].Value = user.HashPassword;
            cmd.Parameters[4].Value = user.ManagerAccess;
            cmd.Parameters[5].Value = user.SaltString;
            cmd.Parameters[6].Value = user.Id;
            cmd.ExecuteNonQuery();
        }

        public User ReadUser(string loginForSearch)
        {
            string query = $"SELECT * FROM application_user WHERE login = @login;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@login", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Prepare();
            cmd.Parameters[0].Value = loginForSearch;
            var reader = cmd.ExecuteReader();
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
                reader.Close();
                return 
                    new User(id, name, passport, login, hashPassword, managerAccess, saltString);
            }
            else
            {
                reader.Close();
                throw new Exception("Пользователь с указанным логином не найден");
            }
        }

        public User ReadUser(int idForSearch)
        {
            string query = $"SELECT * FROM application_user WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idForSearch;
            var reader = cmd.ExecuteReader();
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
                reader.Close();
                return
                    new User(id, name, passport, login, hashPassword, managerAccess, saltString);
            }
            else
            {
                reader.Close();
                throw new Exception("Пользователь с указанным логином не найден");
            }
        }

        public void DeleteUser(int id)
        {
            string query = "DELETE FROM application_user WHERE id = @id";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = id;
            cmd.ExecuteNonQuery();
        }

        public User[] ReadAllUsers()
        {
            string query = "SELECT login FROM application_user;";
            var cmd = new NpgsqlCommand(query, Conn);
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new User[0];
            }
            List<string> loginList = new List<string>();
            while (reader.Read()) loginList.Add(reader.GetString(0));
            reader.Close();
            User[] allUsers = new User[loginList.Count];
            for (int i = 0; i < loginList.Count; i++)
                allUsers[i] = this.ReadUser(loginList[i]);
            return allUsers;
        }


        public void CreateClient(string clientName)
        {
            string query = $"INSERT INTO client (id, name) VALUES (DEFAULT, @name);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Prepare();
            cmd.Parameters[0].Value = clientName;
            cmd.ExecuteNonQuery();
        }

        public void UpdateClient(int idClient, string newClientName)
        {
            string query = $"UPDATE client SET name=@name WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = newClientName;
            cmd.Parameters[0].Value = idClient;
            cmd.ExecuteNonQuery();
        }

        public void DeleteClient(int idClient)
        {
            string query = $"DELETE FROM client WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idClient;
            cmd.ExecuteNonQuery();
        }

        public string[] ReadAllClients()
        {
            //Получение количества строк для указания рамера массива
            string query = "SELECT COUNT(*) FROM client;";
            var cmd = new NpgsqlCommand(query, Conn);
            int numberOfRows = Convert.ToInt32(cmd.ExecuteScalar());
            if(numberOfRows==0) return new string[0];

            cmd.CommandText = "SELECT name FROM client;";
            var reader = cmd.ExecuteReader();
            string[] allClients = new string[numberOfRows];
            for(int i = 0; i < numberOfRows; i++)
            {
                reader.Read();
                allClients[i] = reader.GetString(0);
            }
            reader.Close();
            return allClients;
        }


        public void CreateProject(Project project)
        {
            string query = $"INSERT INTO project (id, name, address, id_client, id_project_state, "+
                $"date_of_start, date_of_complete) VALUES (DEFAULT, @name, @address, " +
                $"(SELECT id FROM client WHERE name = @client_name), " +
                $"@id_project_state, @date_of_start, @date_of_complete);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@address", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@client_name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id_project_state",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_start",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_complete",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Prepare();
            cmd.Parameters[0].Value = project.Name;
            cmd.Parameters[1].Value = project.Address;
            cmd.Parameters[2].Value = project.Client;
            cmd.Parameters[3].Value = (int)project.State;
            cmd.Parameters[4].Value = project.DateOfStart;
            cmd.Parameters[5].Value = project.DateOfComplete;
            cmd.ExecuteNonQuery();
        }

        public void UpdateProject(Project project)
        {
            string query = $"UPDATE project SET name = @name, address = @address, " +
                $"id_client = (SELECT id FROM client WHERE name = @client_name), " +
                $"id_project_state = @id_project_state, date_of_start = @date_of_start, " +
                $"date_of_complete = @date_of_complete WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@address", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@client_name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id_project_state",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_start",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_complete",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Prepare();
            cmd.Parameters[0].Value = project.Name;
            cmd.Parameters[1].Value = project.Address;
            cmd.Parameters[2].Value = project.Client;
            cmd.Parameters[3].Value = (int)project.State;
            cmd.Parameters[4].Value = project.DateOfStart.Date;
            cmd.Parameters[5].Value = project.DateOfComplete.Date;
            cmd.Parameters[6].Value = project.Id;
            cmd.ExecuteNonQuery();
        }

        public Project ReadProject(int idForSearch)
        {
            string query = $"SELECT project.id, project.name, project.address, client.name, " +
                $"project.id_project_state, project.date_of_start, project.date_of_complete" +
                $"FROM project, client WHERE project.id = @id AND project.id_client = client.id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idForSearch;
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string address = reader.GetString(2);
                string client = reader.GetString(3);
                ProjectState state = (ProjectState)reader.GetInt32(4);
                DateTime dateOfStart = (DateTime)reader.GetDate(5);
                DateTime dateOfComplete = (DateTime)reader.GetDate(6);
                reader.Close();
                return
                    new Project(id, name, address, client, state, dateOfStart, dateOfComplete);
            }
            else
            {
                reader.Close();
                throw new Exception("Проект не найден");
            }
        }

        public Project[] ReadAllProject()
        {
            string query = "SELECT id FROM project;";
            var cmd = new NpgsqlCommand(query, Conn);
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new Project[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            Project[] allProjects = new Project[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                allProjects[i] = this.ReadProject(idList[i]);
            return allProjects;
        }

        public Project[] ReadAllProjectByState(ProjectState stateToSearch)
        {
            string query = "SELECT id FROM project WHERE id_project_state = @id_project_state;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id_project_state",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = (int)stateToSearch;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new Project[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            Project[] allProjects = new Project[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                allProjects[i] = this.ReadProject(idList[i]);
            return allProjects;
        }

        public void DeleteProject(int id)
        {
            string query = "DELETE FROM project WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = id;
            cmd.ExecuteNonQuery();
        }

        public void AddUserToProject(int idUser, int idProject)
        {
            string query = "INSERT INTO user_in_project (id_user, id_project) VALUES " +
                "(@id_user, @id_project);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idUser;
            cmd.Parameters[1].Value = idProject;
            cmd.ExecuteNonQuery();
        }

        public void RemoveUserFromProject(int idUser, int idProject)
        {
            string query = "DELETE FROM user_in_project WHERE id_user = @id_user AND " +
                "id_project = @id_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idUser;
            cmd.Parameters[1].Value = idProject;
            cmd.ExecuteNonQuery();
        }

        public User[] ReadUsersByProject(int idForSearch)
        {
            string query = "SELECT id_user FROM user_in_project WHERE id_project=@id_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idForSearch;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new User[0];
            }
            List<int> idUserList = new List<int>();
            while (reader.Read()) idUserList.Add(reader.GetInt32(0));
            reader.Close();
            User[] usersByProject = new User[idUserList.Count];
            for (int i = 0; i < idUserList.Count; i++)
                usersByProject[i] = this.ReadUser(idUserList[i]);
            return usersByProject;
        }

    }
}
