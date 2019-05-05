using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class MainForm : Form
    {
        private IDriverDB driver;
        private IHashPasswordCreator hashPasswordCreator;
        private User actualUser;
        private Project actualProject;

        private ModelOfFacade workerModel;
        private WorkLogGroup workerWorkLog;
        private ModelOfFacade managerModel;
        private WorkLogGroup managerWorkLog;

        public MainForm(IDriverDB driver, IHashPasswordCreator hashPasswordCreator)
        {
            InitializeComponent();
            this.driver = driver;
            this.hashPasswordCreator = hashPasswordCreator;
            actualUser = new User();
            workerModel = new ModelOfFacade(dgvWorkerModel, this);
            workerWorkLog = new WorkLogGroup(this, workerModel, dgvWorkerWorkLog,
                dgvWorkerWorksInProject, lblWorkerElementHeight, lblWorkerElementLenght,
                lblWorkerElementSquare, lblWorkerWorkByElementMultiplicity,
                lblWorkerWorkByElementAmount);
            managerModel = new ModelOfFacade(dgvManagerModel, this);
            managerWorkLog = new WorkLogGroup(this, managerModel, dgvManagerWorkLog,
                dgvSectionOfBuildingWorkInProject, lblManagerModeHeight, lblManagerModelLength, 
                lblManagerModelSquare, lblManagerModelMultiplicity, lblManagerModelAmount);

            var entryForm = new Entry(driver, hashPasswordCreator);
            Application.Run(entryForm);
            try
            {
                actualUser = entryForm.actualUser;
            }
            catch
            {
                MessageBox.Show("Ошибка! Вход в систему не возможен", "Сообщение об ошибке", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            if(actualUser.Id == -1)
            {
                MessageBox.Show("Ошибка! Вход в систему не возможен", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            //TODO refact this
            if (!actualUser.ManagerAccess)
            {
                //ShowWorkerProjects();
            }
            Image checkMark = Image.FromFile(
                @"C:\Users\vestr\source\repos\Project\Project\checkMark.png");
            SetPictures(checkMark);
            ShowlabelActualUserName();
            ShowUsers();
            ShowClients();
            actualProject = new Project();
            ShowActualProject();
            ShowAllEntities();
            //##
            ShowWorkerProjects();

            
        }
        private void SetPictures(Image checkMark)
        {
            pbCheckMarkUserName.Image = checkMark;
            pbCheckMarkUserPassport.Image = checkMark;
            pbCheckMarkUserLogin.Image = checkMark;
            pbCheckMarkUserPassword.Image = checkMark;
            pbCheckMarkUserRepeatPassword.Image = checkMark;
            pbCheckMarkProjectName.Image = checkMark;
            pbCheckMarkProjectAddress.Image = checkMark;
            pbCheckMarkProjectClient.Image = checkMark;
            pbCheckMarkProjectDateOfStart.Image = checkMark;
            pbCheckMarkProjectPlannedDateOfComplete.Image = checkMark;
            pbChekMarkProjectDateOfComplete.Image = checkMark;
            pbCheckMarkClientName.Image = checkMark;
            pbCheckMarkClientAddress.Image = checkMark;
            pbCheckMarkClientInn.Image = checkMark;
            pbCheckMarkTypeOfWorkName.Image = checkMark;
            pbCheckMarkTypeOfWorkDimension.Image = checkMark;
            pbCheckMarkTypeOfWorkMeasureUnit.Image = checkMark;
            pbCheckMarkWorkInProjectMultiplicity.Image = checkMark;
            pbCheckMarkWorkInProjectPrice.Image = checkMark;
            pbCheckMarkPaymentDate.Image = checkMark;
            pbCheckMarkPaymentAmount.Image = checkMark;
            pbCheckMarkElementPictureName.Image = checkMark;
            pbCheckMarkElementPictureLoadContent.Image = checkMark;
            pbCheckMarkTypeOfElementName.Image = checkMark;
            pbCheckMarkTypeOfElementSquare.Image = checkMark;
            pbCheckMarkTypeOfElementHeight.Image = checkMark;
            pbCheckMarkTypeOfElementLength.Image = checkMark;
            pbCheckMarkTypeOfElementPicture.Image = checkMark;
            pbCheckMarkSectionOfBuildingName.Image = checkMark;
            pbCheckMarkSectionOfBuildingQuantityByHeight.Image = checkMark;
            pbCheckMarkSectionOfBuildingQuantityByWidth.Image = checkMark;
        }

        private void ShowActualProject()
        {
            labelActualProjectName.Text = $"Текущий проект: {actualProject.ToString()}";
            ShowUsersInProject();
            if (actualProject.IdClient >= 0)
                labelActualProjectClient.Text = $"Заказчик текущего проекта: " +
                    $"{driver.ReadClient(actualProject.IdClient).ToString()}";
            else labelActualProjectClient.Text = $"Заказчик текущего проекта: Не определен";
            ShowWorksInActualProject();
            ShowSummPaymentsInActualProjectByUsers();
            ShowTypesOfElementInProject();
            ShowSectionsOfBuildingInActualPriject();
            ShowTypesOfElementInSectionOfBuilding();
            //Lables
            ShowTotalSquareByActualProject();
            ShowTotalAmountByActualProject();
            ShowAmountPaymentsByActualProject();
            ShowTotalAmountCompletedWorkByActualProject();
            ShowTotalAmountAcceptedWorkByActualProject();
            ShowTotalAmountRejectedWorkByActualProject();
        }

        private void ShowlabelActualUserName()
        {
            labelActualUserName.Text = "Текущий пользователь: " + actualUser.Name;
        }

        private void ShowAllEntities()
        {
            ShowProjects();
            ShowTypesOfWork();
            ShowDimensionList();
            ShowAllPayments();
            ShowAllElementPictures();
            ShowAllTypesOfElement();
        }

        private void ShowDimensionList()
        {
            foreach (KeyValuePair<Dimension, string> dimension in TypeOfWork.DimensionDictionary)
            {
                cbTypeOfWorkDimension.Items.Add(dimension.Value);
            }
        }

        private void ClearAndSetHeightDgv(DataGridView dgv, GroupBox gb, int objectsLength)
        {
            if(dgv.Rows.Count != 0)
            {
                dgv.Rows.Clear();
            }
            dgv.Height = dgv.ColumnHeadersHeight + dgv.RowTemplate.Height * objectsLength + 3;
            if (dgv.Height > gb.Height - 20)
                dgv.Height = gb.Height - 20;
        }

        private void ClearAndSetHeightDgv(DataGridView dgv, int dgvHeight, int objectsLength)
        {
            dgv.Rows.Clear();
            dgv.Height = dgv.ColumnHeadersHeight + dgv.RowTemplate.Height * objectsLength + 3;
            if (dgv.Height > dgvHeight)
                dgv.Height = dgvHeight;
        }

        private int GetIdSelectedObject(DataGridView dgv)
        {
            int idObject = -1;
            if(dgv.Rows.Count == 0) return idObject;
            try
            {
                idObject = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return idObject;
        }

        private T ReadObject<T>(int idForSearch, Func<int, T> ReadT) where T : new()
        {
            T someObject = new T();
            try
            {
                someObject = ReadT(idForSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return someObject;
        }

        private T SelectedObject<T>(DataGridView DGV, Func<int, T> ReadT) where T : new()
        {
            int idForSearch = GetIdSelectedObject(DGV);
            return ReadObject<T>(idForSearch, ReadT);
        }

        private T[] ReadAllObjectT<T> (Func<T[]> ReadAllT)
        {
            T[] objects = new T[0];
            try
            {
                objects = ReadAllT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return objects;
        }
        ///paramValue
        private T[] ReadAllObjectsByParam<T>(int paramValue, Func<int, T[]> ReadAllT)
        {
            T[] objects = new T[0];
            try
            {
                objects = ReadAllT(paramValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return objects;
        }
        private int GetIdUserInProject(int idUser, int idProject)
        {
            int idUserInProject = -1;
            try
            {
                idUserInProject = driver.GetIdUserInProject(idUser, idProject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return idUserInProject;
        }

        private Project GetProjectFromUserInProject(int idUserInProject)
        {
            return ReadObject<Project>(idUserInProject, driver.GetProjectFromUserInProject);
        }

        private User GetUserFromUserInProject(int idUserInProject)
        {
            return ReadObject<User>(idUserInProject, driver.GetUserFromUserInProject);
        }
         
        private User ReadUser(int idUser)
        {
            return ReadObject<User>(idUser, driver.ReadUser);
        }

        private TypeOfElement GetTypeOfElement(int idElement)
        {
            return ReadObject<TypeOfElement>(idElement, driver.GetTypeOfElement);
        }

        private decimal GetValueWorkByElement(WorkByElement workByElement)
        {
            decimal valueByWork = -1;
            if (workByElement.Id == -1) return valueByWork;
            try
            {
                valueByWork = workByElement.GetValue(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return valueByWork;
        }

        private void ShowDateInTb(TextBox tb, DateTimePicker dtp)
        {
            if (dtp.Value <= new DateTime(1970, 1, 1))
                tb.Text = "Не установлена";
            else tb.Text = dtp.Value.Date.ToString();
            tb.Visible = true;
            dtp.Visible = false;
        }

        private string GetStringFromDecimalValue(decimal value)
        {
            if (value == -1) return "нет";
            else return value.ToString();
        }

        private string GetStringFromDate(DateTime date)
        {
            if (date == new DateTime(1970, 01, 01)) return "Нет";
            return date.ToShortDateString();
        }

        private void ShowProjectsInDgv(Project[] projects, DataGridView dgvProjects, int dgvHeight)
        {
            ClearAndSetHeightDgv(dgvProjects, dgvHeight, projects.Length);
            foreach (Project project in projects)
            {
                decimal square = GetTotalSquare(project);
                decimal payments = GetAmountPayments(project);
                decimal amount = GetTotalAmount(project);
                decimal complete = GetTotalAmountCompletedWork(project);
                decimal accept = GetTotalAmountAcceptedWork(project);
                decimal reject = GetTotalAmountRejectedWork(project);
                string client = ReadClient(project.IdClient).ToString();
                dgvProjects.Rows.Add
                    (project.Id, project.Name, project.Address, client, project.StateString,
                    GetStringFromDate(project.DateOfStart),
                    GetStringFromDate(project.DateOfComplete),
                    GetStringFromDate(project.PlannedDateOfComplete),
                    GetStringFromDecimalValue(square), GetStringFromDecimalValue(payments),
                    GetStringFromDecimalValue(amount), GetStringFromDecimalValue(complete),
                    GetStringFromDecimalValue(accept), GetStringFromDecimalValue(reject));
            }
        }

        private void ShowSectionsOfBuilding(Project project, Label lblProjectNotSaved, 
            DataGridView dgvSectionsOfBuilding, GroupBox groupBox)
        {
            lblProjectNotSaved.Visible = (project.Id == -1);
            var sectionsOfBuilding = ReadSectionsOfBuildingByProject(project);
            ClearAndSetHeightDgv(dgvSectionsOfBuilding, groupBox,
                sectionsOfBuilding.Length);
            foreach (var section in sectionsOfBuilding)
            {
                decimal square = GetSquareOfSectionOfBuilding(section);
                decimal work = GetAmountByWorksFromSectionOfBuilding(section);
                decimal completeWork = GetAmountCompletedWorksFromSectionOfBuilding(section);
                decimal acceptWork = GetAmountAcceptedWorksFromSectionOfBuilding(section);
                decimal rejectWork = GetAmountRejectedWorksFromSectionOfBuilding(section);
                dgvSectionsOfBuilding.Rows.Add(section.Id, section.Name,
                    section.QuantityByHeight, section.QuantityByWidth,
                    GetStringFromDecimalValue(square), GetStringFromDecimalValue(work),
                    GetStringFromDecimalValue(completeWork), GetStringFromDecimalValue(acceptWork),
                    GetStringFromDecimalValue(rejectWork));
            }
        }

        private void ShowWorksInProject(int idProject, SectionOfBuilding sectionOfBuilding, 
            DataGridView dgvWorksInProject, int height)
        {
            var worksInProject = ReadAllWorksInProject(idProject);
            ClearAndSetHeightDgv(dgvWorksInProject, height, worksInProject.Length);
            foreach (WorkInProject work in worksInProject)
            {
                var typeOfWork = ReadTypeOfWork(work.IdTypeOfWork);
                decimal valueWork = GetValueWorkBySectionOfBuilding(work, sectionOfBuilding);
                string valueWorkStr = valueWork == -1 ? "нет" : valueWork.ToString();
                string workCost = valueWork == -1 ?
                    "нет" : (valueWork * (decimal)work.Price).ToString();
                valueWork = GetValueCompletedWorkBySectionOfBuilding(work, sectionOfBuilding);
                string completWork = valueWork == -1 ? "нет" : valueWork.ToString();
                string completWorkCost = valueWork == -1 ?
                    "нет" : (valueWork * (decimal)work.Price).ToString();
                valueWork = GetValueAcceptedWorkBySectionOfBuilding(work, sectionOfBuilding);
                string acceptWork = valueWork == -1 ? "нет" : valueWork.ToString();
                string acceptWorkCost = valueWork == -1 ?
                    "нет" : (valueWork * (decimal)work.Price).ToString();
                valueWork = GetValueRejectedWorkBySectionOfBuilding(work, sectionOfBuilding);
                string rejectWork = valueWork == -1 ? "нет" : valueWork.ToString();
                string rejectWorkCost = valueWork == -1 ?
                    "нет" : (valueWork * (decimal)work.Price).ToString();

                dgvWorksInProject.Rows.Add(
                        work.Id, typeOfWork.Name, typeOfWork.MeasureUnit, work.Price,
                        work.Multiplicity, valueWorkStr, workCost, completWork, completWorkCost,
                        acceptWork, acceptWorkCost, rejectWork, rejectWorkCost);
            }
        }

        private void ShowWorksAmountBySectionOfBuilding(SectionOfBuilding sectionOfBuilding,
            Label lblWorksAmount)
        {
            decimal amount = GetAmountByWorksFromSectionOfBuilding(sectionOfBuilding);
            if (amount == -1) lblWorksAmount.Text =
                    "Общая стоимость работ по модели не определена";
            else
            {
                lblWorksAmount.Text =
                    $"Общая стоимость работ по модели {amount.ToString()} руб.";
            }
        }

        //
        //TabPageUser
        //

        void ShowUsers()
        {
            var allUsers = ReadAllObjectT<User>(driver.ReadAllUsers);
            ClearAndSetHeightDgv(dgvAllUsers, gbAllUsers, allUsers.Length);
            foreach (User user in allUsers)
            {
                dgvAllUsers.Rows.Add(user.Id, user.Name, user.Passport, user.Login,
                    (user.ManagerAccess) ? "Да" : "Нет");
            }
        }

        User SelectedUser()
        {
            return SelectedObject<User>(dgvAllUsers, driver.ReadUser);
        }

        void ShowSelectedUser()
        {
            User user = SelectedUser();
            tbUserName.Text = user.Name;
            tbUserPassport.Text = user.Passport;
            tbUserLogin.Text = user.Login;
            checkBoxManagerAccess.Checked = user.ManagerAccess;
        }

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

        void ShowUsersInProject()
        {
            if (actualProject.Id < 0) return;
            User[] usersInProject = ReadAllObjectsByParam(actualProject.Id, driver.ReadUsersInProject);
            ClearAndSetHeightDgv(dgvUserInProject, gbUsersInProject, usersInProject.Length);
            foreach (User user in usersInProject)
            {
                dgvUserInProject.Rows.Add(user.Id, user.Name, 
                    (user.ManagerAccess) ? "Да" : "Нет");
            }
        }

        private void BtnUserSwitchCancel_Click(object sender, EventArgs e)
        {
            ShowVoidUser();
            gbPasswordPanel.Visible = false;
            gbUserData.Enabled = false;
            dgvAllUsers.Enabled = true;
            btnChangePassword.Visible = false;
            btnCreateUser.Visible = false;
            btnUpdateUser.Visible = false;
        }


        //
        //CreateUser

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

        private void BtnSwitchCreateUser_Click(object sender, EventArgs e)
        {
            ShowVoidUser();
            btnCreateUser.Visible = true;
            btnChangePassword.Visible = false;
            gbPasswordPanel.Visible = true;
            gbUserData.Enabled = true;
            dgvAllUsers.Enabled = true;
        }

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

        //
        //UpdateUser

        private void BtnSwitchUpdateUser_Click(object sender, EventArgs e)
        {
            ShowSelectedUser();
            btnUpdateUser.Location = new Point(487, 213);
            btnUpdateUser.Visible = true;
            btnCreateUser.Visible = false;
            gbPasswordPanel.Visible = false;
            gbUserData.Enabled = true;
            dgvAllUsers.Enabled = false;
        }

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
                    dgvAllUsers.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные пользователя {selectedUser.Name} не были сохранены"
                        + ex.Message,"Сообщение об ошибке", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //
        //ChangePassword

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

        private void BtnSwitchChangePassword_Click(object sender, EventArgs e)
        {
            ShowSelectedUser();
            dgvAllUsers.Enabled = false;
            btnChangePassword.Visible = true;
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
        
        //
        //DeleteUser

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                           ($"Вы действительно хотите безвозвратно удалить пользователя" +
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

        private void BtnAddUserInProject_Click(object sender, EventArgs e)
        {
            if (actualProject.Id >= 0)
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

        //
        //TabPageClient
        //
        private Client[] ReadAllClients()
        {
            return ReadAllObjectT<Client>(driver.ReadAllClients);
        }

        private Client ReadClient(int idClient)
        {
            return ReadObject<Client>(idClient, driver.ReadClient);
        }

        void ShowClients()
        {
            var allClients = ReadAllObjectT(driver.ReadAllClients);
            ClearAndSetHeightDgv(dgvAllClients, gbAllClients, allClients.Length);
            foreach (Client client in allClients)
            {
                dgvAllClients.Rows.Add(client.Id, client.Name, client.Address, client.Inn);
            }
        }

        Client SelectedClient()
        {
            return SelectedObject<Client>(dgvAllClients, driver.ReadClient);
        }

        void ShowVoidClient()
        {
            tbClientName.Clear();
            tbClientAddress.Clear();
            tbClientInn.Clear();
            pbCheckMarkClientName.Visible = false;
            lblCheckClientName.Visible = false;
            pbCheckMarkClientAddress.Visible = false;
            lblCheckClientAddress.Visible = false;
            pbCheckMarkClientInn.Visible = false;
            lblCheckClientInn.Visible = false;
        }

        void ShowSelectedClient()
        {
            var selectedClient = SelectedClient();
            tbClientName.Text = selectedClient.Name;
            tbClientAddress.Text = selectedClient.Address;
            tbClientInn.Text = selectedClient.Inn;
            pbCheckMarkClientName.Visible = false;
            lblCheckClientName.Visible = false;
            pbCheckMarkClientAddress.Visible = false;
            lblCheckClientAddress.Visible = false;
            pbCheckMarkClientInn.Visible = false;
            lblCheckClientInn.Visible = false;
        }

        private void BtnCancelClientSwitch_Click(object sender, EventArgs e)
        {
            gbAllClients.Enabled = true;
            gbClientData.Enabled = false;
            btnUpdateClient.Visible = false;
            btnCreateClient.Visible = false;
            btnCancelClientSwitch.Visible = false;
            ShowVoidClient();
        }

        private void TbClientName_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkClientName.Visible = 
                Client.NameIsMatch(tbClientName.Text);
            lblCheckClientName.Visible = !Client.NameIsMatch(tbClientName.Text);
        }

        private void TbClientAddress_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkClientAddress.Visible =
                Client.AddressIsMatch(tbClientAddress.Text);
            lblCheckClientAddress.Visible = !Client.AddressIsMatch(tbClientAddress.Text);
        }

        private void TbClientInn_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkClientInn.Visible =
                Client.InnIsMatch(tbClientInn.Text);
            lblCheckClientInn.Visible = !Client.InnIsMatch(tbClientInn.Text);
        }

        private void BtnSwitchCreateClient_Click(object sender, EventArgs e)
        {
            ShowVoidClient();
            gbClientData.Enabled = true;
            btnUpdateClient.Visible = false;
            btnCreateClient.Visible = true;
            btnCancelClientSwitch.Visible = true;

        }

        private void BtnCreateClient_Click(object sender, EventArgs e)
        {
            if(Client.NameIsMatch(tbClientName.Text)&&
                Client.AddressIsMatch(tbClientAddress.Text)&&
                Client.InnIsMatch(tbClientInn.Text))
            {
                string name = tbClientName.Text;
                string address = tbClientAddress.Text;
                string inn = tbClientInn.Text;
                var client = new Client(name, address, inn);
                try
                {
                    client.Create(driver);
                    MessageBox.Show($"Данные заказчика {name} сохранены", "Сообщение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowClients();
                    ShowVoidClient();
                    btnCreateClient.Visible = false;
                    btnCancelClientSwitch.Visible = false;
                    gbClientData.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные заказчика {name} не были сохранены. " + ex.Message,
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnSwitchUpdateClient_Click(object sender, EventArgs e)
        {
            gbAllClients.Enabled = false;
            gbClientData.Enabled = true;
            ShowSelectedClient();
            btnUpdateClient.Visible = true;
            btnCreateClient.Visible = false;
            btnCancelClientSwitch.Visible = true;
        }

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            if (Client.NameIsMatch(tbClientName.Text) &&
                Client.AddressIsMatch(tbClientAddress.Text) &&
                Client.InnIsMatch(tbClientInn.Text))
            {
                var selectedClient = SelectedClient();
                selectedClient.Name = tbClientName.Text;
                selectedClient.Address = tbClientAddress.Text;
                selectedClient.Inn = tbClientInn.Text;
                try
                {
                    selectedClient.Update(driver);
                    MessageBox.Show($"Данные заказчика {selectedClient.Name} сохранены", 
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowClients();
                    ShowVoidClient();
                    btnUpdateClient.Visible = false;
                    btnCancelClientSwitch.Visible = false;
                    gbClientData.Enabled = false;
                    gbAllClients.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные заказчика {selectedClient.Name} не были сохранены. " + 
                        ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            var selectedClient = SelectedClient();
            DialogResult result = MessageBox.Show
                          ($"Вы действительно хотите безвозвратно удалить заказчика " +
                          $"{selectedClient.Name}?", "Удаление заказчика",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedClient.Delete(driver);
                    MessageBox.Show($"Заказчик {selectedClient.Name} удален",
                        "Удаление заказчика", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowClients();
                    ShowVoidClient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddClientToProject_Click(object sender, EventArgs e)
        {
            if (actualProject.Id >= 0)
            {
                var selectedClient = SelectedClient();
                DialogResult result = MessageBox.Show
                          ($"Вы действительно хотите добавить заказчика {selectedClient.Name} " +
                          $"в текущий проект?", "Добавление заказчика в проект",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        actualProject.IdClient = selectedClient.Id;
                        actualProject.Update(driver);
                        MessageBox.Show($"Заказчик {selectedClient.Name} добавлен в текущий проект",
                            "Добавление заказчика в проект", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        ShowClients();
                        ShowVoidClient();
                        ShowActualProject();
                        ShowProjects();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        actualProject = driver.ReadProject(actualProject.Id);
                    }
                }
            }
            else
                MessageBox.Show("Необходимо сохранить текущий проект", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //
        //TabPageWork
        //
        private TypeOfWork[] ReadAllTypesOfWork()
        {
            return ReadAllObjectT<TypeOfWork>(driver.ReadAllTypesOfWork);
        }

        private TypeOfWork ReadTypeOfWork(int idForSearch)
        {
            return ReadObject<TypeOfWork>(idForSearch, driver.ReadTypeOfWork);
        }

        private WorkInProject[] ReadAllWorksInProject(int idProject)
        {
            return ReadAllObjectsByParam<WorkInProject>(idProject, driver.ReadWorksByProject);
        }

        private void ShowTypesOfWork()
        {
            var allTypesOfWork = ReadAllTypesOfWork();
            ClearAndSetHeightDgv(
                dgvAllTypesOfWork, gbAllTypesOfWork, allTypesOfWork.Length);
            foreach (TypeOfWork tow in allTypesOfWork)
            {
                dgvAllTypesOfWork.Rows.Add(
                    tow.Id, tow.Name, tow.DimensionToString(), tow.MeasureUnit);
            }
        }

        private TypeOfWork SelectedTypeOfWork()
        {
            return SelectedObject<TypeOfWork>(dgvAllTypesOfWork, driver.ReadTypeOfWork);
        }

        private void ShowSelectedTypeOfWork()
        {
            var tow = SelectedTypeOfWork();
            tbTypeOfWorkName.Text = tow.Name;
            tbTypeOfWorkMeasureUnit.Text = tow.MeasureUnit;
            cbTypeOfWorkDimension.Text = tow.DimensionToString();
            pbCheckMarkTypeOfWorkName.Visible = false;
            pbCheckMarkTypeOfWorkDimension.Visible = false;
            pbCheckMarkTypeOfWorkMeasureUnit.Visible = false;
            lblCheckTypeOfWorkName.Visible = false;
            lblCheckTypeOfWorkDimension.Visible = false;
            lblCheckTypeOfWorkMeasureUnit.Visible = false;
        }

        private void ShowVoidTypeOfWork()
        {
            tbTypeOfWorkName.Clear();
            tbTypeOfWorkMeasureUnit.Clear();
            cbTypeOfWorkDimension.Text = "";
            pbCheckMarkTypeOfWorkName.Visible = false;
            pbCheckMarkTypeOfWorkDimension.Visible = false;
            pbCheckMarkTypeOfWorkMeasureUnit.Visible = false;
            lblCheckTypeOfWorkName.Visible = false;
            lblCheckTypeOfWorkDimension.Visible = false;
            lblCheckTypeOfWorkMeasureUnit.Visible = false;
        }

        private void TbTypeOfWorkName_TextChanged(object sender, EventArgs e)
        {
            lblCheckTypeOfWorkName.Visible = !TypeOfWork.NameIsMatch(tbTypeOfWorkName.Text);
            pbCheckMarkTypeOfWorkName.Visible = TypeOfWork.NameIsMatch(tbTypeOfWorkName.Text);
        }

        private void CbTypeOfWorkDimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCheckTypeOfWorkDimension.Visible = cbTypeOfWorkDimension.SelectedItem == null;
            pbCheckMarkTypeOfWorkDimension.Visible = cbTypeOfWorkDimension.SelectedItem != null;
        }

        private void TbTypeOfWorkMeasureUnit_TextChanged(object sender, EventArgs e)
        {
            lblCheckTypeOfWorkMeasureUnit.Visible = !TypeOfWork.MeasureUnitIsMatch(tbTypeOfWorkMeasureUnit.Text);
            pbCheckMarkTypeOfWorkMeasureUnit.Visible = TypeOfWork.MeasureUnitIsMatch(tbTypeOfWorkMeasureUnit.Text);
        }

        private void BtnWorkSwitchCancel_Click(object sender, EventArgs e)
        {
            ShowVoidTypeOfWork();
            gbTypeOfWorkData.Enabled = false;
            gbTypeOfWorkData.Height = 217;
            gbWorkInProjectData.Visible = false;
            gbAllTypesOfWork.Enabled = true;
            gbWorksInActualProject.Enabled = true;
            btnWorkSwitchCancel.Visible = false;
            btnTypeOfWorkCreate.Visible = false;
            btnTypeOfWorkUpdate.Visible = false;
            btnWorkInProjectCreate.Visible = false;
            btnWorkInProjectUpdate.Visible = false;
            tbWorkInProjectMultiplicity.Enabled = false;
        }

        private void BtnTypeOfWorkSwitchCreate_Click(object sender, EventArgs e)
        {
            ShowVoidTypeOfWork();
            gbTypeOfWorkData.Enabled = true;
            gbWorkInProjectData.Visible = false;
            btnWorkSwitchCancel.Visible = true;
            btnTypeOfWorkCreate.Visible = true;
        }

        private void BtnTypeOfWorkCreate_Click(object sender, EventArgs e)
        {
            if (TypeOfWork.NameIsMatch(tbTypeOfWorkName.Text)&&
                TypeOfWork.MeasureUnitIsMatch(tbTypeOfWorkMeasureUnit.Text) &&
                cbTypeOfWorkDimension.SelectedItem != null)
                try
                {
                    string name = tbTypeOfWorkName.Text;
                    string measureUnit = tbTypeOfWorkMeasureUnit.Text;
                    Dimension dimension = (Dimension)cbTypeOfWorkDimension.SelectedIndex;
                    var typeOfWork = new TypeOfWork(name, measureUnit, dimension);
                    typeOfWork.Create(driver);
                    MessageBox.Show($"Вид работ {tbTypeOfWorkName.Text} сохранен", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTypesOfWork();
                    ShowVoidTypeOfWork();
                    gbTypeOfWorkData.Enabled = false;
                    btnWorkSwitchCancel.Visible = false;
                    btnTypeOfWorkCreate.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnTypeOfWorkSwitchUpdate_Click(object sender, EventArgs e)
        {
            ShowSelectedTypeOfWork();
            gbTypeOfWorkData.Enabled = true;
            gbAllTypesOfWork.Enabled = false;
            gbWorkInProjectData.Visible = false;
            btnWorkSwitchCancel.Visible = true;
            btnTypeOfWorkUpdate.Visible = true;
        }

        private void BtnTypeOfWorkUpdate_Click(object sender, EventArgs e)
        {
            if (TypeOfWork.NameIsMatch(tbTypeOfWorkName.Text) &&
               TypeOfWork.MeasureUnitIsMatch(tbTypeOfWorkMeasureUnit.Text) &&
               cbTypeOfWorkDimension.SelectedItem != null)
            {
                var selectedTypeOfWork = SelectedTypeOfWork();
                selectedTypeOfWork.Name = tbTypeOfWorkName.Text;
                selectedTypeOfWork.MeasureUnit = tbTypeOfWorkMeasureUnit.Text;
                selectedTypeOfWork.Dim = (Dimension)cbTypeOfWorkDimension.SelectedIndex;
                try
                {
                    selectedTypeOfWork.Update(driver);
                    MessageBox.Show($"Изменения сохранены", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTypesOfWork();
                    ShowWorksInActualProject();
                    ShowVoidTypeOfWork();
                    gbTypeOfWorkData.Enabled = false;
                    gbAllTypesOfWork.Enabled = true;
                    btnWorkSwitchCancel.Visible = false;
                    btnTypeOfWorkUpdate.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnTypeOfWorkDelete_Click(object sender, EventArgs e)
        {
            var selectedTypeOfWork = SelectedTypeOfWork();
            DialogResult result = MessageBox.Show
                         ($"Вы действительно хотите безвозвратно удалить вид работ " +
                         $"{selectedTypeOfWork.Name}?", "Удаление вида работ",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedTypeOfWork.Delete(driver);
                    MessageBox.Show($"Вид работ {selectedTypeOfWork.Name} удален",
                        "Удаление вида работ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTypesOfWork();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ShowWorksInActualProject()
        {
            if (actualProject.Id == -1)
            {
                lblWorksActualProjectNotSaved.Visible = true;
                return;
            }
            lblWorksActualProjectNotSaved.Visible = false;
            WorkInProject[] worksInActualProject =
                ReadAllWorksInProject(actualProject.Id);
            ClearAndSetHeightDgv(
                dgvWorksInActualProject, gbWorksInActualProject, worksInActualProject.Length);
            foreach (WorkInProject workInProject in worksInActualProject)
            {
                var typeOfWork = ReadTypeOfWork(workInProject.IdTypeOfWork);
                dgvWorksInActualProject.Rows.Add(
                    workInProject.Id, typeOfWork.Name, typeOfWork.DimensionToString(),
                    typeOfWork.MeasureUnit, workInProject.Price, workInProject.Multiplicity);
            }
            ShowWorksInProjectInSectionOfBuilding();
        }

        private WorkInProject SelectedWorkInProject()
        {
            return SelectedObject<WorkInProject>(
                    dgvWorksInActualProject, driver.ReadWorkInProject);
        }

        private void ShowSelectedWorkInProject()
        {
            var workInProject = SelectedWorkInProject();
            var typeOfWork = ReadTypeOfWork(workInProject.IdTypeOfWork);
            tbTypeOfWorkName.Text = typeOfWork.Name;
            cbTypeOfWorkDimension.Text = typeOfWork.DimensionToString();
            tbTypeOfWorkMeasureUnit.Text = typeOfWork.MeasureUnit;
            gbTypeOfWorkData.Height = 167;
            gbWorkInProjectData.Visible = true;
            tbWorkInProjectPrice.Text = Convert.ToString(workInProject.Price);
            tbWorkInProjectMultiplicity.Text = Convert.ToString(workInProject.Multiplicity);
            pbCheckMarkTypeOfWorkName.Visible = false;
            pbCheckMarkTypeOfWorkDimension.Visible = false;
            pbCheckMarkTypeOfWorkMeasureUnit.Visible = false;
        }

        private void BtnWorkInProjectSwitchCreate_Click(object sender, EventArgs e)
        {
            ShowSelectedTypeOfWork();
            gbAllTypesOfWork.Enabled = false;
            gbTypeOfWorkData.Enabled = false;
            gbWorkInProjectData.Visible = true;
            gbTypeOfWorkData.Height = 167;
            btnWorkSwitchCancel.Visible = true;
            btnWorkInProjectCreate.Visible = true;
            tbWorkInProjectPrice.Clear();
            tbWorkInProjectMultiplicity.Text = "1";
        }

        private void TbWorkInProjectPrice_TextChanged(object sender, EventArgs e)
        {
            lblWorkInProjectCheckPrice.Visible = 
                !WorkInProject.DecimalIsMatch(tbWorkInProjectPrice.Text);
            pbCheckMarkWorkInProjectPrice.Visible =
                WorkInProject.DecimalIsMatch(tbWorkInProjectPrice.Text);
        }

        private void TbWorkInProjectMultiplicity_TextChanged(object sender, EventArgs e)
        {
            lblWorkInProjectCheckMultiplicity.Visible = 
                !WorkInProject.DecimalIsMatch(tbWorkInProjectMultiplicity.Text);
            pbCheckMarkWorkInProjectMultiplicity.Visible =
                WorkInProject.DecimalIsMatch(tbWorkInProjectMultiplicity.Text);
        }


        private void BtnWorkInProjectChangeMultiplicity_Click(object sender, EventArgs e)
        {
            tbWorkInProjectMultiplicity.Enabled = true;
        }

        private void BtnWorkInProjectCreate_Click(object sender, EventArgs e)
        {
            if (WorkInProject.DecimalIsMatch(tbWorkInProjectPrice.Text) &&
                WorkInProject.DecimalIsMatch(tbWorkInProjectMultiplicity.Text))
                try
                {
                    var selectedTypeOfWork = SelectedTypeOfWork();
                    double price = Convert.ToDouble(tbWorkInProjectPrice.Text);
                    double multiplicity = Convert.ToDouble(tbWorkInProjectMultiplicity.Text);
                    var workInProject = new WorkInProject(actualProject.Id, selectedTypeOfWork.Id,
                        price, multiplicity);
                    workInProject.Create(driver);
                    MessageBox.Show(
                        $"Вид работ {selectedTypeOfWork.Name} добавлен в текущий проект", 
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowWorksInActualProject();
                    ShowVoidTypeOfWork();
                    gbAllTypesOfWork.Enabled = true;
                    gbWorkInProjectData.Visible = false;
                    gbTypeOfWorkData.Height = 217;
                    btnWorkSwitchCancel.Visible = false;
                    btnWorkInProjectCreate.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnWorkInProjectSwitchUpdate_Click(object sender, EventArgs e)
        {
            ShowSelectedWorkInProject();
            gbWorksInActualProject.Enabled = false;
            btnWorkInProjectUpdate.Visible = true;
            btnWorkSwitchCancel.Visible = true;
        }

        private void BtnWorkInProjectUpdate_Click(object sender, EventArgs e)
        {
            if (WorkInProject.DecimalIsMatch(tbWorkInProjectPrice.Text) &&
                WorkInProject.DecimalIsMatch(tbWorkInProjectMultiplicity.Text))
                try
                {
                    var workInProject = SelectedWorkInProject();
                    if(workInProject.Id == -1)
                    {
                        MessageBox.Show(
                            "Сохранение данных невозможно, ошибка чтения из базы данных",
                            "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    workInProject.Price = Convert.ToDouble(tbWorkInProjectPrice.Text);
                    workInProject.Multiplicity = 
                        Convert.ToDouble(tbWorkInProjectMultiplicity.Text);
                    workInProject.Update(driver);
                    MessageBox.Show($"Изменения сохранены", "Сообщение", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    ShowWorksInActualProject();
                    ShowVoidTypeOfWork();
                    gbAllTypesOfWork.Enabled = true;
                    gbWorksInActualProject.Enabled = true;
                    gbWorkInProjectData.Visible = false;
                    gbTypeOfWorkData.Height = 217;
                    btnWorkSwitchCancel.Visible = false;
                    btnWorkInProjectUpdate.Visible = false;
                    tbWorkInProjectMultiplicity.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnWorkInProjectDelete_Click(object sender, EventArgs e)
        {
            var workInProject = SelectedWorkInProject();
            var typeOfWork = ReadObject<TypeOfWork>(
                workInProject.IdTypeOfWork, driver.ReadTypeOfWork);
            DialogResult result = MessageBox.Show
                         ($"Вы действительно хотите безвозвратно удалить вид работ " +
                         $"{typeOfWork.Name} из текущего проекта?", "Удаление вида работ",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    workInProject.Delete(driver);
                    MessageBox.Show($"Вид работ {typeOfWork.Name} удален",
                        "Удаление вида работ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowWorksInActualProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        //
        //PagePayment
        //

        private Payment[] ReadAllPayments()
        {
            return ReadAllObjectT<Payment>(driver.ReadAllPayments);
        }

        private Payment[] ReadPaymentsByProject(int idProject)
        {
            return ReadAllObjectsByParam<Payment>(idProject, driver.ReadPaymentsByProject);
        }

        private Project GetProjectFromPayment(Payment payment)
        {
            var project = new Project();
            try
            {
                project = payment.GetProject(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return project;
        }

        private User GetUserFromPayment(Payment payment)
        {
            var user = new User();
            try
            {
                user = payment.GetUser(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return user;
        }

        private User SelectedUserByPayments()
        {
            return SelectedObject<User>(dgvPaymentsInActualProjectByUsers, driver.ReadUser);
        }

        private Project SelectedProjectByPayments()
        {
            if (dgvSumPaymentsByProject.Rows.Count == 0) return new Project();
            return SelectedObject<Project>(dgvSumPaymentsByProject, driver.ReadProject);
        }

        Payment SelectedPayment()
        {
            if(rbAllPayments.Checked)
            return SelectedObject<Payment>(dgvAllPayments, driver.ReadPayment);
            else return SelectedObject<Payment>(dgvPaymentsByProject, driver.ReadPayment);
        }

        private void RbPaymentsByProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPaymentsByProjects.Checked)
            {
                dgvAllPayments.Visible = false;
                dgvSumPaymentsByProject.Visible = true;
                dgvPaymentsByProject.Visible = true;
                lblPaymentsByProjects.Visible = true;
                ShowSummPaymentsByProjects();
            }
            else
            {
                dgvAllPayments.Visible = true;
                dgvSumPaymentsByProject.Visible = false;
                dgvPaymentsByProject.Visible = false;
                lblPaymentsByProjects.Visible = false;
                ShowAllPayments();
            }
        }

        public void ShowPayments()
        {
            if (rbAllPayments.Checked)
            {
                ShowAllPayments();
                ShowSummPaymentsInActualProjectByUsers();
            }
            else
            {
                ShowSummPaymentsByProjects();
                ShowPaymentsInProject();
            }
            ShowSummPaymentsInActualProjectByUsers();
        }

        private void ShowAllPayments()
        {
            var allPayments = ReadAllPayments();
            ClearAndSetHeightDgv(dgvAllPayments, gbAllPayments, allPayments.Length);
            foreach (Payment payment in allPayments)
            {
                dgvAllPayments.Rows.Add(payment.Id, GetProjectFromPayment(payment).ToString(),
                    GetUserFromPayment(payment).ToString(), payment.DateOfPayment.Date, 
                    payment.Amount);
            }
            dgvAllPayments.Visible = true;
            dgvSumPaymentsByProject.Visible = false;
            dgvPaymentsByProject.Visible = false;
        }

        private void ShowSummPaymentsByProjects()
        {
            var allPayments = ReadAllPayments();
            var paymentsSumm =
                from payment in allPayments group payment by payment.IdProject into g
                select new { idProject = g.Key, summ = g.Sum(x => x.Amount) };
            ClearAndSetHeightDgv(
                dgvSumPaymentsByProject, gbAllPayments, paymentsSumm.Count());
            foreach(var group in paymentsSumm)
            {
                var project = ReadObject<Project>(group.idProject, driver.ReadProject);
                dgvSumPaymentsByProject.Rows.Add(
                    project.Id, project.Name, group.summ);
            }
        }

        private void ShowPaymentsInProject()
        {
            var selectedProject = SelectedProjectByPayments();
            if (selectedProject.Id ==-1)
            {
                ClearAndSetHeightDgv(dgvPaymentsByProject, gbAllPayments, 0);
                return;
            }
            var paymentsInProject = 
                ReadAllObjectsByParam<Payment>(selectedProject.Id, ReadPaymentsByProject);
            ClearAndSetHeightDgv(dgvPaymentsByProject, gbAllPayments, paymentsInProject.Length);
            foreach (Payment payment in paymentsInProject)
            {
                User user = GetUserFromPayment(payment);
                dgvPaymentsByProject.Rows.Add(
                    payment.Id, user.Name, payment.DateOfPayment, payment.Amount);
            }
        }

        private void DgvSumPaymentsByProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSumPaymentsByProject.SelectedRows.Count != 0)
                ShowPaymentsInProject();
            else ClearAndSetHeightDgv(dgvPaymentsByProject, gbAllPayments, 0);
        }


        private void ShowSummPaymentsInActualProjectByUsers()
        {
            if (actualProject.Id == -1) return;
            var usersInProject = 
                ReadAllObjectsByParam<User>(actualProject.Id, driver.ReadUsersInProject);
            Payment[] allPaymentsByProject = ReadAllObjectsByParam<Payment>(
                actualProject.Id, driver.ReadPaymentsByProject);
            ClearAndSetHeightDgv(dgvPaymentsInActualProjectByUsers, gbPaymentsInActualProject, 
                usersInProject.Count());
            foreach (User user in usersInProject)
            {
                var summ = (from payment in allPaymentsByProject where payment.IdUser == user.Id
                            select payment.Amount).Sum();
                dgvPaymentsInActualProjectByUsers.Rows.Add(user.Id, user.Name, summ);
            }
        }

        private void ShowPaymentsByUserInProject(int idUser)
        {
            var paymentsByProject = ReadPaymentsByProject(actualProject.Id);
            if(idUser==-1)
            {
                lblPaymentsBySelectedUser.Visible = true;
                ClearAndSetHeightDgv(dgvPaymentsByUserInProject, gbPaymentsInActualProject, 0);
                return;
            }
            lblPaymentsBySelectedUser.Visible = false;
            var paymentsByUser = 
                from payment in paymentsByProject where payment.IdUser == idUser select payment;
            ClearAndSetHeightDgv(dgvPaymentsByUserInProject, gbPaymentsInActualProject,
                paymentsByUser.Count());
            foreach(Payment payment in paymentsByUser)
            {
                dgvPaymentsByUserInProject.Rows.Add(payment.DateOfPayment.Date, payment.Amount);
            }
        }

        private void DgvPaymentsInActualProjectByUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPaymentsInActualProjectByUsers.SelectedRows.Count != 0)
                ShowPaymentsByUserInProject(SelectedUserByPayments().Id);
            else ClearAndSetHeightDgv(dgvPaymentsByUserInProject, gbPaymentsInActualProject, 0);
        }

        private void ShowVoidPayment()
        {
            tbPaymentProject.Clear();
            tbPaymentUser.Clear();
            dtpPaymentDate.Value = new DateTime(1970, 1, 1);
            tbPaymentAmout.Clear();
            lblCheckPaymentDate.Visible = false;
            lblCheckPaymentAmount.Visible = false;
            pbCheckMarkPaymentDate.Visible = false;
            pbCheckMarkPaymentAmount.Visible = false;
        }

        private void ShowSelectedPayment()
        {
            var payment = SelectedPayment();
            tbPaymentProject.Text = GetProjectFromPayment(payment).ToString();
            tbPaymentUser.Text = GetUserFromPayment(payment).ToString();
            dtpPaymentDate.Value = payment.DateOfPayment.Date;
            tbPaymentAmout.Text = Convert.ToString(payment.Amount);
            lblCheckPaymentDate.Visible = false;
            lblCheckPaymentAmount.Visible = false;
            pbCheckMarkPaymentDate.Visible = false;
            pbCheckMarkPaymentAmount.Visible = false;
        }

        private void TbPaymentDate_Click(object sender, EventArgs e)
        {
            tbPaymentDate.Visible = false;
            dtpPaymentDate.Visible = true;
        }

        private void DtpPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            lblCheckPaymentDate.Visible = !(dtpPaymentDate.Value >= actualProject.DateOfStart);
            pbCheckMarkPaymentDate.Visible = dtpPaymentDate.Value >= actualProject.DateOfStart;
            ShowDateInTb(tbPaymentDate, dtpPaymentDate);
        }

        private void TbPaymentAmout_TextChanged(object sender, EventArgs e)
        {
            lblCheckPaymentAmount.Visible = !(Payment.amountRegex.IsMatch(tbPaymentAmout.Text));
            pbCheckMarkPaymentAmount.Visible = Payment.amountRegex.IsMatch(tbPaymentAmout.Text);
        }


        private void BtnPaymentSwitchCreate_Click(object sender, EventArgs e)
        {
            if(actualProject.Id == -1||actualProject.State != ProjectState.Actual)
            {
                MessageBox.Show("Добавить оплату можно только в Текущий проект", 
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(SelectedUserByPayments().Id == -1)
            {
                MessageBox.Show("Исполнитель в текущем проекте не выбран", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ///Don't forget
            gbAllProjects.Enabled = false;
            gbAllUsers.Enabled = false;
            gbPaymentData.Enabled = true;
            btnPaymentCreate.Visible = true;
            btnPaymentSwitchCancel.Visible = true;
            tbPaymentProject.Text = actualProject.ToString();
            tbPaymentUser.Text = SelectedUserByPayments().ToString();
            dtpPaymentDate.Value = DateTime.Now;
        }

        private void BtnPaymentSwitchCancel_Click(object sender, EventArgs e)
        {
            gbAllProjects.Enabled = true;
            gbAllUsers.Enabled = true;
            gbAllPayments.Enabled = true;
            gbPaymentData.Enabled = false;
            btnPaymentCreate.Visible = false;
            btnPaymentSwitchCancel.Visible = false;
            btnPaymentUpdate.Visible = false;
            ShowVoidPayment();
        }

        private void BtnPaymentCreate_Click(object sender, EventArgs e)
        {
            if (actualProject.DateOfPaymentIsChecked(dtpPaymentDate.Value)&&
                Payment.amountRegex.IsMatch(tbPaymentAmout.Text))
            {
                if (SelectedUserByPayments().Id == -1)
                {
                    MessageBox.Show("Исполнитель в текущем проекте не найден",
                        "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var payment = new Payment(SelectedUserByPayments().Id, actualProject.Id, 
                    dtpPaymentDate.Value, Convert.ToDouble(tbPaymentAmout.Text));
                try
                {
                    if (payment.CheckUserInProject(driver))
                    {
                        payment.Create(driver);
                        ShowPayments();
                        ShowVoidPayment();
                        gbAllProjects.Enabled = true;
                        gbAllUsers.Enabled = true;
                        gbPaymentData.Enabled = false;
                        btnPaymentCreate.Visible = false;
                        btnPaymentSwitchCancel.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnPaymentSwitchUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedPayment().Id == -1) return;
            gbAllPayments.Enabled = false;
            gbPaymentData.Enabled = true;
            btnPaymentUpdate.Visible = true;
            btnPaymentSwitchCancel.Visible = true;
            ShowSelectedPayment();
        }

        private void BtnPaymentUpdate_Click(object sender, EventArgs e)
        {
            var payment = SelectedPayment();
            var project = GetProjectFromPayment(payment);
            if (project.DateOfPaymentIsChecked(dtpPaymentDate.Value) &&
                Payment.amountRegex.IsMatch(tbPaymentAmout.Text))
            {
                payment.DateOfPayment = dtpPaymentDate.Value;
                payment.Amount = Convert.ToDouble(tbPaymentAmout.Text);
                try
                {
                    payment.Update(driver);
                    gbAllPayments.Enabled = true;
                    gbPaymentData.Enabled = false;
                    btnPaymentUpdate.Visible = false;
                    btnPaymentSwitchCancel.Visible = false;
                    ShowPayments();
                    ShowVoidPayment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnPaymentDelete_Click(object sender, EventArgs e)
        {
            var payment = SelectedPayment();
            if (payment.Id == -1) return;
            string projectName = GetProjectFromPayment(payment).ToString();
            string userName = GetUserFromPayment(payment).Name;
            DialogResult result = MessageBox.Show
                         ($"Вы действительно хотите удалить безвозвратно оплату по проекту" +
                         $"{projectName} исполнителю {userName} {payment.Amount}?",
                         "Удаление оплаты", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    payment.Delete(driver);
                    MessageBox.Show($"Оплата по проекту {projectName} исполнителю {userName} " +
                        $"{payment.Amount} удалена", "Удаление оплаты", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowPayments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
