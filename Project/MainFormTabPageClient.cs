using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        //ReadAllEntities
        private Client[] ReadAllClients()
        {
            return ReadAllObjectT<Client>(driver.ReadAllClients);
        }

        private Client ReadClient(int idClient)
        {
            return ReadObject<Client>(idClient, driver.ReadClient);
        }

        //SelectedEntity
        Client SelectedClient()
        {
            return SelectedObject<Client>(dgvAllClients, driver.ReadClient);
        }

        //Rb_CheckedChanged

        //ShowEntities
        void ShowClients()
        {
            var allClients = ReadAllObjectT(driver.ReadAllClients);
            ClearAndSetHeightDgv(dgvAllClients, gbAllClients, allClients.Length);
            foreach (Client client in allClients)
            {
                dgvAllClients.Rows.Add(client.Id, client.Name, client.Address, client.Inn);
            }
        }

        //ShowVoidEntity
        void ShowVoidClient()
        {
            tbClientName.Clear();
            tbClientAddress.Clear();
            tbClientInn.Clear();
            pbCheckMarkClientName.Visible = false;
            lblCheckClientName.Visible = false;
            pbCheckMarkClientAddress.Visible = false;
            lblCheckClientAddress.Visible = false;
            pbCheckMarkClientInn.Visible = false;
            lblCheckClientInn.Visible = false;
        }

        //ShowSelectedEntity
        void ShowSelectedClient()
        {
            var selectedClient = SelectedClient();
            tbClientName.Text = selectedClient.Name;
            tbClientAddress.Text = selectedClient.Address;
            tbClientInn.Text = selectedClient.Inn;
            pbCheckMarkClientName.Visible = false;
            lblCheckClientName.Visible = false;
            pbCheckMarkClientAddress.Visible = false;
            lblCheckClientAddress.Visible = false;
            pbCheckMarkClientInn.Visible = false;
            lblCheckClientInn.Visible = false;
        }

        //TbDate_Click

        //DtpDate_valueChanged


        //Tb_TextChanged
        private void TbClientName_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkClientName.Visible =
                Client.NameIsMatch(tbClientName.Text);
            lblCheckClientName.Visible = !Client.NameIsMatch(tbClientName.Text);
        }

        private void TbClientAddress_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkClientAddress.Visible =
                Client.AddressIsMatch(tbClientAddress.Text);
            lblCheckClientAddress.Visible = !Client.AddressIsMatch(tbClientAddress.Text);
        }

        private void TbClientInn_TextChanged(object sender, EventArgs e)
        {
            pbCheckMarkClientInn.Visible =
                Client.InnIsMatch(tbClientInn.Text);
            lblCheckClientInn.Visible = !Client.InnIsMatch(tbClientInn.Text);
        }

        //BtnSwitchCreate_Click
        private void BtnSwitchCreateClient_Click(object sender, EventArgs e)
        {
            ShowVoidClient();
            gbClientData.Enabled = true;
            btnUpdateClient.Visible = false;
            btnCreateClient.Visible = true;
            btnCancelClientSwitch.Visible = true;

        }

        //BtnSwitchCancel_Click
        private void BtnCancelClientSwitch_Click(object sender, EventArgs e)
        {
            gbAllClients.Enabled = true;
            gbClientData.Enabled = false;
            btnUpdateClient.Visible = false;
            btnCreateClient.Visible = false;
            btnCancelClientSwitch.Visible = false;
            ShowVoidClient();
        }

        //BtnCreate_Click
        private void BtnCreateClient_Click(object sender, EventArgs e)
        {
            if (Client.NameIsMatch(tbClientName.Text) &&
                Client.AddressIsMatch(tbClientAddress.Text) &&
                Client.InnIsMatch(tbClientInn.Text))
            {
                string name = tbClientName.Text;
                string address = tbClientAddress.Text;
                string inn = tbClientInn.Text;
                var client = new Client(name, address, inn);
                try
                {
                    client.Create(driver);
                    MessageBox.Show($"Данные заказчика {name} сохранены", "Сообщение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowClients();
                    ShowVoidClient();
                    btnCreateClient.Visible = false;
                    btnCancelClientSwitch.Visible = false;
                    gbClientData.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные заказчика {name} не были сохранены. " + ex.Message,
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //BtnSwitchUpdate_Click
        private void BtnSwitchUpdateClient_Click(object sender, EventArgs e)
        {
            gbAllClients.Enabled = false;
            gbClientData.Enabled = true;
            ShowSelectedClient();
            btnUpdateClient.Visible = true;
            btnCreateClient.Visible = false;
            btnCancelClientSwitch.Visible = true;
        }

        //BtnUpdate_Click
        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            if (Client.NameIsMatch(tbClientName.Text) &&
                Client.AddressIsMatch(tbClientAddress.Text) &&
                Client.InnIsMatch(tbClientInn.Text))
            {
                var selectedClient = SelectedClient();
                selectedClient.Name = tbClientName.Text;
                selectedClient.Address = tbClientAddress.Text;
                selectedClient.Inn = tbClientInn.Text;
                try
                {
                    selectedClient.Update(driver);
                    MessageBox.Show($"Данные заказчика {selectedClient.Name} сохранены",
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowClients();
                    ShowVoidClient();
                    btnUpdateClient.Visible = false;
                    btnCancelClientSwitch.Visible = false;
                    gbClientData.Enabled = false;
                    gbAllClients.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данные заказчика {selectedClient.Name} не были сохранены. " +
                        ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Сохранение данных невозможно, не все поля заполнены корректно",
                "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //BtnDelete_Click
        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            var selectedClient = SelectedClient();
            DialogResult result = MessageBox.Show
                          ($"Вы действительно хотите безвозвратно удалить заказчика " +
                          $"{selectedClient.Name}?", "Удаление заказчика",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedClient.Delete(driver);
                    MessageBox.Show($"Заказчик {selectedClient.Name} удален",
                        "Удаление заказчика", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowClients();
                    ShowVoidClient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddClientToProject_Click(object sender, EventArgs e)
        {
            if (actualProject.Id >= 0)
            {
                var selectedClient = SelectedClient();
                DialogResult result = MessageBox.Show
                          ($"Вы действительно хотите добавить заказчика {selectedClient.Name} " +
                          $"в текущий проект?", "Добавление заказчика в проект",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        actualProject.IdClient = selectedClient.Id;
                        actualProject.Update(driver);
                        MessageBox.Show($"Заказчик {selectedClient.Name} добавлен в текущий проект",
                            "Добавление заказчика в проект", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ShowClients();
                        ShowVoidClient();
                        ShowActualProject();
                        ShowProjects();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        actualProject = driver.ReadProject(actualProject.Id);
                    }
                }
            }
            else
                MessageBox.Show("Необходимо сохранить текущий проект", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
