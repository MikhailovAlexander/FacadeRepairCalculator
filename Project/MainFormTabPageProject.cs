﻿using System;
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

        private Project[] ReadAllProjectsByState(ProjectState state)
        {
            var projects = new Project[0];
            try
            {
                projects = driver.ReadAllProjectByState(state);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return projects;
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

        private void RbAllProjects_CheckedChanged(object sender, EventArgs e)
        {
            ShowProjects();
        }

        private void RbPlannedProjects_CheckedChanged(object sender, EventArgs e)
        {
            ShowProjects();
        }

        private void RbActualProjects_CheckedChanged(object sender, EventArgs e)
        {
            ShowProjects();
        }

        private void RbCompletedProjects_CheckedChanged(object sender, EventArgs e)
        {
            ShowProjects();
        }

        private void RbCanceledProjects_CheckedChanged(object sender, EventArgs e)
        {
            ShowProjects();
        }

        //ShowEntities
        void ShowClientList()
        {
            var allClients = ReadAllClients();
            ClearAndSetHeightDgv(dgvProjectClients, 159, allClients.Length);
            dgvProjectClients.Visible = true;
            dgvProjectClients.Location = new Point(142, 12);
            foreach (Client client in allClients)
            {
                dgvProjectClients.Rows.Add(client.ToString());
            }
        }

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
            var allProjects = new Project[0];
            if (rbAllProjects.Checked) allProjects = ReadAllProjects();
            else if (rbPlannedProjects.Checked) allProjects = ReadAllProjectsByState(ProjectState.Planned);
            else if (rbActualProjects.Checked) allProjects = ReadAllProjectsByState(ProjectState.Actual);
            else if (rbCompletedProjects.Checked) allProjects = ReadAllProjectsByState(ProjectState.Completed);
            else if (rbCanceledProjects.Checked) allProjects = ReadAllProjectsByState(ProjectState.Canceled);
            ShowProjectsInDgv(allProjects, dgvAllProjects, 715);
        }
        
        //ShowVoidEntity 
        void ShowVoidProject()
        {
            gbProjectDataStart.Enabled = false;
            tbProjectName.Clear();
            tbProjectAddress.Clear();
            tbProjectClient.Clear();
            dtpProjectDateOfStart.Value = new DateTime(1970, 1, 1);
            dtpProjectPlannedDateOfComplete.Value = new DateTime(1970, 1, 1);
            dtpProjectDateOfComplete.Value = new DateTime(1970, 1, 1);
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
            if (selectedProject.State == ProjectState.Completed)
                dtpProjectDateOfComplete.Value = selectedProject.DateOfComplete;
            else dtpProjectDateOfComplete.Value = new DateTime(1970, 1, 1);
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

        private void DtpProjectDateOfComplete_ValueChanged(object sender, EventArgs e)
        {
            ShowDateInTb(tbProjectDateOfComplete, dtpProjectDateOfComplete);
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
            btnProjectUpdate.Enabled = false;
            btnProjectSwitchCancel.Enabled = false;
            btnProjectCreate.Enabled = false;
            BtnProjectClientSelectCancel_Click(sender, e);
        }

        //BtnSwitchCreate_Click
        private void BtnSwitchCreateProject_Click(object sender, EventArgs e)
        {
            gbProjectData.Enabled = true;
            gbProjectDataName.Enabled = true;
            gbAllProjects.Enabled = false;
            btnProjectCreate.Enabled = true;
            btnProjectUpdate.Enabled = false;
            btnProjectSwitchCancel.Enabled = true;
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
        }
        
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
                    btnProjectCreate.Enabled = false;
                    btnProjectSwitchCancel.Enabled = false;
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
            if (SelectedProject().State == ProjectState.Canceled ||
                SelectedProject().State == ProjectState.Canceled)
            {
                MessageBox.Show("Редактировать можно только планируемый или текущий проект",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gbProjectData.Enabled = true;
            gbProjectDataName.Enabled = true;
            gbAllProjects.Enabled = false;
            ShowSelectedProject();
            actualProject = SelectedProject();
            ShowActualProject();
            btnProjectCreate.Enabled = false;
            btnProjectUpdate.Enabled = true;
            btnProjectSwitchCancel.Enabled = true;
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
                    btnProjectUpdate.Enabled = false;
                    btnProjectSwitchCancel.Enabled = false;
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
            var inputBox = new InputBox("Старт проекта", "Введите дату начала проекта");
            inputBox.ShowDialog();
            if (inputBox.DialogResult == DialogResult.Cancel) return;
            DateTime dateOfStart = inputBox.DateTimeInput;
            inputBox = new InputBox("Старт проекта", "Введите плановую дату окончания проекта");
            inputBox.ShowDialog();
            if (inputBox.DialogResult == DialogResult.Cancel)return;
            DateTime plannedDateOfComplete = inputBox.DateTimeInput;
            if(actualProject.DatesOfStartAndPlanIsChecked(dateOfStart, plannedDateOfComplete))
            {
                try
                {
                    actualProject.Start(dateOfStart, plannedDateOfComplete, driver);
                    MessageBox.Show("Статус проекта изменен", "Старт проекта", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowActualProject();
                    ShowProjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Дата окончания должна быть позднее даты начала",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProjectCancel_Click(object sender, EventArgs e)
        {
            var selectedProject = SelectedProject();
            if(selectedProject.State == ProjectState.Canceled)
            {
                MessageBox.Show($"Проект {selectedProject.Name} уже отменен",
                        "Отмена проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show
                          ($"Вы действительно хотите отменить проект " +
                          $"{selectedProject.ToString()}?", "Отмена проекта",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProject.Cancel(driver);
                    MessageBox.Show($"Проект {selectedProject.Name} отменен",
                        "Отмена проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowProjects();
                    ShowVoidProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnProjectComplete_Click(object sender, EventArgs e)
        {
            if (SelectedProject().State != ProjectState.Actual)
            {
                MessageBox.Show("Завершить можно только текущий проект",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            actualProject = SelectedProject();
            ShowActualProject();
            var inputBox = new InputBox("Завершение проекта", "Введите дату завершения проекта");
            inputBox.ShowDialog();
            if (inputBox.DialogResult == DialogResult.Cancel) return;
            DateTime dateOfComplete = inputBox.DateTimeInput;
            if (!actualProject.DateOfCompleteCheck(dateOfComplete, driver))
            {
                MessageBox.Show(
                    "Дата завершения проекта не может быть ранее даты оплаты или учета работы",
               "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!actualProject.AllWorksAccepted(driver))
            {
                MessageBox.Show(
                    "Приняты не все работы",
               "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (actualProject.CompleteCheck(dateOfComplete, driver))
            {
                try
                {
                    actualProject.Complete(dateOfComplete, driver);
                    MessageBox.Show($"Проект {actualProject.Name} завершен",
                        "Завершение проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowActualProject();
                    ShowProjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не всем исполнителям произведена оплата",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnViewProjectsByState_Click(object sender, EventArgs e)
        {
            ShowProjects();
        }

    }
}
