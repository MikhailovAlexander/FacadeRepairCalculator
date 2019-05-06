using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm:Form
    {
    //ReadAllEntities
        private Project[] ReadProjectsByActualUser()
        {
            var projects = new Project[0];
            try
            {
                projects = actualUser.GetProjects(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return projects;
        }

        private Payment[] ReadPaymentsByActualUserAndProject(int idProject)
        {
            var payments = new Payment[0];
            try
            {
                payments = actualUser.GetPaymentsByProject(idProject, driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return payments;
        }

        private WorkLog[] ReadWorkLogs(int idWorkByElement)
        {
            return ReadAllObjectsByParam<WorkLog>(idWorkByElement, driver.ReadWorkLogs);
        }

        //SelectedEntity
        private Project SelectedWorkerProject()
        {
            return SelectedObject<Project>(dgvWorkerProjects, driver.ReadProject);
        }

        private SectionOfBuilding SelectedWorkerSectionOfBuilding()
        {
            return SelectedObject<SectionOfBuilding>(
                dgvWorkerSectionsOfBuilding, driver.ReadSectionOfBuilding);
        }

        private WorkInProject SelectedWorkerWorkInProject()
        {
            return SelectedObject<WorkInProject>(dgvWorkerWorksInProject, driver.ReadWorkInProject);
        }

        //Rb_CheckedChanged

        //ShowEntities
        private void ShowWorkerProjects()
        {
            var workerProjects = ReadProjectsByActualUser();
            ShowProjectsInDgv(workerProjects, dgvWorkerProjects, gbWorkerProjects.Height);
        }

        private void DgvWorkerProjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorkerProjects.SelectedRows.Count == 0)
            {
                dgvWorkerSectionsOfBuilding.Rows.Clear();
                dgvWorkerPayments.Rows.Clear();
            }
            else
            {
                var selectedProject = SelectedWorkerProject();
                ShowWorkerSectionsOfBuilding(selectedProject);
                ShowWorkerPayments();
                ShowUserData();
            }
        }

        private void ShowWorkerSectionsOfBuilding(Project project)
        {
            ShowSectionsOfBuilding(project, lblWorkerProjectNotFound,
            dgvWorkerSectionsOfBuilding, gbWorkerSectionsOfBuilding);
        }

        private void DgvWorkerSectionsOfBuilding_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorkerProjects.SelectedRows.Count == 0 || 
                dgvWorkerSectionsOfBuilding.SelectedRows.Count == 0)
            {
                lblWorkerSectionOfBuildingWorkAmount.Text = "Модель не выбрана";
                workerModel.Clear();
            }
            else
            {
                var sectionOfBuilding = SelectedWorkerSectionOfBuilding();
                ShowWorkerWorksInProject();
                ShowWorksAmountBySectionOfBuilding(sectionOfBuilding, 
                    lblWorkerSectionOfBuildingWorkAmount);
                workerModel.ShowModel(sectionOfBuilding);
            }
        }

        private void ShowWorkerWorksInProject()
        {
            if (dgvWorkerSectionsOfBuilding.SelectedRows.Count == 0)
            {
                dgvWorkerWorksInProject.Rows.Clear();
                return;
            }
            var sectionOfBuilding = SelectedWorkerSectionOfBuilding();
            if (sectionOfBuilding.Id == -1)
            {
                dgvWorkerWorksInProject.Rows.Clear();
                return;
            }
            ShowWorksInProject(sectionOfBuilding.IdProject, sectionOfBuilding, 
                dgvWorkerWorksInProject, 380);
        }

        private void DgvWorkerWorksInProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorkerWorksInProject.SelectedRows.Count == 0 ||
                dgvWorkerSectionsOfBuilding.SelectedRows.Count == 0) return;
            else
            {
                var workInProject = SelectedWorkerWorkInProject();
                workerModel.ShowWorkInModel(workInProject);
            }
            workerWorkLog.ShowWorkByElementInfo();
        }

        private void ShowUserData()
        {
            User[] users = { actualUser};
            ShowUsersWithAmountInProject(users, SelectedWorkerProject().Id, dgvWorkerUserData, 50);
        }

        private void ShowWorkerPayments()
        {
            if (dgvWorkerProjects.SelectedRows.Count == 0)
            {
                dgvWorkerPayments.Rows.Clear();
                return;
            }
            var project = SelectedWorkerProject();
            if (project.Id == -1)
            {
                dgvWorkerPayments.Rows.Clear();
                return;
            }
            var payments = ReadPaymentsByActualUserAndProject(project.Id);
            ClearAndSetHeightDgv(dgvWorkerPayments, 400, payments.Length);
            decimal amountByProject = 0;
            foreach (Payment payment in payments)
            {
                dgvWorkerPayments.Rows.Add(payment.Id, payment.DateOfPayment.Date, payment.Amount);
                amountByProject += (decimal)payment.Amount;
            }
            lblWorkerPaymentAmount.Text = $"Cумма выплат по проетку {amountByProject} руб.";
        }

        private void DgvWorkerModel_SelectionChanged(object sender, EventArgs e)
        {
            workerWorkLog.ShowWorkByElementInfo();
        }

        //ShowVoidEntity

        //ShowSelectedEntity

        //TbDate_Click

        //DtpDate_valueChanged

        //Tb_TextChanged

        //BtnSwitchCreate_Click
        private void BtnWorkerSwitchCompleteWork_Click(object sender, EventArgs e)
        {
            if (dgvWorkerProjects.SelectedRows.Count == 0 || 
                dgvWorkerSectionsOfBuilding.SelectedRows.Count == 0 ||
                dgvWorkerWorksInProject.SelectedRows.Count == 0) return;
            if (SelectedWorkerProject().State != ProjectState.Actual) return;
            gbWorkerCompletePanel.Visible = true;
            dtpWorkerDateOfComplete.Value = DateTime.Now;
            dgvWorkerWorksInProject.Width = 749;
        }

        //BtnSwitchCancel_Click
        private void BtnWorkerSwitchCompleteWorkCancel_Click(object sender, EventArgs e)
        {
            gbWorkerCompletePanel.Visible = false;
            dgvWorkerWorksInProject.Width = 944;
        }

        //BtnCreate_Click
        private void BtnWorkerCompleteWork_Click(object sender, EventArgs e)
        {
            DateTime date = dtpWorkerDateOfComplete.Value;
            int idWorkInProject = SelectedWorkerWorkInProject().Id;
            var selectedCells = dgvWorkerModel.SelectedCells;
            List<WorkByElement> workByElements = new List<WorkByElement>();
            try
            {
                foreach (DataGridViewCell cell in selectedCells)
                {
                    int idElement = (int)cell.Tag;
                    if (ElementHasWork(idElement, idWorkInProject))
                    {
                        var workByElement = GetWorkByElement(idElement, idWorkInProject);
                        if (workByElement.CompleteCheck(date, driver))
                            workByElements.Add(workByElement);
                    }
                }
                if(workByElements.Count == 0)
                {
                    MessageBox.Show($"Нет элементов для выполнения работы",
                        "Выполнение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                WorkByElement.CreateWorkLogsComplete(
                    workByElements, actualUser.Id, date, driver);
                ShowWorkerProjects();
                ShowUserData();
                workerModel.ShowModel(SelectedWorkerSectionOfBuilding());
                workerModel.ShowWorkInModel(SelectedWorkerWorkInProject());
                ShowWorkerWorksInProject();
                MessageBox.Show($"Выполнение работы для {workByElements.Count} элементов",
                        "Выполнение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnWorkerCompleteWorkCancel_Click(object sender, EventArgs e)
        {
            int idWorkInProject = SelectedWorkerWorkInProject().Id;
            var selectedCells = dgvWorkerModel.SelectedCells;
            List<WorkLog> completeWorkLogs = new List<WorkLog>();
            try
            {
                foreach (DataGridViewCell cell in selectedCells)
                {
                    int idElement = (int)cell.Tag;
                    if (ElementHasWork(idElement, idWorkInProject))
                    {
                        var workByElement = GetWorkByElement(idElement, idWorkInProject);
                        WorkLog workLog = 
                            workByElement.GetCompleteLog2Delete(actualUser.Id, driver);
                        if (workLog.Id != -1)
                            completeWorkLogs.Add(workLog);
                    }
                }
                if(completeWorkLogs.Count == 0)
                {
                    MessageBox.Show($"Нет элементов для отмены выполнения",
                       "Отмена выполнения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                WorkByElement.DeleteWorkLogsComplete(completeWorkLogs, driver);
                ShowWorkerProjects();
                ShowUserData();
                workerModel.ShowModel(SelectedWorkerSectionOfBuilding());
                workerModel.ShowWorkInModel(SelectedWorkerWorkInProject());
                ShowWorkerWorksInProject();
                MessageBox.Show($"Отмена выполнения работы для {completeWorkLogs.Count} элементов",
                        "Отмена выполнения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnWorkerSwitchChangePassword_Click(object sender, EventArgs e)
        {

            if (actualUser.Id == -1) return;
            
            var inputBox = new InputBox("Смена пароля", "Введите новый пароль", 
                "от 8 до 16 символов в т.ч. цифра, заглавная и строчная латинские буквы",
                Color.White, User.PasswordIsMatch);
            inputBox.SetPasswordChar();
            inputBox.ShowDialog();
            if (inputBox.DialogResult == DialogResult.Cancel) return;
            var password = inputBox.Input;
            inputBox.InputClear();
            inputBox.LabelSet("Введите новый пароль еще раз");
            inputBox.ShowDialog();
            if (inputBox.DialogResult == DialogResult.Cancel) return;
            if (!password.Equals(inputBox.Input))
            {
                MessageBox.Show($"Введенные пароли не совпадают",
                    "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                actualUser.ChangePassword(password, hashPasswordCreator);
                actualUser.Update(driver);
                MessageBox.Show($"Произведена смена пароля",
                    "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
