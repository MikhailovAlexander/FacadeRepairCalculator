using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UsersForm : Form
    {
        IDriverDB driver;
        public User actualUser;
        public User[] allUsers;

        public UsersForm(IDriverDB driver, User actualUser)
        {
            if (!actualUser.ManagerAccess)
            {
                MessageBox.Show("Операции с данными пользователей доступны только менеджеру", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            InitializeComponent();
            this.driver = driver;
            this.actualUser = actualUser;
            if (actualUser.ManagerAccess) this.buttonAddUser.Enabled = true;
            //MessageBox.Show($"##Пользователь {actualUser.Name}. Вход в систему");//##
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.allUsers = driver.ReadAllUsers();
                foreach (User user in allUsers)
                {
                    string managerAccess;
                    if (user.ManagerAccess) managerAccess = "Да";
                    else managerAccess = "Нет";
                    dataGridView1.Rows.Add(user.Name, user.Passport, user.Login, managerAccess);
                }
            }
            catch (Exception ex)
            {
                allUsers = new User[0];
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       public void UsersForm_ReLoad()
        {
            try
            {
                this.allUsers = driver.ReadAllUsers();
                foreach (User user in allUsers)
                {
                    string managerAccess;
                    if (user.ManagerAccess) managerAccess = "Да";
                    else managerAccess = "Нет";
                    dataGridView1.Rows.Add(user.Name, user.Passport, user.Login, managerAccess);
                }
            }
            catch (Exception ex)
            {
                allUsers = new User[0];
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            CreateUser createUserForm = new CreateUser(actualUser, driver, this);
            createUserForm.Show();
        }
    }
}
