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
    public partial class ChangePasswordForm : Form
    {
        IDriverDB driver;
        User actualUser;

        public ChangePasswordForm(User actualUser, IDriverDB driver)
        {
            this.actualUser = actualUser;
            this.driver = driver;
            InitializeComponent();
            labelNameUser.Text = actualUser.Name;
            Image checkMark = Image.FromFile(
                @"C:\Users\vestr\source\repos\Project\Project\checkMark.png");
            pictureBoxCheckMarkPassword.Image = checkMark;
            pictureBoxRepeatMarkPassword.Image = checkMark;
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            if (User.passwordRegex.IsMatch(textBoxUserPasswordInput.Text)
                && textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text))
            {
                try
                {
                    actualUser.ChangePassword(textBoxUserPasswordInput.Text);
                    actualUser.Update(driver);
                    MessageBox.Show($"Пароль пользователя {actualUser.Name} изменен", "Сообщение",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные пользователя {actualUser.Name} не были сохранены. " 
                        + ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void TextBoxUserPasswordInput_TextChanged(object sender, EventArgs e)
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

        private void TextBoxPasswordRepeatInput_TextChanged(object sender, EventArgs e)
        {
            labelPasswordsIsNotEuals.Visible =
                !textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
            pictureBoxRepeatMarkPassword.Visible =
                textBoxPasswordRepeatInput.Text.Equals(textBoxUserPasswordInput.Text);
        }
    }
}
