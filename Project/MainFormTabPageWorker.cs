using System;
using System.Collections.Generic;
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
            ClearAndSetHeightDgv(dgvWorkerProjects, 154, workerProjects.Length);
            foreach(Project project in workerProjects)
                dgvWorkerProjects.Rows.Add
                    (project.Id, project.Name, project.Address,
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

        private void ShowWorkerTotalSquareByProject(Project project)
        {
            decimal totalSquare = GetTotalSquare(project);
            string text = "";
            if (totalSquare == -1) text = "Общая площадь проекта не определена";
            else text = $"Общая площадь проекта {totalSquare.ToString()} кв.м.";
            lblWorkerProjectTotalSquare.Text = text;
        }

        private void ShowWorkerTotalAmountByProject(Project project)
        {
            decimal totalAmount = GetTotalAmount(project);
            string text = "";
            if (totalAmount == -1)
                text = "Общая стоимость работ проекта не определена";
            else
                text = $"Общая стоимость работ проекта {totalAmount.ToString()} руб.";
            lblWorkerProjectWorksAmount.Text = text;
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
                ShowWorkerTotalSquareByProject(selectedProject);
                ShowWorkerTotalAmountByProject(selectedProject);
                ShowWorkerPayments();
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
            var worksInProject = ReadAllWorksInProject(sectionOfBuilding.IdProject);
            ClearAndSetHeightDgv(dgvWorkerWorksInProject, 380, worksInProject.Length);
            foreach (WorkInProject work in worksInProject)
            {
                var typeOfWork = ReadTypeOfWork(work.IdTypeOfWork);
                decimal valueByWork = GetValueByWorkFromSectionOfBuilding(work, sectionOfBuilding);
                if (valueByWork == -1)
                    dgvWorkerWorksInProject.Rows.Add(
                        work.Id, typeOfWork.Name, typeOfWork.MeasureUnit, work.Price,
                        work.Multiplicity, "не определено", "не определено");
                else dgvWorkerWorksInProject.Rows.Add(
                        work.Id, typeOfWork.Name, typeOfWork.MeasureUnit, work.Price,
                        work.Multiplicity, valueByWork,
                        valueByWork * (decimal)work.Price);
            }
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

        //ShowVoidEntity

        //ShowSelectedEntity

        //TbDate_Click

        //DtpDate_valueChanged

        //Tb_TextChanged

        //BtnSwitchCreate_Click

        //BtnSwitchCancel_Click

        //BtnCreate_Click

        //BtnSwitchUpdate_Click

        //BtnUpdate_Click

        //BtnDelete_Click
    }
}
