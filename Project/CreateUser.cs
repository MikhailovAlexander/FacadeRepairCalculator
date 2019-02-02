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
        public CreateUser(User user, IDriverDB driver)
        {
            if(!user.ManagerAccess)
            {
                MessageBox.Show("Создание новых пользователей возможно только менеджером", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            this.driver = driver;
            InitializeComponent();
            //if (textBoxPasswordRepeat.Text.Equals(textBoxUserPassword.Text)&& !string.IsNullOrWhiteSpace(textBoxUserPassword.Text))
            //    this.buttonSaveUser.Enabled = true;


            //User u = new User("Михайлов Александр Витальевич", "5900 №123456", "vestroy@gmail.com", true);
            //User u = driver.ReadUser("vestroy@gmail.com");
            //MessageBox.Show(u.ToString(), "Данные пользователя");
            //u.SaveTo(driver);
            //u.SetHashPasword("topsecret");
            //u.Update(driver);
            //MessageBox.Show(u.ToString(), "Данные пользователя");
        }
        private void ButtonSaveUser_Click(object sender, EventArgs e)
        {
            string name = textBoxUserNameInput.Text;
            string passport = textBoxUserPassport.Text;
            string login = textBoxUserLogin.Text;
            bool managerAccess = checkBoxManagerAccess.Checked;
            var hashPass = new HashPasswordCreator(textBoxUserPassword.Text);
            string hashPassword = hashPass.GetHashToString();
            string salt = hashPass.GetSaltToString();
            User userToSave = new User(name, passport, login, hashPassword, managerAccess, salt);//try catch???
            driver.SaveUser(userToSave);
        }

        private void TextBoxUserPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserPassword.Text))
            {
                this.textBoxPasswordRepeat.Enabled = false;
            }
            else
            {
                this.textBoxPasswordRepeat.Enabled = true;
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

        private void textBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxPasswordRepeat.Text.Equals(textBoxUserPassword.Text))
            {
                textBoxPasswordRepeat.BackColor = Color.Red;
                this.LabelPasswordsIsNotEuals.Visible = true;
                this.buttonSaveUser.Enabled = false;
            }
            else
            {
                textBoxPasswordRepeat.BackColor = Color.White;
                this.LabelPasswordsIsNotEuals.Visible = false;
                this.buttonSaveUser.Enabled = true;
            }
        }
    }
}
