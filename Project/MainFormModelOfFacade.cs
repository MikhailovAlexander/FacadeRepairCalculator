using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        private class ModelOfFacade
        {
            private MainForm mainForm;
            private DataGridView dgvModel;
            private Element[][] elementsOfModel;
            private static int modelSizeMultiplier = 30;
            public int ModelSizeMultiplier
            {
                get { return modelSizeMultiplier; }
                set
                {
                    if (value < 1) throw new Exception("Размер должен быть целым положительным");
                    else modelSizeMultiplier = value;
                }
            }

            public ModelOfFacade(DataGridView dgvModel, MainForm mainForm)
            {
                this.mainForm = mainForm;
                this.dgvModel = dgvModel;
                elementsOfModel = new Element[0][];
            }

            public void ShowWorkInModel(WorkInProject workInProject)
            {
                for (int i = 0; i < dgvModel.RowCount; i++)
                {
                    for (int j = 0; j < dgvModel.ColumnCount; j++)
                    {
                        int idElement = (int)dgvModel.Rows[i].Cells[j].Tag;
                        if (mainForm.ElementHasWork(idElement, workInProject.Id))
                        {
                            dgvModel.Rows[i].Cells[j].Style.BackColor = Color.DimGray;
                        }
                        else dgvModel.Rows[i].Cells[j].Style.BackColor = Color.Empty;
                    }
                }
            }

            public void ShowModel(SectionOfBuilding sectionOfBuilding)
            {
                if (sectionOfBuilding.Id == -1)
                {
                    elementsOfModel = new Element[0][];
                    return;
                }
                elementsOfModel = mainForm.ReadFloorsSectionOfBuilding(sectionOfBuilding);
                if (elementsOfModel.Count() == 0)
                {
                    dgvModel.Rows.Clear();
                    dgvModel.Columns.Clear();
                    return;
                }
                if (!sectionOfBuilding.IsChecked(elementsOfModel))
                {
                    MessageBox.Show("Набор элементов не соответсвует модели", "Сообщение об ошибке",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };
                SetImageColumns(sectionOfBuilding);
                SetRows(sectionOfBuilding);
            }

            private void SetImageColumns(SectionOfBuilding sectionOfBuilding)
            {
                dgvModel.Columns.Clear();
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
                        var typeOfElement = mainForm.ReadTypeOfElement(elementsOfModel[0][i].IdTypeOfElement);
                        imageColumn.Width = GetModelSize(typeOfElement.Length);
                    }
                    dgvModel.Columns.Add(imageColumn);
                }
            }

            private void SetRows(SectionOfBuilding sectionOfBuilding)
            {
                dgvModel.Rows.Clear();
                for (int i = 0; i < sectionOfBuilding.QuantityByHeight; i++)
                {
                    dgvModel.Rows.Add();
                }
                for (int i = 0; i < sectionOfBuilding.QuantityByHeight; i++)
                {
                    int rowNumber = (sectionOfBuilding.QuantityByHeight - 1) - i;
                    if (elementsOfModel[i][0].IdTypeOfElement == -1)
                    {
                        dgvModel.Rows[rowNumber].Height =
                        GetModelSize(2);
                    }
                    else
                    {
                        var typeOfElement =
                            mainForm.ReadTypeOfElement(elementsOfModel[i][0].IdTypeOfElement);
                        dgvModel.Rows[rowNumber].Height = GetModelSize(typeOfElement.Height);
                    }
                    dgvModel.Rows[rowNumber].HeaderCell.ValueType = typeof(string);
                    dgvModel.Rows[rowNumber].HeaderCell.Value = $"{i} этаж";
                    for (int j = 0; j < sectionOfBuilding.QuantityByWidth; j++)
                    {
                        if (elementsOfModel[i][j].IdTypeOfElement == -1)
                        {
                            dgvModel.Rows[rowNumber].Cells[j].Tag =
                            elementsOfModel[i][j].Id;
                        }
                        else
                        {
                            var elementPicture = mainForm.ReadElementPictureByTypeOfElement(
                                elementsOfModel[i][j].IdTypeOfElement);
                            dgvModel.Rows[rowNumber].Cells[j].Value = elementPicture.ResizePicture(
                                dgvModel.Columns[j].Width, dgvModel.Rows[rowNumber].Height);
                            dgvModel.Rows[rowNumber].Cells[j].Tag = elementsOfModel[i][j].Id;
                        }
                    }
                }
            }

            private int GetModelSize(decimal typeOfElementSize)
            {
                return (int)(typeOfElementSize * ModelSizeMultiplier);
            }
        }
    }
}
