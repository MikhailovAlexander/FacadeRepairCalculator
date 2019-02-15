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
            Image checkMark = Image.FromFile(@"C:\Users\vestr\source\repos\Project\Project\checkMark.png");
            this.pictureBoxCheckMarkName.Image = checkMark;
            this.pictureBoxCheckMarkPassport.Image = checkMark;
            this.pictureBoxCheckMarkLogin.Image = checkMark;
            this.pictureBoxCheckMarkPassword.Image = checkMark;
            this.pictureBoxRepeatMarkPassword.Image = checkMark;
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
                var hashPass = new HashPasswordCreator(textBoxUserPasswordInput.Text);
                string hashPassword = hashPass.GetHashToString();
                string salt = hashPass.GetSaltToString();
                driver.SaveUser(new User(name, passport, login, hashPassword, managerAccess, salt));
                usersForm.UsersForm_ReLoad();
                this.Close();
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно", 
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TextBoxUserPassword_TextChanged(object sender, EventArgs e)
        {
            this.textBoxPasswordRepeatInput.Enabled = User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text);
            this.labelPasswordCheck.Visible=!User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text);
            this.pictureBoxCheckMarkPassword.Visible = User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text);
            this.LabelPasswordsIsNotEuals.Visible = this.textBoxPasswordRepeatInput.Enabled && 
                !textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
            if (!User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text))
                textBoxPasswordRepeatInput.Text = "";
        }

        private void TextBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            this.LabelPasswordsIsNotEuals.Visible = 
                !textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
            this.pictureBoxRepeatMarkPassword.Visible = 
                textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
        }

        private void TextBoxUserNameInput_TextChanged(object sender, EventArgs e)
        {
            this.pictureBoxCheckMarkName.Visible = User.nameRegex.IsMatch(textBoxUserNameInput.Text);
            this.labelNameCheck.Visible=!User.nameRegex.IsMatch(textBoxUserNameInput.Text);
        }

        private void TextBoxUserPassport_TextChanged(object sender, EventArgs e)
        {
            this.pictureBoxCheckMarkPassport.Visible = User.passportRegex.IsMatch(textBoxUserPassportInput.Text);
            this.labelPassportCheck.Visible = !User.passportRegex.IsMatch(textBoxUserPassportInput.Text);
        }

        private void TextBoxUserLogin_TextChanged(object sender, EventArgs e)
        {
            this.pictureBoxCheckMarkLogin.Visible = User.loginRegex.IsMatch(textBoxUserLoginInput.Text);
            this.labelLoginCheck.Visible = !User.loginRegex.IsMatch(textBoxUserLoginInput.Text);
        }
    }
}
