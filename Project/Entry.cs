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
    public partial class Entry : Form
    {
        private IDriverDB driver;
        private IHashPasswordCreator hashPasswordCreator;
        public User actualUser;

        public Entry(IDriverDB driver, IHashPasswordCreator hashPasswordCreator)
        {
            InitializeComponent();
            this.driver = driver;
            this.hashPasswordCreator = hashPasswordCreator;
            actualUser = new User();
        }

        private void ButtonPasswordForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь к менеджеру для получения нового пароля", "Очень жаль", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && 
                !string.IsNullOrWhiteSpace(textBoxPassword.Text))
                this.buttonEntry.Enabled = true;
            else this.buttonEntry.Enabled = false;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && 
                !string.IsNullOrWhiteSpace(textBoxPassword.Text))
                this.buttonEntry.Enabled = true;
            else this.buttonEntry.Enabled = false;
        }

        private void ButtonEntry_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string inputPassword = textBoxPassword.Text;
            User checkUser;
            try
            {
                checkUser = driver.ReadUser(login);
                if (checkUser.CheckPassword(inputPassword, hashPasswordCreator))
                {
                    MessageBox.Show(checkUser.Name, "Проверка пройдена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualUser = checkUser;
                    this.Close(); 
                }
                else MessageBox.Show("Проверка не пройдена", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
