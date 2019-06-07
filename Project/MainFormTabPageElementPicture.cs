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
        private ElementPicture[] ReadAllElementPicture()
        {
            return ReadAllObjectT<ElementPicture>(driver.ReadAllElementPictures);
        }

        private ElementPicture ReadElementPicture(int idForSearch)
        {
            return ReadObject<ElementPicture>(idForSearch, driver.ReadElementPicture);
        }

        private ElementPicture ReadElementPictureByTypeOfElement(int idTypeOfElement)
        {
            return ReadObject<ElementPicture>(idTypeOfElement, driver.GetElementPictureByTypeOfElement);
        }

        private ElementPicture SelectedElementPicture()
        {
            return SelectedObject<ElementPicture>(dgvAllElementPicture, driver.ReadElementPicture);
        }

        private void ShowAllElementPictures()
        {
            var AllElementPictures = ReadAllElementPicture();
            ClearAndSetHeightDgv(
                dgvAllElementPicture, gbAllElementPicture, AllElementPictures.Length);
            foreach(ElementPicture picture in AllElementPictures)
            {
                dgvAllElementPicture.Rows.Add(picture.Id, picture.Name, picture.Picture);
            }
        }

        private void DgvAllElementPicture_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAllElementPicture.SelectedRows.Count != 0)
                pbElementPictureSelectedDgv.Image = SelectedElementPicture().Picture;
            else ClearAndSetHeightDgv(dgvPaymentsByProject, gbAllPayments, 0);
        }

        private void ShowVoidElementPicture()
        {
            tbElementPictureName.Clear();
            pbElementPictureLoadContent.Image = null;
            pbElementPictureLoadContent.Visible = false;
            lblCheckElementPictureName.Visible = false;
            pbCheckMarkElementPictureName.Visible = false;
            pbCheckMarkElementPictureLoadContent.Visible = false;
        }

        private void ShowSelectedElementPicture()
        {
            var selectedElementPicture = SelectedElementPicture();
            tbElementPictureName.Text = selectedElementPicture.Name;
            pbElementPictureLoadContent.Image = selectedElementPicture.Picture;
            pbElementPictureLoadContent.Visible = true;
            lblCheckElementPictureName.Visible = false;
            pbCheckMarkElementPictureName.Visible = false;
            pbCheckMarkElementPictureLoadContent.Visible = false;
        }

        private void TbElementPictureName_TextChanged(object sender, EventArgs e)
        {
            lblCheckElementPictureName.Visible = 
                !(ElementPicture.NameIsMatch(tbElementPictureName.Text));
            pbCheckMarkElementPictureName.Visible =
                ElementPicture.NameIsMatch(tbElementPictureName.Text);
        }

        private void PbElementPictureLoadContent_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pbCheckMarkElementPictureLoadContent.Visible =
                pbElementPictureLoadContent.Image != null;
        }

        private void BtnElementPictureSwitchCancel_Click(object sender, EventArgs e)
        {
            ShowVoidElementPicture();
            gbElementPictureNamePicture.Enabled = false;
            btnElementPictureSwitchCancel.Visible = false;
            btnElementPictureCreate.Visible = false;
            btnElementPictureUpdate.Visible = false;
        }

        private void BtnElementPictureSwitchCreate_Click(object sender, EventArgs e)
        {
            ShowVoidElementPicture();
            gbElementPictureNamePicture.Enabled = true;
            btnElementPictureSwitchCancel.Visible = true;
            btnElementPictureCreate.Visible = true;
        }

        private void BtnElementPictureOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdElementOpenImage.ShowDialog() == DialogResult.Cancel) return;
            pbElementPictureLoadContent.Image = Image.FromFile(ofdElementOpenImage.FileName);
            pbElementPictureLoadContent.Visible = true; ;
        }

        private void BtnElementPictureCreate_Click(object sender, EventArgs e)
        {
            if(ElementPicture.NameIsMatch(tbElementPictureName.Text) && 
                pbElementPictureLoadContent.Image!=null)
            {
                var picture = new ElementPicture(
                    tbElementPictureName.Text, pbElementPictureLoadContent.Image);
                try
                {
                    picture.Create(driver);
                    ShowVoidElementPicture();
                    ShowAllElementPictures();
                    gbElementPictureNamePicture.Enabled = false;
                    btnElementPictureSwitchCancel.Visible = false;
                    btnElementPictureCreate.Visible = false;
                    MessageBox.Show($"Изображение {picture.Name} сохранено",
                    "Сохранение изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnElementPictureSwitchUpdate_Click(object sender, EventArgs e)
        {
            ShowSelectedElementPicture();
            gbElementPictureNamePicture.Enabled = true;
            btnElementPictureSwitchCancel.Visible = true;
            btnElementPictureUpdate.Visible = true;
        }

        private void BtnElementPictureUpdate_Click(object sender, EventArgs e)
        {
            var elementPicture = SelectedElementPicture();
            if (elementPicture.Id == -1) return;
            if(ElementPicture.NameIsMatch(tbElementPictureName.Text) &&
                pbElementPictureLoadContent.Image != null)
            {
                elementPicture.Name = tbElementPictureName.Text;
                elementPicture.Picture = pbElementPictureLoadContent.Image;
                try
                {
                    elementPicture.Update(driver);
                    ShowVoidElementPicture();
                    gbElementPictureNamePicture.Enabled = false;
                    btnElementPictureSwitchCancel.Visible = false;
                    btnElementPictureUpdate.Visible = false;
                    ShowAllElementPictures();
                    MessageBox.Show($"Изображение {elementPicture.Name} сохранено",
                        "Сохранение изображения", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void BtnElementPictureDelete_Click(object sender, EventArgs e)
        {
            var elementPicture = SelectedElementPicture();
            if (elementPicture.Id == -1) return;
            DialogResult result = MessageBox.Show
                         ($"Вы действительно хотите безвозвратно удалить изображение " +
                         $"{elementPicture.Name}?",
                         "Удаление изображения", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    elementPicture.Delete(driver);
                    MessageBox.Show($"Изображение {elementPicture.Name} удалено",
                        "Удаление изображения", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowAllElementPictures();
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
