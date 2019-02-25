namespace Project
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlannedProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompletedProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelledProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ProjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1506, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Операции";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangePasswordToolStripMenuItem,
            this.allUsersToolStripMenuItem,
            this.addNewUserToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 20);
            this.toolStripMenuItem1.Text = "Пользователи ";
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.ChangePasswordToolStripMenuItem.Text = "Сменить пароль учетной записи";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // allUsersToolStripMenuItem
            // 
            this.allUsersToolStripMenuItem.Enabled = false;
            this.allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            this.allUsersToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.allUsersToolStripMenuItem.Text = "Все пользователи";
            this.allUsersToolStripMenuItem.Click += new System.EventHandler(this.AllUsersToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Enabled = false;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.addNewUserToolStripMenuItem.Text = "Добавить нового пользователя";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem_Click);
            // 
            // ProjectToolStripMenuItem
            // 
            this.ProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProjectToolStripMenuItem,
            this.ActualProjectsToolStripMenuItem,
            this.PlannedProjectsToolStripMenuItem,
            this.CompletedProjectsToolStripMenuItem,
            this.CancelledProjectsToolStripMenuItem,
            this.AllProjectsToolStripMenuItem});
            this.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem";
            this.ProjectToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ProjectToolStripMenuItem.Text = "Проекты";
            // 
            // CreateProjectToolStripMenuItem
            // 
            this.CreateProjectToolStripMenuItem.Name = "CreateProjectToolStripMenuItem";
            this.CreateProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateProjectToolStripMenuItem.Text = "Создать проект";
            this.CreateProjectToolStripMenuItem.Click += new System.EventHandler(this.CreateProjectToolStripMenuItem_Click);
            // 
            // ActualProjectsToolStripMenuItem
            // 
            this.ActualProjectsToolStripMenuItem.Name = "ActualProjectsToolStripMenuItem";
            this.ActualProjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ActualProjectsToolStripMenuItem.Text = "Актуальные";
            // 
            // PlannedProjectsToolStripMenuItem
            // 
            this.PlannedProjectsToolStripMenuItem.Name = "PlannedProjectsToolStripMenuItem";
            this.PlannedProjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PlannedProjectsToolStripMenuItem.Text = "Планируемые";
            // 
            // CompletedProjectsToolStripMenuItem
            // 
            this.CompletedProjectsToolStripMenuItem.Name = "CompletedProjectsToolStripMenuItem";
            this.CompletedProjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CompletedProjectsToolStripMenuItem.Text = "Завершенные";
            // 
            // CancelledProjectsToolStripMenuItem
            // 
            this.CancelledProjectsToolStripMenuItem.Name = "CancelledProjectsToolStripMenuItem";
            this.CancelledProjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CancelledProjectsToolStripMenuItem.Text = "Отмененные";
            // 
            // AllProjectsToolStripMenuItem
            // 
            this.AllProjectsToolStripMenuItem.Name = "AllProjectsToolStripMenuItem";
            this.AllProjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AllProjectsToolStripMenuItem.Text = "Все";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 727);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActualProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlannedProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompletedProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelledProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllProjectsToolStripMenuItem;
    }
}