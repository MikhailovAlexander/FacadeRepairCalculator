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
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWelcome.Location = new System.Drawing.Point(12, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(447, 26);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Добро пожаловать в Систему учета работ";
            // 
            // labelForInput
            // 
            this.labelForInput.AutoSize = true;
            this.labelForInput.Location = new System.Drawing.Point(14, 80);
            this.labelForInput.Name = "labelForInput";
            this.labelForInput.Size = new System.Drawing.Size(158, 13);
            this.labelForInput.TabIndex = 1;
            this.labelForInput.Text = "Для входа в систему введите";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(14, 111);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(58, 104);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(274, 20);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.TextBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(58, 140);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(274, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(14, 147);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // buttonEntry
            // 
            this.buttonEntry.Enabled = false;
            this.buttonEntry.Location = new System.Drawing.Point(17, 180);
            this.buttonEntry.Name = "buttonEntry";
            this.buttonEntry.Size = new System.Drawing.Size(75, 23);
            this.buttonEntry.TabIndex = 6;
            this.buttonEntry.Text = "Войти";
            this.buttonEntry.UseVisualStyleBackColor = true;
            this.buttonEntry.Click += new System.EventHandler(this.ButtonEntry_Click);
            // 
            // buttonPasswordForget
            // 
            this.buttonPasswordForget.Location = new System.Drawing.Point(116, 180);
            this.buttonPasswordForget.Name = "buttonPasswordForget";
            this.buttonPasswordForget.Size = new System.Drawing.Size(113, 23);
            this.buttonPasswordForget.TabIndex = 7;
            this.buttonPasswordForget.Text = "Забыл пароль";
            this.buttonPasswordForget.UseVisualStyleBackColor = true;
            this.buttonPasswordForget.Click += new System.EventHandler(this.ButtonPasswordForget_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 233);
            this.Controls.Add(this.buttonPasswordForget);
            this.Controls.Add(this.buttonEntry);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelForInput);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Entry";
            this.Text = "Entry";
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
    }
}