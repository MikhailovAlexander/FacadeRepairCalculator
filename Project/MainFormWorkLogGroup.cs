using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        private class WorkLogGroup
        {
            private MainForm mainForm;
            private ModelOfFacade model;
            private DataGridView dgvWorkLog;
            private DataGridView dgvWorksInProject;
            private WorkLog[] workLogs;
            private Label lblHeight;
            private Label lblLenght;
            private Label lblSquare;
            private Label lblMultiplicity;
            private Label lblAmount;
            
            public WorkLogGroup(
                MainForm mainForm, ModelOfFacade model, DataGridView dgvWorkLog, 
                DataGridView dgvWorksInProject, Label lblHeight, Label lblLenght, 
                Label lblSquare, Label lblMultiplicity, Label lblAmount)
            {
                this.mainForm = mainForm;
                this.model = model;
                this.dgvWorkLog = dgvWorkLog;
                this.dgvWorksInProject = dgvWorksInProject;
                workLogs = new WorkLog[0];
                this.lblHeight = lblHeight;
                this.lblLenght = lblLenght;
                this.lblSquare = lblSquare;
                this.lblMultiplicity = lblMultiplicity;
                this.lblAmount = lblAmount;
            }

            public void Clear()
            {
                dgvWorkLog.Rows.Clear();
                workLogs = new WorkLog[0];
                lblHeight.Text = "Высота";
                lblLenght.Text = "Ширина";
                lblSquare.Text = "Площадь";
                lblMultiplicity.Text = "Коэффициент элемента";
                lblAmount.Text = "Стоимость";
            }

            private void ShowWorkLog(WorkByElement workByElement)
            {
                if (workByElement.State == WorkState.Planned)
                {
                    dgvWorkLog.Rows.Clear();
                    return;
                }
                var workLogs = mainForm.ReadWorkLogs(workByElement.Id);
                mainForm.ClearAndSetHeightDgv(dgvWorkLog, 98, workLogs.Length);
                foreach (WorkLog workLog in workLogs)
                {
                    var user = mainForm.ReadUser(workLog.IdUser);
                    dgvWorkLog.Rows.Add(workLog.Id, workLog.Date.Date, workLog.GetTypeString(),
                        user.Name, workLog.Comment);
                }
            }

            public void ShowWorkByElementInfo()
            {
                if (model.DgvModel.SelectedCells.Count != 1 ||
                    dgvWorksInProject.SelectedRows.Count != 1 ||
                    model.DgvModel.SelectedCells[0].Tag == null)
                {
                   Clear();
                    return;
                }
                int idElement = (int)model.DgvModel.SelectedCells[0].Tag;
                var element = mainForm.ReadElement(idElement);
                if(element.Id == -1 || element.IdTypeOfElement == -1)
                {
                    Clear();
                    return;
                }
                var typeOfElement = mainForm.GetTypeOfElement(idElement);
                var workInProject = mainForm.SelectedObject<WorkInProject>(dgvWorksInProject,
                    mainForm.driver.ReadWorkInProject);
                if (!mainForm.ElementHasWork(idElement, workInProject.Id))
                {
                    Clear();
                    return;
                }
                var workByElement = mainForm.GetWorkByElement(idElement, workInProject.Id);
                lblHeight.Text = $"Высота {typeOfElement.Height} м.";
                lblLenght.Text = $"Ширина {typeOfElement.Length} м.";
                lblSquare.Text = $"Площадь {typeOfElement.Square} кв.м.";
                lblMultiplicity.Text =
                    $"Коэффициент элемента {workByElement.Multiplicity}";
                var valueWorkByElement = mainForm.GetValueWorkByElement(workByElement);
                lblAmount.Text = valueWorkByElement == -1 ?
                     "Стоимость не определена" :
                     $"Стоимость {valueWorkByElement * (decimal)workInProject.Price} руб.";
                ShowWorkLog(workByElement);
            }
        }
    }
}