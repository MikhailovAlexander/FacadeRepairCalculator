namespace Project
{
    partial class UpdateUserForm
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
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoginCheck = new System.Windows.Forms.Label();
            this.labelPassportCheck = new System.Windows.Forms.Label();
            this.labelNameCheck = new System.Windows.Forms.Label();
            this.pictureBoxCheckMarkLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckMarkPassport = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckMarkName = new System.Windows.Forms.PictureBox();
            this.checkBoxManagerAccess = new System.Windows.Forms.CheckBox();
            this.labelManagerAccess = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.textBoxUserNameInput = new System.Windows.Forms.TextBox();
            this.labelUserPassport = new System.Windows.Forms.Label();
            this.textBoxUserPassportInput = new System.Windows.Forms.TextBox();
            this.textBoxUserLoginInput = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkName)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveUser.Location = new System.Drawing.Point(486, 229);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(152, 42);
            this.buttonSaveUser.TabIndex = 34;
            this.buttonSaveUser.Text = "Обновить данные пользователя";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            this.buttonSaveUser.Click += new System.EventHandler(this.ButtonSaveUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Внесение изменений в данные пользователя";
            // 
            // labelLoginCheck
            // 
            this.labelLoginCheck.AutoSize = true;
            this.labelLoginCheck.ForeColor = System.Drawing.Color.Red;
            this.labelLoginCheck.Location = new System.Drawing.Point(27, 180);
            this.labelLoginCheck.Name = "labelLoginCheck";
            this.labelLoginCheck.Size = new System.Drawing.Size(315, 13);
            this.labelLoginCheck.TabIndex = 48;
            this.labelLoginCheck.Text = "Введите в качестве логина адрес Вашей электронной почты";
            this.labelLoginCheck.Visible = false;
            // 
            // labelPassportCheck
            // 
            this.labelPassportCheck.AutoSize = true;
            this.labelPassportCheck.ForeColor = System.Drawing.Color.Red;
            this.labelPassportCheck.Location = new System.Drawing.Point(27, 135);
            this.labelPassportCheck.Name = "labelPassportCheck";
            this.labelPassportCheck.Size = new System.Drawing.Size(517, 13);
            this.labelPassportCheck.TabIndex = 47;
            this.labelPassportCheck.Text = "Введите данные в формате: 0000 000000 01.01.2000 г название подразделения выдавше" +
    "го паспорт";
            this.labelPassportCheck.Visible = false;
            // 
            // labelNameCheck
            // 
            this.labelNameCheck.AutoSize = true;
            this.labelNameCheck.ForeColor = System.Drawing.Color.Red;
            this.labelNameCheck.Location = new System.Drawing.Point(27, 88);
            this.labelNameCheck.Name = "labelNameCheck";
            this.labelNameCheck.Size = new System.Drawing.Size(299, 13);
            this.labelNameCheck.TabIndex = 46;
            this.labelNameCheck.Text = "Введите ФИО кирилицей с заглавных букв через пробел";
            this.labelNameCheck.Visible = false;
            // 
            // pictureBoxCheckMarkLogin
            // 
            this.pictureBoxCheckMarkLogin.Location = new System.Drawing.Point(622, 154);
            this.pictureBoxCheckMarkLogin.Name = "pictureBoxCheckMarkLogin";
            this.pictureBoxCheckMarkLogin.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkLogin.TabIndex = 45;
            this.pictureBoxCheckMarkLogin.TabStop = false;
            this.pictureBoxCheckMarkLogin.Visible = false;
            // 
            // pictureBoxCheckMarkPassport
            // 
            this.pictureBoxCheckMarkPassport.Location = new System.Drawing.Point(622, 109);
            this.pictureBoxCheckMarkPassport.Name = "pictureBoxCheckMarkPassport";
            this.pictureBoxCheckMarkPassport.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkPassport.TabIndex = 44;
            this.pictureBoxCheckMarkPassport.TabStop = false;
            this.pictureBoxCheckMarkPassport.Visible = false;
            // 
            // pictureBoxCheckMarkName
            // 
            this.pictureBoxCheckMarkName.Location = new System.Drawing.Point(622, 59);
            this.pictureBoxCheckMarkName.Name = "pictureBoxCheckMarkName";
            this.pictureBoxCheckMarkName.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkName.TabIndex = 43;
            this.pictureBoxCheckMarkName.TabStop = false;
            this.pictureBoxCheckMarkName.Visible = false;
            // 
            // checkBoxManagerAccess
            // 
            this.checkBoxManagerAccess.AutoSize = true;
            this.checkBoxManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxManagerAccess.Location = new System.Drawing.Point(246, 198);
            this.checkBoxManagerAccess.Name = "checkBoxManagerAccess";
            this.checkBoxManagerAccess.Size = new System.Drawing.Size(169, 21);
            this.checkBoxManagerAccess.TabIndex = 42;
            this.checkBoxManagerAccess.Text = "Предоставить доступ";
            this.checkBoxManagerAccess.UseVisualStyleBackColor = true;
            // 
            // labelManagerAccess
            // 
            this.labelManagerAccess.AutoSize = true;
            this.labelManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelManagerAccess.Location = new System.Drawing.Point(27, 198);
            this.labelManagerAccess.Name = "labelManagerAccess";
            this.labelManagerAccess.Size = new System.Drawing.Size(184, 17);
            this.labelManagerAccess.TabIndex = 41;
            this.labelManagerAccess.Text = "Права доступа менеджера";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameUser.Location = new System.Drawing.Point(27, 61);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(168, 17);
            this.labelNameUser.TabIndex = 35;
            this.labelNameUser.Text = "Фамилия Имя Отчество";
            // 
            // textBoxUserNameInput
            // 
            this.textBoxUserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserNameInput.Location = new System.Drawing.Point(246, 61);
            this.textBoxUserNameInput.Name = "textBoxUserNameInput";
            this.textBoxUserNameInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserNameInput.TabIndex = 36;
            this.textBoxUserNameInput.TextChanged += new System.EventHandler(this.textBoxUserNameInput_TextChanged);
            // 
            // labelUserPassport
            // 
            this.labelUserPassport.AutoSize = true;
            this.labelUserPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassport.Location = new System.Drawing.Point(27, 109);
            this.labelUserPassport.Name = "labelUserPassport";
            this.labelUserPassport.Size = new System.Drawing.Size(144, 17);
            this.labelUserPassport.TabIndex = 37;
            this.labelUserPassport.Text = "Паспортные данные";
            // 
            // textBoxUserPassportInput
            // 
            this.textBoxUserPassportInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserPassportInput.Location = new System.Drawing.Point(246, 109);
            this.textBoxUserPassportInput.Name = "textBoxUserPassportInput";
            this.textBoxUserPassportInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserPassportInput.TabIndex = 38;
            this.textBoxUserPassportInput.TextChanged += new System.EventHandler(this.textBoxUserPassportInput_TextChanged);
            // 
            // textBoxUserLoginInput
            // 
            this.textBoxUserLoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserLoginInput.Location = new System.Drawing.Point(246, 154);
            this.textBoxUserLoginInput.Name = "textBoxUserLoginInput";
            this.textBoxUserLoginInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserLoginInput.TabIndex = 40;
            this.textBoxUserLoginInput.TextChanged += new System.EventHandler(this.textBoxUserLoginInput_TextChanged);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserLogin.Location = new System.Drawing.Point(27, 154);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(47, 17);
            this.labelUserLogin.TabIndex = 39;
            this.labelUserLogin.Text = "Логин";
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 292);
            this.Controls.Add(this.labelLoginCheck);
            this.Controls.Add(this.labelPassportCheck);
            this.Controls.Add(this.labelNameCheck);
            this.Controls.Add(this.pictureBoxCheckMarkLogin);
            this.Controls.Add(this.pictureBoxCheckMarkPassport);
            this.Controls.Add(this.pictureBoxCheckMarkName);
            this.Controls.Add(this.checkBoxManagerAccess);
            this.Controls.Add(this.labelManagerAccess);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.textBoxUserNameInput);
            this.Controls.Add(this.labelUserPassport);
            this.Controls.Add(this.textBoxUserPassportInput);
            this.Controls.Add(this.textBoxUserLoginInput);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.label1);
            this.Name = "UpdateUserForm";
            this.Text = "Обновление данных пользователя";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoginCheck;
        private System.Windows.Forms.Label labelPassportCheck;
        private System.Windows.Forms.Label labelNameCheck;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkLogin;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkPassport;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkName;
        private System.Windows.Forms.CheckBox checkBoxManagerAccess;
        private System.Windows.Forms.Label labelManagerAccess;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.TextBox textBoxUserNameInput;
        private System.Windows.Forms.Label labelUserPassport;
        private System.Windows.Forms.TextBox textBoxUserPassportInput;
        private System.Windows.Forms.TextBox textBoxUserLoginInput;
        private System.Windows.Forms.Label labelUserLogin;
    }
}