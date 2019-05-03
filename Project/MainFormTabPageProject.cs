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
    public partial class MainForm : Form
    {
        //ReadAllEntities
        private Project[] ReadAllProjects()
        {
            return ReadAllObjectT<Project>(driver.ReadAllProject);
        }

        private Project ReadProject(int idProject)
        {
            return ReadObject<Project>(idProject, driver.ReadProject);
        }

        private decimal GetTotalValue(Project project, Func<IDriverDB, decimal> GetValue)
        {
            decimal totalValue = -1;
            if (project.Id == -1) return totalValue;
            try
            {
                totalValue = GetValue(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return -1;
            }
            return totalValue;
        }

        private decimal GetTotalAmount(Project project)
        {
            return GetTotalValue(project, project.GetTotalAmount);
        }

        private decimal GetTotalSquare(Project project)
        {
            return GetTotalValue(project, project.GetTotalSquare);
        }

        private decimal GetAmountPayments(Project project)
        {
            return GetTotalValue(project, project.GetAmountPayments);
        }

        private decimal GetTotalAmountCompletedWork(Project project)
        {
            return GetTotalValue(project, project.GetTotalAmountCompletedWork);
        }

        private decimal GetTotalAmountAcceptedWork(Project project)
        {
            return GetTotalValue(project, project.GetTotalAmountAcceptedWork);
        }

        private decimal GetTotalAmountRejectedWork(Project project)
        {
            return GetTotalValue(project, project.GetTotalAmountRejectedWork);
        }

        //SelectedEntity
        Project SelectedProject()
        {
            return SelectedObject<Project>(dgvAllProjects, driver.ReadProject);
        }

        //Rb_CheckedChanged

        //ShowEntities
        void ShowClientList()
        {
            var allClients = ReadAllClients();
            ClearAndSetHeightDgv(dgvProjectClients, 250, allClients.Length);
            dgvProjectClients.Visible = true;
            foreach (Client client in allClients)
            {
                dgvProjectClients.Rows.Add(client.ToString());
            }
        }
        //TODO Refact
        private int GetIdClientFromTbProjectClient()
        {
            int idClient = -1;
            try
            {
                idClient = Convert.ToInt32(Project.clientRegex.Match(tbProjectClient.Text).Groups[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return idClient;
        }

        void ShowProjects()
        {
            var allProjects = ReadAllProjects();
            ClearAndSetHeightDgv(dgvAllProjects, gbAllProjects, allProjects.Length);
            foreach (Project project in allProjects)
            {
                dgvAllProjects.Rows.Add
                    (project.Id, project.Name, project.Address,
                    ReadObject<Client>(project.IdClient, driver.ReadClient).ToString(),
                    Project.ProjectStateDictionary[project.State],
                    //Замена минимального значения даты на "Не установлена" 
                    //для отображения пользователю
                    (project.DateOfStart == new DateTime(1970, 01, 01)) ?
                    "Не установлена" : project.DateOfStart.Date.ToString(),
                    (project.DateOfComplete == new DateTime(1970, 01, 01)) ?
                    "Не установлена" : project.DateOfComplete.Date.ToString(),
                    (project.PlannedDateOfComplete == new DateTime(1970, 01, 01)) ?
                   "Не установлена" : project.PlannedDateOfComplete.Date.ToString());
            }
        }

        private void ShowTotalSquareByActualProject()
        {
            decimal totalSquare = GetTotalSquare(actualProject);
            string text = "";
            if (totalSquare == -1) text = "Общая площадь проекта не определена";
            else text = $"Общая площадь проекта {totalSquare.ToString()} кв.м.";
            lblSectionOfBuildingActualProjectTotalSquare.Text = text;
            lblProjectTotalSquare.Text = text;
        }

        private void ShowTotalAmountByActualProject()
        {
            decimal totalAmount = GetTotalAmount(actualProject);
            string text = "";
            if (totalAmount == -1)
                text = "Общая стоимость работ проекта не определена";
            else
                text = $"Общая стоимость работ проекта {totalAmount.ToString()} руб.";
            lblSectionOfBuildingActualProjectWorksAmount.Text = text;
            lblProjectWorksAmount.Text = text;
        }

        private void ShowAmountPaymentsByActualProject()
        {
            decimal amount = GetAmountPayments(actualProject);
            string text = "";
            if (amount == -1)
                text = "Сумма выплат по проекту не определена";
            else
                text = $"Сумма выплат по проекту {amount.ToString()} руб.";
            lbllProjectAmountPayments.Text = text;
        }

        private void ShowTotalAmountCompletedWorkByActualProject()
        {
            decimal totalAmount = GetTotalAmountCompletedWork(actualProject);
            string text = "";
            text = totalAmount == -1? "Общая стоимость выполненных работ не определена":
                $"Общая стоимость выполненных работ {totalAmount.ToString()} руб.";
            lblProjectCompletedWork.Text = text;
            //lblProjectWorksAmount.Text = text;
        }

        private void ShowTotalAmountAcceptedWorkByActualProject()
        {
            decimal totalAmount = GetTotalAmountAcceptedWork(actualProject);
            string text = "";
            text = totalAmount == -1 ? "Общая стоимость принятых работ не определена" :
                $"Общая стоимость принятых работ {totalAmount.ToString()} руб.";
            lblProjectAcceptedWork.Text = text;
            //lblProjectWorksAmount.Text = text;
        }

        private void ShowTotalAmountRejectedWorkByActualProject()
        {
            decimal totalAmount = GetTotalAmountRejectedWork(actualProject);
            string text = "";
            text = totalAmount == -1 ? "Общая стоимость отклоненных работ не определена" :
                $"Общая стоимость отклоненных работ {totalAmount.ToString()} руб.";
            lblProjectRejectedWork.Text = text;
            //lblProjectWorksAmount.Text = text;
        }

        //ShowVoidEntity 
        void ShowVoidProject()
        {
            gbProjectDataStart.Enabled = false;
            tbProjectName.Clear();
            tbProjectAddress.Clear();
            tbProjectClient.Clear();
            //
            dtpProjectDateOfStart.Value = new DateTime(1970, 1, 1);
            dtpProjectPlannedDateOfComplete.Value = new DateTime(1970, 1, 1);
            pbCheckMarkProjectName.Visible = false;
            pbCheckMarkProjectAddress.Visible = false;
            pbCheckMarkProjectClient.Visible = false;
            pbCheckMarkProjectDateOfStart.Visible = false;
            pbCheckMarkProjectPlannedDateOfComplete.Visible = false;
            lblCheckProjectName.Visible = false;
            lblCheckProjectAddress.Visible = false;
            lblCheckProjectClient.Visible = false;
            lblCheckProjectDateOfStart.Visible = false;
            lblCheckProjectPlannedDateOfComplete.Visible = false;
        }

        //ShowSelectedEntity
        void ShowSelectedProject()
        {
            var selectedProject = SelectedProject();
            tbProjectName.Text = selectedProject.Name;
            tbProjectAddress.Text = selectedProject.Address;
            tbProjectClient.Text = ReadClient(selectedProject.IdClient).ToString();
            if (selectedProject.State != ProjectState.Planned)
            {
                dtpProjectDateOfStart.Value = selectedProject.DateOfStart;
                dtpProjectPlannedDateOfComplete.Value = selectedProject.PlannedDateOfComplete;
            }
            pbCheckMarkProjectName.Visible = false;
            pbCheckMarkProjectAddress.Visible = false;
            pbCheckMarkProjectClient.Visible = false;
            pbCheckMarkProjectDateOfStart.Visible = false;
            pbCheckMarkProjectPlannedDateOfComplete.Visible = false;
            lblCheckProjectName.Visible = false;
            lblCheckProjectAddress.Visible = false;
            lblCheckProjectClient.Visible = false;
            lblCheckProjectDateOfStart.Visible = false;
            lblCheckProjectPlannedDateOfComplete.Visible = false;
        }

        //TbDate_Click
        private void TbProjectDateOfStart_Click(object sender, EventArgs e)
        {
            tbProjectDateOfStart.Visible = false;
            dtpProjectDateOfStart.Visible = true;
        }

        private void TbProjectPlannedDateOfComplete_Click(object sender, EventArgs e)
        {
            tbProjectPlannedDateOfComplete.Visible = false;
            dtpProjectPlannedDateOfComplete.Visible = true;
        }

        //DtpDate_valueChanged
        private void DtpProjectDateOfStart_ValueChanged(object sender, EventArgs e)
        {
            lblCheckProjectDateOfStart.Visible =
                dtpProjectDateOfStart.Value >= dtpProjectPlannedDateOfComplete.Value;
            pbCheckMarkProjectDateOfStart.Visible =
                dtpProjectDateOfStart.Value < dtpProjectPlannedDateOfComplete.Value;
            lblCheckProjectPlannedDateOfComplete.Visible =
                dtpProjectDateOfStart.Value >= dtpProjectPlannedDateOfComplete.Value;
            pbCheckMarkProjectPlannedDateOfComplete.Visible =
                dtpProjectDateOfStart.Value < dtpProjectPlannedDateOfComplete.Value;
            ShowDateInTb(tbProjectDateOfStart, dtpProjectDateOfStart);
        }

        private void DtpProjectPlannedDateOfComplete_ValueChanged(object sender, EventArgs e)
        {
            lblCheckProjectPlannedDateOfComplete.Visible =
                dtpProjectDateOfStart.Value >= dtpProjectPlannedDateOfComplete.Value;
            pbCheckMarkProjectPlannedDateOfComplete.Visible =
                dtpProjectDateOfStart.Value < dtpProjectPlannedDateOfComplete.Value;
            lblCheckProjectDateOfStart.Visible =
                dtpProjectDateOfStart.Value >= dtpProjectPlannedDateOfComplete.Value;
            pbCheckMarkProjectDateOfStart.Visible =
                dtpProjectDateOfStart.Value < dtpProjectPlannedDateOfComplete.Value;
            ShowDateInTb(tbProjectPlannedDateOfComplete, dtpProjectPlannedDateOfComplete);
        }
        
        //Tb_TextChanged
        private void TbProjectName_TextChanged(object sender, EventArgs e)
        {
            lblCheckProjectName.Visible = !Project.NameIsMatch(tbProjectName.Text);
            pbCheckMarkProjectName.Visible =
                Project.NameIsMatch(tbProjectName.Text);
        }

        private void TbProjectAddress_TextChanged(object sender, EventArgs e)
        {
            lblCheckProjectAddress.Visible = !Project.AddressIsMatch(tbProjectAddress.Text);
            pbCheckMarkProjectAddress.Visible =
                Project.AddressIsMatch(tbProjectAddress.Text);
        }

        private void TbProjectClient_TextChanged(object sender, EventArgs e)
        {
            lblCheckProjectClient.Visible = !Project.ClientIsMatch(tbProjectClient.Text);
            pbCheckMarkProjectClient.Visible =
                Project.ClientIsMatch(tbProjectClient.Text);
        }

        //BtnSwitchCancel_Click
        private void BtnProjectSwitchCancel_Click(object sender, EventArgs e)
        {
            //Защита от несохраненных изменений текущего проекта
            if (actualProject.Id != -1)
                actualProject = ReadProject(actualProject.Id);
            gbProjectData.Enabled = false;
            gbAllProjects.Enabled = true;
            gbProjectDataStart.Enabled = false;
            ShowVoidProject();
            btnProjectUpdate.Visible = false;
            btnProjectSwitchCancel.Visible = false;
            btnProjectCreate.Visible = false;
            BtnProjectClientSelectCancel_Click(sender, e);
        }

        //BtnSwitchCreate_Click
        private void BtnSwitchCreateProject_Click(object sender, EventArgs e)
        {
            gbProjectData.Enabled = true;
            gbProjectDataName.Enabled = true;
            gbAllProjects.Enabled = false;
            btnProjectCreate.Visible = true;
            btnProjectUpdate.Visible = false;
            btnProjectSwitchCancel.Visible = true;
            ShowVoidProject();
            dtpProjectDateOfStart.Value = DateTime.Now;
            dtpProjectPlannedDateOfComplete.Value = DateTime.Now;
        }

        private void BtnProjectSetClient_Click(object sender, EventArgs e)
        {
            tbProjectClient.Visible = false;
            btnProjectSetClient.Visible = false;
            btnProjectClientSelect.Visible = true;
            btnProjectClientSelectCancel.Visible = true;
            ShowClientList();
            gbProjectDataName.Height = 381;
        }
        //TODO Refact
        private void BtnProjectClientSelect_Click(object sender, EventArgs e)
        {
            tbProjectClient.Text = dgvProjectClients.SelectedCells[0].Value.ToString();
            tbProjectClient.Visible = true;
            btnProjectSetClient.Visible = true;
            btnProjectClientSelect.Visible = false;
            btnProjectClientSelectCancel.Visible = false;
            dgvProjectClients.Visible = false;
            gbProjectDataName.Height = 181;
        }

        private void BtnProjectClientSelectCancel_Click(object sender, EventArgs e)
        {
            tbProjectClient.Visible = true;
            btnProjectSetClient.Visible = true;
            btnProjectClientSelect.Visible = false;
            btnProjectClientSelectCancel.Visible = false;
            dgvProjectClients.Visible = false;
            gbProjectDataName.Height = 181;
        }

        //BtnCreate_Click
        private void BtnCreateProject_Click(object sender, EventArgs e)
        {
            if (Project.NameIsMatch(tbProjectName.Text) &&
                Project.AddressIsMatch(tbProjectAddress.Text) &&
                Project.ClientIsMatch(tbProjectClient.Text))
                try
                {
                    string name = tbProjectName.Text;
                    string address = tbProjectAddress.Text;
                    int idClient = GetIdClientFromTbProjectClient();
                    Project project = new Project(name, address, idClient);
                    int newProjectId = driver.CreateProject(project);
                    MessageBox.Show($"Проект {project.Name} сохранен", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualProject = driver.ReadProject(newProjectId);
                    ShowProjects();
                    ShowActualProject();
                    gbProjectData.Enabled = false;
                    gbAllProjects.Enabled = true;
                    btnProjectCreate.Visible = false;
                    btnProjectSwitchCancel.Visible = false;
                    pbCheckMarkProjectName.Visible = false;
                    pbCheckMarkProjectAddress.Visible = false;
                    pbCheckMarkProjectClient.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //BtnSwitchUpdate_Click
        private void BtnSwitchUpdateProject_Click(object sender, EventArgs e)
        {
            gbProjectData.Enabled = true;
            gbProjectDataName.Enabled = true;
            gbAllProjects.Enabled = false;
            ShowSelectedProject();
            actualProject = SelectedProject();
            ShowActualProject();
            btnProjectUpdate.Visible = true;
            btnProjectSwitchCancel.Visible = true;
            if (actualProject.State != ProjectState.Planned)
            {
                gbProjectDataStart.Enabled = true;
                dtpProjectDateOfStart.Value = actualProject.DateOfStart;
                dtpProjectPlannedDateOfComplete.Value = actualProject.PlannedDateOfComplete;
            }
        }

        //BtnUpdate_Click
        private void BtnUpdateProject_Click(object sender, EventArgs e)
        {
            if (Project.NameIsMatch(tbProjectName.Text) &&
                Project.AddressIsMatch(tbProjectAddress.Text) &&
                Project.ClientIsMatch(tbProjectClient.Text))
            {
                Project project = new Project(actualProject.Id, actualProject.Name,
                    actualProject.Address, actualProject.IdClient, actualProject.State,
                    actualProject.DateOfStart, actualProject.DateOfComplete,
                    actualProject.PlannedDateOfComplete);
                try
                {
                    project.Name = tbProjectName.Text;
                    project.Address = tbProjectAddress.Text;
                    project.IdClient = GetIdClientFromTbProjectClient();
                    if (project.State != ProjectState.Planned)
                    {
                        if (dtpProjectPlannedDateOfComplete.Value <= dtpProjectDateOfStart.Value)
                        {
                            MessageBox.Show(
                                "Сохранение данных невозможно, не все поля заполнены корректно",
                                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            project.DateOfStart = dtpProjectDateOfStart.Value;
                            project.PlannedDateOfComplete = dtpProjectPlannedDateOfComplete.Value;
                        }
                    }
                    project.Update(driver);
                    actualProject = ReadProject(actualProject.Id);
                    MessageBox.Show($"Проект {project.Name} обновлен", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowProjects();
                    ShowActualProject();
                    gbProjectData.Enabled = false;
                    gbAllProjects.Enabled = true;
                    gbProjectDataStart.Enabled = false;
                    btnProjectUpdate.Visible = false;
                    btnProjectSwitchCancel.Visible = false;
                    pbCheckMarkProjectName.Visible = false;
                    pbCheckMarkProjectAddress.Visible = false;
                    pbCheckMarkProjectClient.Visible = false;
                    pbCheckMarkProjectDateOfStart.Visible = false;
                    pbCheckMarkProjectPlannedDateOfComplete.Visible = false;
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

        //BtnDelete_Click
        private void BtnDeleteProject_Click(object sender, EventArgs e)
        {
            var selectedProject = SelectedProject();
            DialogResult result = MessageBox.Show
                          ($"Вы действительно хотите безвозвратно удалить проект " +
                          $"{selectedProject.ToString()}?", "Удаление проекта",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProject.Delete(driver);
                    MessageBox.Show($"Проект {selectedProject.Name} удален",
                        "Удаление проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowProjects();
                    ShowVoidProject();
                    if(actualProject.Id == selectedProject.Id)
                    {
                        actualProject = new Project();
                        ShowActualProject();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnOpenProject_Click(object sender, EventArgs e)
        {
            actualProject = SelectedProject();
            ShowSelectedProject();
            ShowActualProject();
        }

        private void BtnProjectSwitchStart_Click(object sender, EventArgs e)
        {
            if (SelectedProject().State != ProjectState.Planned)
            {
                MessageBox.Show("Начать можно только планируемый проект",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            actualProject = SelectedProject();
            ShowActualProject();
            actualProject.State = ProjectState.Actual;
            ShowSelectedProject();
            gbAllProjects.Enabled = false;
            gbProjectData.Enabled = true;
            gbProjectDataName.Enabled = false;
            gbProjectDataStart.Enabled = true;
            btnProjectSwitchCancel.Visible = true;
            btnProjectUpdate.Visible = true;
        }
    }
}
