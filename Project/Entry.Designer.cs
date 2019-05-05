namespace Project
{
    partial class Entry
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelForInput = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonEntry = new System.Windows.Forms.Button();
            this.buttonPasswordForget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWelcome.Location = new System.Drawing.Point(138, 43);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(213, 26);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Добро пожаловать!";
            // 
            // labelForInput
            // 
            this.labelForInput.AutoSize = true;
            this.labelForInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelForInput.Location = new System.Drawing.Point(19, 81);
            this.labelForInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForInput.Name = "labelForInput";
            this.labelForInput.Size = new System.Drawing.Size(215, 18);
            this.labelForInput.TabIndex = 1;
            this.labelForInput.Text = "Для входа в систему введите";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelLogin.Location = new System.Drawing.Point(19, 119);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 18);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(77, 116);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(364, 23);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.TextBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(77, 156);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(364, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelPassword.Location = new System.Drawing.Point(19, 159);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 18);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // buttonEntry
            // 
            this.buttonEntry.Enabled = false;
            this.buttonEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEntry.Location = new System.Drawing.Point(22, 200);
            this.buttonEntry.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEntry.Name = "buttonEntry";
            this.buttonEntry.Size = new System.Drawing.Size(100, 28);
            this.buttonEntry.TabIndex = 6;
            this.buttonEntry.Text = "Войти";
            this.buttonEntry.UseVisualStyleBackColor = true;
            this.buttonEntry.Click += new System.EventHandler(this.ButtonEntry_Click);
            // 
            // buttonPasswordForget
            // 
            this.buttonPasswordForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPasswordForget.Location = new System.Drawing.Point(153, 200);
            this.buttonPasswordForget.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPasswordForget.Name = "buttonPasswordForget";
            this.buttonPasswordForget.Size = new System.Drawing.Size(151, 28);
            this.buttonPasswordForget.TabIndex = 7;
            this.buttonPasswordForget.Text = "Забыл пароль";
            this.buttonPasswordForget.UseVisualStyleBackColor = true;
            this.buttonPasswordForget.Click += new System.EventHandler(this.ButtonPasswordForget_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(72, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Система учета ремонтных работ";
            // 
            // Entry
            // 
            this.AcceptButton = this.buttonEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPasswordForget);
            this.Controls.Add(this.buttonEntry);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelForInput);
            this.Controls.Add(this.labelWelcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelForInput;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonEntry;
        private System.Windows.Forms.Button buttonPasswordForget;
        private System.Windows.Forms.Label label1;
    }
}