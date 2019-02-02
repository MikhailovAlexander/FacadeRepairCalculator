using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                MessageBox.Show("Создание новых пользователей возможно только менеджером", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            this.driver = driver;
            this.usersForm = usersForm;
            InitializeComponent();
            Image checkMark = Image.FromFile(@"C:\Users\vestr\source\repos\Project\Project\checkMark.png");
            this.pictureBoxCheckName.Image = checkMark;
            this.pictureBoxCheckPassport.Image = checkMark;
            this.pictureBoxCheckLogin.Image = checkMark;
            this.pictureBoxCheckPassword.Image = checkMark;
            this.pictureBoxRepeatPassword.Image = checkMark;
        }
    

            //if (textBoxPasswordRepeat.Text.Equals(textBoxUserPassword.Text)&& !string.IsNullOrWhiteSpace(textBoxUserPassword.Text))
            //    this.buttonSaveUser.Enabled = true;


            //User u = new User("Михайлов Александр Витальевич", "5900 №123456", "vestroy@gmail.com", true);
            //User u = driver.ReadUser("vestroy@gmail.com");
            //MessageBox.Show(u.ToString(), "Данные пользователя");
            //u.SaveTo(driver);
            //u.SetHashPasword("topsecret");
            //u.Update(driver);
            //MessageBox.Show(u.ToString(), "Данные пользователя");
        
        private void ButtonSaveUser_Click(object sender, EventArgs e)
        {
            string name = textBoxUserNameInput.Text;
            string passport = textBoxUserPassport.Text;
            string login = textBoxUserLogin.Text;
            bool managerAccess = checkBoxManagerAccess.Checked;
            var hashPass = new HashPasswordCreator(textBoxUserPassword.Text);
            string hashPassword = hashPass.GetHashToString();
            string salt = hashPass.GetSaltToString();
            User userToSave = new User(name, passport, login, hashPassword, managerAccess, salt);
            driver.SaveUser(userToSave);
            usersForm.UsersForm_ReLoad();
            this.Close();
        }

        private void TextBoxUserPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserPassword.Text))
            {
                this.textBoxPasswordRepeat.Enabled = false;
                this.pictureBoxCheckPassword.Visible = false;
            }
            else
            {
                this.textBoxPasswordRepeat.Enabled = true;
                this.pictureBoxCheckPassword.Visible = true;
                if (!textBoxPasswordRepeat.Text.Equals(textBoxUserPassword.Text))
                {
                    this.LabelPasswordsIsNotEuals.Visible = true;
                    textBoxPasswordRepeat.BackColor = Color.Red;
                    this.buttonSaveUser.Enabled = false;
                }
                else
                {
                    this.LabelPasswordsIsNotEuals.Visible = false;
                    textBoxPasswordRepeat.BackColor = Color.White;
                    this.buttonSaveUser.Enabled = true;
                }
            }

        }

        private void TextBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxPasswordRepeat.Text.Equals(textBoxUserPassword.Text))
            {
                textBoxPasswordRepeat.BackColor = Color.Red;
                this.LabelPasswordsIsNotEuals.Visible = true;
                this.buttonSaveUser.Enabled = false;
                this.pictureBoxRepeatPassword.Visible = false;
            }
            else
            {
                textBoxPasswordRepeat.BackColor = Color.White;
                this.LabelPasswordsIsNotEuals.Visible = false;
                this.buttonSaveUser.Enabled = true;
                this.pictureBoxRepeatPassword.Visible = true;
            }
        }

        private void TextBoxUserNameInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserNameInput.Text))
            {
                this.pictureBoxCheckName.Visible = false;
            }
            else this.pictureBoxCheckName.Visible = true;
        }

        private void TextBoxUserPassport_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserPassport.Text))
            {
                this.pictureBoxCheckPassport.Visible = false;
            }
            else this.pictureBoxCheckPassport.Visible = true;
        }

        private void TextBoxUserLogin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserLogin.Text))
            {
                this.pictureBoxCheckLogin.Visible = false;
            }
            else this.pictureBoxCheckLogin.Visible = true;
        }
    }
}
