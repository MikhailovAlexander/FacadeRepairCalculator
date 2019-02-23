namespace Project
{
    partial class ChangePasswordForm
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
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.pictureBoxRepeatMarkPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckMarkPassword = new System.Windows.Forms.PictureBox();
            this.labelPasswordCheck = new System.Windows.Forms.Label();
            this.labelPasswordsIsNotEuals = new System.Windows.Forms.Label();
            this.textBoxPasswordRepeatInput = new System.Windows.Forms.TextBox();
            this.labelЗPasswordRepeat = new System.Windows.Forms.Label();
            this.textBoxUserPasswordInput = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatMarkPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonChangePassword.Location = new System.Drawing.Point(499, 171);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(152, 42);
            this.buttonChangePassword.TabIndex = 34;
            this.buttonChangePassword.Text = "Сменить пароль пользователя";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // pictureBoxRepeatMarkPassword
            // 
            this.pictureBoxRepeatMarkPassword.Location = new System.Drawing.Point(624, 115);
            this.pictureBoxRepeatMarkPassword.Name = "pictureBoxRepeatMarkPassword";
            this.pictureBoxRepeatMarkPassword.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxRepeatMarkPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRepeatMarkPassword.TabIndex = 33;
            this.pictureBoxRepeatMarkPassword.TabStop = false;
            this.pictureBoxRepeatMarkPassword.Visible = false;
            // 
            // pictureBoxCheckMarkPassword
            // 
            this.pictureBoxCheckMarkPassword.Location = new System.Drawing.Point(624, 60);
            this.pictureBoxCheckMarkPassword.Name = "pictureBoxCheckMarkPassword";
            this.pictureBoxCheckMarkPassword.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxCheckMarkPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckMarkPassword.TabIndex = 32;
            this.pictureBoxCheckMarkPassword.TabStop = false;
            this.pictureBoxCheckMarkPassword.Visible = false;
            // 
            // labelPasswordCheck
            // 
            this.labelPasswordCheck.AutoSize = true;
            this.labelPasswordCheck.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordCheck.Location = new System.Drawing.Point(9, 88);
            this.labelPasswordCheck.Name = "labelPasswordCheck";
            this.labelPasswordCheck.Size = new System.Drawing.Size(631, 13);
            this.labelPasswordCheck.TabIndex = 31;
            this.labelPasswordCheck.Text = "Введите пароль от 8 до 16 символов, содержащий не меннее 1 цифры, одной заглавной" +
    " и одной строчной латинских букв";
            this.labelPasswordCheck.Visible = false;
            // 
            // labelPasswordsIsNotEuals
            // 
            this.labelPasswordsIsNotEuals.AutoSize = true;
            this.labelPasswordsIsNotEuals.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordsIsNotEuals.Location = new System.Drawing.Point(245, 146);
            this.labelPasswordsIsNotEuals.Name = "labelPasswordsIsNotEuals";
            this.labelPasswordsIsNotEuals.Size = new System.Drawing.Size(176, 13);
            this.labelPasswordsIsNotEuals.TabIndex = 30;
            this.labelPasswordsIsNotEuals.Text = "Введенные пароли не совпадают";
            this.labelPasswordsIsNotEuals.Visible = false;
            // 
            // textBoxPasswordRepeatInput
            // 
            this.textBoxPasswordRepeatInput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPasswordRepeatInput.Enabled = false;
            this.textBoxPasswordRepeatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPasswordRepeatInput.Location = new System.Drawing.Point(248, 115);
            this.textBoxPasswordRepeatInput.Name = "textBoxPasswordRepeatInput";
            this.textBoxPasswordRepeatInput.PasswordChar = '*';
            this.textBoxPasswordRepeatInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxPasswordRepeatInput.TabIndex = 28;
            this.textBoxPasswordRepeatInput.UseSystemPasswordChar = true;
            this.textBoxPasswordRepeatInput.TextChanged += new System.EventHandler(this.TextBoxPasswordRepeatInput_TextChanged);
            // 
            // labelЗPasswordRepeat
            // 
            this.labelЗPasswordRepeat.AutoSize = true;
            this.labelЗPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelЗPasswordRepeat.Location = new System.Drawing.Point(9, 115);
            this.labelЗPasswordRepeat.Name = "labelЗPasswordRepeat";
            this.labelЗPasswordRepeat.Size = new System.Drawing.Size(175, 17);
            this.labelЗPasswordRepeat.TabIndex = 27;
            this.labelЗPasswordRepeat.Text = "Повторите новый пароль";
            // 
            // textBoxUserPasswordInput
            // 
            this.textBoxUserPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUserPasswordInput.Location = new System.Drawing.Point(248, 60);
            this.textBoxUserPasswordInput.Name = "textBoxUserPasswordInput";
            this.textBoxUserPasswordInput.PasswordChar = '*';
            this.textBoxUserPasswordInput.Size = new System.Drawing.Size(369, 23);
            this.textBoxUserPasswordInput.TabIndex = 26;
            this.textBoxUserPasswordInput.UseSystemPasswordChar = true;
            this.textBoxUserPasswordInput.TextChanged += new System.EventHandler(this.TextBoxUserPasswordInput_TextChanged);
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassword.Location = new System.Drawing.Point(9, 60);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(239, 17);
            this.labelUserPassword.TabIndex = 25;
            this.labelUserPassword.Text = "Новый пароль для входа в систему";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameUser.Location = new System.Drawing.Point(9, 26);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(168, 17);
            this.labelNameUser.TabIndex = 35;
            this.labelNameUser.Text = "Фамилия Имя Отчество";
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.buttonChangePassword;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 225);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.pictureBoxRepeatMarkPassword);
            this.Controls.Add(this.pictureBoxCheckMarkPassword);
            this.Controls.Add(this.labelPasswordCheck);
            this.Controls.Add(this.labelPasswordsIsNotEuals);
            this.Controls.Add(this.textBoxPasswordRepeatInput);
            this.Controls.Add(this.labelЗPasswordRepeat);
            this.Controls.Add(this.textBoxUserPasswordInput);
            this.Controls.Add(this.labelUserPassword);
            this.Name = "ChangePasswordForm";
            this.Text = "Смена пароля пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatMarkPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMarkPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.PictureBox pictureBoxRepeatMarkPassword;
        private System.Windows.Forms.PictureBox pictureBoxCheckMarkPassword;
        private System.Windows.Forms.Label labelPasswordCheck;
        private System.Windows.Forms.Label labelPasswordsIsNotEuals;
        private System.Windows.Forms.TextBox textBoxPasswordRepeatInput;
        private System.Windows.Forms.Label labelЗPasswordRepeat;
        private System.Windows.Forms.TextBox textBoxUserPasswordInput;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelNameUser;
    }
}