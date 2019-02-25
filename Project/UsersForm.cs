using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO change password

namespace Project
{
    public partial class UsersForm : Form
    {
        IDriverDB driver;
        public User actualUser;
        public User[] allUsers;
        public Project actualProject;

        public UsersForm(IDriverDB driver, User actualUser)
        {
            if (!actualUser.ManagerAccess)
            {
                MessageBox.Show("Операции с данными пользователей доступны только менеджеру", 
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            InitializeComponent();
            this.driver = driver;
            this.actualUser = actualUser;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                allUsers = driver.ReadAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            dataGridView1.Height = dataGridView1.ColumnHeadersHeight + 
                    dataGridView1.RowTemplate.Height * allUsers.Length+3;
            Height = dataGridView1.Height + buttonAddUser.Height + 100;
            //Счетчик инкрементирован для отображения пользователю 
            int i = 1;
            foreach (User user in allUsers)
            {
                dataGridView1.Rows.Add(i++, user.Name, user.Passport, user.Login, 
                    (user.ManagerAccess) ? "Да" : "Нет");
            }
        }

        public void UsersForm_ReLoad()
        {
            try
            {
                this.allUsers = driver.ReadAllUsers();
                dataGridView1.Rows.Clear();
                dataGridView1.Height = dataGridView1.ColumnHeadersHeight 
                    + dataGridView1.RowTemplate.Height * allUsers.Length + 3;
                //Счетчик инкрементирован для отображения пользователю 
                int i = 1;
                foreach (User user in allUsers)
                {
                    dataGridView1.Rows.Add(i++, user.Name, user.Passport, user.Login, 
                        (user.ManagerAccess) ? "Да" : "Нет");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private User SelectedUser()
        {
            //Декрементация индекса для обращения к массиву
            int selectedUserIndex =
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) - 1;
            return allUsers[selectedUserIndex];
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            var createUserForm = new CreateUser(actualUser, driver, this);
            createUserForm.Show();
        }

        private void ButtonUpdateUser_Click(object sender, EventArgs e)
        {
            var updateUserForm = new UpdateUserForm(driver, actualUser, SelectedUser(), this);
            updateUserForm.Show();
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ($"Вы действительно хотите безвозвратно удалить пользователя?" +
                $"{SelectedUser().Name}", "Удаление пользователя", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    driver.DeleteUser(SelectedUser().Id);
                    MessageBox.Show($"Пользователь {SelectedUser().Name} удален",
                        "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsersForm_ReLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonChangeUserPassword_Click(object sender, EventArgs e)
        {
            var ChangePasswordForm = new ChangePasswordForm(SelectedUser(), driver);
            ChangePasswordForm.Show();
        }

        public void AddUserInProjectForm(Project actualProject)
        {
            this.actualProject = actualProject;
            buttonAddUser.Visible = false;
            buttonChangeUserPassword.Visible = false;
            buttonDeleteUser.Visible = false;
            buttonUpdateUser.Visible = false;
            buttonAddUserInProject.Visible = true;
        }

        private void ButtonAddUserInProject_Click(object sender, EventArgs e)
        {
            if(actualProject != null&&SelectedUser() != null)
            {
                try
                {
                    driver.AddUserToProject(SelectedUser().Id, actualProject.Id);
                    MessageBox.Show($"Пользователь {SelectedUser().Name} добавлен в проект " +
                        $"{actualProject.Name}", "Сообщение",MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
