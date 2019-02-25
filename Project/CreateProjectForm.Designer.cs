namespace Project
{
    partial class CreateProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddressCheck = new System.Windows.Forms.Label();
            this.labelNameCheck = new System.Windows.Forms.Label();
            this.pictureBoxCheckMarkAddress = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckMarkName = new System.Windows.Forms.PictureBox();
            this.buttonSaveProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNameProject = new System.Windows.Forms.Label();
            this.textBoxProjectNameInput = new System.Windows.Forms.TextBox();
            this.labelUserAddress = new System.Windows.Forms.Label();
            this.textBoxProjectAddressInput = new System.Windows.Forms.TextBox();
            this.labelUserClient = new System.Windows.Forms.Label();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxClientNameInput = new System.Windows.Forms.TextBox();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.buttonAddClientCancel = new System.Windows.Forms.Button();
            this.labelProjectUsers = new System.Windows.Forms.Label();
            this.dataGridViewUserInProject = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManagerAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddUsers = new System.Windows.Forms.Button();
            this.buttonRemoveUsers = new System.Windows.Forms.Button();
            this.groupBoxUserInProject = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInProject)).BeginInit();
            this.groupBoxUserInProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAddressCheck
            // 
            this.labelAddressCheck.AutoSize = true;
            this.labelAddressCheck.ForeColor = System.Drawing.Color.Red;
            this.labelAddressCheck.Location = new System.Drawing.Point(11, 145);
            this.labelAddressCheck.Name = "labelAddressCheck";
            this.labelAddressCheck.Size = new System.Drawing.Size(126, 13);
            this.labelAddressCheck.TabIndex = 46;
            this.labelAddressCheck.Text = "Введите адрес проекта";
            this.labelAddressCheck.Visible = false;
            // 
            // labelNameCheck
            // 
            this.labelNameCheck.AutoSize = true;
            this.labelNameCheck.ForeColor = System.Drawing.Color.Red;
            this.labelNameCheck.Location = new System.Drawing.Point(11, 98);
            this.labelNameCheck.Name = "labelNameCheck";
            this.labelNameCheck.Size = new System.Drawing.Size(144, 13);
            this.labelNameCheck.TabIndex = 45;
            this.labelNameCheck.Text = "Введите название проекта";
            this.labelNameCheck.Visible = false;
            // 
            // pictureBoxCheckMarkAddress
            // 
            this.pictureBoxCheckMarkAddress.Location = new System.Drawing.Point(606, 119);
            this.pictureBoxCheckMarkAddress.Name = "pictureBoxCheckMarkAddress";
            this.pictureBoxCheckMarkAddress.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkAddress.TabIndex = 41;
            this.pictureBoxCheckMarkAddress.TabStop = false;
            this.pictureBoxCheckMarkAddress.Visible = false;
            // 
            // pictureBoxCheckMarkName
            // 
            this.pictureBoxCheckMarkName.Location = new System.Drawing.Point(606, 69);
            this.pictureBoxCheckMarkName.Name = "pictureBoxCheckMarkName";
            this.pictureBoxCheckMarkName.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkName.TabIndex = 40;
            this.pictureBoxCheckMarkName.TabStop = false;
            this.pictureBoxCheckMarkName.Visible = false;
            // 
            // buttonSaveProject
            // 
            this.buttonSaveProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveProject.Location = new System.Drawing.Point(481, 207);
            this.buttonSaveProject.Name = "buttonSaveProject";
            this.buttonSaveProject.Size = new System.Drawing.Size(152, 26);
            this.buttonSaveProject.TabIndex = 37;
            this.buttonSaveProject.Text = "Сохранить проект";
            this.buttonSaveProject.UseVisualStyleBackColor = true;
            this.buttonSaveProject.Click += new System.EventHandler(this.ButtonSaveProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Введите данные нового проекта";
            // 
            // labelNameProject
            // 
            this.labelNameProject.AutoSize = true;
            this.labelNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameProject.Location = new System.Drawing.Point(11, 71);
            this.labelNameProject.Name = "labelNameProject";
            this.labelNameProject.Size = new System.Drawing.Size(130, 17);
            this.labelNameProject.TabIndex = 25;
            this.labelNameProject.Text = "Название проекта";
            // 
            // textBoxProjectNameInput
            // 
            this.textBoxProjectNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProjectNameInput.Location = new System.Drawing.Point(230, 71);
            this.textBoxProjectNameInput.Name = "textBoxProjectNameInput";
            this.textBoxProjectNameInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxProjectNameInput.TabIndex = 26;
            this.textBoxProjectNameInput.TextChanged += new System.EventHandler(this.TextBoxProjectNameInput_TextChanged);
            // 
            // labelUserAddress
            // 
            this.labelUserAddress.AutoSize = true;
            this.labelUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserAddress.Location = new System.Drawing.Point(11, 119);
            this.labelUserAddress.Name = "labelUserAddress";
            this.labelUserAddress.Size = new System.Drawing.Size(48, 17);
            this.labelUserAddress.TabIndex = 27;
            this.labelUserAddress.Text = "Адрес";
            // 
            // textBoxProjectAddressInput
            // 
            this.textBoxProjectAddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProjectAddressInput.Location = new System.Drawing.Point(230, 119);
            this.textBoxProjectAddressInput.Name = "textBoxProjectAddressInput";
            this.textBoxProjectAddressInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxProjectAddressInput.TabIndex = 28;
            this.textBoxProjectAddressInput.TextChanged += new System.EventHandler(this.TextBoxProjectAddressInput_TextChanged);
            // 
            // labelUserClient
            // 
            this.labelUserClient.AutoSize = true;
            this.labelUserClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserClient.Location = new System.Drawing.Point(13, 173);
            this.labelUserClient.Name = "labelUserClient";
            this.labelUserClient.Size = new System.Drawing.Size(70, 17);
            this.labelUserClient.TabIndex = 29;
            this.labelUserClient.Text = "Заказчик";
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(230, 173);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(369, 17);
            this.listBoxClient.TabIndex = 48;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddClient.Location = new System.Drawing.Point(16, 207);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(152, 26);
            this.buttonAddClient.TabIndex = 49;
            this.buttonAddClient.Text = "Добавить заказчика";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // textBoxClientNameInput
            // 
            this.textBoxClientNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxClientNameInput.Location = new System.Drawing.Point(174, 207);
            this.textBoxClientNameInput.Name = "textBoxClientNameInput";
            this.textBoxClientNameInput.Size = new System.Drawing.Size(459, 23);
            this.textBoxClientNameInput.TabIndex = 50;
            this.textBoxClientNameInput.Visible = false;
            this.textBoxClientNameInput.TextChanged += new System.EventHandler(this.TextBoxClientNameInput_TextChanged);
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCreateClient.Location = new System.Drawing.Point(174, 236);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(166, 27);
            this.buttonCreateClient.TabIndex = 51;
            this.buttonCreateClient.Text = "Сохранить заказчика";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Visible = false;
            this.buttonCreateClient.Click += new System.EventHandler(this.ButtonCreateClient_Click);
            // 
            // buttonAddClientCancel
            // 
            this.buttonAddClientCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddClientCancel.Location = new System.Drawing.Point(346, 236);
            this.buttonAddClientCancel.Name = "buttonAddClientCancel";
            this.buttonAddClientCancel.Size = new System.Drawing.Size(166, 27);
            this.buttonAddClientCancel.TabIndex = 52;
            this.buttonAddClientCancel.Text = "Не сохранять";
            this.buttonAddClientCancel.UseVisualStyleBackColor = true;
            this.buttonAddClientCancel.Visible = false;
            this.buttonAddClientCancel.Click += new System.EventHandler(this.ButtonAddClientCancel_Click);
            // 
            // labelProjectUsers
            // 
            this.labelProjectUsers.AutoSize = true;
            this.labelProjectUsers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelProjectUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelProjectUsers.Location = new System.Drawing.Point(12, 14);
            this.labelProjectUsers.Name = "labelProjectUsers";
            this.labelProjectUsers.Size = new System.Drawing.Size(155, 20);
            this.labelProjectUsers.TabIndex = 53;
            this.labelProjectUsers.Text = "Участники проекта";
            // 
            // dataGridViewUserInProject
            // 
            this.dataGridViewUserInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnUserName,
            this.ColumnManagerAccess});
            this.dataGridViewUserInProject.Location = new System.Drawing.Point(16, 63);
            this.dataGridViewUserInProject.Name = "dataGridViewUserInProject";
            this.dataGridViewUserInProject.RowHeadersVisible = false;
            this.dataGridViewUserInProject.Size = new System.Drawing.Size(533, 53);
            this.dataGridViewUserInProject.TabIndex = 54;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "№п/п";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Width = 50;
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.HeaderText = "ФИО участника";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.Width = 400;
            // 
            // ColumnManagerAccess
            // 
            this.ColumnManagerAccess.HeaderText = "Менеджер";
            this.ColumnManagerAccess.Name = "ColumnManagerAccess";
            this.ColumnManagerAccess.Width = 80;
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddUsers.Location = new System.Drawing.Point(572, 63);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(169, 26);
            this.buttonAddUsers.TabIndex = 55;
            this.buttonAddUsers.Text = "Добавить участника";
            this.buttonAddUsers.UseVisualStyleBackColor = true;
            this.buttonAddUsers.Click += new System.EventHandler(this.ButtonAddUsers_Click);
            // 
            // buttonRemoveUsers
            // 
            this.buttonRemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRemoveUsers.Location = new System.Drawing.Point(572, 104);
            this.buttonRemoveUsers.Name = "buttonRemoveUsers";
            this.buttonRemoveUsers.Size = new System.Drawing.Size(169, 26);
            this.buttonRemoveUsers.TabIndex = 56;
            this.buttonRemoveUsers.Text = "Удалить участника";
            this.buttonRemoveUsers.UseVisualStyleBackColor = true;
            // 
            // groupBoxUserInProject
            // 
            this.groupBoxUserInProject.Controls.Add(this.dataGridViewUserInProject);
            this.groupBoxUserInProject.Controls.Add(this.buttonRemoveUsers);
            this.groupBoxUserInProject.Controls.Add(this.labelProjectUsers);
            this.groupBoxUserInProject.Controls.Add(this.buttonAddUsers);
            this.groupBoxUserInProject.Location = new System.Drawing.Point(669, 12);
            this.groupBoxUserInProject.Name = "groupBoxUserInProject";
            this.groupBoxUserInProject.Size = new System.Drawing.Size(749, 218);
            this.groupBoxUserInProject.TabIndex = 57;
            this.groupBoxUserInProject.TabStop = false;
            this.groupBoxUserInProject.Visible = false;
            // 
            // CreateProjectForm
            // 
            this.AcceptButton = this.buttonSaveProject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 468);
            this.Controls.Add(this.groupBoxUserInProject);
            this.Controls.Add(this.buttonAddClientCancel);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.textBoxClientNameInput);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.labelAddressCheck);
            this.Controls.Add(this.labelNameCheck);
            this.Controls.Add(this.pictureBoxCheckMarkAddress);
            this.Controls.Add(this.pictureBoxCheckMarkName);
            this.Controls.Add(this.buttonSaveProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameProject);
            this.Controls.Add(this.textBoxProjectNameInput);
            this.Controls.Add(this.labelUserAddress);
            this.Controls.Add(this.textBoxProjectAddressInput);
            this.Controls.Add(this.labelUserClient);
            this.Name = "CreateProjectForm";
            this.Text = "Создание проекта";
            this.Load += new System.EventHandler(this.CreateProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInProject)).EndInit();
            this.groupBoxUserInProject.ResumeLayout(false);
            this.groupBoxUserInProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAddressCheck;
        private System.Windows.Forms.Label labelNameCheck;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkAddress;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkName;
        private System.Windows.Forms.Button buttonSaveProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNameProject;
        private System.Windows.Forms.TextBox textBoxProjectNameInput;
        private System.Windows.Forms.Label labelUserAddress;
        private System.Windows.Forms.TextBox textBoxProjectAddressInput;
        private System.Windows.Forms.Label labelUserClient;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxClientNameInput;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Button buttonAddClientCancel;
        private System.Windows.Forms.Label labelProjectUsers;
        private System.Windows.Forms.DataGridView dataGridViewUserInProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManagerAccess;
        private System.Windows.Forms.Button buttonAddUsers;
        private System.Windows.Forms.Button buttonRemoveUsers;
        private System.Windows.Forms.GroupBox groupBoxUserInProject;
    }
}