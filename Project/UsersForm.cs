using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Сделать удаление
//Доделать обновление 

namespace Project
{
    public partial class UsersForm : Form
    {
        IDriverDB driver;
        public User actualUser;
        public User[] allUsers;
        public User selectedUser;

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
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                allUsers = driver.ReadAllUsers();
                dataGridView1.Height = dataGridView1.ColumnHeadersHeight + dataGridView1.RowTemplate.Height * allUsers.Length+3;
                //Счетчик инкрементирован для отображения пользователю 
                int i = 1;
                foreach (User user in allUsers)
                {
                    dataGridView1.Rows.Add(i++, user.Name, user.Passport, user.Login, (user.ManagerAccess) ? "Да" : "Нет");
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
                dataGridView1.Rows.Clear();
                dataGridView1.Height = dataGridView1.ColumnHeadersHeight + dataGridView1.RowTemplate.Height * allUsers.Length + 3;
                //Счетчик инкрементирован для отображения пользователю 
                int i = 1;
                foreach (User user in allUsers)
                {
                    dataGridView1.Rows.Add(i++, user.Name, user.Passport, user.Login, (user.ManagerAccess) ? "Да" : "Нет");
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

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            //Декрементация индекса для обращения к массиву
            int userToUpdateIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) - 1;
            UpdateUserForm updateUser = new UpdateUserForm(driver, actualUser, allUsers[userToUpdateIndex], this);
            updateUser.Show();
        }
    }
}
