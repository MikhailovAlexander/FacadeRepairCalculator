using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        //ReadAllEntities
        private User[] ReadAllUsers()
        {
            return ReadAllObjectT<User>(driver.ReadAllUsers);
        }
        //SelectedEntity
        User SelectedUser()
        {
            return SelectedObject<User>(dgvAllUsers, driver.ReadUser);
        }

        //Rb_CheckedChanged

        //ShowEntities
        void ShowUsers()
        {
            var allUsers = ReadAllUsers();
            ClearAndSetHeightDgv(dgvAllUsers, gbAllUsers, allUsers.Length);
            foreach (User user in allUsers)
            {
                dgvAllUsers.Rows.Add(user.Id, user.Name, user.Passport, user.Login,
                    user.ManagerAccessString);
            }
        }

        void ShowUsersInProject()
        {
            if (actualProject.Id < 0) return;
            User[] usersInProject = ReadAllObjectsByParam(actualProject.Id, driver.ReadUsersInProject);
            ClearAndSetHeightDgv(dgvUserInProject, gbUsersInProject, usersInProject.Length);
            foreach (User user in usersInProject)
            {
                string payments = GetStringFromDecimalValue(
                    GetAmountPaymentsByProjectAndUser(actualProject.Id, user));
                string complete = GetStringFromDecimalValue(
                    GetAmountCompletedWorkByProjectAndUser(actualProject.Id, user));
                string accept = GetStringFromDecimalValue(
                    GetAmountAcceptedWorkByProjectAndUser(actualProject.Id, user));
                string reject = GetStringFromDecimalValue(
                    GetAmountRejectedWorkByProjectAndUser(actualProject.Id, user));
                dgvUserInProject.Rows.Add(user.Id, user.Name, user.ManagerAccessString, payments,
                    complete, accept, reject);
            }
        }

        //ShowVoidEntity
        void ShowVoidUser()
        {
            tbUserName.Clear();
            tbUserPassport.Clear();
            tbUserLogin.Clear();
            checkBoxManagerAccess.Checked = false;
            tbUserPassword.Clear();
            tbUserPasswordRepeat.Clear();
            pbCheckMarkUserName.Visible = false;
            lblCheckUserName.Visible = false;
            pbCheckMarkUserPassport.Visible = false;
            lblCheckUserPassport.Visible = false;
            pbCheckMarkUserLogin.Visible = false;
            lblCheckUserLogin.Visible = false;
        }

        //ShowSelectedEntity
        void ShowSelectedUser()
        {
            User user = SelectedUser();
            tbUserName.Text = user.Name;
            tbUserPassport.Text = user.Passport;
            tbUserLogin.Text = user.Login;
            checkBoxManagerAccess.Checked = user.ManagerAccess;
        }

        //TbDate_Click

        //DtpDate_valueChanged


        //Tb_TextChanged
        private void TbUserName_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkUserName.Visible = User.NameIsMatch(tbUserName.Text);
            lblCheckUserName.Visible = !User.NameIsMatch(tbUserName.Text);
        }

        private void TbUserPassport_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkUserPassport.Visible =
                User.PassportIsMatch(tbUserPassport.Text);
            lblCheckUserPassport.Visible =
                !User.PassportIsMatch(tbUserPassport.Text);
        }

        private void TbUserLogin_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkUserLogin.Visible = User.LoginIsMatch(tbUserLogin.Text);
            lblCheckUserLogin.Visible = !User.LoginIsMatch(tbUserLogin.Text);
        }

        private void TbUserPasswordInput_TextChanged(object sender, EventArgs e)
        {
            bool passwordIsMatch = User.PasswordIsMatch(tbUserPassword.Text);
            tbUserPasswordRepeat.Enabled = passwordIsMatch;
            lblCheckUserPassword.Visible = !passwordIsMatch;
            pbCheckMarkUserPassword.Visible = passwordIsMatch;
            lblUserCheckPasswordsIsNotEuals.Visible = tbUserPasswordRepeat.Enabled &&
                !tbUserPasswordRepeat.Text.Equals(tbUserPassword.Text);
            if (passwordIsMatch) tbUserPasswordRepeat.Text = "";
        }

        private void TbPasswordRepeatInput_TextChanged(object sender, EventArgs e)
        {
            lblUserCheckPasswordsIsNotEuals.Visible =
                !tbUserPasswordRepeat.Text.Equals(tbUserPassword.Text);
            pbCheckMarkUserRepeatPassword.Visible =
                tbUserPasswordRepeat.Text.Equals(tbUserPassword.Text);
        }

        //BtnSwitchCreate_Click
        private void BtnSwitchCreateUser_Click(object sender, EventArgs e)
        {
            ShowVoidUser();
            btnCreateUser.Visible = true;
            btnUserSwitchCancel.Visible = true;
            btnChangePassword.Visible = false;
            gbPasswordPanel.Visible = true;
            gbUserData.Enabled = true;
            dgvAllUsers.Enabled = true;
        }

        //BtnSwitchCancel_Click
        private void BtnUserSwitchCancel_Click(object sender, EventArgs e)
        {
            ShowVoidUser();
            gbPasswordPanel.Visible = false;
            gbUserData.Enabled = false;
            dgvAllUsers.Enabled = true;
            btnChangePassword.Visible = false;
            btnCreateUser.Visible = false;
            btnUpdateUser.Visible = false;
            btnUserSwitchCancel.Visible = false;
        }

        //BtnCreate_Click
        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            if (User.NameIsMatch(tbUserName.Text)
                && User.PassportIsMatch(tbUserPassport.Text)
                && User.LoginIsMatch(tbUserLogin.Text)
                && User.PasswordIsMatch(tbUserPassword.Text)
                && tbUserPasswordRepeat.Text.Equals(tbUserPassword.Text))
            {
                string name = tbUserName.Text;
                string passport = tbUserPassport.Text;
                string login = tbUserLogin.Text;
                bool managerAccess = checkBoxManagerAccess.Checked;
                hashPasswordCreator.EncodePasswordAndGenerteSalt(tbUserPassword.Text);
                string hashPassword = hashPasswordCreator.GetHashToString();
                string salt = hashPasswordCreator.GetSaltToString();
                User user = new User(name, passport, login, hashPassword, managerAccess, salt);
                try
                {
                    user.Create(driver);
                    MessageBox.Show($"Данные пользователя {name} сохранены", "Сообщение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowUsers();
                    ShowVoidUser();
                    btnCreateUser.Visible = false;
                    btnUserSwitchCancel.Visible = false;
                    gbPasswordPanel.Visible = false;
                    gbUserData.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные пользователя {name} не были сохранены. " + ex.Message,
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //BtnSwitchUpdate_Click
        private void BtnSwitchUpdateUser_Click(object sender, EventArgs e)
        {
            ShowSelectedUser();
            btnUpdateUser.Location = new Point(487, 213);
            btnUpdateUser.Visible = true;
            btnUserSwitchCancel.Visible = true;
            btnCreateUser.Visible = false;
            gbPasswordPanel.Visible = false;
            gbUserData.Enabled = true;
            dgvAllUsers.Enabled = false;
        }

        //BtnUpdate_Click
        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (User.NameIsMatch(tbUserName.Text)
                && User.PassportIsMatch(tbUserPassport.Text)
                && User.LoginIsMatch(tbUserLogin.Text))
            {
                var selectedUser = SelectedUser();
                selectedUser.Name = tbUserName.Text;
                selectedUser.Passport = tbUserPassport.Text;
                selectedUser.Login = tbUserLogin.Text;
                selectedUser.ManagerAccess = checkBoxManagerAccess.Checked;
                try
                {
                    selectedUser.Update(driver);
                    MessageBox.Show($"Данные пользователя {selectedUser.Name} сохранены",
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowUsers();
                    ShowVoidUser();
                    gbUserData.Enabled = false;
                    btnUpdateUser.Visible = false;
                    btnUserSwitchCancel.Visible = false;
                    dgvAllUsers.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные пользователя {selectedUser.Name} не были сохранены"
                        + ex.Message, "Сообщение об ошибке",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //BtnDelete_Click
        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                           ($"Вы действительно хотите безвозвратно удалить пользователя " +
                           $"{SelectedUser().Name}?", "Удаление пользователя",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var selectedUser = SelectedUser();
                try
                {
                    selectedUser.Delete(driver);
                    MessageBox.Show($"Пользователь {selectedUser.Name} удален",
                        "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowUsers();
                    ShowVoidUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSwitchChangePassword_Click(object sender, EventArgs e)
        {
            ShowSelectedUser();
            dgvAllUsers.Enabled = false;
            btnChangePassword.Visible = true;
            btnUserSwitchCancel.Visible = true;
            btnUpdateUser.Visible = false;
            btnCreateUser.Visible = false;
            gbPasswordPanel.Visible = true;
            gbUserData.Enabled = false;
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (User.PasswordIsMatch(tbUserPassword.Text)
                && tbUserPasswordRepeat.Text.Equals(tbUserPassword.Text))
            {
                var selectedUser = SelectedUser();
                try
                {
                    selectedUser.ChangePassword(tbUserPassword.Text, hashPasswordCreator);
                    selectedUser.Update(driver);
                    MessageBox.Show($"Пароль пользователя {selectedUser.Name} изменен", "Сообщение",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAllUsers.Enabled = true;
                    btnUserSwitchCancel.Visible = false;
                    gbPasswordPanel.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные пользователя {selectedUser.Name} не были сохранены. "
                        + ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void GbPasswordPanel_VisibleChanged(object sender, EventArgs e)
        {
            tbUserPassword.Clear();
            tbUserPasswordRepeat.Clear();
            pbCheckMarkUserPassword.Visible = false;
            pbCheckMarkUserRepeatPassword.Visible = false;
            lblUserCheckPasswordsIsNotEuals.Visible = false;
            lblCheckUserPassword.Visible = false;
        }

        private void BtnAddUserInProject_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                 actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(actualProject.Id == -1))
            {
                var selectedUser = SelectedUser();
                try
                {
                    driver.AddUserToProject(selectedUser.Id, actualProject.Id);
                    MessageBox.Show($"Пользователь {selectedUser.Name} добавлен в текущий проект",
                        "Добавление пользователя в проект", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowUsersInProject();
                    ShowActualProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Необходимо сохранить текущий проект", "Сообщение об ошибке",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvUserInProject.RowCount != 0)
            {
                string nameUserToRemove = Convert.ToString(
                    dgvUserInProject.SelectedRows[0].Cells[1].Value);
                DialogResult result = MessageBox.Show
                    ($"Вы действительно хотите безвозвратно удалить пользователя" +
                    $"{nameUserToRemove} из проекта {actualProject.ToString()}?",
                    "Удаление пользователя из проекта", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idUserToRemove = Convert.ToInt32(dgvUserInProject.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        driver.DeleteUserFromProject(idUserToRemove, actualProject.Id);
                        MessageBox.Show(
                            $"Пользователь {nameUserToRemove} удален из текущего проекта",
                            "Удаление пользователя из проекта", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ShowUsersInProject();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Пользователь не выбран", "Сообщение об ошибке", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
