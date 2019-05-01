using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

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

        private void DeleteFromTable(string nameTable, int idObjectToDelete)
        {
            string query = $"DELETE FROM {nameTable} WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idObjectToDelete;
            cmd.ExecuteNonQuery();
        }

        public void DeleteFromTableWithParams(string nameTable, string nameParam1,
            int valueParam1, string nameParam2, int valueParam2)
        {
            string query = $"DELETE FROM {nameTable} WHERE {nameParam1} = @{nameParam1} AND " +
               $"{nameParam2} = @{nameParam2};";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter($"@{nameParam1}", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter($"@{nameParam2}", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = valueParam1;
            cmd.Parameters[1].Value = valueParam2;
            cmd.ExecuteNonQuery();
        }

        private NpgsqlDataReader ReadObjectGetReader(string nameTable, int idObject)
        {
            string query = $"SELECT * FROM {nameTable} WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idObject;
            return cmd.ExecuteReader();
        }

        private Object ReadValueFromTable(string paramIn, string paramOut, string nameTable, Object ValueIn)
        {
            string query = $"SELECT {paramOut} FROM {nameTable} WHERE {paramIn} = @{paramIn};";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.AddWithValue($"@{paramIn}", ValueIn);
            return cmd.ExecuteScalar();
        }

        private T[] ReadAllTObjects<T>(string nameTable, string nameParametr, int idParametr,
            Func<int, T> ReadObject)
        {
            string query = $"SELECT id FROM {nameTable} WHERE {nameParametr} = @{nameParametr};";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter($"@{nameParametr}", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idParametr;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new T[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            T[] objects = new T[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                objects[i] = ReadObject(idList[i]);
            return objects;
        }

        private T[] ReadAllTObjects<T>(string nameTable, Func<int, T> ReadObject) where T : new()
        {
            string query = $"SELECT id FROM {nameTable};";
            var cmd = new NpgsqlCommand(query, Conn);
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new T[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            T[] objects = new T[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                objects[i] = ReadObject(idList[i]);
            return objects;
        }
        
        private T[] ReadAllTObjectsFromTables<T>(string nameTable1, string nameColumn1,
            string nameTable2, string nameColumn2, int idParametr, Func<int, T> ReadObject)
        {
            string query = $"SELECT {nameTable1}.id FROM {nameTable1}, {nameTable2} " +
                $"WHERE {nameTable1}.{nameColumn1} = {nameTable2}.id AND {nameTable2}.{nameColumn2} = @{nameColumn2};";
            // select project.id from project, user_in_project where user_in_project.id_project = project.id and user_in_project.id_user = @id.user;
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter($"@{nameColumn2}", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idParametr;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new T[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            T[] objects = new T[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                objects[i] = ReadObject(idList[i]);
            return objects;
        }

        private T[] ReadObjectsByEntity<T>(string nameTable, string paramOut, string ParamIn, int ParamInValue,
            Func<int, T> ReadObject)
        {
            //string query = "SELECT id_user FROM user_in_project WHERE id_project=@id_project;";
            string query = $"SELECT {paramOut} FROM {nameTable} WHERE {ParamIn} = @{ParamIn};";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter($"@{ParamIn}", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = ParamInValue;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new T[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            T[] objects = new T[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                objects[i] = ReadObject(idList[i]);
            return objects;
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
            cmd.Parameters.Add(
                new NpgsqlParameter("@hash_password", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@manager_access", NpgsqlTypes.NpgsqlDbType.Boolean));
            cmd.Parameters.Add(
                new NpgsqlParameter("@salt_string", NpgsqlTypes.NpgsqlDbType.Varchar));
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
            cmd.Parameters.Add(new NpgsqlParameter("@passport", NpgsqlTypes.NpgsqlDbType.Varchar));
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
            var reader = ReadObjectGetReader(User.nameTableInDB, idForSearch);
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
                throw new Exception("Пользователь не найден");
            }
        }

        public void DeleteUser(int idUser)
        {
            DeleteFromTable(User.nameTableInDB, idUser);
        }

        public User[] ReadAllUsers()
        {
            return ReadAllTObjects<User>(User.nameTableInDB, ReadUser);
        }

        public void AddUserToProject(int idUser, int idProject)
        {
            string query = $"INSERT INTO {Project.nameTableInDBUserInProject} " +
                $"(id_user, id_project) VALUES (@id_user, @id_project);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idUser;
            cmd.Parameters[1].Value = idProject;
            cmd.ExecuteNonQuery();
        }

        public void DeleteUserFromProject(int idUser, int idProject)
        {
            DeleteFromTableWithParams(Project.nameTableInDBUserInProject, "id_user", idUser,
            "id_project", idProject);
        }

        public User[] ReadUsersInProject(int idProject)
        {
            return ReadObjectsByEntity<User>(Project.nameTableInDBUserInProject, "id_user", "id_project", idProject, ReadUser);
        }

        public int GetIdUserInProject(int idUser, int idProject)
        {
            string query = "SELECT id FROM user_in_project WHERE id_user=@id_user AND id_project=@id_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idUser;
            cmd.Parameters[1].Value = idProject;
            object result = cmd.ExecuteScalar();
            int id = -1;
            if(result != null) id = Convert.ToInt32(result);
            return id;
        }

        public Project GetProjectFromUserInProject(int idUserInProject)
        {
            Object result = ReadValueFromTable(
                "id", "id_project", Project.nameTableInDBUserInProject, idUserInProject);
            if (result == null) return new Project();
            int idProject = Convert.ToInt32(result);
            return ReadProject(idProject);
        }

        public User GetUserFromUserInProject(int idUserInProject)
        {
            Object result = ReadValueFromTable(
                "id", "id_user", Project.nameTableInDBUserInProject, idUserInProject);
            if (result == null) return new User();
            int idUser = Convert.ToInt32(result);
            return ReadUser(idUser);
        }

        public void CreateClient(Client client)
        {
            string query = $"INSERT INTO client (id, name, address, inn) " +
                $"VALUES (DEFAULT, @name, @address, @inn);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@address", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@inn", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Prepare();
            cmd.Parameters[0].Value = client.Name;
            cmd.Parameters[1].Value = client.Address;
            cmd.Parameters[2].Value = client.Inn;
            cmd.ExecuteNonQuery();
        }

        public void UpdateClient(Client client)
        {
            string query = $"UPDATE client SET name = @name, address = @address, inn = @inn WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@address", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@inn", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = client.Name;
            cmd.Parameters[1].Value = client.Address;
            cmd.Parameters[2].Value = client.Inn;
            cmd.Parameters[3].Value = client.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteClient(int idClient)
        {
            DeleteFromTable(Client.nameTableInDB, idClient);
        }

        public Client ReadClient(int idForSearch)
        {
            var reader = ReadObjectGetReader(Client.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string address = reader.GetString(2);
                string inn = reader.GetString(3);
                reader.Close();
                return
                    new Client(id, name, address, inn);
            }
            else
            {
                reader.Close();
                throw new Exception("Заказчик с указанным id не найден");
            }
        }

        public Client[] ReadAllClients()
        {
            return ReadAllTObjects<Client>(Client.nameTableInDB, ReadClient);
        }


        public int CreateProject(Project project)
        {
            string query = $"INSERT INTO project (id, name, address, id_client, " +
                $"id_project_state, date_of_start, date_of_complete, planned_date_of_complete) " +
                $"VALUES (DEFAULT, @name, @address, @id_client, @id_project_state, " +
                $"@date_of_start, @date_of_complete, @planned_date_of_complete) RETURNING id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@address", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id_client",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@id_project_state",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_start",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_complete",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("@planned_date_of_complete",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Prepare();
            cmd.Parameters[0].Value = project.Name;
            cmd.Parameters[1].Value = project.Address;
            cmd.Parameters[2].Value = project.IdClient;
            cmd.Parameters[3].Value = (int)project.State;
            cmd.Parameters[4].Value = project.DateOfStart.Date;
            cmd.Parameters[5].Value = project.DateOfComplete.Date;
            cmd.Parameters[6].Value = project.PlannedDateOfComplete.Date;

            int idProject = Convert.ToInt32(cmd.ExecuteScalar());
            return idProject;
        }

        public void UpdateProject(Project project)
        {
            string query = $"UPDATE project SET name = @name, address = @address, " +
                $"id_client = @id_client, id_project_state = @id_project_state, " +
                $"date_of_start = @date_of_start, date_of_complete = @date_of_complete, " +
                $"planned_date_of_complete = @planned_date_of_complete WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@address", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id_client", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@id_project_state",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_start",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("@date_of_complete",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("@planned_date_of_complete",
                                                       NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = project.Name;
            cmd.Parameters[1].Value = project.Address;
            cmd.Parameters[2].Value = project.IdClient;
            cmd.Parameters[3].Value = (int)project.State;
            cmd.Parameters[4].Value = project.DateOfStart.Date;
            cmd.Parameters[5].Value = project.DateOfComplete.Date;
            cmd.Parameters[6].Value = project.PlannedDateOfComplete.Date;
            cmd.Parameters[7].Value = project.Id;
            cmd.ExecuteNonQuery();
        }

        public Project ReadProject(int idForSearch)
        {
            var reader = ReadObjectGetReader(Project.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string address = reader.GetString(2);
                int idClient = reader.GetInt32(3);
                ProjectState state = (ProjectState)reader.GetInt32(4);
                DateTime dateOfStart = (DateTime)reader.GetDate(5);
                DateTime dateOfComplete = (DateTime)reader.GetDate(6);
                DateTime plannedDateOfComplete = (DateTime)reader.GetDate(7);
                reader.Close();
                return new Project(id, name, address, idClient, state, dateOfStart, dateOfComplete,
                                   plannedDateOfComplete);
            }
            else
            {
                reader.Close();
                throw new Exception("Проект не найден");
            }
        }

        public Project[] ReadAllProject()
        {
            return ReadAllTObjects<Project>(Project.nameTableInDB, ReadProject);
        }

        public Project[] ReadAllProjectByState(ProjectState stateToSearch)
        {
            return ReadAllTObjects<Project>(Project.nameTableInDB, "id_project_state", (int)stateToSearch, ReadProject);
        }

        public Project[] ReadAllProjectByUser(int idUser)
        {
            string query = $"SELECT {Project.nameTableInDB}.id " +
                $"FROM {Project.nameTableInDB}, {Project.nameTableInDBUserInProject} " +
                $"WHERE {Project.nameTableInDB}.id = " +
                $"{Project.nameTableInDBUserInProject}.id_project AND " +
                $"{Project.nameTableInDBUserInProject}.id_user = @id_user;";
            // select project.id from project, user_in_project where user_in_project.id_project = project.id and user_in_project.id_user = @id.user;
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter($"@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idUser;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new Project[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            Project[] projects = new Project[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                projects[i] = ReadProject(idList[i]);
            return projects;
        }

        public void DeleteProject(int idProject)
        {
            DeleteFromTable(Project.nameTableInDB, idProject);
        }

        public decimal GetTotalSquare(int idProject)
        {
            string query = $"SELECT SUM(square) FROM {Element.nameTableInDB}, " +
                $"{TypeOfElement.nameTableInDB}, {SectionOfBuilding.nameTableInDB} " +
                $"WHERE id_type_of_element IS NOT NULL AND " +
                $"id_section_of_building = {SectionOfBuilding.nameTableInDB}.id AND " +
                $"id_type_of_element = {TypeOfElement.nameTableInDB}.id AND " +
                $"id_project = @id_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter(
                    "@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idProject;
            object result = cmd.ExecuteScalar();
            decimal square = -1;
            if (result != null && !DBNull.Value.Equals(result)) square = Convert.ToDecimal(result);
            return square;
        }

        private decimal GetValueByWork(int idProject, WorkInProject workInProject)
        {
            string valueParam = "";
            var typeOfWork = ReadTypeOfWork(workInProject.IdTypeOfWork);
            if (typeOfWork.Dim == Dimension.Piece) valueParam = "1";
            else if (typeOfWork.Dim == Dimension.Length) valueParam = "length";
            else if (typeOfWork.Dim == Dimension.Square) valueParam = "square";
            else if (typeOfWork.Dim == Dimension.Height) valueParam = "height";
            string query =
                $"SELECT SUM({valueParam} * {WorkInProject.nameTableInDB}.multiplicity * " +
                $"{WorkByElement.nameTableInDB}.multiplicity) FROM " +

                $"{TypeOfElement.nameTableInDB}, {Element.nameTableInDB}, " +
                $"{WorkByElement.nameTableInDB}, {WorkInProject.nameTableInDB}, " +
                $"{SectionOfBuilding.nameTableInDB}, {Project.nameTableInDB} WHERE " +

                $"{WorkByElement.nameTableInDB}.id_element = {Element.nameTableInDB}.id AND " +
                $"{TypeOfElement.nameTableInDB}.id = " +
                $"{Element.nameTableInDB}.id_type_of_element AND " +
                $"{WorkByElement.nameTableInDB}.id_work_in_project = " +
                $"{WorkInProject.nameTableInDB}.id AND " +
                $"{WorkInProject.nameTableInDB}.id = @id_work_in_project AND " +
                $"{Element.nameTableInDB}.id_section_of_building = " +
                $"{SectionOfBuilding.nameTableInDB}.id AND " +
                $"{Project.nameTableInDB}.id = @id_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_in_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = workInProject.Id;
            cmd.Parameters[1].Value = idProject;
            object result = cmd.ExecuteScalar();
            if (result != null && !DBNull.Value.Equals(result))
                return Convert.ToDecimal(result);
            else return 0;
        }

        public decimal GetAmountByWorksFromProject(int idProject)
        {
            var worksInProject = new WorkInProject[0];
            try
            {
                worksInProject = ReadWorksByProject(idProject);
            }
            catch { return -1; }
            if (worksInProject.Length == 0) return 0;
            decimal totalAmount = 0;
            decimal value = 0;
            foreach (WorkInProject work in worksInProject)
            {
                try
                {
                    value = GetValueByWork(idProject, work);
                    totalAmount += value * (decimal)work.Price;
                }
                catch { return -1; }
            }
            return totalAmount;
        }

        public decimal GetAmountPaymentsByProject(int idProject)
        {
            string query = $"SELECT SUM(amount) FROM {Payment.nameTableInDB} WHERE " +
                $"id_project = @id_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter(
                    "@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idProject;
            object result = cmd.ExecuteScalar();
            decimal amount = -1;
            if (result != null && !DBNull.Value.Equals(result)) amount = Convert.ToDecimal(result);
            return amount;
        }

        public void CreateTypeOfWork(TypeOfWork typeOfWork)
        {
            string query = $"INSERT INTO type_of_work (id, name, measure_unit, id_dimension) " +
                $"VALUES (DEFAULT, @name, @measure_unit, @id_dimension);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@measure_unit", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(new NpgsqlParameter("@id_dimension",
                                                       NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = typeOfWork.Name;
            cmd.Parameters[1].Value = typeOfWork.MeasureUnit;
            cmd.Parameters[2].Value = (int)typeOfWork.Dim;
            cmd.ExecuteNonQuery();
        }

        public TypeOfWork ReadTypeOfWork(int idForSearch)
        {
            var reader = ReadObjectGetReader(TypeOfWork.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string measureUnit = reader.GetString(2);
                Dimension dimension = (Dimension)reader.GetInt32(3);
                reader.Close();
                return new TypeOfWork(id, name, measureUnit, dimension);
            }
            else
            {
                reader.Close();
                throw new Exception("Вид работ не найден");
            }
        }

        public void UpdateTypeOfWork(TypeOfWork typeOfWork)
        {
            string query = $"UPDATE type_of_work SET name = @name, " +
                $"measure_unit = @measure_unit, id_dimension = @id_dimension WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
                new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@measure_unit", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_dimension", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = typeOfWork.Name;
            cmd.Parameters[1].Value = typeOfWork.MeasureUnit;
            cmd.Parameters[2].Value = (int)typeOfWork.Dim;
            cmd.Parameters[3].Value = typeOfWork.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteTypeOfWork(int idTypeOfWork)
        {
            DeleteFromTable(TypeOfWork.nameTableInDB, idTypeOfWork);
        }

        public TypeOfWork[] ReadAllTypesOfWork()
        {
            return ReadAllTObjects<TypeOfWork>(TypeOfWork.nameTableInDB, ReadTypeOfWork);
        }


        public void CreateWorkInProject(WorkInProject workInProject)
        {
            string query = $"INSERT INTO work_in_project " +
                $"(id, id_project, id_type_of_work, price, multiplicity) " +
                $"VALUES (DEFAULT, @id_project, @id_type_of_work, @price, @multiplicity);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_type_of_work", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@price", NpgsqlTypes.NpgsqlDbType.Double));
            cmd.Parameters.Add(
                new NpgsqlParameter("@multiplicity", NpgsqlTypes.NpgsqlDbType.Double));
            cmd.Prepare();
            cmd.Parameters[0].Value = workInProject.IdProject;
            cmd.Parameters[1].Value = workInProject.IdTypeOfWork;
            cmd.Parameters[2].Value = workInProject.Price;
            cmd.Parameters[3].Value = workInProject.Multiplicity;
            cmd.ExecuteNonQuery();
        }

        public WorkInProject ReadWorkInProject(int idForSearch)
        {
            var reader = ReadObjectGetReader(WorkInProject.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                int idProject = reader.GetInt32(1);
                int idTypeOfWork = reader.GetInt32(2);
                double price = reader.GetDouble(3);
                double multiplicity = reader.GetDouble(4);
                reader.Close();
                return new WorkInProject(id, idProject, idTypeOfWork, price, multiplicity);
            }
            else
            {
                reader.Close();
                throw new Exception("Работа в проекта не найдена");
            }
        }

        public void UpdateWorkInProject(WorkInProject workInProject)
        {
            string query = $"UPDATE work_in_project SET id_project = @id_project, " +
                $"id_type_of_work = @id_type_of_work, price = @price, multiplicity = @multiplicity " +
                $"WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_type_of_work", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@price", NpgsqlTypes.NpgsqlDbType.Double));
            cmd.Parameters.Add(
                new NpgsqlParameter("@multiplicity", NpgsqlTypes.NpgsqlDbType.Double));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = workInProject.IdProject;
            cmd.Parameters[1].Value = workInProject.IdTypeOfWork;
            cmd.Parameters[2].Value = workInProject.Price;
            cmd.Parameters[3].Value = workInProject.Multiplicity;
            cmd.Parameters[4].Value = workInProject.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteWorkInProject(int idWorkInProject)
        {
            DeleteFromTable(WorkInProject.nameTableInDB, idWorkInProject);
        }

        public WorkInProject[] ReadWorksByProject(int idProject)
        {
            return ReadAllTObjects<WorkInProject>(WorkInProject.nameTableInDB, "id_project", 
                idProject, ReadWorkInProject);
        }


        public void CreatePayment(Payment payment)
        {
            string query = $"INSERT INTO {Payment.nameTableInDB} " +
                $"(id, id_user, id_project,date_of_payment, amount) " +
                $"VALUES (DEFAULT, @id_user, @id_project, @date_of_payment, @amount);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@date_of_payment", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(
                new NpgsqlParameter("@amount", NpgsqlTypes.NpgsqlDbType.Double));
            cmd.Prepare();
            cmd.Parameters[0].Value = payment.IdUser;
            cmd.Parameters[1].Value = payment.IdProject;
            cmd.Parameters[2].Value = payment.DateOfPayment.Date;
            cmd.Parameters[3].Value = payment.Amount;
            cmd.ExecuteNonQuery();
        }

        public Payment ReadPayment(int idForSearch)
        {
            var reader = ReadObjectGetReader(Payment.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                int idUser = reader.GetInt32(1);
                int idProject = reader.GetInt32(2);
                DateTime dateOfPayment = (DateTime)reader.GetDate(3);
                double amount = reader.GetDouble(4);
                reader.Close();
                return new Payment(id, idUser, idProject, dateOfPayment, amount);
            }
            else
            {
                reader.Close();
                throw new Exception("Платеж не найден");
            }
        }

        public void UpdatePayment(Payment payment)
        {
            string query =
                $"UPDATE {Payment.nameTableInDB} SET id_user = @id_user, " +
                $"id_project = @id_project, date_of_payment = @date_of_payment, " +
                $"amount = @amount WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@date_of_payment", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(
                new NpgsqlParameter("@amount", NpgsqlTypes.NpgsqlDbType.Double));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = payment.IdUser;
            cmd.Parameters[1].Value = payment.IdProject;
            cmd.Parameters[2].Value = payment.DateOfPayment.Date;
            cmd.Parameters[3].Value = payment.Amount;
            cmd.Parameters[4].Value = payment.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeletePayment(int idPayment)
        {
            DeleteFromTable(Payment.nameTableInDB, idPayment);
        }

        public Payment[] ReadAllPayments()
        {
            return ReadAllTObjects<Payment>(Payment.nameTableInDB, ReadPayment);
        }

        public Payment[] ReadPaymentsByProject(int idProject)
        {
            return ReadAllTObjects<Payment>(
                Payment.nameTableInDB, "id_project", idProject, ReadPayment);
        }

        public Payment[] ReadPaymentsByUser(int idUser)
        {
            return ReadAllTObjects<Payment>(Payment.nameTableInDB, "id_user", idUser, ReadPayment);
        }

        public Payment[] ReadPaymentsByUserAndProject(int idUser, int idProject)
        {
            string query = $"SELECT {Payment.nameTableInDB}.id " +
                $"FROM {Payment.nameTableInDB} WHERE id_user = @id_user AND " +
                $"id_project = @id_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter($"@id_user", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter($"@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idUser;
            cmd.Parameters[1].Value = idProject;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new Payment[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            Payment[] payments = new Payment[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                payments[i] = ReadPayment(idList[i]);
            return payments;
        }

        public void CreateTypeOfElement(TypeOfElement typeOfElement)
        {
            string query =
                $"INSERT INTO {TypeOfElement.nameTableInDB} " +
                $"(id, name, id_element_picture, square, height, length) " +
                $"VALUES (DEFAULT, @name, @id_element_picture, @square, @height, @length);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_element_picture", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@square", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Parameters.Add(
               new NpgsqlParameter("@height", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Parameters.Add(
               new NpgsqlParameter("@length", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Prepare();
            cmd.Parameters[0].Value = typeOfElement.Name;
            cmd.Parameters[1].Value = typeOfElement.IdElementPicture;
            cmd.Parameters[2].Value = typeOfElement.Square;
            cmd.Parameters[3].Value = typeOfElement.Height;
            cmd.Parameters[4].Value = typeOfElement.Length;
            cmd.ExecuteNonQuery();
        }

        public TypeOfElement ReadTypeOfElement(int idForSearch)
        {
            var reader =  ReadObjectGetReader(TypeOfElement.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int idElementPicture = reader.GetInt32(2);
                decimal square = reader.GetDecimal(3);
                decimal height = reader.GetDecimal(4);
                decimal length = reader.GetDecimal(5);
                reader.Close();
                return new TypeOfElement(id, name, idElementPicture, square, height, length);
            }
            else
            {
                reader.Close();
                throw new Exception("Тип элемента не найден");
            }
        }

        public void UpdateTypeOfElement(TypeOfElement typeOfElement)
        {
            string query =
                $"UPDATE {TypeOfElement.nameTableInDB} SET name = @name, " +
                $"id_element_picture = @id_element_picture, square = @square, " +
                $"height = @height, length = @length WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_element_picture", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@square", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Parameters.Add(
               new NpgsqlParameter("@height", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Parameters.Add(
               new NpgsqlParameter("@length", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = typeOfElement.Name;
            cmd.Parameters[1].Value = typeOfElement.IdElementPicture;
            cmd.Parameters[2].Value = typeOfElement.Square;
            cmd.Parameters[3].Value = typeOfElement.Height;
            cmd.Parameters[4].Value = typeOfElement.Length;
            cmd.Parameters[5].Value = typeOfElement.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteTypeOfElement(int idTypeOfElement)
        {
            DeleteFromTable(TypeOfElement.nameTableInDB, idTypeOfElement);
        }

        public TypeOfElement[] ReadAllTypesOfElement()
        {
            return ReadAllTObjects<TypeOfElement>(TypeOfElement.nameTableInDB, ReadTypeOfElement);
        }

        public void AddTypeOfElementInProject(int idTypeOfElement, int idProject)
        {
            string query = $"INSERT INTO {Project.nameTableInDBTypeOfElementInProject} " +
                $"(id_type_of_element, id_project) VALUES (@id_type_of_element, @id_project);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter(
                "@id_type_of_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idTypeOfElement;
            cmd.Parameters[1].Value = idProject;
            cmd.ExecuteNonQuery();
        }

        public void DeleteTypeOfElementFromProject(int idTypeOfElement, int idProject)
        {
            DeleteFromTableWithParams(Project.nameTableInDBTypeOfElementInProject, 
                "id_type_of_element", idTypeOfElement, "id_project", idProject);
        }

        public TypeOfElement[] ReadTypesOfElementInProject(int idProject)
        {
            return ReadObjectsByEntity<TypeOfElement>(Project.nameTableInDBTypeOfElementInProject, 
                "id_type_of_element", "id_project", idProject, ReadTypeOfElement);
        }

        public void CreateElement(Element element)
        {
            string query =
                $"INSERT INTO {Element.nameTableInDB} " +
                $"(id, id_section_of_building, id_type_of_element, ordinal_nubmer_by_height, " +
                $"ordinal_nubmer_by_width) VALUES " +
                $"(DEFAULT, @id_section_of_building, @id_type_of_element, " +
                $"@ordinal_nubmer_by_height, @ordinal_nubmer_by_width);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_section_of_building", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_type_of_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@ordinal_nubmer_by_height", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@ordinal_nubmer_by_width", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = element.IdSectionOfBuilding;
            cmd.Parameters[1].Value = element.IdTypeOfElement;
            cmd.Parameters[2].Value = element.OrdinalNubmerByHeight;
            cmd.Parameters[3].Value = element.OrdinalNubmerByWidth;
            cmd.ExecuteNonQuery();
        }

        private void CreateVoidElementInTransaction(Element element, NpgsqlTransaction transaction)
        {
            string query =
                $"INSERT INTO {Element.nameTableInDB} " +
                $"(id, id_section_of_building, ordinal_nubmer_by_height, ordinal_nubmer_by_width) " +
                $"VALUES (DEFAULT, @id_section_of_building, " +
                $"@ordinal_nubmer_by_height, @ordinal_nubmer_by_width);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Transaction = transaction;
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_section_of_building", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@ordinal_nubmer_by_height", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@ordinal_nubmer_by_width", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = element.IdSectionOfBuilding;
            cmd.Parameters[1].Value = element.OrdinalNubmerByHeight;
            cmd.Parameters[2].Value = element.OrdinalNubmerByWidth;
            cmd.ExecuteNonQuery();
        }

        public Element ReadElement(int idForSearch)
        {
            var reader = ReadObjectGetReader(Element.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                int idSectionOfBuilding = reader.GetInt32(1);
                int idTypeOfElement = -1;
                if (!DBNull.Value.Equals(reader.GetValue(2))) idTypeOfElement = reader.GetInt32(2);
                int ordinalNubmerByHeight = reader.GetInt32(3);
                int ordinalNubmerByWidth = reader.GetInt32(4);
                reader.Close();
                return new Element(id, idSectionOfBuilding, idTypeOfElement, 
                    ordinalNubmerByHeight, ordinalNubmerByWidth);
            }
            else
            {
                reader.Close();
                throw new Exception("Элемент не найден");
            }
        }

        public void UpdateElement(Element element)
        {
            string query =
                $"UPDATE {Element.nameTableInDB} SET " +
                $"id_section_of_building = @id_section_of_building, " +
                $"id_type_of_element = @id_type_of_element, " +
                $"ordinal_nubmer_by_height = @ordinal_nubmer_by_height, " +
                $"ordinal_nubmer_by_width = @ordinal_nubmer_by_width WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_section_of_building", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_type_of_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@ordinal_nubmer_by_height", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@ordinal_nubmer_by_width", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = element.IdSectionOfBuilding;
            cmd.Parameters[1].Value = element.IdTypeOfElement;
            cmd.Parameters[2].Value = element.OrdinalNubmerByHeight;
            cmd.Parameters[3].Value = element.OrdinalNubmerByWidth;
            cmd.Parameters[4].Value = element.Id;
            cmd.ExecuteNonQuery();
        }

        private void UpdateElementSetIdTypeOfElement(int idElement, int idTypeOfElement, 
            NpgsqlTransaction transaction)
        {
            string query =
                $"UPDATE {Element.nameTableInDB} SET id_type_of_element = @id_type_of_element " +
                $"WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Transaction = transaction;
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_type_of_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idTypeOfElement;
            cmd.Parameters[1].Value = idElement;
            cmd.ExecuteNonQuery();
        }

        public void UpdateVoidElementsSetIdTypeOfElement(Element[][] elements)
        {
            NpgsqlTransaction transaction = Conn.BeginTransaction();
            try
            {
                foreach (Element[] elementsByFloor in elements)
                {
                    foreach (Element element in elementsByFloor)
                    {
                        UpdateElementSetIdTypeOfElement(element.Id, element.IdTypeOfElement, transaction);
                    }
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"Ошибка при проведении транзакции {ex.Message}");
            }
        }

        public void DeleteElement(int idElement)
        {
            DeleteFromTable(Element.nameTableInDB, idElement);
        }

        public Element[] ReadAllElementsFromSectionOfBuilding(int idSectionOfBuilding)
        {
            return ReadAllTObjects<Element>(Element.nameTableInDB, "id_section_of_building", 
                idSectionOfBuilding, ReadElement);
        }

        public Element[] ReadAllElementsFromSectionOfBuildingByFloor(int idSectionOfBuilding, int numberOfFloor)
        {
            string query = $"SELECT id FROM {Element.nameTableInDB} " +
                $"WHERE id_section_of_building = @id_section_of_building AND " +
                $"ordinal_nubmer_by_height = @ordinal_nubmer_by_height " +
                $"ORDER BY ordinal_nubmer_by_width;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter($"@id_section_of_building", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter($"@ordinal_nubmer_by_height", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idSectionOfBuilding;
            cmd.Parameters[1].Value = numberOfFloor;
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return new Element[0];
            }
            List<int> idList = new List<int>();
            while (reader.Read()) idList.Add(reader.GetInt32(0));
            reader.Close();
            Element[] elements = new Element[idList.Count];
            for (int i = 0; i < idList.Count; i++)
                elements[i] = ReadElement(idList[i]);
            return elements;
        }

        public void CreateElementPicture(ElementPicture elementPicture)
        {
            var imageConverter = new ImageConverter();
            byte[] pictureByte =
                (byte[])imageConverter.ConvertTo(elementPicture.Picture, typeof(byte[]));

            string query = 
                $"INSERT INTO {ElementPicture.nameTableInDB} (id, name, picture) VALUES (DEFAULT, @name, @picture);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@picture", NpgsqlTypes.NpgsqlDbType.Bytea));
            cmd.Prepare();
            cmd.Parameters[0].Value = elementPicture.Name;
            cmd.Parameters[1].Value = pictureByte;
            cmd.ExecuteNonQuery();
        }

        public ElementPicture ReadElementPicture(int idForSearch)
        {
            var reader = ReadObjectGetReader(ElementPicture.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                byte[] pictureByte = (byte[])reader.GetValue(2);
                reader.Close();
                Stream stream = new MemoryStream(pictureByte);
                Image picture = Image.FromStream(stream);
                return new ElementPicture(id, name, picture);
            }
            else
            {
                reader.Close();
                throw new Exception("Изображение не найдено");
            }
        }

        public void UpdateElementPicture(ElementPicture elementPicture)
        {
            var imageConverter = new ImageConverter();
            byte[] pictureByte =
                (byte[])imageConverter.ConvertTo(elementPicture.Picture, typeof(byte[]));

            string query =
                $"UPDATE {ElementPicture.nameTableInDB} SET name = @name, " +
                $"picture = @picture WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
              new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@picture", NpgsqlTypes.NpgsqlDbType.Bytea));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = elementPicture.Name;
            cmd.Parameters[1].Value = pictureByte;
            cmd.Parameters[2].Value = elementPicture.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteElementPicture(int idElement)
        {
            DeleteFromTable(ElementPicture.nameTableInDB, idElement);
        }

        public ElementPicture[] ReadAllElementPictures()
        {
            return ReadAllTObjects(ElementPicture.nameTableInDB, ReadElementPicture);
        }

        public ElementPicture GetElementPictureByTypeOfElement(int idTypeOfElement)
        {
            int idPictureElement = (int)ReadValueFromTable("id", "id_element_picture",
                TypeOfElement.nameTableInDB, idTypeOfElement);
            return ReadElementPicture(idPictureElement);
        }



        public int CreateSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            string query =
                $"INSERT INTO {SectionOfBuilding.nameTableInDB} " +
                $"(id, name, id_project, quantity_by_height, quantity_by_width) VALUES " +
                $"(DEFAULT, @name, @id_project, @quantity_by_height, @quantity_by_width) " +
                $"RETURNING id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@quantity_by_height", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@quantity_by_width", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = sectionOfBuilding.Name;
            cmd.Parameters[1].Value = sectionOfBuilding.IdProject;
            cmd.Parameters[2].Value = sectionOfBuilding.QuantityByHeight;
            cmd.Parameters[3].Value = sectionOfBuilding.QuantityByWidth;

            int idSectionOfBuilding = Convert.ToInt32(cmd.ExecuteScalar());
            return idSectionOfBuilding;
        }

        public void CreateSectionOfBuildingWithElements(SectionOfBuilding sectionOfBuilding)
        {
            NpgsqlTransaction transaction = Conn.BeginTransaction();
            string query =
                $"INSERT INTO {SectionOfBuilding.nameTableInDB} " +
                $"(id, name, id_project, quantity_by_height, quantity_by_width) VALUES " +
                $"(DEFAULT, @name, @id_project, @quantity_by_height, @quantity_by_width) " +
                $"RETURNING id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Transaction = transaction;
            cmd.Parameters.Add(
               new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@quantity_by_height", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@quantity_by_width", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = sectionOfBuilding.Name;
            cmd.Parameters[1].Value = sectionOfBuilding.IdProject;
            cmd.Parameters[2].Value = sectionOfBuilding.QuantityByHeight;
            cmd.Parameters[3].Value = sectionOfBuilding.QuantityByWidth;
            try
            {
                int idSectionOfBuilding = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 0; i < sectionOfBuilding.QuantityByHeight; i++)
                {
                    for (int j = 0; j < sectionOfBuilding.QuantityByWidth; j++)
                    {
                        var element = new Element(idSectionOfBuilding, i, j);
                        CreateVoidElementInTransaction(element, transaction);
                    }
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"Ошибка при проведении транзакции {ex.Message}");
            }
        }

        public SectionOfBuilding ReadSectionOfBuilding(int idForSearch)
        {
            var reader = ReadObjectGetReader(SectionOfBuilding.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int idProject = reader.GetInt32(2);
                int quantityByHeight = reader.GetInt32(3);
                int quantityByWidth = reader.GetInt32(4);
                reader.Close();
                return new SectionOfBuilding(
                    id, name, idProject, quantityByHeight, quantityByWidth);
            }
            else
            {
                reader.Close();
                throw new Exception("Здание не найдено");
            }
        }

        public void UpdateSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            string query =
                $"UPDATE {SectionOfBuilding.nameTableInDB} SET name = @name, " +
                $"id_project = @id_project, quantity_by_height = @quantity_by_height, " +
                $"quantity_by_width = @quantity_by_width WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
              new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@quantity_by_height", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@quantity_by_width", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = sectionOfBuilding.Name;
            cmd.Parameters[1].Value = sectionOfBuilding.IdProject;
            cmd.Parameters[2].Value = sectionOfBuilding.QuantityByHeight;
            cmd.Parameters[3].Value = sectionOfBuilding.QuantityByWidth;
            cmd.Parameters[4].Value = sectionOfBuilding.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteSectionOfBuilding(int idSectionOfBuilding)
        {
            DeleteFromTable(SectionOfBuilding.nameTableInDB, idSectionOfBuilding);
        }

        public void DeleteSectionOfBuildingWithElements(int idSectionOfBuilding)
        {
            using (NpgsqlTransaction transaction = Conn.BeginTransaction())
            {
                string query = $"DELETE FROM {SectionOfBuilding.nameTableInDB} WHERE id = @id;";
                var cmd = new NpgsqlCommand(query, Conn);
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Prepare();
                cmd.Parameters[0].Value = idSectionOfBuilding;
                query = $"DELETE FROM {Element.nameTableInDB} WHERE " +
                    $"id_section_of_building = @id_section_of_building;";
                var cmd2 = new NpgsqlCommand(query, Conn);
                cmd2.Transaction = transaction;
                cmd2.Parameters.Add(new NpgsqlParameter(
                    "@id_section_of_building", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd2.Prepare();
                cmd2.Parameters[0].Value = idSectionOfBuilding;
                try
                {
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Ошибка при проведении транзакции {ex.Message}");
                }
            }
        }

        public SectionOfBuilding[] ReadAllSectionsOfBuilding()
        {
            return ReadAllTObjects<SectionOfBuilding>(
                SectionOfBuilding.nameTableInDB, ReadSectionOfBuilding);
        }

        public SectionOfBuilding[] ReadAllSectionsOfBuildingByProject(int idProject)
        {
            return ReadAllTObjects<SectionOfBuilding>(SectionOfBuilding.nameTableInDB, 
                "id_project", idProject, ReadSectionOfBuilding);
        }

        public decimal GetSquareOfSectionOfBuilding(int idSectionOfBuilding)
        {
            string query = $"SELECT SUM(square) FROM {Element.nameTableInDB}, " +
                $"{TypeOfElement.nameTableInDB} WHERE id_type_of_element IS NOT NULL AND " +
                $"id_section_of_building = @id_section_of_building AND " +
                $"id_type_of_element = {TypeOfElement.nameTableInDB}.id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(new NpgsqlParameter(
                    "@id_section_of_building", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idSectionOfBuilding;
            object result = cmd.ExecuteScalar();
            decimal square = -1;
            if (result != null && !DBNull.Value.Equals(result)) square = Convert.ToDecimal(result);
            return square;
        }

        public decimal GetValueByWorkFromSectionOfBuilding(WorkInProject workInProject,
            int idSecionOfBuilding)
        {
            string valueParam = "";
            var typeOfWork = ReadTypeOfWork(workInProject.IdTypeOfWork);
            if (typeOfWork.Dim == Dimension.Piece) valueParam = "1";
            else if (typeOfWork.Dim == Dimension.Length) valueParam = "length";
            else if (typeOfWork.Dim == Dimension.Square) valueParam = "square";
            else if (typeOfWork.Dim == Dimension.Height) valueParam = "height";
            string query =
                $"SELECT SUM({valueParam} * {WorkInProject.nameTableInDB}.multiplicity * " +
                $"{WorkByElement.nameTableInDB}.multiplicity) FROM " +
                $"{TypeOfElement.nameTableInDB}, {Element.nameTableInDB}, " +
                $"{WorkByElement.nameTableInDB}, {WorkInProject.nameTableInDB} WHERE " +
                $"{WorkInProject.nameTableInDB}.id = @id_work_in_project AND " +
                $"{WorkByElement.nameTableInDB}.id_work_in_project = @id_work_in_project AND " +
                $"{Element.nameTableInDB}.id_section_of_building = @id_section_of_building AND " +
                $"{WorkByElement.nameTableInDB}.id_element = {Element.nameTableInDB}.id AND " +
                $"{TypeOfElement.nameTableInDB}.id = {Element.nameTableInDB}.id_type_of_element;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_in_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_section_of_building", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = workInProject.Id;
            cmd.Parameters[1].Value = idSecionOfBuilding;
            object result = cmd.ExecuteScalar();
            if (DBNull.Value.Equals(result)) return -1;
            return Convert.ToDecimal(result);
        }


        public decimal GetAmountByWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            var worksInProject = new WorkInProject[0];
            try
            {
                worksInProject = ReadWorksByProject(sectionOfBuilding.IdProject);
            }
            catch { return -1; }
            if (worksInProject.Length == 0) return 0;
            decimal amount = 0;
            decimal value = 0;
            foreach (WorkInProject work in worksInProject)
            {
                try
                {
                    value = GetValueByWorkFromSectionOfBuilding(work, sectionOfBuilding.Id);
                    if (value == -1) continue;
                    amount += value * (decimal)work.Price;
                }
                catch { return -1; }
            }
            return amount;
        }

        public void CreateWorkByElement(WorkByElement workByElement)
        {
            string query =
                $"INSERT INTO {WorkByElement.nameTableInDB} " +
                $"(id, id_element, id_work_in_project, id_work_state, multiplicity) VALUES " +
                $"(DEFAULT, @id_element, @id_work_in_project, @id_work_state, @multiplicity);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_work_in_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_state", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@multiplicity", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Prepare();
            cmd.Parameters[0].Value = workByElement.IdElement;
            cmd.Parameters[1].Value = workByElement.IdWorkInProject;
            cmd.Parameters[2].Value = (int)workByElement.State;
            cmd.Parameters[3].Value = workByElement.Multiplicity;
            cmd.ExecuteNonQuery();
        }

        private void CreateWorkByElementInTransaction(WorkByElement workByElement, 
            NpgsqlTransaction transaction)
        {
            string query =
                $"INSERT INTO {WorkByElement.nameTableInDB} " +
                $"(id, id_element, id_work_in_project, id_work_state, multiplicity) VALUES " +
                $"(DEFAULT, @id_element, @id_work_in_project, @id_work_state, @multiplicity);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Transaction = transaction;
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_work_in_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_state", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@multiplicity", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Prepare();
            cmd.Parameters[0].Value = workByElement.IdElement;
            cmd.Parameters[1].Value = workByElement.IdWorkInProject;
            cmd.Parameters[2].Value = (int)workByElement.State;
            cmd.Parameters[3].Value = workByElement.Multiplicity;
            cmd.ExecuteNonQuery();
        }

        public void CreateWorkByElements(List<WorkByElement> workByElements)
        {
            NpgsqlTransaction transaction = Conn.BeginTransaction();

            try
            {
                foreach (WorkByElement workByElement in workByElements)
                    CreateWorkByElementInTransaction(workByElement, transaction);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"Ошибка при проведении транзакции {ex.Message}");
            }
        }

        public WorkByElement ReadWorkByElement(int idForSearch)
        {
            var reader = ReadObjectGetReader(WorkByElement.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                int idElement = reader.GetInt32(1);
                int idWorkInProject = reader.GetInt32(2);
                WorkState state = (WorkState)reader.GetInt32(3);
                decimal multiplicity = reader.GetDecimal(4);
                reader.Close();
                return new WorkByElement(id, idElement, idWorkInProject, state, multiplicity);
            }
            else
            {
                reader.Close();
                throw new Exception("Работа по элементу не найдена");
            }
        }

        public void UpdateWorkByElement(WorkByElement workByElement)
        {
            string query =
                $"UPDATE {WorkByElement.nameTableInDB} SET " +
                $"id_element = @id_element, id_work_in_project = @id_work_in_project, " +
                $"id_work_state = @id_work_state, multiplicity = @multiplicity WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_work_in_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_state", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@multiplicity", NpgsqlTypes.NpgsqlDbType.Numeric));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = workByElement.IdElement;
            cmd.Parameters[1].Value = workByElement.IdWorkInProject;
            cmd.Parameters[2].Value = (int)workByElement.State;
            cmd.Parameters[3].Value = workByElement.Multiplicity;
            cmd.Parameters[4].Value = workByElement.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteWorkByElement(int idWork)
        {
            DeleteFromTable(WorkByElement.nameTableInDB, idWork);
        }

        public void DeleteWorkByElements(List<WorkByElement> workByElements2Delete)
        {
            
            NpgsqlTransaction transaction = Conn.BeginTransaction();
            string query =
                $"DELETE FROM {WorkByElement.nameTableInDB} WHERE " +
                $"id_element = @id_element AND id_work_in_project = @id_work_in_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Transaction = transaction;
            try
            {
                foreach (WorkByElement workByElement in workByElements2Delete)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(
                                new NpgsqlParameter("@id_element", NpgsqlTypes.NpgsqlDbType.Integer));
                    cmd.Parameters.Add(
                        new NpgsqlParameter("@id_work_in_project", NpgsqlTypes.NpgsqlDbType.Integer));
                    cmd.Prepare();
                    cmd.Parameters[0].Value = workByElement.IdElement;
                    cmd.Parameters[1].Value = workByElement.IdWorkInProject;
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"Ошибка при проведении транзакции {ex.Message}");
            }
        }

        public void ChangeStateWorkByElementWithTransaction(int idWorkByElement, WorkState state, 
            NpgsqlTransaction transaction)
        {
            string query =
                $"UPDATE {WorkByElement.nameTableInDB} SET id_work_state = @id_work_state " +
                $"WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Transaction = transaction;
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_state", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = (int)state;
            cmd.Parameters[1].Value = idWorkByElement;
            cmd.ExecuteNonQuery();
        }

        public bool HasWorkByElement(int idWorkInProject, int idElement)
        {
            string query =
                $"SELECT COUNT(*) FROM {WorkByElement.nameTableInDB} WHERE " +
                $"id_element = @id_element AND id_work_in_project = @id_work_in_project;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_work_in_project", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = idElement;
            cmd.Parameters[1].Value = idWorkInProject;
            object result = cmd.ExecuteScalar();
            if (Convert.ToInt32(result) > 0) return true;
            return false;
        }

        public void CreateCompletedWorkWithTransaction(CompletedWork completedWork, 
            NpgsqlTransaction transaction)
        {
            string query =
                $"INSERT INTO {CompletedWork.nameTableInDB} " +
                $"(id, id_work_by_element, id_worker, date_of_complete) VALUES " +
                $"(DEFAULT, @id_work_by_element, @id_worker, @date_of_complete);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Transaction = transaction;
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_by_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_worker", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@date_of_complete", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Prepare();
            cmd.Parameters[0].Value = completedWork.IdWorkByElement;
            cmd.Parameters[1].Value = completedWork.IdWorker;
            cmd.Parameters[2].Value = completedWork.DateOfComplete;
            try
            {
                cmd.ExecuteNonQuery();
                ChangeStateWorkByElementWithTransaction(completedWork.IdWorkByElement, 
                    WorkState.Completed, transaction);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"Ошибка при проведении транзакции {ex.Message}");
            }
        }

        public void CreateCompletedWork(CompletedWork completedWork)
        {
            string query =
                $"INSERT INTO {CompletedWork.nameTableInDB} " +
                $"(id, id_work_by_element, id_worker, date_of_complete, reject) VALUES " +
                $"(DEFAULT, @id_work_by_element, @id_worker, @date_of_complete, @reject);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_by_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_worker", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@date_of_complete", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(
               new NpgsqlParameter("@reject", NpgsqlTypes.NpgsqlDbType.Boolean));
            cmd.Prepare();
            cmd.Parameters[0].Value = completedWork.IdWorkByElement;
            cmd.Parameters[1].Value = completedWork.IdWorker;
            cmd.Parameters[2].Value = completedWork.DateOfComplete;
            cmd.Parameters[3].Value = completedWork.Reject;
            cmd.ExecuteNonQuery();
        }

        public CompletedWork ReadCompletedWork(int idForSearch)
        {
            var reader = ReadObjectGetReader(CompletedWork.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                int idWorkByElement = reader.GetInt32(1);
                int idWorker = reader.GetInt32(2);
                DateTime dateOfComplete = (DateTime)reader.GetDate(3);
                bool reject = reader.GetBoolean(4);
                reader.Close();
                return new CompletedWork(id, idWorkByElement, idWorker, dateOfComplete, reject);
            }
            else
            {
                reader.Close();
                throw new Exception("Выполненная работа не найдена");
            }
        }

        public void UpdateCompletedWork(CompletedWork completedWork)
        {
            string query =
               $"UPDATE {CompletedWork.nameTableInDB} SET " +
               $"id_work_by_element = @id_work_by_element, id_worker = @id_worker, " +
               $"date_of_complete = @date_of_complete, reject = @reject WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_by_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_worker", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@date_of_complete", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(
               new NpgsqlParameter("@reject", NpgsqlTypes.NpgsqlDbType.Boolean));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = completedWork.IdWorkByElement;
            cmd.Parameters[1].Value = completedWork.IdWorker;
            cmd.Parameters[2].Value = completedWork.DateOfComplete;
            cmd.Parameters[3].Value = completedWork.Reject;
            cmd.Parameters[4].Value = completedWork.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteCompletedWork(int idCompletedWork)
        {
            DeleteFromTable(CompletedWork.nameTableInDB, idCompletedWork);
        }

        public void CreateAcceptedWork(AcceptedWork acceptedWork)
        {
            string query =
                $"INSERT INTO {AcceptedWork.nameTableInDB} " +
                $"(id, id_work_by_element, id_manager, date_of_accept) VALUES " +
                $"(DEFAULT, @id_work_by_element, @id_worker, @date_of_accept);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_by_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_manager", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@date_of_accept", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Prepare();
            cmd.Parameters[0].Value = acceptedWork.IdWorkByElement;
            cmd.Parameters[1].Value = acceptedWork.IdManager;
            cmd.Parameters[2].Value = acceptedWork.DateOfAccept;
            cmd.ExecuteNonQuery();
        }

        public AcceptedWork ReadAcceptedWork(int idForSearch)
        {
            var reader = ReadObjectGetReader(AcceptedWork.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                int idWorkByElement = reader.GetInt32(1);
                int idManager = reader.GetInt32(2);
                DateTime dateOfAccept = (DateTime)reader.GetDate(3);
                reader.Close();
                return new AcceptedWork(id, idWorkByElement, idManager, dateOfAccept);
            }
            else
            {
                reader.Close();
                throw new Exception("Принятая работа не найдена");
            }
        }

        public void UpdateAcceptedWork(AcceptedWork acceptedWork)
        {
            string query =
               $"UPDATE {AcceptedWork.nameTableInDB} SET " +
               $"id_work_by_element = @id_work_by_element, id_manager = @id_manager, " +
               $"date_of_accept = @date_of_accept WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_by_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_manager", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@date_of_accept", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = acceptedWork.IdWorkByElement;
            cmd.Parameters[1].Value = acceptedWork.IdManager;
            cmd.Parameters[2].Value = acceptedWork.DateOfAccept;
            cmd.Parameters[3].Value = acceptedWork.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteAcceptedWork(int idCompletedWork)
        {
            DeleteFromTable(AcceptedWork.nameTableInDB, idCompletedWork);
        }

        public void CreateRejectedWork(RejectedWork rejectedWork)
        {
            string query =
                $"INSERT INTO {RejectedWork.nameTableInDB} (id, id_work_by_element, id_manager, " +
                $"date_of_reject, comment, rectify) VALUES (DEFAULT, @id_work_by_element, " +
                $"@id_worker, @date_of_reject, @comment, @rectify);";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_by_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_manager", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@date_of_reject", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(
              new NpgsqlParameter("@comment", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
              new NpgsqlParameter("@rectify", NpgsqlTypes.NpgsqlDbType.Boolean));
            cmd.Prepare();
            cmd.Parameters[0].Value = rejectedWork.IdWorkByElement;
            cmd.Parameters[1].Value = rejectedWork.IdManager;
            cmd.Parameters[2].Value = rejectedWork.DateOfReject;
            cmd.Parameters[3].Value = rejectedWork.Comment;
            cmd.Parameters[4].Value = rejectedWork.Rectify;
            cmd.ExecuteNonQuery();
        }

        public RejectedWork ReadRejectedWork(int idForSearch)
        {
            var reader = ReadObjectGetReader(RejectedWork.nameTableInDB, idForSearch);
            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                int idWorkByElement = reader.GetInt32(1);
                int idManager = reader.GetInt32(2);
                DateTime dateOfReject = (DateTime)reader.GetDate(3);
                string comment = reader.GetString(4);
                bool rectify = reader.GetBoolean(5);
                reader.Close();
                return new RejectedWork(
                    id, idWorkByElement, idManager, dateOfReject, comment, rectify);
            }
            else
            {
                reader.Close();
                throw new Exception("Отказ в работе не найден");
            }
        }

        public void UpdateRejectedWork(RejectedWork rejectedWork)
        {
            string query =
               $"UPDATE {RejectedWork.nameTableInDB} SET id_work_by_element = " +
               $"@id_work_by_element, id_manager = @id_manager, date_of_reject = " +
               $"@date_of_reject, comment = @comment, rectify = @rectify WHERE id = @id;";
            var cmd = new NpgsqlCommand(query, Conn);
            cmd.Parameters.Add(
               new NpgsqlParameter("@id_work_by_element", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id_manager", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(
               new NpgsqlParameter("@date_of_reject", NpgsqlTypes.NpgsqlDbType.Date));
            cmd.Parameters.Add(
              new NpgsqlParameter("@comment", NpgsqlTypes.NpgsqlDbType.Varchar));
            cmd.Parameters.Add(
              new NpgsqlParameter("@rectify", NpgsqlTypes.NpgsqlDbType.Boolean));
            cmd.Parameters.Add(
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Prepare();
            cmd.Parameters[0].Value = rejectedWork.IdWorkByElement;
            cmd.Parameters[1].Value = rejectedWork.IdManager;
            cmd.Parameters[2].Value = rejectedWork.DateOfReject;
            cmd.Parameters[3].Value = rejectedWork.Comment;
            cmd.Parameters[4].Value = rejectedWork.Rectify;
            cmd.Parameters[5].Value = rejectedWork.Id;
            cmd.ExecuteNonQuery();
        }

        public void DeleteRejectedWork(int idRejectedWork)
        {
            DeleteFromTable(RejectedWork.nameTableInDB, idRejectedWork);
        }
    }

}
