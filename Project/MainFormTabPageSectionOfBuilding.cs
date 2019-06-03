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
    //ReadAllEntities

        private SectionOfBuilding ReadSectionOfBuilding(int idForSearch)
        {
            return ReadObject<SectionOfBuilding>(idForSearch, driver.ReadSectionOfBuilding);
        }

        private SectionOfBuilding[] ReadSectionsOfBuildingByActualProject()
        {
            return ReadSectionsOfBuildingByProject(actualProject);
        }

        private SectionOfBuilding[] ReadSectionsOfBuildingByProject(Project project)
        {
            if (project.Id == -1) return new SectionOfBuilding[0];
            return ReadAllObjectsByParam<SectionOfBuilding>(project.Id,
                driver.ReadAllSectionsOfBuildingByProject);
        }

        private Element[] ReadElementsFromSectionOfBuilding(int idSectionOfBuilding)
        {
            return ReadAllObjectsByParam<Element>(idSectionOfBuilding, driver.ReadAllElementsFromSectionOfBuilding);
        }

        private Element[][] ReadFloorsSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            Element[][] elements = new Element[0][];
            try
            {
                elements = sectionOfBuilding.GetFloors(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return elements;
        }

        private decimal GetSomeAmountFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding,
            Func<IDriverDB, decimal> GetAmount)
        {
            decimal amount = -1;
            if (sectionOfBuilding.Id == -1) return amount;
            try
            {
                amount = GetAmount(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return amount;
        }

        private decimal GetSquareOfSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeAmountFromSectionOfBuilding(
                sectionOfBuilding, sectionOfBuilding.GetSquare);
        }

        private decimal GetAmountByWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeAmountFromSectionOfBuilding(
                sectionOfBuilding, sectionOfBuilding.GetAmountByWorks);
        }

        private decimal GetAmountCompletedWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeAmountFromSectionOfBuilding(
                sectionOfBuilding, sectionOfBuilding.GetAmountByCompletedWork);
        }

        private decimal GetAmountAcceptedWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeAmountFromSectionOfBuilding(
                sectionOfBuilding, sectionOfBuilding.GetAmountByAcceptedWork);
        }

        private decimal GetAmountRejectedWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeAmountFromSectionOfBuilding(
                sectionOfBuilding, sectionOfBuilding.GetAmountByRejectedWork);
        }

        private decimal GetSomeValueWorkBySectionOfBuilding(
            WorkInProject workInProject, SectionOfBuilding sectionOfBuilding, 
            Func<WorkInProject, IDriverDB, decimal>GetValue)
        {
            decimal valueByWork = -1;
            if (sectionOfBuilding.Id == -1) return valueByWork;
            try
            {
                valueByWork = GetValue(workInProject, driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return valueByWork;
        }

        private decimal GetValueWorkBySectionOfBuilding(WorkInProject workInProject, 
            SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeValueWorkBySectionOfBuilding(workInProject, sectionOfBuilding,
                sectionOfBuilding.GetValueByWork);
        }

        private decimal GetValueCompletedWorkBySectionOfBuilding(WorkInProject workInProject,
            SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeValueWorkBySectionOfBuilding(workInProject, sectionOfBuilding,
                sectionOfBuilding.GetValueByCompletedWork);
        }

        private decimal GetValueAcceptedWorkBySectionOfBuilding(WorkInProject workInProject,
            SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeValueWorkBySectionOfBuilding(workInProject, sectionOfBuilding,
                sectionOfBuilding.GetValueByAcceptedWork);
        }

        private decimal GetValueRejectedWorkBySectionOfBuilding(WorkInProject workInProject,
            SectionOfBuilding sectionOfBuilding)
        {
            return GetSomeValueWorkBySectionOfBuilding(workInProject, sectionOfBuilding,
                sectionOfBuilding.GetValueByRejectedWork);
        }

        private Element ReadElement(int idForSearch)
        {
            return ReadObject<Element>(idForSearch, driver.ReadElement);
        }

        private WorkByElement ReadWorkByElement(int idForSearch)
        {
            return ReadObject<WorkByElement>(idForSearch, driver.ReadWorkByElement);
        }

        private WorkByElement GetWorkByElement(int idElement, int idWorkInProject)
        {
            var workByElement = new WorkByElement();
            try
            {
                workByElement = driver.GetWorkByElement(idElement, idWorkInProject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return workByElement;
        }

        private bool ElementHasWork(int idElement, int idWorkInProject)
        {
            var element = ReadElement(idElement);
            bool elementHasWork = false;
            try
            {
                elementHasWork = element.HasWorkByElement(idWorkInProject, driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return elementHasWork;
        }

        //SelectedEntity

        private SectionOfBuilding SelectedSectionOfBuilding()
        {
            return SelectedObject<SectionOfBuilding>(
                dgvSectionsOfBuildingByActualProject, driver.ReadSectionOfBuilding);
        }

        private WorkInProject SelectedWorkInProjectInSectionOfBuilding()
        {
            return SelectedObject<WorkInProject>(dgvSectionOfBuildingWorkInProject, driver.ReadWorkInProject);
        }

        //Rb_CheckedChanged

        //ShowEntities
        private void ShowActualProjectInSectionOfBuilding()
        {
            Project[] projects = { actualProject};
            ShowProjectsInDgv(projects, dgvSectionOfBuildingActualProject, 50);
        }

        private void ShowSectionsOfBuildingInActualPriject()
        {
            ShowSectionsOfBuilding(actualProject, lblSectionOfBuldingActualProjectNotSaved1,
            dgvSectionsOfBuildingByActualProject, gbAllSectionsOfBuilding);
        }

        private void DgvSectionsOfBuildingByActualProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSectionsOfBuildingByActualProject.SelectedRows.Count == 0)
            {
                dgvManagerModel.Rows.Clear();
                dgvManagerModel.Columns.Clear();
                btnSectionOfBuildingSwitchModelUpdate.Visible = false;
                btnSectionOfBuildingSwitchSetWork.Visible = false;
                btnSectionOfBuildingSwitchUpdate.Enabled = false;
                btnSectionOfBuildingDelete.Enabled = false;
            }
            else
            {
                ShowSelectedSectionOfBuilding();
                ShowWorksInProjectInSectionOfBuilding();
                managerModel.ShowModel(SelectedSectionOfBuilding());
                btnSectionOfBuildingSwitchModelUpdate.Visible = true;
                btnSectionOfBuildingSwitchSetWork.Visible = true;
                btnSectionOfBuildingSwitchUpdate.Enabled = true;
                btnSectionOfBuildingDelete.Enabled = true;
            }
        }

        private void AddElementPicturesInListView(ListView listView)
        {
            var allPictures = ReadAllElementPicture();
            ImageList largeImageList = new ImageList();
            largeImageList.ImageSize = new Size(100, 100);
            foreach (ElementPicture picture in allPictures)
            {
                largeImageList.Images.Add(picture.Id.ToString(), picture.Picture);
            }
            listView.LargeImageList = largeImageList;
        }

        private void ShowWorksInProjectInSectionOfBuilding()
        {
            if(dgvSectionsOfBuildingByActualProject.SelectedRows.Count == 0)
            {
                dgvSectionOfBuildingWorkInProject.Rows.Clear();
                return;
            }
            var sectionOfBuilding = SelectedSectionOfBuilding();
            if (actualProject.Id == -1 || sectionOfBuilding.Id == -1)
            {
                dgvSectionOfBuildingWorkInProject.Rows.Clear();
                return;
            }
            ShowWorksInProject(
                actualProject.Id, sectionOfBuilding, dgvSectionOfBuildingWorkInProject, 
                gbTypeOfElementInProjectBySectionOfBuilding.Size.Height);
            ShowAmountBySectionOfBuilding(sectionOfBuilding);
        }

        private void ShowAmountBySectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            ShowWorksAmountBySectionOfBuilding(sectionOfBuilding, lblSectionOfBuildingWorksAmount);
        }
                
        private void ShowTypesOfElementInSectionOfBuilding()
        {
            lblSectionOfBuldingActualProjectNotSaved2.Visible = (actualProject.Id == -1);
            var typesOfElementInProject = ReadAllObjectsByParam<TypeOfElement>(
                actualProject.Id, driver.ReadTypesOfElementInProject);
            lvSectionOfBuildingTypesOfElementInProject.Clear();
            AddElementPicturesInListView(lvSectionOfBuildingTypesOfElementInProject);

            foreach (TypeOfElement typeOfElement in typesOfElementInProject)
            {
                var item = new ListViewItem()
                {
                    Tag = typeOfElement.Id,
                    ImageKey = typeOfElement.IdElementPicture.ToString(),
                    Text = typeOfElement.Name
                };
                lvSectionOfBuildingTypesOfElementInProject.Items.Add(item);
            }
        }

        private void LvSectionOfBuildingTypesOfElementInProject_ItemDrag(
            object sender, ItemDragEventArgs e)
        {
            var listView = sender as ListView;
            listView.DoDragDrop(listView.SelectedItems[0].Tag, DragDropEffects.Copy);
        }

        private void DgvManagerModel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
                e.Effect = DragDropEffects.Copy;
        }

        private void DgvManagerModel_DragDrop(object sender, DragEventArgs e)
        {
            Point cursorLocation = dgvManagerModel.PointToClient(new Point(e.X, e.Y));
            var hitTestInfo = dgvManagerModel.HitTest(cursorLocation.X, cursorLocation.Y);
            if(hitTestInfo.ColumnIndex != -1 && hitTestInfo.RowIndex != -1)
            {
                int row = hitTestInfo.RowIndex;
                int numberByHeight = (dgvManagerModel.Rows.Count - 1) - row;
                int column = hitTestInfo.ColumnIndex;
                int numberByWidth = column;
                int idTypeOfElement = (int)e.Data.GetData(typeof(int));
                int idElement = (int)dgvManagerModel.Rows[row].Cells[column].Tag;
                if (managerModel.elementsOfModel[numberByHeight][numberByWidth].Id != idElement)
                {
                    MessageBox.Show("Элемент в модели не найден!", "Сообщение об ошибке", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var elementPicture = ReadElementPictureByTypeOfElement(idTypeOfElement);
                if (elementPicture.Picture == null)
                {
                    MessageBox.Show("Изображение не найдено!", "Сообщение об ошибке",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Image picture = elementPicture.ResizePicture(
                    dgvManagerModel.Columns[column].Width, 
                    dgvManagerModel.Rows[row].Height);
                managerModel.elementsOfModel[numberByHeight][numberByWidth].IdTypeOfElement =
                 idTypeOfElement;
                dgvManagerModel.Rows[row].Cells[column].Value = picture;
            }
            else managerModel.ChangeSizeCellsInModel(hitTestInfo.RowIndex, hitTestInfo.ColumnIndex,
                (int)e.Data.GetData(typeof(int)));
        }

        private void DgvManagerModel_SelectionChanged(object sender, EventArgs e)
        {
            managerWorkLog.ShowWorkByElementInfo();
        }

        //ShowVoidEntity
        private void ShowVoidSectionOfBuilding()
        {
            tbSectionOfBuildingName.Clear();
            tbSectionOfBuildingQuantityByHeight.Clear();
            tbSectionOfBuildingQuantityByWidth.Clear();
            lblCheckSectionOfBuildingName.Visible = false;
            lblCheckSectionOfBuildingQuantityByHeight.Visible = false;
            lblCheckSectionOfBuildingQuantityByWidth.Visible = false;
            lblSectuinOfBuildingSquare.Text = "Общая площадь не определена";
            pbCheckMarkSectionOfBuildingName.Visible = false;
            pbCheckMarkSectionOfBuildingQuantityByHeight.Visible = false;
            pbCheckMarkSectionOfBuildingQuantityByWidth.Visible = false;
        }

        //ShowSelectedEntity
        private void ShowSelectedSectionOfBuilding()
        {
            var selectedSectionOfBuilding = SelectedSectionOfBuilding();
            tbSectionOfBuildingName.Text = selectedSectionOfBuilding.Name;
            tbSectionOfBuildingQuantityByHeight.Text = 
                selectedSectionOfBuilding.QuantityByHeight.ToString();
            tbSectionOfBuildingQuantityByWidth.Text = 
                selectedSectionOfBuilding.QuantityByWidth.ToString();
            lblCheckSectionOfBuildingName.Visible = false;
            lblCheckSectionOfBuildingQuantityByHeight.Visible = false;
            lblCheckSectionOfBuildingQuantityByWidth.Visible = false;
            decimal square = GetSquareOfSectionOfBuilding(selectedSectionOfBuilding);
            if(square == -1) lblSectuinOfBuildingSquare.Text = "Общая площадь не определена";
            else lblSectuinOfBuildingSquare.Text = $"Общая площадь {square} кв.м.";
            pbCheckMarkSectionOfBuildingName.Visible = false;
            pbCheckMarkSectionOfBuildingQuantityByHeight.Visible = false;
            pbCheckMarkSectionOfBuildingQuantityByWidth.Visible = false;
        }

        //TbDate_Click

        //DtpDate_valueChanged

        //Tb_TextChanged
        private void TbSectionOfBuildingName_TextChanged(object sender, EventArgs e)
        {
            lblCheckSectionOfBuildingName.Visible = 
                !SectionOfBuilding.NameIsMatch(tbSectionOfBuildingName.Text);
            pbCheckMarkSectionOfBuildingName.Visible =
                SectionOfBuilding.NameIsMatch(tbSectionOfBuildingName.Text);
        }

        private void TbSectionOfBuildingQuantityByHeight_TextChanged(object sender, EventArgs e)
        {
            lblCheckSectionOfBuildingQuantityByHeight.Visible =
                !SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByHeight.Text);
            pbCheckMarkSectionOfBuildingQuantityByHeight.Visible =
                SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByHeight.Text);
        }

        private void TbSectionOfBuildingQuantityByWidth_TextChanged(object sender, EventArgs e)
        {
            lblCheckSectionOfBuildingQuantityByWidth.Visible =
                !SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByWidth.Text);
            pbCheckMarkSectionOfBuildingQuantityByWidth.Visible =
                SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByWidth.Text);
        }

        //BtnSwitchCreate_Click
        private void BtnSectionOfBuildingSwitchCreate_Click(object sender, EventArgs e)
        {
            if(actualProject.Id==-1)
            {
                MessageBox.Show("Текущий проект не сохранен",
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowVoidSectionOfBuilding();
            gbSectionOfBuildingData.Visible = true;
            SectionOfBuildingModel.Visible = false;
            gbSectionOfBuildingData.Enabled = true;
            btnSectionOfBuildingCreate.Visible = true;
            btnSectionOfBuildingSwitchCancel.Visible = true;
        }

        //BtnSwitchCancel_Click
        private void BtnSectionOfBuildingSwitchCancel_Click(object sender, EventArgs e)
        {
            ShowSelectedSectionOfBuilding();
            gbSectionOfBuildingData.Enabled = false;
            gbSectionOfBuildingData.Visible = false;
            SectionOfBuildingModel.Visible = true;
            gbAllSectionsOfBuilding.Enabled = true;
            btnSectionOfBuildingCreate.Visible = false;
            btnSectionOfBuildingUpdate.Visible = false;
            btnSectionOfBuildingSwitchCancel.Visible = false;
            tbSectionOfBuildingQuantityByHeight.Enabled = true;
            tbSectionOfBuildingQuantityByWidth.Enabled = true;
        }

        //BtnCreate_Click
        private void BtnSectionOfBuildingCreate_Click(object sender, EventArgs e)
        {
            if (SectionOfBuilding.NameIsMatch(tbSectionOfBuildingName.Text) &&
                SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByHeight.Text) &&
                SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByWidth.Text))
            {
                string name = tbSectionOfBuildingName.Text;
                int quantityByHeight = Convert.ToInt32(tbSectionOfBuildingQuantityByHeight.Text);
                int quantityByWidth = Convert.ToInt32(tbSectionOfBuildingQuantityByWidth.Text);
                if(quantityByHeight == 0 || quantityByWidth == 0)
                {
                    MessageBox.Show("Невозможно создать модель с нулевым количеством элементов", 
                        "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var sectionOfBuilding = new SectionOfBuilding(name, actualProject.Id,
                    quantityByHeight, quantityByWidth);
                try
                {
                    sectionOfBuilding.CreateWithElements(driver);
                    MessageBox.Show("Модель фасада сохранена", "Сохранение модели", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowActualProject();
                    ShowVoidSectionOfBuilding();
                    managerModel.ShowModel(SelectedSectionOfBuilding());
                    gbSectionOfBuildingData.Enabled = false;
                    gbSectionOfBuildingData.Visible = false;
                    SectionOfBuildingModel.Visible = true;
                    btnSectionOfBuildingCreate.Visible = false;
                    btnSectionOfBuildingSwitchCancel.Visible = false;
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

        //BtnSwitchUpdate_Click
        private void BtnSectionOfBuildingSwitchUpdate_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SelectedSectionOfBuilding().Id == -1) return;
            gbAllSectionsOfBuilding.Enabled = false;
            gbSectionOfBuildingData.Enabled = true;
            gbSectionOfBuildingData.Visible = true;
            SectionOfBuildingModel.Visible = false;
            tbSectionOfBuildingQuantityByHeight.Enabled = false;
            tbSectionOfBuildingQuantityByWidth.Enabled = false;
            btnSectionOfBuildingSwitchCancel.Visible = true;
            btnSectionOfBuildingUpdate.Visible = true;
            ShowSelectedSectionOfBuilding();
        }

        //BtnUpdate_Click
        private void BtnSectionOfBuildingUpdate_Click(object sender, EventArgs e)
        {
            var sectionOfBuilding = SelectedSectionOfBuilding();
            if (SectionOfBuilding.NameIsMatch(tbSectionOfBuildingName.Text) &&
                SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByHeight.Text) &&
                SectionOfBuilding.IntIsMatch(tbSectionOfBuildingQuantityByWidth.Text))
            {
                sectionOfBuilding.Name = tbSectionOfBuildingName.Text;
                sectionOfBuilding.QuantityByHeight = Convert.ToInt32(tbSectionOfBuildingQuantityByHeight.Text);
                sectionOfBuilding.QuantityByWidth = Convert.ToInt32(tbSectionOfBuildingQuantityByWidth.Text);
                try
                {
                    sectionOfBuilding.Update(driver);
                    MessageBox.Show("Изменения сохранены", "Сохранение модели", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    ShowActualProject();
                    ShowSectionsOfBuildingInActualPriject();
                    ShowSelectedSectionOfBuilding();
                    managerModel.ShowModel(SelectedSectionOfBuilding());
                    gbSectionOfBuildingData.Enabled = false;
                    gbSectionOfBuildingData.Visible = false;
                    SectionOfBuildingModel.Visible = true;
                    gbAllSectionsOfBuilding.Enabled = true;
                    tbSectionOfBuildingQuantityByHeight.Enabled = true;
                    tbSectionOfBuildingQuantityByWidth.Enabled = true;
                    btnSectionOfBuildingUpdate.Visible = false;
                    btnSectionOfBuildingSwitchCancel.Visible = false;
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
        private void BtnSectionOfBuildingDelete_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedSectionOfBuilding = SelectedSectionOfBuilding();
            if (selectedSectionOfBuilding.Id == -1) return;
            DialogResult result = MessageBox.Show
                         ($"Вы действительно хотите удалить безвозвратно модель фасада " +
                         $"{selectedSectionOfBuilding.Name}?",
                         "Удаление модели фасада", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedSectionOfBuilding.DeleteWithElements(driver);
                    MessageBox.Show($"Модель фасада {selectedSectionOfBuilding.Name} удалена", 
                        "Удаление оплаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSectionsOfBuildingInActualPriject();
                    ShowActualProject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSectionOfBuildingSwitchModelUpdate_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnSectionOfBuildingModelUpdate.Visible = true;
            btnSectionOfBuildingSwitchModelCancel.Visible = true;
            btnSectionOfBuildingSwitchModelUpdate.Enabled = false;
            lvSectionOfBuildingTypesOfElementInProject.Enabled = true;
            btnSectionOfBuildingSwitchSetWork.Visible = false;
        }

        private void BtnSectionOfBuildingModelUpdate_Click(object sender, EventArgs e)
        {
            var sectionOfBuilding = SelectedSectionOfBuilding();
            bool sectionOfBuildingHasWork = false;
            try
            {
                sectionOfBuildingHasWork = sectionOfBuilding.HasWork(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (sectionOfBuildingHasWork)
            {
                DialogResult result = MessageBox.Show(
                    $"По элементам фасада назначены работы! Внесение изменений может привести " +
                    $"к некорректному отображению объемов и стоимости работ. Вы хотите продолжить?",
                    "Изменение модели", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            try
            {
                sectionOfBuilding.UpdateAllElementsSetTypeOfElement(
                    managerModel.elementsOfModel, driver);
                MessageBox.Show("Изменения сохранены", "Изменение модели", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                btnSectionOfBuildingModelUpdate.Visible = false;
                btnSectionOfBuildingSwitchModelCancel.Visible = false;
                btnSectionOfBuildingSwitchModelUpdate.Enabled = true;
                lvSectionOfBuildingTypesOfElementInProject.Enabled = false;
                ShowSectionsOfBuildingInActualPriject();
                ShowSelectedSectionOfBuilding();
                btnSectionOfBuildingSwitchSetWork.Visible = true;
                ShowActualProject();
                ShowProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSectionOfBuildingSwitchModelCancel_Click(object sender, EventArgs e)
        {
            lblSectionOfBuildingWorksAmount.Visible = false;
            btnSectionOfBuildingModelUpdate.Visible = false;
            btnSectionOfBuildingSwitchModelCancel.Visible = false;
            btnSectionOfBuildingSwitchSetWork.Enabled = true;
            btnSectionOfBuildingSwitchSetWork.Visible = true;
            gbManagerModelSetWork.Visible = false;
            btnSectionOfBuildingSwitchModelUpdate.Enabled = true;
            btnSectionOfBuildingSwitchModelUpdate.Visible = true;
            lvSectionOfBuildingTypesOfElementInProject.Enabled = false;
            lvSectionOfBuildingTypesOfElementInProject.Visible = true;
            dgvSectionOfBuildingWorkInProject.Visible = false;
            managerModel.ShowModel(SelectedSectionOfBuilding());
            gbAllSectionsOfBuilding.Enabled = true;
        }

        private void BtnSectionOfBuildingSwitchSetWork_Click(object sender, EventArgs e)
        {
            lblSectionOfBuildingWorksAmount.Visible = true;
            btnSectionOfBuildingSwitchSetWork.Enabled = false;
            gbManagerModelSetWork.Visible = true;
            btnSectionOfBuildingSwitchModelCancel.Visible = true;
            btnSectionOfBuildingSwitchModelUpdate.Visible = false;
            dgvSectionOfBuildingWorkInProject.Visible = true;
            lvSectionOfBuildingTypesOfElementInProject.Visible = false;
            ShowWorksInProjectInSectionOfBuilding();
            managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
        }

        private void BtnSectionOfBuildingSetWork_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvManagerModel.SelectedCells;
            List<WorkByElement> workByElements = new List<WorkByElement>();
            foreach (DataGridViewCell cell in selectedCells)
            {
                int idElement = (int)cell.Tag;
                if(!ElementHasWork(idElement, idWorkInProject))
                    workByElements.Add(new WorkByElement(idElement, idWorkInProject));
            }
            try
            {
                WorkByElement.CreateWorkByElements(workByElements, driver);
                managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
                ShowWorksInProjectInSectionOfBuilding();
                ShowActualProject();
                ShowProjects();
                MessageBox.Show($"Работа назначена для {workByElements.Count} элементов",
                        "Назначение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSectionOfBuildingCancelWork_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvManagerModel.SelectedCells;
            List<WorkByElement> workByElements2Delete = new List<WorkByElement>();
            foreach (DataGridViewCell cell in selectedCells)
            {
                int idElement = (int)cell.Tag;
                if (ElementHasWork(idElement, idWorkInProject))
                    workByElements2Delete.Add(new WorkByElement(idElement, idWorkInProject));
            }
            try
            {
                WorkByElement.DeleteWorkByElements(workByElements2Delete, driver);
                managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
                ShowWorksInProjectInSectionOfBuilding();
                ShowActualProject();
                ShowProjects();
                MessageBox.Show(
                    $"Назначение работы отменено для {workByElements2Delete.Count} элементов",
                    "Назначение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSectionOfBuildingChangeMultiplicity_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvManagerModel.SelectedCells.Count != 1 ||
                dgvSectionOfBuildingWorkInProject.SelectedRows.Count == 0) return;
            int idElement = (int)dgvManagerModel.SelectedCells[0].Tag;
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            if (!ElementHasWork(idElement, idWorkInProject)) return;
            var inputBox = new InputBox("Коэффициент работ для элемента",
                "Введите размер коэффициента", "Введите число с двумя знаками после запятой", 
                Color.DimGray, BaseWithName.DecimalIsMatch);
            inputBox.ShowDialog();
            if (inputBox.DialogResult == DialogResult.Cancel) return;
            var workByElement = GetWorkByElement(idElement, idWorkInProject);
            if(workByElement.Id == -1)
            {
                MessageBox.Show($"Элемент не найден",
                    "Изменение коэффициента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                decimal multiplicity = Convert.ToDecimal(inputBox.Input);
                workByElement.Multiplicity = multiplicity;
                workByElement.Update(driver);
                MessageBox.Show("Изменения сохранены", "Изменение коэффициента", MessageBoxButtons.OK,
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

        private void DgvSectionOfBuildingWorkInProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSectionOfBuildingWorkInProject.SelectedRows.Count == 0)
            {
                managerModel.ShowModel(SelectedSectionOfBuilding());
            }
            else
            {
                managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
            }
            managerWorkLog.ShowWorkByElementInfo();
        }

        private void BtnSectionOfBuildingAcceptWork_Click(object sender, EventArgs e)
        {
            if (actualProject.State != ProjectState.Actual)
            {
                MessageBox.Show("Учет работ возможен только для текущего проекта",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dateOfAccept = dtpManagerModelLogDate.Value;
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvManagerModel.SelectedCells;
            List<WorkByElement> workByElements = new List<WorkByElement>();
            foreach (DataGridViewCell cell in selectedCells)
            {
                int idElement = (int)cell.Tag;
                if (ElementHasWork(idElement, idWorkInProject))
                {
                    var workByElement = GetWorkByElement(idElement, idWorkInProject);
                    if (workByElement.AcceptCheck(dateOfAccept, driver))
                        workByElements.Add(workByElement);
                }
            }
            if (workByElements.Count == 0)
            {
                MessageBox.Show($"Нет элементов для приемки работ",
                    "Приемка работ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                WorkByElement.CreateWorkLogsAccept(workByElements, actualUser.Id, dateOfAccept, 
                    driver);
                managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
                ShowWorksInProjectInSectionOfBuilding();
                ShowActualProject();
                ShowProjects();
                MessageBox.Show($"Работа принята для {workByElements.Count} элементов",
                        "Приемка работ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSectionOfBuildingAcceptWorkCancel_Click(object sender, EventArgs e)
        {
            if (actualProject.State != ProjectState.Actual)
            {
                MessageBox.Show("Учет работ возможен только для текущего проекта",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvManagerModel.SelectedCells;
            List<WorkLog> acceptWorkLogs = new List<WorkLog>();
            try
            {
                foreach (DataGridViewCell cell in selectedCells)
                {
                    int idElement = (int)cell.Tag;
                    if (ElementHasWork(idElement, idWorkInProject))
                    {
                        var workByElement = GetWorkByElement(idElement, idWorkInProject);
                        WorkLog workLog =
                            workByElement.GetAcceptLog2Delete(actualUser.Id, driver);
                        if (workLog.Id != -1)
                            acceptWorkLogs.Add(workLog);
                    }
                }
                if (acceptWorkLogs.Count == 0)
                {
                    MessageBox.Show($"Нет элементов для отмены приемки",
                       "Отмена приемки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                WorkByElement.DeleteWorkLogsAccept(acceptWorkLogs, driver);
                managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
                ShowActualProject();
                ShowProjects();
                ShowWorksInProjectInSectionOfBuilding();
                MessageBox.Show($"Отменa приемки работы для {acceptWorkLogs.Count} элементов",
                        "Отмена приемки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSectionOfBuildingRejectWork_Click(object sender, EventArgs e)
        {
            if (actualProject.State != ProjectState.Actual)
            {
                MessageBox.Show("Учет работ возможен только для текущего проекта",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dateOfReject = dtpManagerModelLogDate.Value;
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvManagerModel.SelectedCells;
            List<WorkByElement> workByElements = new List<WorkByElement>();
            foreach (DataGridViewCell cell in selectedCells)
            {
                int idElement = (int)cell.Tag;
                if (ElementHasWork(idElement, idWorkInProject))
                {
                    var workByElement = GetWorkByElement(idElement, idWorkInProject);
                    if (workByElement.RejectCheck(dateOfReject, driver))
                        workByElements.Add(workByElement);
                }
            }
            if (workByElements.Count == 0)
            {
                MessageBox.Show($"Нет элементов для отклонения работ",
                    "Отклонение работ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var inputBox = new InputBox("Комментарий к отклонению работ", 
                "Введите текст комментария", "от 3 до 100 символов кириллицей", Color.Red, 
                BaseWithName.NameIsMatch);
            inputBox.ShowDialog();
            if (inputBox.DialogResult == DialogResult.Cancel) return;
            string comment = "";
            try
            {
                comment = inputBox.Input;
                WorkByElement.CreateWorkLogsReject(workByElements, actualUser.Id, dateOfReject,
                    comment, driver);
                managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
                ShowActualProject();
                ShowProjects();
                ShowWorksInProjectInSectionOfBuilding();
                MessageBox.Show($"Работа отклонена для {workByElements.Count} элементов",
                        "Отклонение работ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSectionOfBuildingRejectWorkCancel_Click(object sender, EventArgs e)
        {
            if (actualProject.State != ProjectState.Actual)
            {
                MessageBox.Show("Учет работ возможен только для текущего проекта",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvManagerModel.SelectedCells;
            List<WorkLog> rejectWorkLogs = new List<WorkLog>();
            try
            {
                foreach (DataGridViewCell cell in selectedCells)
                {
                    int idElement = (int)cell.Tag;
                    if (ElementHasWork(idElement, idWorkInProject))
                    {
                        var workByElement = GetWorkByElement(idElement, idWorkInProject);
                        WorkLog workLog =
                            workByElement.GetRejectLog2Delete(actualUser.Id, driver);
                        if (workLog.Id != -1)
                            rejectWorkLogs.Add(workLog);
                    }
                }
                if (rejectWorkLogs.Count == 0)
                {
                    MessageBox.Show($"Нет элементов для отмены отклонения",
                       "Отмена отклонения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                WorkByElement.DeleteWorkLogsReject(rejectWorkLogs, driver);
                managerModel.ShowWorkInModel(SelectedWorkInProjectInSectionOfBuilding());
                ShowActualProject();
                ShowProjects();
                ShowWorksInProjectInSectionOfBuilding();
                MessageBox.Show($"Отменa отклонения работы для {rejectWorkLogs.Count} элементов",
                        "Отмена отклонения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
    }

}
