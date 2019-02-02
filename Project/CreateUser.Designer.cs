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
            this.textBoxUserPassport = new System.Windows.Forms.TextBox();
            this.labelUserPassport = new System.Windows.Forms.Label();
            this.textBoxUserNameInput = new System.Windows.Forms.TextBox();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.labelЗPasswordRepeat = new System.Windows.Forms.Label();
            this.labelManagerAccess = new System.Windows.Forms.Label();
            this.checkBoxManagerAccess = new System.Windows.Forms.CheckBox();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.LabelPasswordsIsNotEuals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserPassport
            // 
            this.textBoxUserPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserPassport.Location = new System.Drawing.Point(243, 104);
            this.textBoxUserPassport.Name = "textBoxUserPassport";
            this.textBoxUserPassport.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserPassport.TabIndex = 4;
            // 
            // labelUserPassport
            // 
            this.labelUserPassport.AutoSize = true;
            this.labelUserPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassport.Location = new System.Drawing.Point(24, 104);
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
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserLogin.Location = new System.Drawing.Point(243, 137);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserLogin.TabIndex = 6;
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserLogin.Location = new System.Drawing.Point(24, 137);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(47, 17);
            this.labelUserLogin.TabIndex = 5;
            this.labelUserLogin.Text = "Логин";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserPassword.Location = new System.Drawing.Point(243, 195);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '*';
            this.textBoxUserPassword.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserPassword.TabIndex = 8;
            this.textBoxUserPassword.UseSystemPasswordChar = true;
            this.textBoxUserPassword.TextChanged += new System.EventHandler(this.TextBoxUserPassword_TextChanged);
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassword.Location = new System.Drawing.Point(24, 195);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(194, 17);
            this.labelUserPassword.TabIndex = 7;
            this.labelUserPassword.Text = "Пароль для входа в систему";
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPasswordRepeat.Enabled = false;
            this.textBoxPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(243, 228);
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.PasswordChar = '*';
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(369, 23);
            this.textBoxPasswordRepeat.TabIndex = 10;
            this.textBoxPasswordRepeat.UseSystemPasswordChar = true;
            this.textBoxPasswordRepeat.TextChanged += new System.EventHandler(this.textBoxPasswordRepeat_TextChanged);
            // 
            // labelЗPasswordRepeat
            // 
            this.labelЗPasswordRepeat.AutoSize = true;
            this.labelЗPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelЗPasswordRepeat.Location = new System.Drawing.Point(24, 228);
            this.labelЗPasswordRepeat.Name = "labelЗPasswordRepeat";
            this.labelЗPasswordRepeat.Size = new System.Drawing.Size(130, 17);
            this.labelЗPasswordRepeat.TabIndex = 9;
            this.labelЗPasswordRepeat.Text = "Повторите пароль";
            // 
            // labelManagerAccess
            // 
            this.labelManagerAccess.AutoSize = true;
            this.labelManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelManagerAccess.Location = new System.Drawing.Point(24, 168);
            this.labelManagerAccess.Name = "labelManagerAccess";
            this.labelManagerAccess.Size = new System.Drawing.Size(184, 17);
            this.labelManagerAccess.TabIndex = 11;
            this.labelManagerAccess.Text = "Права доступа менеджера";
            // 
            // checkBoxManagerAccess
            // 
            this.checkBoxManagerAccess.AutoSize = true;
            this.checkBoxManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxManagerAccess.Location = new System.Drawing.Point(243, 168);
            this.checkBoxManagerAccess.Name = "checkBoxManagerAccess";
            this.checkBoxManagerAccess.Size = new System.Drawing.Size(169, 21);
            this.checkBoxManagerAccess.TabIndex = 12;
            this.checkBoxManagerAccess.Text = "Предоставить доступ";
            this.checkBoxManagerAccess.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Enabled = false;
            this.buttonSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveUser.Location = new System.Drawing.Point(460, 275);
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
            this.LabelPasswordsIsNotEuals.Location = new System.Drawing.Point(240, 266);
            this.LabelPasswordsIsNotEuals.Name = "LabelPasswordsIsNotEuals";
            this.LabelPasswordsIsNotEuals.Size = new System.Drawing.Size(176, 13);
            this.LabelPasswordsIsNotEuals.TabIndex = 14;
            this.LabelPasswordsIsNotEuals.Text = "Введенные пароли не совпадают";
            this.LabelPasswordsIsNotEuals.Visible = false;
            // 
            // CreateUser
            // 
            this.AcceptButton = this.buttonSaveUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 354);
            this.Controls.Add(this.LabelPasswordsIsNotEuals);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.checkBoxManagerAccess);
            this.Controls.Add(this.labelManagerAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasswordRepeat);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.labelЗPasswordRepeat);
            this.Controls.Add(this.textBoxUserNameInput);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.labelUserPassport);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textBoxUserPassport);
            this.Controls.Add(this.textBoxUserLogin);
            this.Controls.Add(this.labelUserLogin);
            this.Name = "CreateUser";
            this.Text = "Создание нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUserPassport;
        private System.Windows.Forms.Label labelUserPassport;
        private System.Windows.Forms.TextBox textBoxUserNameInput;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox textBoxPasswordRepeat;
        private System.Windows.Forms.Label labelЗPasswordRepeat;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelManagerAccess;
        private System.Windows.Forms.CheckBox checkBoxManagerAccess;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Label LabelPasswordsIsNotEuals;
    }
}

