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
        IDriverDB driver;
        public Entry(IDriverDB driver)
        {
            InitializeComponent();
            this.driver = driver;
        }

        private void ButtonPasswordForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь к менеджеру для получения нового пароля", "Очень жаль", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
                this.buttonEntry.Enabled = true;
            else this.buttonEntry.Enabled = false;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
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
                var passCheck = new HashPasswordCreator(inputPassword);
                if (passCheck.VeryfyHash(checkUser.HashPassword, checkUser.SaltString))
                {
                    MessageBox.Show(checkUser.Name, "Проверка пройдена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm(driver, checkUser);
                    mainForm.Show();
                    //this.Visible=false;
                    //if (mainForm.IsDisposed) this.Close(); 
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
