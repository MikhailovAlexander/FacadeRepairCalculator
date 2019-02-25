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
    public partial class CreateProjectForm : Form
    {
        IDriverDB driver;
        User actualUser;
        Project actualProject;

        public CreateProjectForm(IDriverDB driver, User actualUser)
        {
            this.driver = driver;
            this.actualUser = actualUser;
            InitializeComponent();
            Image checkMark = Image.FromFile(
                @"C:\Users\vestr\source\repos\Project\Project\checkMark.png");
            pictureBoxCheckMarkName.Image = checkMark;
            pictureBoxCheckMarkAddress.Image = checkMark;
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            listBoxClient.DataSource = driver.ReadAllClients();
        }

        private void TextBoxProjectNameInput_TextChanged(object sender, EventArgs e)
        {
            labelNameCheck.Visible = string.IsNullOrWhiteSpace(textBoxProjectNameInput.Text);
            pictureBoxCheckMarkName.Visible = 
                !string.IsNullOrWhiteSpace(textBoxProjectNameInput.Text);
        }

        private void TextBoxProjectAddressInput_TextChanged(object sender, EventArgs e)
        {
            labelAddressCheck.Visible = string.IsNullOrWhiteSpace(textBoxProjectAddressInput.Text);
            pictureBoxCheckMarkAddress.Visible = 
                !string.IsNullOrWhiteSpace(textBoxProjectAddressInput.Text);
        }

        private void ShowUserInProject()
        {
            //TODO
            User[] usersInProject= driver.ReadUsersByProject (actualProject.Id);
            dataGridViewUserInProject.Rows.Clear();
            dataGridViewUserInProject.Height = dataGridViewUserInProject.ColumnHeadersHeight
                + dataGridViewUserInProject.RowTemplate.Height * usersInProject.Length + 3;
            //Счетчик инкрементирован для отображения пользователю 
            int i = 1;
            foreach (User user in usersInProject)
            {
                dataGridViewUserInProject.Rows.Add
                    (i++, user.Name,(user.ManagerAccess) ? "Да" : "Нет");
            }
        }

        private void ButtonSaveProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProjectNameInput.Text)||
                string.IsNullOrWhiteSpace(textBoxProjectAddressInput.Text)||
                string.IsNullOrWhiteSpace(listBoxClient.Text))
                MessageBox.Show("Заполните все поля формы", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //MessageBox.Show(textBoxProjectNameInput.Text +
                    //textBoxProjectAddressInput.Text + listBoxClient.Text, "##",
                    //MessageBoxButtons.OK);
                var project = new Project(textBoxProjectNameInput.Text,
                    textBoxProjectAddressInput.Text, listBoxClient.Text);
                try
                {
                    driver.CreateProject(project);
                    MessageBox.Show($"Проект {project.Name} сохранен", "Сообщение", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    groupBoxUserInProject.Visible = true;
                    ShowUserInProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            textBoxClientNameInput.Visible = true;
            buttonAddClientCancel.Visible = true;
        }

        private void TextBoxClientNameInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxClientNameInput.Text))
                buttonCreateClient.Visible = false;
            else buttonCreateClient.Visible = true;
        }

        private void ButtonCreateClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxClientNameInput.Text))
                MessageBox.Show("Введите название заказчика", "Сообщение об ошибке", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    driver.CreateClient(textBoxClientNameInput.Text);
                    listBoxClient.DataSource = driver.ReadAllClients();
                    textBoxClientNameInput.Visible = false;
                    buttonCreateClient.Visible = false;
                    buttonAddClientCancel.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonAddClientCancel_Click(object sender, EventArgs e)
        {
            textBoxClientNameInput.Visible = false;
            buttonCreateClient.Visible = false;
            buttonAddClientCancel.Visible = false;
            textBoxClientNameInput.Clear();
        }

        private void ButtonAddUsers_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm(driver, actualUser);
            usersForm.
        }
    }
}
