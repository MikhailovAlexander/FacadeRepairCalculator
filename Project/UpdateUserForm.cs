using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Доделать смену пароля отдельно
namespace Project
{
    public partial class UpdateUserForm : Form
    {
        User actualUser;
        User userToUpdate;
        IDriverDB driver;
        UsersForm usersForm;

        public UpdateUserForm(IDriverDB driver, User actualUser, User userToUpdate, UsersForm usersForm)
        {
            this.actualUser = actualUser;
            if (!actualUser.ManagerAccess)
            {
                MessageBox.Show("Операции с данными пользователей доступны только менеджеру", 
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            this.driver = driver;
            this.userToUpdate = userToUpdate;
            this.usersForm = usersForm;
            InitializeComponent();
            Image checkMark = Image.FromFile(@"C:\Users\vestr\source\repos\Project\Project\checkMark.png");
            pictureBoxCheckMarkName.Image = checkMark;
            pictureBoxCheckMarkPassport.Image = checkMark;
            pictureBoxCheckMarkLogin.Image = checkMark;
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            textBoxUserNameInput.Text = userToUpdate.Name;
            textBoxUserPassportInput.Text = userToUpdate.Passport;
            textBoxUserLoginInput.Text = userToUpdate.Login;
            checkBoxManagerAccess.Checked = userToUpdate.ManagerAccess;
        }


        private void textBoxUserNameInput_TextChanged(object sender, EventArgs e)
        {
            pictureBoxCheckMarkName.Visible = User.nameRegex.IsMatch(textBoxUserNameInput.Text);
            labelNameCheck.Visible=!User.nameRegex.IsMatch(textBoxUserNameInput.Text);
        }

        private void textBoxUserPassportInput_TextChanged(object sender, EventArgs e)
        {
            pictureBoxCheckMarkPassport.Visible = User.passportRegex.IsMatch(textBoxUserPassportInput.Text);
            labelPassportCheck.Visible=!User.passportRegex.IsMatch(textBoxUserPassportInput.Text);
        }

        private void textBoxUserLoginInput_TextChanged(object sender, EventArgs e)
        {
            pictureBoxCheckMarkLogin.Visible = User.loginRegex.IsMatch(textBoxUserLoginInput.Text);
            labelLoginCheck.Visible=!User.loginRegex.IsMatch(textBoxUserLoginInput.Text);
        }

        private void ButtonSaveUser_Click(object sender, EventArgs e)
        {
            if (User.nameRegex.IsMatch(textBoxUserNameInput.Text)
               && User.passportRegex.IsMatch(textBoxUserPassportInput.Text)
               && User.loginRegex.IsMatch(textBoxUserLoginInput.Text))
            {
                try
                {
                    userToUpdate.Name = textBoxUserNameInput.Text;
                    userToUpdate.Passport = textBoxUserPassportInput.Text;
                    userToUpdate.Login = textBoxUserLoginInput.Text;
                    userToUpdate.ManagerAccess = checkBoxManagerAccess.Checked;
                    driver.UpdateUser(userToUpdate);
                    usersForm.UsersForm_ReLoad();
                    MessageBox.Show($"Данные пользователя {userToUpdate.Name} обновлены",
                    "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
