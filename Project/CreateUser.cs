using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Project
{
    public partial class CreateUser : Form
    {
        IDriverDB driver;
        UsersForm usersForm;

        public CreateUser(User user, IDriverDB driver, UsersForm usersForm)
        {
            if (!user.ManagerAccess)
            {
                MessageBox.Show("Создание новых пользователей возможно только менеджером", 
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            this.driver = driver;
            this.usersForm = usersForm;
            InitializeComponent();
            Image checkMark = Image.FromFile(
                @"C:\Users\vestr\source\repos\Project\Project\checkMark.png");
            pictureBoxCheckMarkName.Image = checkMark;
            pictureBoxCheckMarkPassport.Image = checkMark;
            pictureBoxCheckMarkLogin.Image = checkMark;
            pictureBoxCheckMarkPassword.Image = checkMark;
            pictureBoxRepeatMarkPassword.Image = checkMark;
        }
        
        private void ButtonSaveUser_Click(object sender, EventArgs e)
        {
            if (User.nameRegex.IsMatch(textBoxUserNameInput.Text) 
                && User.passportRegex.IsMatch(textBoxUserPassportInput.Text)
                && User.loginRegex.IsMatch(textBoxUserLoginInput.Text) 
                && User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text)
                && textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text))
            {
                string name = textBoxUserNameInput.Text;
                string passport = textBoxUserPassportInput.Text;
                string login = textBoxUserLoginInput.Text;
                bool managerAccess = checkBoxManagerAccess.Checked;
                var hashPassGen = new HashPasswordCreator(textBoxUserPasswordInput.Text);
                string hashPassword = hashPassGen.GetHashToString();
                string salt = hashPassGen.GetSaltToString();
                try
                {
                    driver.CreateUser(new User(name, passport, login, hashPassword, managerAccess,
                                               salt));
                    MessageBox.Show($"Данные пользователя {name} сохранены", "Сообщение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usersForm.UsersForm_ReLoad();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Данные пользователя {name} не были сохранены. " + ex.Message,
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно", 
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TextBoxUserPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPasswordRepeatInput.Enabled = 
                User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text);
            labelPasswordCheck.Visible = 
                !User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text);
            pictureBoxCheckMarkPassword.Visible = 
                User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text);
            labelPasswordsIsNotEuals.Visible = textBoxPasswordRepeatInput.Enabled && 
                !textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
            if (!User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text))
                textBoxPasswordRepeatInput.Text = "";
        }

        private void TextBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            labelPasswordsIsNotEuals.Visible = 
                !textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
            pictureBoxRepeatMarkPassword.Visible = 
                textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
        }

        private void TextBoxUserNameInput_TextChanged(object sender, EventArgs e)
        {
            pictureBoxCheckMarkName.Visible = User.nameRegex.IsMatch(textBoxUserNameInput.Text);
            labelNameCheck.Visible=!User.nameRegex.IsMatch(textBoxUserNameInput.Text);
        }

        private void TextBoxUserPassport_TextChanged(object sender, EventArgs e)
        {
            pictureBoxCheckMarkPassport.Visible = 
                User.passportRegex.IsMatch(textBoxUserPassportInput.Text);
            labelPassportCheck.Visible = 
                !User.passportRegex.IsMatch(textBoxUserPassportInput.Text);
        }

        private void TextBoxUserLogin_TextChanged(object sender, EventArgs e)
        {
            pictureBoxCheckMarkLogin.Visible = User.loginRegex.IsMatch(textBoxUserLoginInput.Text);
            labelLoginCheck.Visible = !User.loginRegex.IsMatch(textBoxUserLoginInput.Text);
        }

    }
}
