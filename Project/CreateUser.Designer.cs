namespace Project
{
    partial class CreateUser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUserPassportInput = new System.Windows.Forms.TextBox();
            this.labelUserPassport = new System.Windows.Forms.Label();
            this.textBoxUserNameInput = new System.Windows.Forms.TextBox();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserLoginInput = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.textBoxUserPasswordInput = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxPasswordRepeatInput = new System.Windows.Forms.TextBox();
            this.labelЗPasswordRepeat = new System.Windows.Forms.Label();
            this.labelManagerAccess = new System.Windows.Forms.Label();
            this.checkBoxManagerAccess = new System.Windows.Forms.CheckBox();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.LabelPasswordsIsNotEuals = new System.Windows.Forms.Label();
            this.labelPasswordCheck = new System.Windows.Forms.Label();
            this.pictureBoxCheckMarkName = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckMarkPassport = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckMarkLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckMarkPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxRepeatMarkPassword = new System.Windows.Forms.PictureBox();
            this.labelNameCheck = new System.Windows.Forms.Label();
            this.labelPassportCheck = new System.Windows.Forms.Label();
            this.labelLoginCheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatMarkPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserPassportInput
            // 
            this.textBoxUserPassportInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserPassportInput.Location = new System.Drawing.Point(243, 119);
            this.textBoxUserPassportInput.Name = "textBoxUserPassportInput";
            this.textBoxUserPassportInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserPassportInput.TabIndex = 4;
            this.textBoxUserPassportInput.TextChanged += new System.EventHandler(this.TextBoxUserPassport_TextChanged);
            // 
            // labelUserPassport
            // 
            this.labelUserPassport.AutoSize = true;
            this.labelUserPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassport.Location = new System.Drawing.Point(24, 119);
            this.labelUserPassport.Name = "labelUserPassport";
            this.labelUserPassport.Size = new System.Drawing.Size(144, 17);
            this.labelUserPassport.TabIndex = 3;
            this.labelUserPassport.Text = "Паспортные данные";
            // 
            // textBoxUserNameInput
            // 
            this.textBoxUserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserNameInput.Location = new System.Drawing.Point(243, 71);
            this.textBoxUserNameInput.Name = "textBoxUserNameInput";
            this.textBoxUserNameInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserNameInput.TabIndex = 2;
            this.textBoxUserNameInput.TextChanged += new System.EventHandler(this.TextBoxUserNameInput_TextChanged);
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameUser.Location = new System.Drawing.Point(24, 71);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(168, 17);
            this.labelNameUser.TabIndex = 1;
            this.labelNameUser.Text = "Фамилия Имя Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные нового пользователя";
            // 
            // textBoxUserLoginInput
            // 
            this.textBoxUserLoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserLoginInput.Location = new System.Drawing.Point(243, 164);
            this.textBoxUserLoginInput.Name = "textBoxUserLoginInput";
            this.textBoxUserLoginInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserLoginInput.TabIndex = 6;
            this.textBoxUserLoginInput.TextChanged += new System.EventHandler(this.TextBoxUserLogin_TextChanged);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserLogin.Location = new System.Drawing.Point(24, 164);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(47, 17);
            this.labelUserLogin.TabIndex = 5;
            this.labelUserLogin.Text = "Логин";
            // 
            // textBoxUserPasswordInput
            // 
            this.textBoxUserPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserPasswordInput.Location = new System.Drawing.Point(243, 235);
            this.textBoxUserPasswordInput.Name = "textBoxUserPasswordInput";
            this.textBoxUserPasswordInput.PasswordChar = '*';
            this.textBoxUserPasswordInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserPasswordInput.TabIndex = 8;
            this.textBoxUserPasswordInput.UseSystemPasswordChar = true;
            this.textBoxUserPasswordInput.TextChanged += new System.EventHandler(this.TextBoxUserPassword_TextChanged);
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassword.Location = new System.Drawing.Point(24, 235);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(194, 17);
            this.labelUserPassword.TabIndex = 7;
            this.labelUserPassword.Text = "Пароль для входа в систему";
            // 
            // textBoxPasswordRepeatInput
            // 
            this.textBoxPasswordRepeatInput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPasswordRepeatInput.Enabled = false;
            this.textBoxPasswordRepeatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPasswordRepeatInput.Location = new System.Drawing.Point(243, 290);
            this.textBoxPasswordRepeatInput.Name = "textBoxPasswordRepeatInput";
            this.textBoxPasswordRepeatInput.PasswordChar = '*';
            this.textBoxPasswordRepeatInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxPasswordRepeatInput.TabIndex = 10;
            this.textBoxPasswordRepeatInput.UseSystemPasswordChar = true;
            this.textBoxPasswordRepeatInput.TextChanged += new System.EventHandler(this.TextBoxPasswordRepeat_TextChanged);
            // 
            // labelЗPasswordRepeat
            // 
            this.labelЗPasswordRepeat.AutoSize = true;
            this.labelЗPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelЗPasswordRepeat.Location = new System.Drawing.Point(24, 290);
            this.labelЗPasswordRepeat.Name = "labelЗPasswordRepeat";
            this.labelЗPasswordRepeat.Size = new System.Drawing.Size(130, 17);
            this.labelЗPasswordRepeat.TabIndex = 9;
            this.labelЗPasswordRepeat.Text = "Повторите пароль";
            // 
            // labelManagerAccess
            // 
            this.labelManagerAccess.AutoSize = true;
            this.labelManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelManagerAccess.Location = new System.Drawing.Point(24, 208);
            this.labelManagerAccess.Name = "labelManagerAccess";
            this.labelManagerAccess.Size = new System.Drawing.Size(184, 17);
            this.labelManagerAccess.TabIndex = 11;
            this.labelManagerAccess.Text = "Права доступа менеджера";
            // 
            // checkBoxManagerAccess
            // 
            this.checkBoxManagerAccess.AutoSize = true;
            this.checkBoxManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxManagerAccess.Location = new System.Drawing.Point(243, 208);
            this.checkBoxManagerAccess.Name = "checkBoxManagerAccess";
            this.checkBoxManagerAccess.Size = new System.Drawing.Size(169, 21);
            this.checkBoxManagerAccess.TabIndex = 12;
            this.checkBoxManagerAccess.Text = "Предоставить доступ";
            this.checkBoxManagerAccess.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveUser.Location = new System.Drawing.Point(460, 337);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(152, 42);
            this.buttonSaveUser.TabIndex = 13;
            this.buttonSaveUser.Text = "Сохранить данные пользователя";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            this.buttonSaveUser.Click += new System.EventHandler(this.ButtonSaveUser_Click);
            // 
            // LabelPasswordsIsNotEuals
            // 
            this.LabelPasswordsIsNotEuals.AutoSize = true;
            this.LabelPasswordsIsNotEuals.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswordsIsNotEuals.Location = new System.Drawing.Point(240, 321);
            this.LabelPasswordsIsNotEuals.Name = "LabelPasswordsIsNotEuals";
            this.LabelPasswordsIsNotEuals.Size = new System.Drawing.Size(176, 13);
            this.LabelPasswordsIsNotEuals.TabIndex = 14;
            this.LabelPasswordsIsNotEuals.Text = "Введенные пароли не совпадают";
            this.LabelPasswordsIsNotEuals.Visible = false;
            // 
            // labelPasswordCheck
            // 
            this.labelPasswordCheck.AutoSize = true;
            this.labelPasswordCheck.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordCheck.Location = new System.Drawing.Point(24, 263);
            this.labelPasswordCheck.Name = "labelPasswordCheck";
            this.labelPasswordCheck.Size = new System.Drawing.Size(631, 13);
            this.labelPasswordCheck.TabIndex = 15;
            this.labelPasswordCheck.Text = "Введите пароль от 8 до 16 символов, содержащий не меннее 1 цифры, одной заглавной" +
    " и одной строчной латинских букв";
            this.labelPasswordCheck.Visible = false;
            // 
            // pictureBoxCheckMarkName
            // 
            this.pictureBoxCheckMarkName.Location = new System.Drawing.Point(619, 69);
            this.pictureBoxCheckMarkName.Name = "pictureBoxCheckMarkName";
            this.pictureBoxCheckMarkName.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkName.TabIndex = 16;
            this.pictureBoxCheckMarkName.TabStop = false;
            this.pictureBoxCheckMarkName.Visible = false;
            // 
            // pictureBoxCheckMarkPassport
            // 
            this.pictureBoxCheckMarkPassport.Location = new System.Drawing.Point(619, 119);
            this.pictureBoxCheckMarkPassport.Name = "pictureBoxCheckMarkPassport";
            this.pictureBoxCheckMarkPassport.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkPassport.TabIndex = 17;
            this.pictureBoxCheckMarkPassport.TabStop = false;
            this.pictureBoxCheckMarkPassport.Visible = false;
            // 
            // pictureBoxCheckMarkLogin
            // 
            this.pictureBoxCheckMarkLogin.Location = new System.Drawing.Point(619, 164);
            this.pictureBoxCheckMarkLogin.Name = "pictureBoxCheckMarkLogin";
            this.pictureBoxCheckMarkLogin.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkLogin.TabIndex = 18;
            this.pictureBoxCheckMarkLogin.TabStop = false;
            this.pictureBoxCheckMarkLogin.Visible = false;
            // 
            // pictureBoxCheckMarkPassword
            // 
            this.pictureBoxCheckMarkPassword.Location = new System.Drawing.Point(619, 235);
            this.pictureBoxCheckMarkPassword.Name = "pictureBoxCheckMarkPassword";
            this.pictureBoxCheckMarkPassword.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkPassword.TabIndex = 19;
            this.pictureBoxCheckMarkPassword.TabStop = false;
            this.pictureBoxCheckMarkPassword.Visible = false;
            // 
            // pictureBoxRepeatMarkPassword
            // 
            this.pictureBoxRepeatMarkPassword.Location = new System.Drawing.Point(619, 290);
            this.pictureBoxRepeatMarkPassword.Name = "pictureBoxRepeatMarkPassword";
            this.pictureBoxRepeatMarkPassword.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxRepeatMarkPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRepeatMarkPassword.TabIndex = 20;
            this.pictureBoxRepeatMarkPassword.TabStop = false;
            this.pictureBoxRepeatMarkPassword.Visible = false;
            // 
            // labelNameCheck
            // 
            this.labelNameCheck.AutoSize = true;
            this.labelNameCheck.ForeColor = System.Drawing.Color.Red;
            this.labelNameCheck.Location = new System.Drawing.Point(24, 98);
            this.labelNameCheck.Name = "labelNameCheck";
            this.labelNameCheck.Size = new System.Drawing.Size(299, 13);
            this.labelNameCheck.TabIndex = 21;
            this.labelNameCheck.Text = "Введите ФИО кирилицей с заглавных букв через пробел";
            this.labelNameCheck.Visible = false;
            // 
            // labelPassportCheck
            // 
            this.labelPassportCheck.AutoSize = true;
            this.labelPassportCheck.ForeColor = System.Drawing.Color.Red;
            this.labelPassportCheck.Location = new System.Drawing.Point(24, 145);
            this.labelPassportCheck.Name = "labelPassportCheck";
            this.labelPassportCheck.Size = new System.Drawing.Size(517, 13);
            this.labelPassportCheck.TabIndex = 22;
            this.labelPassportCheck.Text = "Введите данные в формате: 0000 000000 01.01.2000 г название подразделения выдавше" +
    "го паспорт";
            this.labelPassportCheck.Visible = false;
            // 
            // labelLoginCheck
            // 
            this.labelLoginCheck.AutoSize = true;
            this.labelLoginCheck.ForeColor = System.Drawing.Color.Red;
            this.labelLoginCheck.Location = new System.Drawing.Point(24, 190);
            this.labelLoginCheck.Name = "labelLoginCheck";
            this.labelLoginCheck.Size = new System.Drawing.Size(315, 13);
            this.labelLoginCheck.TabIndex = 23;
            this.labelLoginCheck.Text = "Введите в качестве логина адрес Вашей электронной почты";
            this.labelLoginCheck.Visible = false;
            // 
            // CreateUser
            // 
            this.AcceptButton = this.buttonSaveUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 384);
            this.Controls.Add(this.labelLoginCheck);
            this.Controls.Add(this.labelPassportCheck);
            this.Controls.Add(this.labelNameCheck);
            this.Controls.Add(this.pictureBoxRepeatMarkPassword);
            this.Controls.Add(this.pictureBoxCheckMarkPassword);
            this.Controls.Add(this.pictureBoxCheckMarkLogin);
            this.Controls.Add(this.pictureBoxCheckMarkPassport);
            this.Controls.Add(this.pictureBoxCheckMarkName);
            this.Controls.Add(this.labelPasswordCheck);
            this.Controls.Add(this.LabelPasswordsIsNotEuals);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.checkBoxManagerAccess);
            this.Controls.Add(this.labelManagerAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasswordRepeatInput);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.labelЗPasswordRepeat);
            this.Controls.Add(this.textBoxUserNameInput);
            this.Controls.Add(this.textBoxUserPasswordInput);
            this.Controls.Add(this.labelUserPassport);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textBoxUserPassportInput);
            this.Controls.Add(this.textBoxUserLoginInput);
            this.Controls.Add(this.labelUserLogin);
            this.Name = "CreateUser";
            this.Text = "Создание нового пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatMarkPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUserPassportInput;
        private System.Windows.Forms.Label labelUserPassport;
        private System.Windows.Forms.TextBox textBoxUserNameInput;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserLoginInput;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox textBoxPasswordRepeatInput;
        private System.Windows.Forms.Label labelЗPasswordRepeat;
        private System.Windows.Forms.TextBox textBoxUserPasswordInput;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelManagerAccess;
        private System.Windows.Forms.CheckBox checkBoxManagerAccess;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Label LabelPasswordsIsNotEuals;
        private System.Windows.Forms.Label labelPasswordCheck;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkName;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkPassport;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkLogin;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkPassword;
        private System.Windows.Forms.PictureBox pictureBoxRepeatMarkPassword;
        private System.Windows.Forms.Label labelNameCheck;
        private System.Windows.Forms.Label labelPassportCheck;
        private System.Windows.Forms.Label labelLoginCheck;
    }
}

