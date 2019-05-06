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
            ShowActualProjectInSectionOfBuilding();
        }

        private void ShowlabelActualUserName()
        {
            labelActualUserName.Text = $"Текущий пользователь: {actualUser.Name}";
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

        private decimal GetAmountSomeWorkByProjectAndUser(int idProject, User user, 
            Func<int, IDriverDB,decimal> GetAmount)
        {
            decimal amount = -1;
            if (user.Id == -1 || idProject == -1) return amount;
            try
            {
                amount = GetAmount(idProject, driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return amount;
        }

        private decimal GetAmountPaymentsByProjectAndUser(int idProject, User user)
        {
            return GetAmountSomeWorkByProjectAndUser(idProject, user,
                user.GetPaymentsAmountByProject);
        }

        private decimal GetAmountCompletedWorkByProjectAndUser(int idProject, User user)
        {
            return GetAmountSomeWorkByProjectAndUser(idProject, user, 
                user.GetAmountCompletedWorkByProject);
        }

        private decimal GetAmountAcceptedWorkByProjectAndUser(int idProject, User user)
        {
            return GetAmountSomeWorkByProjectAndUser(idProject, user,
                user.GetAmountAcceptedWorkByProject);
        }

        private decimal GetAmountRejectedWorkByProjectAndUser(int idProject, User user)
        {
            return GetAmountSomeWorkByProjectAndUser(idProject, user,
                user.GetAmountRejectedWorkByProject);
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
                string client = project.IdClient == -1? 
                    "нет" : ReadClient(project.IdClient).ToString();
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

        void ShowUsersWithAmountInProject(User[] users, int idProject, DataGridView dgvUsers, int height)
        {
            if (idProject == -1) return;
            ClearAndSetHeightDgv(dgvUsers, height, users.Length);
            foreach (User user in users)
            {
                string payments = GetStringFromDecimalValue(
                    GetAmountPaymentsByProjectAndUser(actualProject.Id, user));
                string complete = GetStringFromDecimalValue(
                    GetAmountCompletedWorkByProjectAndUser(actualProject.Id, user));
                string accept = GetStringFromDecimalValue(
                    GetAmountAcceptedWorkByProjectAndUser(actualProject.Id, user));
                string reject = GetStringFromDecimalValue(
                    GetAmountRejectedWorkByProjectAndUser(actualProject.Id, user));
                dgvUsers.Rows.Add(user.Id, user.Name, user.Passport, user.ManagerAccessString, payments,
                    complete, accept, reject);
            }
        }

        private void ShowWorksAmountBySectionOfBuilding(SectionOfBuilding sectionOfBuilding,
            Label lblWorksAmount)
        {
            decimal amount = GetAmountByWorksFromSectionOfBuilding(sectionOfBuilding);
            lblWorksAmount.Text = amount == -1 ?
                    "Общая стоимость работ по модели не определена":
                    $"Общая стоимость работ по модели {amount.ToString()} руб.";
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

        
    }
}
