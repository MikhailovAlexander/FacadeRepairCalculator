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
    //Смена пароля добавить форму
    public partial class MainForm : Form
    {
        IDriverDB driver;
        public User actualUser;

        public MainForm(IDriverDB driver)
        {
            InitializeComponent();
            this.driver = driver;
            Entry entryForm = new Entry(driver, this);
            Application.Run(entryForm);
            try
            {
                this.actualUser = (User)this.Tag;
            }
            catch
            {
                MessageBox.Show("Ошибка! Вход в систему не возможен", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
