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
    public partial class MainForm : Form
    {
        IDriverDB driver;
        public User actualUser;

        public MainForm(IDriverDB driver)
        {
            InitializeComponent();
            this.driver = driver;
            actualUser = new User();
            var entryForm = new Entry(driver, this);
            Application.Run(entryForm);
            try
            {
                actualUser = (User)this.Tag;
            }
            catch
            {
                MessageBox.Show("Ошибка! Вход в систему не возможен", "Сообщение об ошибке", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if (actualUser.ManagerAccess)
            {
                addNewUserToolStripMenuItem.Enabled = true;
                allUsersToolStripMenuItem.Enabled = true;
            }
            //MessageBox.Show($"##Пользователь {actualUser.Name}. Вход в систему");
        }

        private void AllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm(driver, actualUser)
            { Owner = this };
            try { usersForm.Show(); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Формирование фиктивной формы для вызова createUserForm
            var usersForm = new UsersForm(driver, actualUser);
            var createUserForm = new CreateUser(actualUser, driver, usersForm)
            { Owner = this };
            createUserForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changePasswordForm = new ChangePasswordForm(actualUser, driver)
            { Owner = this };
            changePasswordForm.Show();
        }

        private void CreateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createProjectForm = new CreateProjectForm(driver, actualUser);
            createProjectForm.Show();
        }
    }
}
