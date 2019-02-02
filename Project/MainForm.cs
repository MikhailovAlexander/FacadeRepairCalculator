using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Необходимо вынести работу с пользователями на отдельную форму, оставив на данной лишь кнопку для работы с данными пользователями
namespace Project
{
    public partial class MainForm : Form
    {
        IDriverDB driver;
        public User actualUser;
        public User[] allUsers;

        public MainForm(IDriverDB driver, User actualUser)
        {
            InitializeComponent();
            this.driver = driver;
            this.actualUser = actualUser;
            if (actualUser.ManagerAccess) this.menuStrip1.Enabled = true;
            MessageBox.Show($"##Пользователь {actualUser.Name}. Вход в систему");//##
        }

        private void AllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(driver, actualUser);
            try { usersForm.Show(); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(driver, actualUser);//Формирование фиктивной формы для вызова createUserForm
            CreateUser createUserForm = new CreateUser(actualUser, driver, usersForm);//
            createUserForm.Show();
        }
    }
}
