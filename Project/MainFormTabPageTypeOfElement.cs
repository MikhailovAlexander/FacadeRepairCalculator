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
        private TypeOfElement[] ReadAllTypesOfElement()
        {
            return ReadAllObjectT<TypeOfElement>(driver.ReadAllTypesOfElement);
        }

        private TypeOfElement ReadTypeOfElement(int idForSearch)
        {
            return ReadObject<TypeOfElement>(idForSearch, driver.ReadTypeOfElement);
        }



        private Image GetPictureFromTypeOfElement(int idTypeOfElement)
        {
            var typeOfElement = ReadTypeOfElement(idTypeOfElement);
            Image picture = null;
            try
            {
                picture = typeOfElement.GetPicture(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return picture;
        }

        //SelectedEntity
        public TypeOfElement SelectedTypeOfElement()
        {
            return SelectedObject<TypeOfElement>(dgvAllTypesOfElement, driver.ReadTypeOfElement);
        }

        public TypeOfElement SelectedTypeOfElementInProject()
        {
            return SelectedObject<TypeOfElement>(dgvTypesOfElementInProject, driver.ReadTypeOfElement);
        }

        public ElementPicture SelectedElementPictureInTypeOfElement()

        {
            return SelectedObject<ElementPicture>(dgvTypeOfElementSetPicture, driver.ReadElementPicture);
        }

        //Rb_CheckedChanged

        //ShowEntities
        public void ShowAllTypesOfElement()
        {
            var allTypesOfElement = ReadAllTypesOfElement();
            ClearAndSetHeightDgv(
                dgvAllTypesOfElement, gbAllTypesOfElement, allTypesOfElement.Length);
            foreach(TypeOfElement typeOfElement in allTypesOfElement)
            {
                dgvAllTypesOfElement.Rows.Add(typeOfElement.Id, typeOfElement.Name,
                    typeOfElement.Square, typeOfElement.Height, typeOfElement.Length,
                    typeOfElement.IdElementPicture);
            }
        }

        private void DgvAllTypesOfElement_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvAllTypesOfElement.SelectedRows.Count == 0)
            {
                pbTypeOfElementSelectedDgvAll.Image = null;
                pbTypeOfElementSelectedDgvAll.Visible = false;
            }
            else
            {
                pbTypeOfElementSelectedDgvAll.Image = ReadElementPicture(
                    (int)(dgvAllTypesOfElement.SelectedRows[0].Cells[5].Value)).Picture;
                pbTypeOfElementSelectedDgvAll.Visible = true;
            }
        }

        public void ShowTypesOfElementInProject()
        {
            lblTypesOfElementActualProjectNotSaved.Visible = (actualProject.Id == -1);
            lblSectionOfBuldingActualProjectNotSaved2.Visible = (actualProject.Id == -1);
            var typesOfElementInProject = ReadAllObjectsByParam<TypeOfElement>(
                actualProject.Id, driver.ReadTypesOfElementInProject);
            ClearAndSetHeightDgv(dgvTypesOfElementInProject, gbTypeOfElementInProject,
                typesOfElementInProject.Length);
            foreach (TypeOfElement typeOfElement in typesOfElementInProject)
            {
                dgvTypesOfElementInProject.Rows.Add(typeOfElement.Id, typeOfElement.Name,
                    typeOfElement.Square, typeOfElement.Height, typeOfElement.Length,
                    typeOfElement.IdElementPicture);
            }
            ShowTypesOfElementInSectionOfBuilding();
        }

        private void DgvTypesOfElementInProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTypesOfElementInProject.SelectedRows.Count == 0)
            {
                pbTypeOfElementSelectedDgvInProject.Image = null;
                pbTypeOfElementSelectedDgvInProject.Visible = false;
            }
            else
            {
                pbTypeOfElementSelectedDgvInProject.Image = ReadElementPicture(
                    (int)(dgvTypesOfElementInProject.SelectedRows[0].Cells[5].Value)).Picture;
                pbTypeOfElementSelectedDgvInProject.Visible = true;
            }
        }

        public void ShowAllElementPictureInTypeOfWork()
        {
            var allElementPicture = ReadAllElementPicture();
            ClearAndSetHeightDgv(dgvTypeOfElementSetPicture, 300, allElementPicture.Length);
            foreach(ElementPicture elementPicture in allElementPicture)
            {
                dgvTypeOfElementSetPicture.Rows.Add(elementPicture.Id, elementPicture.Name, elementPicture.Picture);
            }
        }

        //ShowVoidEntity
        public void ShowVoidTypeOfElement()
        {
            tbTypeOfElementName.Clear();
            tbTypeOfElementSquare.Clear();
            tbTypeOfElementHeight.Clear();
            tbTypeOfElementLength.Clear();
            pbTypeOfElementPicture.Image = null;
            pbTypeOfElementPicture.Visible = false;
            lblCheckTypeOfElementName.Visible = false;
            lblCheckTypeOfElementSquare.Visible = false;
            lblCheckTypeOfElementHeight.Visible = false;
            lblCheckTypeOfElementLength.Visible = false;
            pbCheckMarkTypeOfElementName.Visible = false;
            pbCheckMarkTypeOfElementSquare.Visible = false;
            pbCheckMarkTypeOfElementHeight.Visible = false;
            pbCheckMarkTypeOfElementLength.Visible = false;
            pbCheckMarkTypeOfElementPicture.Visible = false;
            dgvTypeOfElementSetPicture.Rows.Clear();
        }

        //ShowSelectedEntity
        public void ShowSelectedTypeOfElement()
        {
            var selectedTypeOfElement = SelectedTypeOfElement();
            tbTypeOfElementName.Text = selectedTypeOfElement.Name;
            tbTypeOfElementSquare.Text = selectedTypeOfElement.Square.ToString();
            tbTypeOfElementHeight.Text = selectedTypeOfElement.Height.ToString();
            tbTypeOfElementLength.Text = selectedTypeOfElement.Length.ToString();

            dgvTypeOfElementSetPicture.Rows.Clear();
            var elementPicture = ReadElementPicture(selectedTypeOfElement.IdElementPicture);
            dgvTypeOfElementSetPicture.Rows.Add(elementPicture.Id, elementPicture.Name);
            dgvTypeOfElementSetPicture.SelectAll();

            lblCheckTypeOfElementName.Visible = false;
            lblCheckTypeOfElementSquare.Visible = false;
            lblCheckTypeOfElementHeight.Visible = false;
            lblCheckTypeOfElementLength.Visible = false;
            pbCheckMarkTypeOfElementName.Visible = false;
            pbCheckMarkTypeOfElementSquare.Visible = false;
            pbCheckMarkTypeOfElementHeight.Visible = false;
            pbCheckMarkTypeOfElementLength.Visible = false;
            pbCheckMarkTypeOfElementPicture.Visible = false;
            
        }

        //TbDate_Click

        //DtpDate_valueChanged

        //Tb_TextChanged
        private void TbTypeOfElementName_TextChanged(object sender, EventArgs e)
        {
            lblCheckTypeOfElementName.Visible = 
                !TypeOfElement.NameIsMatch(tbTypeOfElementName.Text);
            pbCheckMarkTypeOfElementName.Visible = 
                TypeOfElement.NameIsMatch(tbTypeOfElementName.Text);
        }

        private void TbTypeOfElementSquare_TextChanged(object sender, EventArgs e)
        {
            lblCheckTypeOfElementSquare.Visible =
                !TypeOfElement.DecimalIsMatch(tbTypeOfElementSquare.Text);
            pbCheckMarkTypeOfElementSquare.Visible =
                TypeOfElement.DecimalIsMatch(tbTypeOfElementSquare.Text);
        }

        private void TbTypeOfElementHeight_TextChanged(object sender, EventArgs e)
        {
            lblCheckTypeOfElementHeight.Visible =
                !TypeOfElement.DecimalIsMatch(tbTypeOfElementHeight.Text);
            pbCheckMarkTypeOfElementHeight.Visible =
                TypeOfElement.DecimalIsMatch(tbTypeOfElementHeight.Text);
        }

        private void TbTypeOfElementLength_TextChanged(object sender, EventArgs e)
        {
            lblCheckTypeOfElementLength.Visible =
               !TypeOfElement.DecimalIsMatch(tbTypeOfElementLength.Text);
            pbCheckMarkTypeOfElementLength.Visible =
                TypeOfElement.DecimalIsMatch(tbTypeOfElementLength.Text);
        }

        //BtnSwitchCancel_Click
        private void BtnTypeOfElementSwitchCancel_Click(object sender, EventArgs e)
        {
            ShowVoidTypeOfElement();
            gbTypeOfElementData.Enabled = false;
            gbAllTypesOfElement.Enabled = true;
            btnTypeOfElementCreate.Visible = false;
            btnTypeOfElementUpdate.Visible = false;
            btnTypeOfElementSwitchCancel.Visible = false;

            btnTypeOfElementSwitchSetPicture.Enabled = true;
            btnTypeOfElementSetPicture.Visible = false;
            btnTypeOfElementCancelPicture.Visible = false;
            dgvTypeOfElementSetPicture.Rows.Clear();
            dgvTypeOfElementSetPicture.Visible = false;
            gbTypeOfElementData.Height = 315;
        }

        //BtnSwitchCreate_Click
        private void BtnTypeOfElementSwitchCreate_Click(object sender, EventArgs e)
        {
            ShowVoidTypeOfElement();
            gbTypeOfElementData.Enabled = true;
            btnTypeOfElementCreate.Visible = true;
            btnTypeOfElementSwitchCancel.Visible = true;
        }

        private void BtnTypeOfElementSwitchSetPicture_Click(object sender, EventArgs e)
        {
            btnTypeOfElementSwitchSetPicture.Enabled = false;
            btnTypeOfElementSetPicture.Visible = true;
            btnTypeOfElementCancelPicture.Visible = true;
            btnTypeOfElementSwitchCancel.Visible = false;
            ShowAllElementPictureInTypeOfWork();
            dgvTypeOfElementSetPicture.Visible = true;
            gbTypeOfElementData.Height = 615;
        }

        private void BtnTypeOfElementSetPicture_Click(object sender, EventArgs e)
        {
            //Need test
            btnTypeOfElementSwitchSetPicture.Enabled = true;
            btnTypeOfElementSetPicture.Visible = false;
            btnTypeOfElementCancelPicture.Visible = false;
            btnTypeOfElementSwitchCancel.Visible = true;
            dgvTypeOfElementSetPicture.Visible = false;
            gbTypeOfElementData.Height = 315;
        }

        private void BtnTypeOfElementCancelPicture_Click(object sender, EventArgs e)
        {
            btnTypeOfElementSwitchSetPicture.Enabled = true;
            btnTypeOfElementSetPicture.Visible = false;
            btnTypeOfElementCancelPicture.Visible = false;
            btnTypeOfElementSwitchCancel.Visible = true;
            dgvTypeOfElementSetPicture.Rows.Clear();
            dgvTypeOfElementSetPicture.Visible = false;
            gbTypeOfElementData.Height = 315;
        }

        private void DgvTypeOfElementSetPicture_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvTypeOfElementSetPicture.SelectedRows.Count == 0)
            {
                pbTypeOfElementPicture.Image = null;
                pbTypeOfElementPicture.Visible = false;
            }
            else
            {
                pbTypeOfElementPicture.Image = SelectedElementPictureInTypeOfElement().Picture;
                pbTypeOfElementPicture.Visible = true;
            }
        }

        //BtnCreate_Click
        private void BtnTypeOfElementCreate_Click(object sender, EventArgs e)
        {
            if (TypeOfElement.NameIsMatch(tbTypeOfElementName.Text) &&
                TypeOfElement.DecimalIsMatch(tbTypeOfElementSquare.Text) &&
                TypeOfElement.DecimalIsMatch(tbTypeOfElementHeight.Text) &&
                TypeOfElement.DecimalIsMatch(tbTypeOfElementLength.Text) &&
                SelectedElementPictureInTypeOfElement().Id != 0)
            {
                string name = tbTypeOfElementName.Text;
                decimal square = Convert.ToDecimal(tbTypeOfElementSquare.Text);
                decimal height = Convert.ToDecimal(tbTypeOfElementHeight.Text);
                decimal length = Convert.ToDecimal(tbTypeOfElementLength.Text);
                int idElementPicture = SelectedElementPictureInTypeOfElement().Id;
                TypeOfElement typeOfElement = new TypeOfElement(
                    name, idElementPicture, square, height, length);
                try
                {
                    typeOfElement.Create(driver);
                    ShowVoidTypeOfElement();
                    ShowAllTypesOfElement();
                    gbTypeOfElementData.Enabled = false;
                    btnTypeOfElementCreate.Visible = false;
                    btnTypeOfElementSwitchCancel.Visible = false;
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
        private void BtnTypeOfElementSwitchUpdate_Click(object sender, EventArgs e)
        {
            ShowSelectedTypeOfElement();
            gbTypeOfElementData.Enabled = true;
            gbAllTypesOfElement.Enabled = false;
            btnTypeOfElementUpdate.Visible = true;
            btnTypeOfElementSwitchCancel.Visible = true;
        }

        //BtnUpdate_Click
        private void BtnTypeOfElementUpdate_Click(object sender, EventArgs e)
        {
            var typeOfElement = SelectedTypeOfElement();
            if (typeOfElement.Id == -1) return;
            if (TypeOfElement.NameIsMatch(tbTypeOfElementName.Text) &&
                TypeOfElement.DecimalIsMatch(tbTypeOfElementSquare.Text) &&
                TypeOfElement.DecimalIsMatch(tbTypeOfElementHeight.Text) &&
                TypeOfElement.DecimalIsMatch(tbTypeOfElementLength.Text) &&
                SelectedElementPictureInTypeOfElement().Id != 0)
            {
                typeOfElement.Name = tbTypeOfElementName.Text;
                typeOfElement.Square = Convert.ToDecimal(tbTypeOfElementSquare.Text);
                typeOfElement.Height = Convert.ToDecimal(tbTypeOfElementHeight.Text);
                typeOfElement.Length = Convert.ToDecimal(tbTypeOfElementLength.Text);
                typeOfElement.IdElementPicture = SelectedElementPictureInTypeOfElement().Id;
                try
                {
                    typeOfElement.Update(driver);
                    ShowVoidTypeOfElement();
                    ShowAllTypesOfElement();
                    gbTypeOfElementData.Enabled = false;
                    gbAllTypesOfElement.Enabled = true;
                    btnTypeOfElementUpdate.Visible = false;
                    btnTypeOfElementSwitchCancel.Visible = false;
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
        private void BtnTypeOfElementDelete_Click(object sender, EventArgs e)
        {
            var typeOfElement = SelectedTypeOfElement();
            if (typeOfElement.Id == -1) return;
            DialogResult result = MessageBox.Show
                         ($"Вы действительно хотите безвозвратно удалить элемент фасада" +
                         $"{typeOfElement.Name}?",
                         "Удаление элемента фасада", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    typeOfElement.Delete(driver);
                    MessageBox.Show($"Элемент фасада {typeOfElement.Name} удален",
                        "Удаление элемент фасада", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowAllTypesOfElement();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnTypeOfElementAddToProject_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (actualProject.Id == -1)
            {
                MessageBox.Show("Необходимо сохранить текущий проект", "Сообщение об ошибке",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedTypeOfElement = SelectedTypeOfElement();
            if (selectedTypeOfElement.Id == -1) return;
            try
            {
                actualProject.AddTypeOfElement(driver, SelectedTypeOfElement().Id);
                MessageBox.Show(
                    $"Элемент фасада {selectedTypeOfElement.Name} добавлен в текущий проект",
                   "Добавление элемента в проект", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ShowTypesOfElementInProject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
               
        }

        private void BtnTypeOfElementDeleteFromProject_Click(object sender, EventArgs e)
        {
            if (actualProject.State == ProjectState.Canceled ||
                actualProject.State == ProjectState.Completed)
            {
                MessageBox.Show("Изменение отмененого или завершенного проекта не возможно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedTypeOfElement = SelectedTypeOfElementInProject();
            if (selectedTypeOfElement.Id == -1) return;
            DialogResult result = MessageBox.Show(
                $"Вы действительно хотите безвозвратно удалить элемент фасада " +
                $"{selectedTypeOfElement.Name} из проекта {actualProject.ToString()}?",
                "Удаление элемента фасада из проекта", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    actualProject.DeleteTypeOfElement(driver, selectedTypeOfElement.Id);
                    MessageBox.Show($"Элемент фасада {selectedTypeOfElement.Name} " +
                        $"удален из текущего проекта", "Удаление пользователя из проекта", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTypesOfElementInProject();
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

