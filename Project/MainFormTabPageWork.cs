using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        //ReadAllEntities
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

        //SelectedEntity
        private TypeOfWork SelectedTypeOfWork()
        {
            return SelectedObject<TypeOfWork>(dgvAllTypesOfWork, driver.ReadTypeOfWork);
        }

        private WorkInProject SelectedWorkInProject()
        {
            return SelectedObject<WorkInProject>(
                    dgvWorksInActualProject, driver.ReadWorkInProject);
        }

        //Rb_CheckedChanged

        //ShowEntities
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

        //ShowVoidEntity
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

        //ShowSelectedEntity
        private void ShowSelectedTypeOfWork()
        {
            var tow = SelectedTypeOfWork();
            tbTypeOfWorkName.Text = tow.Name;
            tbTypeOfWorkMeasureUnit.Text = tow.MeasureUnit;
            cbTypeOfWorkDimension.Text = tow.DimensionToString();
            tbWorkInProjectMultiplicity.Enabled = false;
            pbCheckMarkTypeOfWorkName.Visible = false;
            pbCheckMarkTypeOfWorkDimension.Visible = false;
            pbCheckMarkTypeOfWorkMeasureUnit.Visible = false;
            lblCheckTypeOfWorkName.Visible = false;
            lblCheckTypeOfWorkDimension.Visible = false;
            lblCheckTypeOfWorkMeasureUnit.Visible = false;
            lblWorkInProjectCheckPrice.Visible = false;
            lblWorkInProjectCheckMultiplicity.Visible = false;
        }

        private void ShowSelectedWorkInProject()
        {
            var workInProject = SelectedWorkInProject();
            var typeOfWork = ReadTypeOfWork(workInProject.IdTypeOfWork);
            tbTypeOfWorkName.Text = typeOfWork.Name;
            cbTypeOfWorkDimension.Text = typeOfWork.DimensionToString();
            tbTypeOfWorkMeasureUnit.Text = typeOfWork.MeasureUnit;
            tbWorkInProjectMultiplicity.Enabled = false;
            gbTypeOfWorkData.Height = 167;
            gbWorkInProjectData.Visible = true;
            tbWorkInProjectPrice.Text = Convert.ToString(workInProject.Price);
            tbWorkInProjectMultiplicity.Text = Convert.ToString(workInProject.Multiplicity);
            pbCheckMarkTypeOfWorkName.Visible = false;
            pbCheckMarkTypeOfWorkDimension.Visible = false;
            pbCheckMarkTypeOfWorkMeasureUnit.Visible = false;
            lblWorkInProjectCheckPrice.Visible = false;
            lblWorkInProjectCheckMultiplicity.Visible = false;
        }
        //TbDate_Click

        //DtpDate_valueChanged


        //Tb_TextChanged
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

        //BtnSwitchCreate_Click
        private void BtnTypeOfWorkSwitchCreate_Click(object sender, EventArgs e)
        {
            ShowVoidTypeOfWork();
            gbTypeOfWorkData.Enabled = true;
            gbWorkInProjectData.Visible = false;
            btnWorkSwitchCancel.Visible = true;
            btnTypeOfWorkCreate.Visible = true;
        }

        private void BtnWorkInProjectSwitchCreate_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(actualProject.Id == -1)
            {
                MessageBox.Show("Текущий проект не сохранен",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gbAllTypesOfWork.Enabled = false;
            gbTypeOfWorkData.Enabled = false;
            gbWorkInProjectData.Visible = true;
            gbTypeOfWorkData.Height = 167;
            btnWorkSwitchCancel.Visible = true;
            btnWorkInProjectCreate.Visible = true;
            tbWorkInProjectPrice.Clear();
            tbWorkInProjectMultiplicity.Text = "1";
            ShowSelectedTypeOfWork();
        }

        private void BtnWorkInProjectChangeMultiplicity_Click(object sender, EventArgs e)
        {
            tbWorkInProjectMultiplicity.Enabled = true;
        }

        //BtnSwitchCancel_Click
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

        //BtnCreate_Click
        private void BtnTypeOfWorkCreate_Click(object sender, EventArgs e)
        {
            if (TypeOfWork.NameIsMatch(tbTypeOfWorkName.Text) &&
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

        private void BtnWorkInProjectCreate_Click(object sender, EventArgs e)
        {
            if (WorkInProject.DecimalIsMatch(tbWorkInProjectPrice.Text) &&
                WorkInProject.DecimalIsMatch(tbWorkInProjectMultiplicity.Text))
                try
                {
                    var selectedTypeOfWork = SelectedTypeOfWork();
                    decimal price = Convert.ToDecimal(tbWorkInProjectPrice.Text);
                    decimal multiplicity = Convert.ToDecimal(tbWorkInProjectMultiplicity.Text);
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

        //BtnSwitchUpdate_Click
        private void BtnTypeOfWorkSwitchUpdate_Click(object sender, EventArgs e)
        {
            ShowSelectedTypeOfWork();
            gbTypeOfWorkData.Enabled = true;
            gbAllTypesOfWork.Enabled = false;
            gbWorkInProjectData.Visible = false;
            btnWorkSwitchCancel.Visible = true;
            btnTypeOfWorkUpdate.Visible = true;
        }

        private void BtnWorkInProjectSwitchUpdate_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowSelectedWorkInProject();
            gbWorksInActualProject.Enabled = false;
            btnWorkInProjectUpdate.Visible = true;
            btnWorkSwitchCancel.Visible = true;
        }

        //BtnUpdate_Click
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

        private void BtnWorkInProjectUpdate_Click(object sender, EventArgs e)
        {
            if (WorkInProject.DecimalIsMatch(tbWorkInProjectPrice.Text) &&
                WorkInProject.DecimalIsMatch(tbWorkInProjectMultiplicity.Text))
                try
                {
                    var workInProject = SelectedWorkInProject();
                    if (workInProject.Id == -1)
                    {
                        MessageBox.Show(
                            "Сохранение данных невозможно, ошибка чтения из базы данных",
                            "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    workInProject.Price = Convert.ToDecimal(tbWorkInProjectPrice.Text);
                    workInProject.Multiplicity =
                        Convert.ToDecimal(tbWorkInProjectMultiplicity.Text);
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

        //BtnDelete_Click
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

        private void BtnWorkInProjectDelete_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
