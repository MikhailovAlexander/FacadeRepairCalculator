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
        private Payment[] ReadAllPayments()
        {
            return ReadAllObjectT<Payment>(driver.ReadAllPayments);
        }

        private Payment[] ReadPaymentsByProject(int idProject)
        {
            return ReadAllObjectsByParam<Payment>(idProject, driver.ReadPaymentsByProject);
        }

        private Project GetProjectFromPayment(Payment payment)
        {
            var project = new Project();
            try
            {
                project = payment.GetProject(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return project;
        }

        private User GetUserFromPayment(Payment payment)
        {
            var user = new User();
            try
            {
                user = payment.GetUser(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return user;
        }

        //SelectedEntity
        private User SelectedUserByPayments()
        {
            return SelectedObject<User>(dgvPaymentsInActualProjectByUsers, driver.ReadUser);
        }

        private Project SelectedProjectByPayments()
        {
            if (dgvSumPaymentsByProject.Rows.Count == 0) return new Project();
            return SelectedObject<Project>(dgvSumPaymentsByProject, driver.ReadProject);
        }

        Payment SelectedPayment()
        {
            if (rbAllPayments.Checked)
                return SelectedObject<Payment>(dgvAllPayments, driver.ReadPayment);
            else return SelectedObject<Payment>(dgvPaymentsByProject, driver.ReadPayment);
        }

        //Rb_CheckedChanged
        private void RbPaymentsByProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPaymentsByProjects.Checked)
            {
                dgvAllPayments.Visible = false;
                dgvSumPaymentsByProject.Visible = true;
                dgvPaymentsByProject.Visible = true;
                lblPaymentsByProjects.Visible = true;
                ShowSummPaymentsByProjects();
            }
            else
            {
                dgvAllPayments.Visible = true;
                dgvSumPaymentsByProject.Visible = false;
                dgvPaymentsByProject.Visible = false;
                lblPaymentsByProjects.Visible = false;
                ShowAllPayments();
            }
        }

        //ShowEntities
        public void ShowPayments()
        {
            if (rbAllPayments.Checked)
            {
                ShowAllPayments();
                ShowSummPaymentsInActualProjectByUsers();
            }
            else
            {
                ShowSummPaymentsByProjects();
                ShowPaymentsInProject();
            }
            ShowSummPaymentsInActualProjectByUsers();
        }

        private void ShowAllPayments()
        {
            var allPayments = ReadAllPayments();
            ClearAndSetHeightDgv(dgvAllPayments, gbAllPayments, allPayments.Length);
            foreach (Payment payment in allPayments)
            {
                dgvAllPayments.Rows.Add(payment.Id, GetProjectFromPayment(payment).ToString(),
                    GetUserFromPayment(payment).ToString(), payment.DateOfPayment.Date,
                    payment.Amount);
            }
            dgvAllPayments.Visible = true;
            dgvSumPaymentsByProject.Visible = false;
            dgvPaymentsByProject.Visible = false;
        }

        private void ShowSummPaymentsByProjects()
        {
            var allPayments = ReadAllPayments();
            var paymentsSumm =
                from payment in allPayments
                group payment by payment.IdProject into g
                select new { idProject = g.Key, summ = g.Sum(x => x.Amount) };
            ClearAndSetHeightDgv(
                dgvSumPaymentsByProject, gbAllPayments, paymentsSumm.Count());
            foreach (var group in paymentsSumm)
            {
                var project = ReadObject<Project>(group.idProject, driver.ReadProject);
                dgvSumPaymentsByProject.Rows.Add(
                    project.Id, project.Name, group.summ);
            }
        }

        private void ShowPaymentsInProject()
        {
            var selectedProject = SelectedProjectByPayments();
            if (selectedProject.Id == -1)
            {
                ClearAndSetHeightDgv(dgvPaymentsByProject, gbAllPayments, 0);
                return;
            }
            var paymentsInProject = ReadPaymentsByProject(selectedProject.Id);
            ClearAndSetHeightDgv(dgvPaymentsByProject, gbAllPayments, paymentsInProject.Length);
            foreach (Payment payment in paymentsInProject)
            {
                User user = GetUserFromPayment(payment);
                dgvPaymentsByProject.Rows.Add(
                    payment.Id, user.Name, payment.DateOfPayment, payment.Amount);
            }
        }

        private void DgvSumPaymentsByProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSumPaymentsByProject.SelectedRows.Count != 0)
                ShowPaymentsInProject();
            else ClearAndSetHeightDgv(dgvPaymentsByProject, gbAllPayments, 0);
        }


        private void ShowSummPaymentsInActualProjectByUsers()
        {
            if (actualProject.Id == -1) return;
            var usersInProject =
                ReadAllObjectsByParam<User>(actualProject.Id, driver.ReadUsersInProject);
            Payment[] allPaymentsByProject = ReadAllObjectsByParam<Payment>(
                actualProject.Id, driver.ReadPaymentsByProject);
            ClearAndSetHeightDgv(dgvPaymentsInActualProjectByUsers, gbPaymentsInActualProject,
                usersInProject.Count());
            foreach (User user in usersInProject)
            {
                var summ = (from payment in allPaymentsByProject
                            where payment.IdUser == user.Id
                            select payment.Amount).Sum();
                string complete = GetStringFromDecimalValue(
                    GetAmountCompletedWorkByProjectAndUser(actualProject.Id, user));
                string accept = GetStringFromDecimalValue(
                    GetAmountAcceptedWorkByProjectAndUser(actualProject.Id, user));
                string reject = GetStringFromDecimalValue(
                    GetAmountRejectedWorkByProjectAndUser(actualProject.Id, user));
                dgvPaymentsInActualProjectByUsers.Rows.Add(user.Id, user.Name, summ, complete, 
                    accept, reject);
            }
        }

        private void ShowPaymentsByUserInProject(int idUser)
        {
            var paymentsByProject = ReadPaymentsByProject(actualProject.Id);
            if (idUser == -1)
            {
                lblPaymentsBySelectedUser.Visible = true;
                ClearAndSetHeightDgv(dgvPaymentsByUserInProject, gbPaymentsInActualProject, 0);
                return;
            }
            lblPaymentsBySelectedUser.Visible = false;
            var paymentsByUser =
                from payment in paymentsByProject where payment.IdUser == idUser select payment;
            ClearAndSetHeightDgv(dgvPaymentsByUserInProject, gbPaymentsInActualProject,
                paymentsByUser.Count());
            foreach (Payment payment in paymentsByUser)
            {
                dgvPaymentsByUserInProject.Rows.Add(payment.DateOfPayment.Date, payment.Amount);
            }
        }

        private void DgvPaymentsInActualProjectByUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPaymentsInActualProjectByUsers.SelectedRows.Count != 0)
                ShowPaymentsByUserInProject(SelectedUserByPayments().Id);
            else ClearAndSetHeightDgv(dgvPaymentsByUserInProject, gbPaymentsInActualProject, 0);
        }
        //ShowVoidEntity
        private void ShowVoidPayment()
        {
            tbPaymentProject.Clear();
            tbPaymentUser.Clear();
            dtpPaymentDate.Value = new DateTime(1970, 1, 1);
            tbPaymentAmout.Clear();
            lblCheckPaymentDate.Visible = false;
            lblCheckPaymentAmount.Visible = false;
            pbCheckMarkPaymentDate.Visible = false;
            pbCheckMarkPaymentAmount.Visible = false;
        }

        //ShowSelectedEntity
        private void ShowSelectedPayment()
        {
            var payment = SelectedPayment();
            tbPaymentProject.Text = GetProjectFromPayment(payment).ToString();
            tbPaymentUser.Text = GetUserFromPayment(payment).ToString();
            dtpPaymentDate.Value = payment.DateOfPayment.Date;
            tbPaymentAmout.Text = Convert.ToString(payment.Amount);
            lblCheckPaymentDate.Visible = false;
            lblCheckPaymentAmount.Visible = false;
            pbCheckMarkPaymentDate.Visible = false;
            pbCheckMarkPaymentAmount.Visible = false;
        }


        //TbDate_Click
        private void TbPaymentDate_Click(object sender, EventArgs e)
        {
            tbPaymentDate.Visible = false;
            dtpPaymentDate.Visible = true;
        }

        //DtpDate_valueChanged
        private void DtpPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            lblCheckPaymentDate.Visible = !(dtpPaymentDate.Value >= actualProject.DateOfStart);
            pbCheckMarkPaymentDate.Visible = dtpPaymentDate.Value >= actualProject.DateOfStart;
            ShowDateInTb(tbPaymentDate, dtpPaymentDate);
        }

        //Tb_TextChanged
        private void TbPaymentAmout_TextChanged(object sender, EventArgs e)
        {
            lblCheckPaymentAmount.Visible = !(Payment.DecimalIsMatch(tbPaymentAmout.Text));
            pbCheckMarkPaymentAmount.Visible = Payment.DecimalIsMatch(tbPaymentAmout.Text);
        }

        //BtnSwitchCreate_Click
        private void BtnPaymentSwitchCreate_Click(object sender, EventArgs e)
        {
            if (actualProject.Id == -1 || actualProject.State != ProjectState.Actual)
            {
                MessageBox.Show("Добавить оплату можно только в Текущий проект",
                    "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SelectedUserByPayments().Id == -1)
            {
                MessageBox.Show("Исполнитель в текущем проекте не выбран", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ///Don't forget
            gbAllProjects.Enabled = false;
            gbAllUsers.Enabled = false;
            gbPaymentData.Enabled = true;
            btnPaymentCreate.Visible = true;
            btnPaymentSwitchCancel.Visible = true;
            tbPaymentProject.Text = actualProject.ToString();
            tbPaymentUser.Text = SelectedUserByPayments().ToString();
            dtpPaymentDate.Value = DateTime.Now;
        }

        //BtnSwitchCancel_Click
        private void BtnPaymentSwitchCancel_Click(object sender, EventArgs e)
        {
            gbAllProjects.Enabled = true;
            gbAllUsers.Enabled = true;
            gbAllPayments.Enabled = true;
            gbPaymentData.Enabled = false;
            btnPaymentCreate.Visible = false;
            btnPaymentSwitchCancel.Visible = false;
            btnPaymentUpdate.Visible = false;
            ShowVoidPayment();
        }
        //BtnCreate_Click
        private void BtnPaymentCreate_Click(object sender, EventArgs e)
        {
            if (actualProject.DateOfPaymentIsChecked(dtpPaymentDate.Value) &&
                Payment.DecimalIsMatch(tbPaymentAmout.Text))
            {
                if (SelectedUserByPayments().Id == -1)
                {
                    MessageBox.Show("Исполнитель в текущем проекте не найден",
                        "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var payment = new Payment(SelectedUserByPayments().Id, actualProject.Id,
                    dtpPaymentDate.Value, Convert.ToDecimal(tbPaymentAmout.Text));
                try
                {
                    if (payment.CheckUserInProject(driver))
                    {
                        payment.Create(driver);
                        ShowActualProject();
                        ShowProjects();
                        ShowPayments();
                        ShowVoidPayment();
                        gbAllProjects.Enabled = true;
                        gbAllUsers.Enabled = true;
                        gbPaymentData.Enabled = false;
                        btnPaymentCreate.Visible = false;
                        btnPaymentSwitchCancel.Visible = false;
                    }
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
        private void BtnPaymentSwitchUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedPayment().Id == -1) return;
            gbAllPayments.Enabled = false;
            gbPaymentData.Enabled = true;
            btnPaymentUpdate.Visible = true;
            btnPaymentSwitchCancel.Visible = true;
            ShowSelectedPayment();
        }

        //BtnUpdate_Click
        private void BtnPaymentUpdate_Click(object sender, EventArgs e)
        {
            var payment = SelectedPayment();
            var project = GetProjectFromPayment(payment);
            if (project.DateOfPaymentIsChecked(dtpPaymentDate.Value) &&
                Payment.DecimalIsMatch(tbPaymentAmout.Text))
            {
                payment.DateOfPayment = dtpPaymentDate.Value;
                payment.Amount = Convert.ToDecimal(tbPaymentAmout.Text);
                try
                {
                    payment.Update(driver);
                    gbAllPayments.Enabled = true;
                    gbPaymentData.Enabled = false;
                    btnPaymentUpdate.Visible = false;
                    btnPaymentSwitchCancel.Visible = false;
                    ShowActualProject();
                    ShowProjects();
                    ShowPayments();
                    ShowVoidPayment();
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
        private void BtnPaymentDelete_Click(object sender, EventArgs e)
        {
            var payment = SelectedPayment();
            if (payment.Id == -1) return;
            string projectName = GetProjectFromPayment(payment).ToString();
            string userName = GetUserFromPayment(payment).Name;
            DialogResult result = MessageBox.Show
                         ($"Вы действительно хотите удалить безвозвратно оплату по проекту" +
                         $"{projectName} исполнителю {userName} {payment.Amount}?",
                         "Удаление оплаты", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    payment.Delete(driver);
                    MessageBox.Show($"Оплата по проекту {projectName} исполнителю {userName} " +
                        $"{payment.Amount} удалена", "Удаление оплаты", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ShowPayments();
                    ShowActualProject();
                    ShowProjects();
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
