﻿using System;
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

        private decimal GetSquareOfSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            decimal square = -1;
            try
            {
                square = sectionOfBuilding.GetSquare(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return square;
        }

       
        private decimal GetAmountByWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding)
        {
            decimal amount = -1;
            if (sectionOfBuilding.Id == -1) return amount;
            try
            {
                amount = sectionOfBuilding.GetAmountByWorks(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return amount;
        }

        private decimal GetValueByWorkFromSectionOfBuilding(WorkInProject workInProject, 
            SectionOfBuilding sectionOfBuilding)
        {
            decimal valueByWork = -1;
            if (sectionOfBuilding.Id == -1) return valueByWork;
            try
            {
                valueByWork = sectionOfBuilding.GetValueByWork(workInProject, driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return valueByWork;
        }

        private Element ReadElement(int idForSearch)
        {
            return ReadObject<Element>(idForSearch, driver.ReadElement);
        }

        private WorkByElement ReadWorkByElement(int idForSearch)
        {
            return ReadObject<WorkByElement>(idForSearch, driver.ReadWorkByElement);
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
        private void ShowSectionsOfBuildingInActualPriject()
        {
            ShowSectionsOfBuilding(actualProject, lblSectionOfBuldingActualProjectNotSaved1,
            dgvSectionsOfBuildingByActualProject, gbAllSectionsOfBuilding);
            ShowTotalSquareByActualProject();
            ShowTotalAmountByActualProject();
        }

        private void DgvSectionsOfBuildingByActualProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSectionsOfBuildingByActualProject.SelectedRows.Count == 0)
            {
                dgvSectionOfBuildingModel.Rows.Clear();
                dgvSectionOfBuildingModel.Columns.Clear();
                btnSectionOfBuildingSwitchModelUpdate.Visible = false;
                btnSectionOfBuildingSwitchSetWork.Visible = false;
                btnSectionOfBuildingSwitchUpdate.Enabled = false;
                btnSectionOfBuildingDelete.Enabled = false;
            }
            else
            {
                ShowSelectedSectionOfBuilding();
                ShowModel();
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

        ///MODEL!!!
        private void DgvSectionOfBuildingModelSetImageColumns(SectionOfBuilding sectionOfBuilding)
        {
            dgvSectionOfBuildingModel.Columns.Clear();
            for (int i = 0; i < sectionOfBuilding.QuantityByWidth; i++)
            {
                var imageColumn = new DataGridViewImageColumn()
                {
                    Name = i.ToString(),
                    HeaderText = $"Элемент №{i}",
                    Width = GetModelSize(2)
            };
                if (elementsOfModel[0][i].IdTypeOfElement != -1)
                {
                    var typeOfElement = ReadTypeOfElement(elementsOfModel[0][i].IdTypeOfElement);
                    imageColumn.Width = GetModelSize(typeOfElement.Length);
                }
                dgvSectionOfBuildingModel.Columns.Add(imageColumn);
            }
        }

        private void DgvSectionOfBuildingModelSetRows(SectionOfBuilding sectionOfBuilding)
        {
            dgvSectionOfBuildingModel.Rows.Clear();
            for (int i = 0; i < sectionOfBuilding.QuantityByHeight; i++)
            {
                dgvSectionOfBuildingModel.Rows.Add();
            }
            for (int i = 0; i < sectionOfBuilding.QuantityByHeight; i++)
            {
                int rowNumber = (sectionOfBuilding.QuantityByHeight - 1) - i;
                if (elementsOfModel[i][0].IdTypeOfElement == -1)
                {
                    dgvSectionOfBuildingModel.Rows[rowNumber].Height =
                    GetModelSize(2);
                }
                else
                {
                    var typeOfElement = ReadTypeOfElement(elementsOfModel[i][0].IdTypeOfElement);
                    dgvSectionOfBuildingModel.Rows[rowNumber].Height =
                        GetModelSize(typeOfElement.Height);
                }
                dgvSectionOfBuildingModel.Rows[rowNumber].HeaderCell.ValueType = typeof(string);
                dgvSectionOfBuildingModel.Rows[rowNumber].HeaderCell.Value = $"{i} этаж";
                for (int j = 0; j < sectionOfBuilding.QuantityByWidth; j++)
                {
                    if (elementsOfModel[i][j].IdTypeOfElement == -1)
                    {
                        dgvSectionOfBuildingModel.Rows[rowNumber].Cells[j].Tag =
                        elementsOfModel[i][j].Id;
                    }
                    else
                    {
                        var typeOfElement = 
                            ReadTypeOfElement(elementsOfModel[i][j].IdTypeOfElement);
                        Image img = new Bitmap(
                            ReadElementPicture(typeOfElement.IdElementPicture).Picture,
                            new Size(dgvSectionOfBuildingModel.Columns[j].Width,
                            dgvSectionOfBuildingModel.Rows[rowNumber].Height));
                        dgvSectionOfBuildingModel.Rows[rowNumber].Cells[j].Value = img;
                        dgvSectionOfBuildingModel.Rows[rowNumber].Cells[j].Tag =
                            elementsOfModel[i][j].Id;
                    }
                }
            }
        }

        private void ShowModel()
        {
            var selectedSectionOfBuilding = SelectedSectionOfBuilding();
            if (selectedSectionOfBuilding.Id == -1)
            {
                elementsOfModel = new Element[0][];
                return;
            }
            elementsOfModel = ReadFloorsSectionOfBuilding(selectedSectionOfBuilding);
            if(elementsOfModel.Count() == 0)
            {
                dgvSectionOfBuildingModel.Rows.Clear();
                dgvSectionOfBuildingModel.Columns.Clear();
                return;
            }
            if (!selectedSectionOfBuilding.IsChecked(elementsOfModel))
            {
                MessageBox.Show("Набор элементов не соответсвует модели", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            DgvSectionOfBuildingModelSetImageColumns(selectedSectionOfBuilding);
            DgvSectionOfBuildingModelSetRows(selectedSectionOfBuilding);
        }

        private void ShowWorkInModel()
        {
            var workInProject = SelectedWorkInProjectInSectionOfBuilding();
            for(int i = 0; i < dgvSectionOfBuildingModel.RowCount; i++)
            {
                for(int j = 0; j < dgvSectionOfBuildingModel.ColumnCount; j++)
                {
                    int idElement = (int)dgvSectionOfBuildingModel.Rows[i].Cells[j].Tag;
                    if (ElementHasWork(idElement, workInProject.Id))
                    {
                        dgvSectionOfBuildingModel.Rows[i].Cells[j].Style.BackColor = Color.DimGray;
                    }
                    else dgvSectionOfBuildingModel.Rows[i].Cells[j].Style.BackColor = Color.Empty;
                }
            }
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
            var worksInProject = ReadAllWorksInProject(actualProject.Id);
            ClearAndSetHeightDgv(dgvSectionOfBuildingWorkInProject, 
                gbTypeOfElementInProjectBySectionOfBuilding, worksInProject.Length);
            foreach (WorkInProject work in worksInProject)
            {
                var typeOfWork = ReadTypeOfWork(work.IdTypeOfWork);
                decimal valueByWork = GetValueByWorkFromSectionOfBuilding(work, sectionOfBuilding);
                if(valueByWork == -1)
                    dgvSectionOfBuildingWorkInProject.Rows.Add(
                        work.Id, typeOfWork.Name, typeOfWork.MeasureUnit, work.Price, 
                        work.Multiplicity, "не определено", "не определено");
                else dgvSectionOfBuildingWorkInProject.Rows.Add(
                        work.Id, typeOfWork.Name, typeOfWork.MeasureUnit, work.Price,
                        work.Multiplicity, valueByWork, 
                        valueByWork*(decimal)work.Price);
            }
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

        private void DgvSectionOfBuildingModel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
                e.Effect = DragDropEffects.Copy;
        }

        private void DgvSectionOfBuildingModel_DragDrop(object sender, DragEventArgs e)
        {
            Point cursorLocation = dgvSectionOfBuildingModel.PointToClient(new Point(e.X, e.Y));
            var hitTestInfo = dgvSectionOfBuildingModel.HitTest(cursorLocation.X, cursorLocation.Y);
            if(hitTestInfo.ColumnIndex != -1 && hitTestInfo.RowIndex != -1)
            {
                int row = hitTestInfo.RowIndex;
                int numberByHeight = (dgvSectionOfBuildingModel.Rows.Count - 1) - row;
                int column = hitTestInfo.ColumnIndex;
                int numberByWidth = column;
                int idTypeOfElement = (int)e.Data.GetData(typeof(int));
                int idElement = (int)dgvSectionOfBuildingModel.Rows[row].Cells[column].Tag;
                if (elementsOfModel[numberByHeight][numberByWidth].Id != idElement)
                {
                    var element = ReadObject<Element>(elementsOfModel[numberByHeight][numberByWidth].Id,
                        driver.ReadElement);
                    MessageBox.Show("Элемент в модели не найден!", "Сообщение об ошибке", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Image picture = GetPictureFromTypeOfElement(idTypeOfElement);
                if (picture == null)
                {
                    MessageBox.Show("Изображение не найдено!", "Сообщение об ошибке",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                picture = 
                    new Bitmap(picture, new Size(dgvSectionOfBuildingModel.Columns[column].Width,
                    dgvSectionOfBuildingModel.Rows[row].Height));
                elementsOfModel[numberByHeight][numberByWidth].IdTypeOfElement =
                 idTypeOfElement;
                dgvSectionOfBuildingModel.Rows[row].Cells[column].Value = picture;
            }
            else ChangeSizeCellsInModel(hitTestInfo.RowIndex, hitTestInfo.ColumnIndex,
                (int)e.Data.GetData(typeof(int)));
        }

        private void ChangeSizeCellsInModel(int rowIndex, int columnIndex, int idTypeOfElement)
        {
            if (rowIndex == -1 && columnIndex == -1) return;
            var typeOfElement = ReadTypeOfElement(idTypeOfElement);
            if (typeOfElement.Id == -1)
            {
                MessageBox.Show("Тип элемента не найден", "Сообщение об ошибке",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rowIndex == -1)
            {
                DialogResult result = 
                    MessageBox.Show ($"Вы действительно хотите изменить ширину столбца?", 
                    "Изменение размера", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                    ChangeColumnWidthInModel(columnIndex, GetModelSize(typeOfElement.Length));
            }
            else
            {
                DialogResult result = MessageBox.Show($"Вы действительно хотите изменить высоту строки?",
                    "Изменение размера", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                    ChangeRowHeightInModel(rowIndex, GetModelSize(typeOfElement.Height));
            }
        }
        //
        private int GetModelSize(decimal typeOfElementSize)
        {
            return (int)(typeOfElementSize * ModelSizeMultiplier);
        }

        private void ChangeRowHeightInModel(int rowIndex, int height)
        {
            dgvSectionOfBuildingModel.Rows[rowIndex].Height = height;
            for(int i = 0; i < dgvSectionOfBuildingModel.Columns.Count; i++)
            {
                Image image = (Image)dgvSectionOfBuildingModel.Rows[rowIndex].Cells[i].Value;
                dgvSectionOfBuildingModel.Rows[rowIndex].Cells[i].Value = new Bitmap(image, 
                    new Size(dgvSectionOfBuildingModel.Columns[i].Width, height));
            }
        }

        private void ChangeColumnWidthInModel(int columnIndex, int width)
        {
            dgvSectionOfBuildingModel.Columns[columnIndex].Width = width;
            for (int i = 0; i < dgvSectionOfBuildingModel.Rows.Count; i++)
            {
                Image image = (Image)dgvSectionOfBuildingModel.Rows[i].Cells[columnIndex].Value;
                dgvSectionOfBuildingModel.Rows[i].Cells[columnIndex].Value = new Bitmap(image,
                    new Size(width, dgvSectionOfBuildingModel.Rows[i].Height));
            }
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
            ShowVoidSectionOfBuilding();
            gbSectionOfBuildingData.Enabled = true;
            btnSectionOfBuildingCreate.Visible = true;
            btnSectionOfBuildingSwitchCancel.Visible = true;
        }

        //BtnSwitchCancel_Click
        private void BtnSectionOfBuildingSwitchCancel_Click(object sender, EventArgs e)
        {
            ShowSelectedSectionOfBuilding();
            gbSectionOfBuildingData.Enabled = false;
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
                var sectionOfBuilding = new SectionOfBuilding(name, actualProject.Id,
                    quantityByHeight, quantityByWidth);
                try
                {
                    sectionOfBuilding.CreateWithElements(driver);
                    ShowSectionsOfBuildingInActualPriject();
                    ShowVoidSectionOfBuilding();
                    ShowModel();
                    gbSectionOfBuildingData.Enabled = false;
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
            if (SelectedSectionOfBuilding().Id == -1) return;
            gbAllSectionsOfBuilding.Enabled = false;
            gbSectionOfBuildingData.Enabled = true;
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
                    ShowSectionsOfBuildingInActualPriject();
                    ShowSelectedSectionOfBuilding();
                    ShowModel();
                    gbSectionOfBuildingData.Enabled = false;
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
            btnSectionOfBuildingModelUpdate.Visible = true;
            btnSectionOfBuildingSwitchModelCancel.Visible = true;
            lvSectionOfBuildingTypesOfElementInProject.Enabled = true;
            gbAllSectionsOfBuilding.Enabled = false;
            btnSectionOfBuildingSwitchSetWork.Visible = false;
        }

        private void BtnSectionOfBuildingModelUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedSectionOfBuilding().UpdateAllElementsSetTypeOfElement(
                    elementsOfModel, driver);
                btnSectionOfBuildingModelUpdate.Visible = false;
                btnSectionOfBuildingSwitchModelCancel.Visible = false;
                lvSectionOfBuildingTypesOfElementInProject.Enabled = false;
                ShowSectionsOfBuildingInActualPriject();
                ShowSelectedSectionOfBuilding();
                gbAllSectionsOfBuilding.Enabled = true;
                btnSectionOfBuildingSwitchSetWork.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSectionOfBuildingSwitchModelCancel_Click(object sender, EventArgs e)
        {
            btnSectionOfBuildingModelUpdate.Visible = false;
            btnSectionOfBuildingSwitchModelCancel.Visible = false;
            btnSectionOfBuildingSwitchSetWork.Enabled = true;
            btnSectionOfBuildingSwitchSetWork.Visible = true;
            btnSectionOfBuildingSetWork.Visible = false;
            btnSectionOfBuildingCancelWork.Visible = false;
            btnSectionOfBuildingSwitchModelUpdate.Visible = true;
            lvSectionOfBuildingTypesOfElementInProject.Enabled = false;
            lvSectionOfBuildingTypesOfElementInProject.Visible = true;
            dgvSectionOfBuildingWorkInProject.Visible = false;
            ShowModel();
            gbAllSectionsOfBuilding.Enabled = true;
        }

        private void BtnSectionOfBuildingSwitchSetWork_Click(object sender, EventArgs e)
        {
            gbAllSectionsOfBuilding.Enabled = false;
            btnSectionOfBuildingSwitchSetWork.Enabled = false;
            btnSectionOfBuildingSetWork.Visible = true;
            btnSectionOfBuildingCancelWork.Visible = true;
            btnSectionOfBuildingSwitchModelCancel.Visible = true;
            btnSectionOfBuildingSwitchModelUpdate.Visible = false;
            dgvSectionOfBuildingWorkInProject.Visible = true;
            lvSectionOfBuildingTypesOfElementInProject.Visible = false;
            ShowWorksInProjectInSectionOfBuilding();
            ShowWorkInModel();
        }

        private void BtnSectionOfBuildingSetWork_Click(object sender, EventArgs e)
        {
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvSectionOfBuildingModel.SelectedCells;
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
                ShowWorkInModel();
                ShowWorksInProjectInSectionOfBuilding();
                MessageBox.Show($"Работа назначена для {workByElements} элементов",
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
            int idWorkInProject = SelectedWorkInProjectInSectionOfBuilding().Id;
            var selectedCells = dgvSectionOfBuildingModel.SelectedCells;
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
                ShowWorkInModel();
                ShowWorksInProjectInSectionOfBuilding();
                MessageBox.Show($"Назначение работы отменено для {workByElements2Delete} элементов",
                        "Назначение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ShowModel();
            }
            else
            {
                ShowWorkInModel();
            }
        }

    }

}
