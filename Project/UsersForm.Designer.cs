namespace Project
{
    partial class UsersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userManagerAccessColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonChangeUserPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIndexColumn,
            this.userNameColumn,
            this.userPassportColumn,
            this.userLoginColumn,
            this.userManagerAccessColumn});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // UserIndexColumn
            // 
            this.UserIndexColumn.Frozen = true;
            this.UserIndexColumn.HeaderText = "№";
            this.UserIndexColumn.Name = "UserIndexColumn";
            this.UserIndexColumn.ReadOnly = true;
            this.UserIndexColumn.Width = 30;
            // 
            // userNameColumn
            // 
            this.userNameColumn.Frozen = true;
            this.userNameColumn.HeaderText = "ФИО пользователя";
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            this.userNameColumn.Width = 300;
            // 
            // userPassportColumn
            // 
            this.userPassportColumn.HeaderText = "Паспортные данные";
            this.userPassportColumn.Name = "userPassportColumn";
            this.userPassportColumn.ReadOnly = true;
            this.userPassportColumn.Width = 200;
            // 
            // userLoginColumn
            // 
            this.userLoginColumn.HeaderText = "Логин";
            this.userLoginColumn.Name = "userLoginColumn";
            this.userLoginColumn.ReadOnly = true;
            this.userLoginColumn.Width = 200;
            // 
            // userManagerAccessColumn
            // 
            this.userManagerAccessColumn.HeaderText = "Права доступа менеджера";
            this.userManagerAccessColumn.Name = "userManagerAccessColumn";
            this.userManagerAccessColumn.ReadOnly = true;
            this.userManagerAccessColumn.Width = 90;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddUser.Location = new System.Drawing.Point(662, 378);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(110, 49);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateUser.Location = new System.Drawing.Point(458, 378);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(110, 49);
            this.buttonUpdateUser.TabIndex = 3;
            this.buttonUpdateUser.Text = "Редактировать данные пользователя";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.ButtonUpdateUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(42, 378);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(110, 49);
            this.buttonDeleteUser.TabIndex = 4;
            this.buttonDeleteUser.Text = "Удалить пользователя";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // buttonChangeUserPassword
            // 
            this.buttonChangeUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeUserPassword.Location = new System.Drawing.Point(254, 378);
            this.buttonChangeUserPassword.Name = "buttonChangeUserPassword";
            this.buttonChangeUserPassword.Size = new System.Drawing.Size(110, 49);
            this.buttonChangeUserPassword.TabIndex = 5;
            this.buttonChangeUserPassword.Text = "Сменить пароль пользователя";
            this.buttonChangeUserPassword.UseVisualStyleBackColor = true;
            this.buttonChangeUserPassword.Click += new System.EventHandler(this.ButtonChangeUserPassword_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.buttonChangeUserPassword);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonUpdateUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersForm";
            this.Text = "Пользователи системы";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassportColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userManagerAccessColumn;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonChangeUserPassword;
    }
}