namespace Project
{
    public partial class MainForm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProject = new System.Windows.Forms.TabPage();
            this.gblProjectPanel = new System.Windows.Forms.GroupBox();
            this.gbProjectData = new System.Windows.Forms.GroupBox();
            this.gbProjectDataComplete = new System.Windows.Forms.GroupBox();
            this.tbProjectDateOfComplete = new System.Windows.Forms.TextBox();
            this.lblProjectDateOfComplete = new System.Windows.Forms.Label();
            this.dtpProjectDateOfComplete = new System.Windows.Forms.DateTimePicker();
            this.lblCheckProjectDateOfComplete = new System.Windows.Forms.Label();
            this.pbChekMarkProjectDateOfComplete = new System.Windows.Forms.PictureBox();
            this.gbProjectDataName = new System.Windows.Forms.GroupBox();
            this.lblCheckProjectClient = new System.Windows.Forms.Label();
            this.tbProjectClient = new System.Windows.Forms.TextBox();
            this.btnProjectSetClient = new System.Windows.Forms.Button();
            this.btnProjectClientSelectCancel = new System.Windows.Forms.Button();
            this.btnProjectClientSelect = new System.Windows.Forms.Button();
            this.dgvProjectClients = new System.Windows.Forms.DataGridView();
            this.dgvTbColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.pbCheckMarkProjectClient = new System.Windows.Forms.PictureBox();
            this.pbCheckMarkProjectAddress = new System.Windows.Forms.PictureBox();
            this.lblCheckProjectName = new System.Windows.Forms.Label();
            this.pbCheckMarkProjectName = new System.Windows.Forms.PictureBox();
            this.lblCheckProjectAddress = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectAddress = new System.Windows.Forms.Label();
            this.tbProjectAddress = new System.Windows.Forms.TextBox();
            this.gbProjectDataStart = new System.Windows.Forms.GroupBox();
            this.tbProjectPlannedDateOfComplete = new System.Windows.Forms.TextBox();
            this.tbProjectDateOfStart = new System.Windows.Forms.TextBox();
            this.dtpProjectPlannedDateOfComplete = new System.Windows.Forms.DateTimePicker();
            this.lblProjectDateOfStart = new System.Windows.Forms.Label();
            this.pbCheckMarkProjectPlannedDateOfComplete = new System.Windows.Forms.PictureBox();
            this.dtpProjectDateOfStart = new System.Windows.Forms.DateTimePicker();
            this.lblCheckProjectDateOfStart = new System.Windows.Forms.Label();
            this.pbCheckMarkProjectDateOfStart = new System.Windows.Forms.PictureBox();
            this.lblCheckProjectPlannedDateOfComplete = new System.Windows.Forms.Label();
            this.lblProjectPlanDateOfComplete = new System.Windows.Forms.Label();
            this.btnProjectSwitchCancel = new System.Windows.Forms.Button();
            this.btnProjectUpdate = new System.Windows.Forms.Button();
            this.btnProjectCreate = new System.Windows.Forms.Button();
            this.gbAllProjects = new System.Windows.Forms.GroupBox();
            this.lbllProjectAmountPayments = new System.Windows.Forms.Label();
            this.lblProjectTotalSquare = new System.Windows.Forms.Label();
            this.lbllProjectWorksAmount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProjectSwitchStart = new System.Windows.Forms.Button();
            this.buttonSwitchCreateProject = new System.Windows.Forms.Button();
            this.buttonSwitchUpdateProject = new System.Windows.Forms.Button();
            this.groupBoxProjectState = new System.Windows.Forms.GroupBox();
            this.buttonViewProjectsByState = new System.Windows.Forms.Button();
            this.radioButtonCancelledProjects = new System.Windows.Forms.RadioButton();
            this.radioButtonCompletedProjects = new System.Windows.Forms.RadioButton();
            this.radioButtonActualProjects = new System.Windows.Forms.RadioButton();
            this.radioButtonPlannedProjects = new System.Windows.Forms.RadioButton();
            this.radioButtonAllProjects = new System.Windows.Forms.RadioButton();
            this.buttonDeleteProject = new System.Windows.Forms.Button();
            this.dgvAllProjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlannedDateOfComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOpenProject = new System.Windows.Forms.Button();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.groupBoxUserPanel = new System.Windows.Forms.GroupBox();
            this.buttonUserSwitchCancel = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.gbUserData = new System.Windows.Forms.GroupBox();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.lblCheckUserLogin = new System.Windows.Forms.Label();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.lblCheckUserPassport = new System.Windows.Forms.Label();
            this.tbUserPassport = new System.Windows.Forms.TextBox();
            this.lblCheckUserName = new System.Windows.Forms.Label();
            this.labelUserPassport = new System.Windows.Forms.Label();
            this.pbCheckMarkUserLogin = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pbCheckMarkUserPassport = new System.Windows.Forms.PictureBox();
            this.labelManagerAccess = new System.Windows.Forms.Label();
            this.pbCheckMarkUserName = new System.Windows.Forms.PictureBox();
            this.checkBoxManagerAccess = new System.Windows.Forms.CheckBox();
            this.gbPasswordPanel = new System.Windows.Forms.GroupBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.labelЗPasswordRepeat = new System.Windows.Forms.Label();
            this.tbUserPasswordRepeat = new System.Windows.Forms.TextBox();
            this.lblUserCheckPasswordsIsNotEuals = new System.Windows.Forms.Label();
            this.pbCheckMarkUserRepeatPassword = new System.Windows.Forms.PictureBox();
            this.lblCheckUserPassword = new System.Windows.Forms.Label();
            this.pbCheckMarkUserPassword = new System.Windows.Forms.PictureBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.gbUsersInProject = new System.Windows.Forms.GroupBox();
            this.dgvUserInProject = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManagerAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.gbAllUsers = new System.Windows.Forms.GroupBox();
            this.checkBoxAllUsersVision = new System.Windows.Forms.CheckBox();
            this.buttonAddUserInProject = new System.Windows.Forms.Button();
            this.buttonSwitchChangePassword = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonSwitchUpdateUser = new System.Windows.Forms.Button();
            this.buttonSwitchCreateUser = new System.Windows.Forms.Button();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.UserIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userManagerAccessColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.gbAllClients = new System.Windows.Forms.GroupBox();
            this.buttonAddClientToProject = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonSwitchUpdateClient = new System.Windows.Forms.Button();
            this.buttonSwitchCreateClient = new System.Windows.Forms.Button();
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClentInn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxClent = new System.Windows.Forms.GroupBox();
            this.labelActualProjectClient = new System.Windows.Forms.Label();
            this.btnCancelClientSwitch = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.gbClientData = new System.Windows.Forms.GroupBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelInn = new System.Windows.Forms.Label();
            this.lblCheckClientInn = new System.Windows.Forms.Label();
            this.tbClientInn = new System.Windows.Forms.TextBox();
            this.lblCheckClientAddress = new System.Windows.Forms.Label();
            this.tbClientAddress = new System.Windows.Forms.TextBox();
            this.lblCheckClientName = new System.Windows.Forms.Label();
            this.labelClientAddress = new System.Windows.Forms.Label();
            this.pbCheckMarkClientInn = new System.Windows.Forms.PictureBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.pbCheckMarkClientAddress = new System.Windows.Forms.PictureBox();
            this.pbCheckMarkClientName = new System.Windows.Forms.PictureBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.tabPageWork = new System.Windows.Forms.TabPage();
            this.gbWorkPanel = new System.Windows.Forms.GroupBox();
            this.btnWorkSwitchCancel = new System.Windows.Forms.Button();
            this.gbTypeOfWorkData = new System.Windows.Forms.GroupBox();
            this.btnTypeOfWorkUpdate = new System.Windows.Forms.Button();
            this.btnTypeOfWorkCreate = new System.Windows.Forms.Button();
            this.cbTypeOfWorkDimension = new System.Windows.Forms.ComboBox();
            this.tbTypeOfWorkMeasureUnit = new System.Windows.Forms.TextBox();
            this.lblCheckTypeOfWorkMeasureUnit = new System.Windows.Forms.Label();
            this.labelMeasureUnitTypeOfWork = new System.Windows.Forms.Label();
            this.pbCheckMarkTypeOfWorkMeasureUnit = new System.Windows.Forms.PictureBox();
            this.labelNameTypeOfWork = new System.Windows.Forms.Label();
            this.lblCheckTypeOfWorkDimension = new System.Windows.Forms.Label();
            this.lblCheckTypeOfWorkName = new System.Windows.Forms.Label();
            this.lblDimensionTypeOfWork = new System.Windows.Forms.Label();
            this.tbTypeOfWorkName = new System.Windows.Forms.TextBox();
            this.pbCheckMarkTypeOfWorkDimension = new System.Windows.Forms.PictureBox();
            this.pbCheckMarkTypeOfWorkName = new System.Windows.Forms.PictureBox();
            this.gbWorkInProjectData = new System.Windows.Forms.GroupBox();
            this.btnWorkInProjectChangeMultiplicity = new System.Windows.Forms.Button();
            this.btnWorkInProjectUpdate = new System.Windows.Forms.Button();
            this.labelPriceWorkInProject = new System.Windows.Forms.Label();
            this.btnWorkInProjectCreate = new System.Windows.Forms.Button();
            this.tbWorkInProjectPrice = new System.Windows.Forms.TextBox();
            this.labelMultiplicityWorkInProject = new System.Windows.Forms.Label();
            this.tbWorkInProjectMultiplicity = new System.Windows.Forms.TextBox();
            this.lblWorkInProjectCheckMultiplicity = new System.Windows.Forms.Label();
            this.pbCheckMarkWorkInProjectMultiplicity = new System.Windows.Forms.PictureBox();
            this.lblWorkInProjectCheckPrice = new System.Windows.Forms.Label();
            this.pbCheckMarkWorkInProjectPrice = new System.Windows.Forms.PictureBox();
            this.gbWorksInActualProject = new System.Windows.Forms.GroupBox();
            this.lblWorksActualProjectNotSaved = new System.Windows.Forms.Label();
            this.dgvWorksInActualProject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWorkInProjectPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWorkInProjectMultiplicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWorkInProjectDelete = new System.Windows.Forms.Button();
            this.btnWorkInProjectSwitchUpdate = new System.Windows.Forms.Button();
            this.gbAllTypesOfWork = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnWorkInProjectSwitchCreate = new System.Windows.Forms.Button();
            this.btnTypeOfWorkDelete = new System.Windows.Forms.Button();
            this.btnTypeOfWorkSwitchUpdate = new System.Windows.Forms.Button();
            this.btnTypeOfWorkSwitchCreate = new System.Windows.Forms.Button();
            this.dgvAllTypesOfWork = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.gbPaymentPanel = new System.Windows.Forms.GroupBox();
            this.gbPaymentData = new System.Windows.Forms.GroupBox();
            this.tbPaymentDate = new System.Windows.Forms.TextBox();
            this.lblCheckPaymentDate = new System.Windows.Forms.Label();
            this.tbPaymentUser = new System.Windows.Forms.TextBox();
            this.pbCheckMarkPaymentDate = new System.Windows.Forms.PictureBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.btnPaymentSwitchCancel = new System.Windows.Forms.Button();
            this.btnPaymentUpdate = new System.Windows.Forms.Button();
            this.btnPaymentCreate = new System.Windows.Forms.Button();
            this.tbPaymentAmout = new System.Windows.Forms.TextBox();
            this.lblCheckPaymentAmount = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.pbCheckMarkPaymentAmount = new System.Windows.Forms.PictureBox();
            this.lblPaymentProject = new System.Windows.Forms.Label();
            this.lblPaymentUser = new System.Windows.Forms.Label();
            this.tbPaymentProject = new System.Windows.Forms.TextBox();
            this.gbPaymentsInActualProject = new System.Windows.Forms.GroupBox();
            this.dgvPaymentsByUserInProject = new System.Windows.Forms.DataGridView();
            this.dgvTbColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPaymentsBySelectedUser = new System.Windows.Forms.Label();
            this.lblPaymentsActualProjectNotSaved = new System.Windows.Forms.Label();
            this.dgvPaymentsInActualProjectByUsers = new System.Windows.Forms.DataGridView();
            this.dgvTbColumnUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbColumnPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAllPayments = new System.Windows.Forms.GroupBox();
            this.lblPaymentsByProjects = new System.Windows.Forms.Label();
            this.dgvPaymentsByProject = new System.Windows.Forms.DataGridView();
            this.ColumnIdPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPaymentRbDgv = new System.Windows.Forms.GroupBox();
            this.rbAllPayments = new System.Windows.Forms.RadioButton();
            this.rbPaymentsByProjects = new System.Windows.Forms.RadioButton();
            this.dgvSumPaymentsByProject = new System.Windows.Forms.DataGridView();
            this.ColumnIdProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbColumnAmountByProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPaymentDelete = new System.Windows.Forms.Button();
            this.btnPaymentSwitchUpdate = new System.Windows.Forms.Button();
            this.btnPaymentSwitchCreate = new System.Windows.Forms.Button();
            this.dgvAllPayments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbColumnProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbColumnDateOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTypeOfElement = new System.Windows.Forms.TabPage();
            this.gbTypeOfElementPanel = new System.Windows.Forms.GroupBox();
            this.btnTypeOfElementSwitchCancel = new System.Windows.Forms.Button();
            this.btnTypeOfElementCreate = new System.Windows.Forms.Button();
            this.gbTypeOfElementData = new System.Windows.Forms.GroupBox();
            this.btnTypeOfElementCancelPicture = new System.Windows.Forms.Button();
            this.btnTypeOfElementSetPicture = new System.Windows.Forms.Button();
            this.pbCheckMarkTypeOfElementPicture = new System.Windows.Forms.PictureBox();
            this.dgvTypeOfElementSetPicture = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTypeOfElementSwitchSetPicture = new System.Windows.Forms.Button();
            this.pbTypeOfElementPicture = new System.Windows.Forms.PictureBox();
            this.lblCheckTypeOfElementLength = new System.Windows.Forms.Label();
            this.tbTypeOfElementLength = new System.Windows.Forms.TextBox();
            this.lblTypeOfElementLength = new System.Windows.Forms.Label();
            this.pbCheckMarkTypeOfElementLength = new System.Windows.Forms.PictureBox();
            this.lblCheckTypeOfElementHeight = new System.Windows.Forms.Label();
            this.tbTypeOfElementHeight = new System.Windows.Forms.TextBox();
            this.lblTypeOfElementHeight = new System.Windows.Forms.Label();
            this.pbCheckMarkTypeOfElementHeight = new System.Windows.Forms.PictureBox();
            this.lblTypeOfElementName = new System.Windows.Forms.Label();
            this.lblCheckTypeOfElementSquare = new System.Windows.Forms.Label();
            this.tbTypeOfElementSquare = new System.Windows.Forms.TextBox();
            this.lblCheckTypeOfElementName = new System.Windows.Forms.Label();
            this.lblTypeOfElementSquare = new System.Windows.Forms.Label();
            this.tbTypeOfElementName = new System.Windows.Forms.TextBox();
            this.pbCheckMarkTypeOfElementSquare = new System.Windows.Forms.PictureBox();
            this.pbCheckMarkTypeOfElementName = new System.Windows.Forms.PictureBox();
            this.btnTypeOfElementUpdate = new System.Windows.Forms.Button();
            this.gbTypeOfElementInProject = new System.Windows.Forms.GroupBox();
            this.lblTypesOfElementActualProjectNotSaved = new System.Windows.Forms.Label();
            this.pbTypeOfElementSelectedDgvInProject = new System.Windows.Forms.PictureBox();
            this.dgvTypesOfElementInProject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeOfElementInProjectIdElementPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTypeOfElementDeleteFromProject = new System.Windows.Forms.Button();
            this.gbAllTypesOfElement = new System.Windows.Forms.GroupBox();
            this.pbTypeOfElementSelectedDgvAll = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnTypeOfElementAddToProject = new System.Windows.Forms.Button();
            this.btnTypeOfElementDelete = new System.Windows.Forms.Button();
            this.btnTypeOfElementSwitchUpdate = new System.Windows.Forms.Button();
            this.btnTypeOfElementSwitchCreate = new System.Windows.Forms.Button();
            this.dgvAllTypesOfElement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdElementPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageElementPicture = new System.Windows.Forms.TabPage();
            this.gbElementPictureData = new System.Windows.Forms.GroupBox();
            this.btnElementPictureSwitchCancel = new System.Windows.Forms.Button();
            this.btnElementPictureUpdate = new System.Windows.Forms.Button();
            this.gbElementPictureNamePicture = new System.Windows.Forms.GroupBox();
            this.btnElementPictureOpenFile = new System.Windows.Forms.Button();
            this.pbElementPictureLoadContent = new System.Windows.Forms.PictureBox();
            this.lblElementPictureName = new System.Windows.Forms.Label();
            this.lblCheckElementPictureName = new System.Windows.Forms.Label();
            this.tbElementPictureName = new System.Windows.Forms.TextBox();
            this.pbCheckMarkElementPictureLoadContent = new System.Windows.Forms.PictureBox();
            this.pbCheckMarkElementPictureName = new System.Windows.Forms.PictureBox();
            this.btnElementPictureCreate = new System.Windows.Forms.Button();
            this.gbAllElementPicture = new System.Windows.Forms.GroupBox();
            this.pbElementPictureSelectedDgv = new System.Windows.Forms.PictureBox();
            this.btnElementPictureDelete = new System.Windows.Forms.Button();
            this.btnElementPictureSwitchUpdate = new System.Windows.Forms.Button();
            this.btnElementPictureSwitchCreate = new System.Windows.Forms.Button();
            this.dgvAllElementPicture = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTbColumnPictureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnElementPicturePicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageSectionOfBuilding = new System.Windows.Forms.TabPage();
            this.gbSectionOfBuildingPanel = new System.Windows.Forms.GroupBox();
            this.SectionOfBuildingModel = new System.Windows.Forms.GroupBox();
            this.btnSectionOfBuildingCancelWork = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingSetWork = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingSwitchSetWork = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingSwitchModelCancel = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingModelUpdate = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingSwitchModelUpdate = new System.Windows.Forms.Button();
            this.dgvSectionOfBuildingModel = new System.Windows.Forms.DataGridView();
            this.btnSectionOfBuildingSwitchCancel = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingCreate = new System.Windows.Forms.Button();
            this.gbSectionOfBuildingData = new System.Windows.Forms.GroupBox();
            this.lblSectuinOfBuildingSquare = new System.Windows.Forms.Label();
            this.lblCheckSectionOfBuildingQuantityByWidth = new System.Windows.Forms.Label();
            this.tbSectionOfBuildingQuantityByWidth = new System.Windows.Forms.TextBox();
            this.lblSectionOfBuildingQuantityByWidth = new System.Windows.Forms.Label();
            this.pbCheckMarkSectionOfBuildingQuantityByWidth = new System.Windows.Forms.PictureBox();
            this.lblSectionOfBuildingName = new System.Windows.Forms.Label();
            this.lblCheckSectionOfBuildingQuantityByHeight = new System.Windows.Forms.Label();
            this.tbSectionOfBuildingQuantityByHeight = new System.Windows.Forms.TextBox();
            this.lblCheckSectionOfBuildingName = new System.Windows.Forms.Label();
            this.lblSectionOfBuildingQuantityByHeight = new System.Windows.Forms.Label();
            this.tbSectionOfBuildingName = new System.Windows.Forms.TextBox();
            this.pbCheckMarkSectionOfBuildingQuantityByHeight = new System.Windows.Forms.PictureBox();
            this.pbCheckMarkSectionOfBuildingName = new System.Windows.Forms.PictureBox();
            this.btnSectionOfBuildingUpdate = new System.Windows.Forms.Button();
            this.gbTypeOfElementInProjectBySectionOfBuilding = new System.Windows.Forms.GroupBox();
            this.lblSectionOfBuildingWorksAmount = new System.Windows.Forms.Label();
            this.dgvSectionOfBuildingWorkInProject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSectionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSectionCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvSectionOfBuildingTypesOfElementInProject = new System.Windows.Forms.ListView();
            this.lblSectionOfBuldingActualProjectNotSaved2 = new System.Windows.Forms.Label();
            this.gbAllSectionsOfBuilding = new System.Windows.Forms.GroupBox();
            this.lblSectionOfBuildingActualProjectWorksAmount = new System.Windows.Forms.Label();
            this.lblSectionOfBuildingActualProjectTotalSquare = new System.Windows.Forms.Label();
            this.lblSectionOfBuldingActualProjectNotSaved1 = new System.Windows.Forms.Label();
            this.btnSectionOfBuildingDelete = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingSwitchUpdate = new System.Windows.Forms.Button();
            this.btnSectionOfBuildingSwitchCreate = new System.Windows.Forms.Button();
            this.dgvSectionsOfBuildingByActualProject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSquareSectionOfBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelActualProjectName = new System.Windows.Forms.Label();
            this.labelActualUserName = new System.Windows.Forms.Label();
            this.ofdElementOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.Menu.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageProject.SuspendLayout();
            this.gblProjectPanel.SuspendLayout();
            this.gbProjectData.SuspendLayout();
            this.gbProjectDataComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChekMarkProjectDateOfComplete)).BeginInit();
            this.gbProjectDataName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectName)).BeginInit();
            this.gbProjectDataStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectPlannedDateOfComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectDateOfStart)).BeginInit();
            this.gbAllProjects.SuspendLayout();
            this.groupBoxProjectState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProjects)).BeginInit();
            this.tabPageUser.SuspendLayout();
            this.groupBoxUserPanel.SuspendLayout();
            this.gbUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserPassport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserName)).BeginInit();
            this.gbPasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserRepeatPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserPassword)).BeginInit();
            this.gbUsersInProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInProject)).BeginInit();
            this.gbAllUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.tabPageClient.SuspendLayout();
            this.gbAllClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.groupBoxClent.SuspendLayout();
            this.gbClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkClientInn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkClientAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkClientName)).BeginInit();
            this.tabPageWork.SuspendLayout();
            this.gbWorkPanel.SuspendLayout();
            this.gbTypeOfWorkData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfWorkMeasureUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfWorkDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfWorkName)).BeginInit();
            this.gbWorkInProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkWorkInProjectMultiplicity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkWorkInProjectPrice)).BeginInit();
            this.gbWorksInActualProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksInActualProject)).BeginInit();
            this.gbAllTypesOfWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTypesOfWork)).BeginInit();
            this.tabPagePayment.SuspendLayout();
            this.gbPaymentPanel.SuspendLayout();
            this.gbPaymentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkPaymentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkPaymentAmount)).BeginInit();
            this.gbPaymentsInActualProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsByUserInProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsInActualProjectByUsers)).BeginInit();
            this.gbAllPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsByProject)).BeginInit();
            this.gbPaymentRbDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumPaymentsByProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).BeginInit();
            this.tabPageTypeOfElement.SuspendLayout();
            this.gbTypeOfElementPanel.SuspendLayout();
            this.gbTypeOfElementData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeOfElementSetPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeOfElementPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementName)).BeginInit();
            this.gbTypeOfElementInProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeOfElementSelectedDgvInProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypesOfElementInProject)).BeginInit();
            this.gbAllTypesOfElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeOfElementSelectedDgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTypesOfElement)).BeginInit();
            this.tabPageElementPicture.SuspendLayout();
            this.gbElementPictureData.SuspendLayout();
            this.gbElementPictureNamePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbElementPictureLoadContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkElementPictureLoadContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkElementPictureName)).BeginInit();
            this.gbAllElementPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbElementPictureSelectedDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllElementPicture)).BeginInit();
            this.tabPageSectionOfBuilding.SuspendLayout();
            this.gbSectionOfBuildingPanel.SuspendLayout();
            this.SectionOfBuildingModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionOfBuildingModel)).BeginInit();
            this.gbSectionOfBuildingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkSectionOfBuildingQuantityByWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkSectionOfBuildingQuantityByHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkSectionOfBuildingName)).BeginInit();
            this.gbTypeOfElementInProjectBySectionOfBuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionOfBuildingWorkInProject)).BeginInit();
            this.gbAllSectionsOfBuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionsOfBuildingByActualProject)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ProjectToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1959, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Операции";
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
            this.CreateProjectToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.CreateProjectToolStripMenuItem.Text = "Создать проект";
            this.CreateProjectToolStripMenuItem.Click += new System.EventHandler(this.CreateProjectToolStripMenuItem_Click);
            // 
            // ActualProjectsToolStripMenuItem
            // 
            this.ActualProjectsToolStripMenuItem.Name = "ActualProjectsToolStripMenuItem";
            this.ActualProjectsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ActualProjectsToolStripMenuItem.Text = "Актуальные";
            // 
            // PlannedProjectsToolStripMenuItem
            // 
            this.PlannedProjectsToolStripMenuItem.Name = "PlannedProjectsToolStripMenuItem";
            this.PlannedProjectsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.PlannedProjectsToolStripMenuItem.Text = "Планируемые";
            // 
            // CompletedProjectsToolStripMenuItem
            // 
            this.CompletedProjectsToolStripMenuItem.Name = "CompletedProjectsToolStripMenuItem";
            this.CompletedProjectsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.CompletedProjectsToolStripMenuItem.Text = "Завершенные";
            // 
            // CancelledProjectsToolStripMenuItem
            // 
            this.CancelledProjectsToolStripMenuItem.Name = "CancelledProjectsToolStripMenuItem";
            this.CancelledProjectsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.CancelledProjectsToolStripMenuItem.Text = "Отмененные";
            // 
            // AllProjectsToolStripMenuItem
            // 
            this.AllProjectsToolStripMenuItem.Name = "AllProjectsToolStripMenuItem";
            this.AllProjectsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.AllProjectsToolStripMenuItem.Text = "Все";
            this.AllProjectsToolStripMenuItem.Click += new System.EventHandler(this.AllProjectsToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageProject);
            this.tabControlMain.Controls.Add(this.tabPageUser);
            this.tabControlMain.Controls.Add(this.tabPageClient);
            this.tabControlMain.Controls.Add(this.tabPageWork);
            this.tabControlMain.Controls.Add(this.tabPagePayment);
            this.tabControlMain.Controls.Add(this.tabPageTypeOfElement);
            this.tabControlMain.Controls.Add(this.tabPageElementPicture);
            this.tabControlMain.Controls.Add(this.tabPageSectionOfBuilding);
            this.tabControlMain.Location = new System.Drawing.Point(0, 48);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1959, 972);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageProject
            // 
            this.tabPageProject.Controls.Add(this.gblProjectPanel);
            this.tabPageProject.Controls.Add(this.gbAllProjects);
            this.tabPageProject.Location = new System.Drawing.Point(4, 22);
            this.tabPageProject.Name = "tabPageProject";
            this.tabPageProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProject.Size = new System.Drawing.Size(1951, 946);
            this.tabPageProject.TabIndex = 1;
            this.tabPageProject.Text = "Проекты";
            this.tabPageProject.UseVisualStyleBackColor = true;
            // 
            // gblProjectPanel
            // 
            this.gblProjectPanel.Controls.Add(this.gbProjectData);
            this.gblProjectPanel.Location = new System.Drawing.Point(1092, 6);
            this.gblProjectPanel.Name = "gblProjectPanel";
            this.gblProjectPanel.Size = new System.Drawing.Size(831, 899);
            this.gblProjectPanel.TabIndex = 1;
            this.gblProjectPanel.TabStop = false;
            this.gblProjectPanel.Text = "Текущий проект";
            // 
            // gbProjectData
            // 
            this.gbProjectData.Controls.Add(this.gbProjectDataComplete);
            this.gbProjectData.Controls.Add(this.gbProjectDataName);
            this.gbProjectData.Controls.Add(this.gbProjectDataStart);
            this.gbProjectData.Controls.Add(this.btnProjectSwitchCancel);
            this.gbProjectData.Controls.Add(this.btnProjectUpdate);
            this.gbProjectData.Controls.Add(this.btnProjectCreate);
            this.gbProjectData.Enabled = false;
            this.gbProjectData.Location = new System.Drawing.Point(7, 19);
            this.gbProjectData.Name = "gbProjectData";
            this.gbProjectData.Size = new System.Drawing.Size(818, 373);
            this.gbProjectData.TabIndex = 68;
            this.gbProjectData.TabStop = false;
            this.gbProjectData.Text = "Данные проекта";
            // 
            // gbProjectDataComplete
            // 
            this.gbProjectDataComplete.Controls.Add(this.tbProjectDateOfComplete);
            this.gbProjectDataComplete.Controls.Add(this.lblProjectDateOfComplete);
            this.gbProjectDataComplete.Controls.Add(this.dtpProjectDateOfComplete);
            this.gbProjectDataComplete.Controls.Add(this.lblCheckProjectDateOfComplete);
            this.gbProjectDataComplete.Controls.Add(this.pbChekMarkProjectDateOfComplete);
            this.gbProjectDataComplete.Enabled = false;
            this.gbProjectDataComplete.Location = new System.Drawing.Point(4, 300);
            this.gbProjectDataComplete.Name = "gbProjectDataComplete";
            this.gbProjectDataComplete.Size = new System.Drawing.Size(631, 62);
            this.gbProjectDataComplete.TabIndex = 77;
            this.gbProjectDataComplete.TabStop = false;
            // 
            // tbProjectDateOfComplete
            // 
            this.tbProjectDateOfComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProjectDateOfComplete.Location = new System.Drawing.Point(252, 16);
            this.tbProjectDateOfComplete.Name = "tbProjectDateOfComplete";
            this.tbProjectDateOfComplete.ReadOnly = true;
            this.tbProjectDateOfComplete.Size = new System.Drawing.Size(342, 23);
            this.tbProjectDateOfComplete.TabIndex = 75;
            // 
            // lblProjectDateOfComplete
            // 
            this.lblProjectDateOfComplete.AutoSize = true;
            this.lblProjectDateOfComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjectDateOfComplete.Location = new System.Drawing.Point(6, 16);
            this.lblProjectDateOfComplete.Name = "lblProjectDateOfComplete";
            this.lblProjectDateOfComplete.Size = new System.Drawing.Size(175, 17);
            this.lblProjectDateOfComplete.TabIndex = 53;
            this.lblProjectDateOfComplete.Text = "Дата окончания проекта";
            // 
            // dtpProjectDateOfComplete
            // 
            this.dtpProjectDateOfComplete.Location = new System.Drawing.Point(253, 12);
            this.dtpProjectDateOfComplete.Name = "dtpProjectDateOfComplete";
            this.dtpProjectDateOfComplete.Size = new System.Drawing.Size(140, 20);
            this.dtpProjectDateOfComplete.TabIndex = 68;
            this.dtpProjectDateOfComplete.Visible = false;
            // 
            // lblCheckProjectDateOfComplete
            // 
            this.lblCheckProjectDateOfComplete.AutoSize = true;
            this.lblCheckProjectDateOfComplete.ForeColor = System.Drawing.Color.Red;
            this.lblCheckProjectDateOfComplete.Location = new System.Drawing.Point(6, 43);
            this.lblCheckProjectDateOfComplete.Name = "lblCheckProjectDateOfComplete";
            this.lblCheckProjectDateOfComplete.Size = new System.Drawing.Size(275, 13);
            this.lblCheckProjectDateOfComplete.TabIndex = 61;
            this.lblCheckProjectDateOfComplete.Text = "Дата окончания не может быть раньше даты начала";
            this.lblCheckProjectDateOfComplete.Visible = false;
            // 
            // pbChekMarkProjectDateOfComplete
            // 
            this.pbChekMarkProjectDateOfComplete.Location = new System.Drawing.Point(601, 14);
            this.pbChekMarkProjectDateOfComplete.Name = "pbChekMarkProjectDateOfComplete";
            this.pbChekMarkProjectDateOfComplete.Size = new System.Drawing.Size(27, 25);
            this.pbChekMarkProjectDateOfComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChekMarkProjectDateOfComplete.TabIndex = 59;
            this.pbChekMarkProjectDateOfComplete.TabStop = false;
            this.pbChekMarkProjectDateOfComplete.Visible = false;
            // 
            // gbProjectDataName
            // 
            this.gbProjectDataName.Controls.Add(this.lblCheckProjectClient);
            this.gbProjectDataName.Controls.Add(this.tbProjectClient);
            this.gbProjectDataName.Controls.Add(this.btnProjectSetClient);
            this.gbProjectDataName.Controls.Add(this.btnProjectClientSelectCancel);
            this.gbProjectDataName.Controls.Add(this.btnProjectClientSelect);
            this.gbProjectDataName.Controls.Add(this.dgvProjectClients);
            this.gbProjectDataName.Controls.Add(this.lblProjectName);
            this.gbProjectDataName.Controls.Add(this.pbCheckMarkProjectClient);
            this.gbProjectDataName.Controls.Add(this.pbCheckMarkProjectAddress);
            this.gbProjectDataName.Controls.Add(this.lblCheckProjectName);
            this.gbProjectDataName.Controls.Add(this.pbCheckMarkProjectName);
            this.gbProjectDataName.Controls.Add(this.lblCheckProjectAddress);
            this.gbProjectDataName.Controls.Add(this.tbProjectName);
            this.gbProjectDataName.Controls.Add(this.lblProjectAddress);
            this.gbProjectDataName.Controls.Add(this.tbProjectAddress);
            this.gbProjectDataName.Location = new System.Drawing.Point(4, 11);
            this.gbProjectDataName.Name = "gbProjectDataName";
            this.gbProjectDataName.Size = new System.Drawing.Size(634, 181);
            this.gbProjectDataName.TabIndex = 69;
            this.gbProjectDataName.TabStop = false;
            // 
            // lblCheckProjectClient
            // 
            this.lblCheckProjectClient.AutoSize = true;
            this.lblCheckProjectClient.ForeColor = System.Drawing.Color.Red;
            this.lblCheckProjectClient.Location = new System.Drawing.Point(104, 146);
            this.lblCheckProjectClient.Name = "lblCheckProjectClient";
            this.lblCheckProjectClient.Size = new System.Drawing.Size(113, 13);
            this.lblCheckProjectClient.TabIndex = 74;
            this.lblCheckProjectClient.Text = "Выберите заказчика";
            this.lblCheckProjectClient.Visible = false;
            // 
            // tbProjectClient
            // 
            this.tbProjectClient.Enabled = false;
            this.tbProjectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProjectClient.Location = new System.Drawing.Point(142, 120);
            this.tbProjectClient.Name = "tbProjectClient";
            this.tbProjectClient.Size = new System.Drawing.Size(452, 23);
            this.tbProjectClient.TabIndex = 73;
            this.tbProjectClient.TextChanged += new System.EventHandler(this.TbProjectClient_TextChanged);
            // 
            // btnProjectSetClient
            // 
            this.btnProjectSetClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProjectSetClient.Location = new System.Drawing.Point(6, 119);
            this.btnProjectSetClient.Name = "btnProjectSetClient";
            this.btnProjectSetClient.Size = new System.Drawing.Size(92, 24);
            this.btnProjectSetClient.TabIndex = 72;
            this.btnProjectSetClient.Text = "Заказчик";
            this.btnProjectSetClient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProjectSetClient.UseVisualStyleBackColor = true;
            this.btnProjectSetClient.Click += new System.EventHandler(this.BtnProjectSetClient_Click);
            // 
            // btnProjectClientSelectCancel
            // 
            this.btnProjectClientSelectCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProjectClientSelectCancel.Location = new System.Drawing.Point(6, 147);
            this.btnProjectClientSelectCancel.Name = "btnProjectClientSelectCancel";
            this.btnProjectClientSelectCancel.Size = new System.Drawing.Size(92, 24);
            this.btnProjectClientSelectCancel.TabIndex = 71;
            this.btnProjectClientSelectCancel.Text = "Отменить";
            this.btnProjectClientSelectCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProjectClientSelectCancel.UseVisualStyleBackColor = true;
            this.btnProjectClientSelectCancel.Visible = false;
            this.btnProjectClientSelectCancel.Click += new System.EventHandler(this.BtnProjectClientSelectCancel_Click);
            // 
            // btnProjectClientSelect
            // 
            this.btnProjectClientSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProjectClientSelect.Location = new System.Drawing.Point(6, 118);
            this.btnProjectClientSelect.Name = "btnProjectClientSelect";
            this.btnProjectClientSelect.Size = new System.Drawing.Size(92, 24);
            this.btnProjectClientSelect.TabIndex = 70;
            this.btnProjectClientSelect.Text = "Выбрать";
            this.btnProjectClientSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProjectClientSelect.UseVisualStyleBackColor = true;
            this.btnProjectClientSelect.Visible = false;
            this.btnProjectClientSelect.Click += new System.EventHandler(this.BtnProjectClientSelect_Click);
            // 
            // dgvProjectClients
            // 
            this.dgvProjectClients.AllowUserToAddRows = false;
            this.dgvProjectClients.AllowUserToDeleteRows = false;
            this.dgvProjectClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTbColumnClient});
            this.dgvProjectClients.Location = new System.Drawing.Point(142, 119);
            this.dgvProjectClients.MultiSelect = false;
            this.dgvProjectClients.Name = "dgvProjectClients";
            this.dgvProjectClients.ReadOnly = true;
            this.dgvProjectClients.RowHeadersVisible = false;
            this.dgvProjectClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectClients.Size = new System.Drawing.Size(441, 48);
            this.dgvProjectClients.TabIndex = 70;
            this.dgvProjectClients.Visible = false;
            // 
            // dgvTbColumnClient
            // 
            this.dgvTbColumnClient.HeaderText = "Заказчик";
            this.dgvTbColumnClient.Name = "dgvTbColumnClient";
            this.dgvTbColumnClient.ReadOnly = true;
            this.dgvTbColumnClient.Width = 430;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjectName.Location = new System.Drawing.Point(6, 25);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(130, 17);
            this.lblProjectName.TabIndex = 53;
            this.lblProjectName.Text = "Название проекта";
            // 
            // pbCheckMarkProjectClient
            // 
            this.pbCheckMarkProjectClient.Location = new System.Drawing.Point(601, 120);
            this.pbCheckMarkProjectClient.Name = "pbCheckMarkProjectClient";
            this.pbCheckMarkProjectClient.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkProjectClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkProjectClient.TabIndex = 70;
            this.pbCheckMarkProjectClient.TabStop = false;
            this.pbCheckMarkProjectClient.Visible = false;
            // 
            // pbCheckMarkProjectAddress
            // 
            this.pbCheckMarkProjectAddress.Location = new System.Drawing.Point(601, 73);
            this.pbCheckMarkProjectAddress.Name = "pbCheckMarkProjectAddress";
            this.pbCheckMarkProjectAddress.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkProjectAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkProjectAddress.TabIndex = 60;
            this.pbCheckMarkProjectAddress.TabStop = false;
            this.pbCheckMarkProjectAddress.Visible = false;
            // 
            // lblCheckProjectName
            // 
            this.lblCheckProjectName.AutoSize = true;
            this.lblCheckProjectName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckProjectName.Location = new System.Drawing.Point(6, 52);
            this.lblCheckProjectName.Name = "lblCheckProjectName";
            this.lblCheckProjectName.Size = new System.Drawing.Size(549, 13);
            this.lblCheckProjectName.TabIndex = 61;
            this.lblCheckProjectName.Text = "Введите название проекта длиной от 3 до 100 символов, используя кирилицу цифры и " +
    "знаки препинания ";
            this.lblCheckProjectName.Visible = false;
            // 
            // pbCheckMarkProjectName
            // 
            this.pbCheckMarkProjectName.Location = new System.Drawing.Point(601, 23);
            this.pbCheckMarkProjectName.Name = "pbCheckMarkProjectName";
            this.pbCheckMarkProjectName.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkProjectName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkProjectName.TabIndex = 59;
            this.pbCheckMarkProjectName.TabStop = false;
            this.pbCheckMarkProjectName.Visible = false;
            // 
            // lblCheckProjectAddress
            // 
            this.lblCheckProjectAddress.AutoSize = true;
            this.lblCheckProjectAddress.ForeColor = System.Drawing.Color.Red;
            this.lblCheckProjectAddress.Location = new System.Drawing.Point(6, 99);
            this.lblCheckProjectAddress.Name = "lblCheckProjectAddress";
            this.lblCheckProjectAddress.Size = new System.Drawing.Size(531, 13);
            this.lblCheckProjectAddress.TabIndex = 62;
            this.lblCheckProjectAddress.Text = "Введите адрес проекта длиной от 3 до 100 символов, используя кирилицу цифры и зна" +
    "ки препинания ";
            this.lblCheckProjectAddress.Visible = false;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProjectName.Location = new System.Drawing.Point(142, 25);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(452, 23);
            this.tbProjectName.TabIndex = 54;
            this.tbProjectName.TextChanged += new System.EventHandler(this.TbProjectName_TextChanged);
            // 
            // lblProjectAddress
            // 
            this.lblProjectAddress.AutoSize = true;
            this.lblProjectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjectAddress.Location = new System.Drawing.Point(6, 73);
            this.lblProjectAddress.Name = "lblProjectAddress";
            this.lblProjectAddress.Size = new System.Drawing.Size(48, 17);
            this.lblProjectAddress.TabIndex = 55;
            this.lblProjectAddress.Text = "Адрес";
            // 
            // tbProjectAddress
            // 
            this.tbProjectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProjectAddress.Location = new System.Drawing.Point(142, 73);
            this.tbProjectAddress.Name = "tbProjectAddress";
            this.tbProjectAddress.Size = new System.Drawing.Size(452, 23);
            this.tbProjectAddress.TabIndex = 56;
            this.tbProjectAddress.TextChanged += new System.EventHandler(this.TbProjectAddress_TextChanged);
            // 
            // gbProjectDataStart
            // 
            this.gbProjectDataStart.Controls.Add(this.tbProjectPlannedDateOfComplete);
            this.gbProjectDataStart.Controls.Add(this.tbProjectDateOfStart);
            this.gbProjectDataStart.Controls.Add(this.dtpProjectPlannedDateOfComplete);
            this.gbProjectDataStart.Controls.Add(this.lblProjectDateOfStart);
            this.gbProjectDataStart.Controls.Add(this.pbCheckMarkProjectPlannedDateOfComplete);
            this.gbProjectDataStart.Controls.Add(this.dtpProjectDateOfStart);
            this.gbProjectDataStart.Controls.Add(this.lblCheckProjectDateOfStart);
            this.gbProjectDataStart.Controls.Add(this.pbCheckMarkProjectDateOfStart);
            this.gbProjectDataStart.Controls.Add(this.lblCheckProjectPlannedDateOfComplete);
            this.gbProjectDataStart.Controls.Add(this.lblProjectPlanDateOfComplete);
            this.gbProjectDataStart.Enabled = false;
            this.gbProjectDataStart.Location = new System.Drawing.Point(4, 190);
            this.gbProjectDataStart.Name = "gbProjectDataStart";
            this.gbProjectDataStart.Size = new System.Drawing.Size(631, 110);
            this.gbProjectDataStart.TabIndex = 69;
            this.gbProjectDataStart.TabStop = false;
            // 
            // tbProjectPlannedDateOfComplete
            // 
            this.tbProjectPlannedDateOfComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProjectPlannedDateOfComplete.Location = new System.Drawing.Point(252, 64);
            this.tbProjectPlannedDateOfComplete.Name = "tbProjectPlannedDateOfComplete";
            this.tbProjectPlannedDateOfComplete.ReadOnly = true;
            this.tbProjectPlannedDateOfComplete.Size = new System.Drawing.Size(342, 23);
            this.tbProjectPlannedDateOfComplete.TabIndex = 76;
            this.tbProjectPlannedDateOfComplete.Click += new System.EventHandler(this.TbProjectPlannedDateOfComplete_Click);
            // 
            // tbProjectDateOfStart
            // 
            this.tbProjectDateOfStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProjectDateOfStart.Location = new System.Drawing.Point(252, 16);
            this.tbProjectDateOfStart.Name = "tbProjectDateOfStart";
            this.tbProjectDateOfStart.ReadOnly = true;
            this.tbProjectDateOfStart.Size = new System.Drawing.Size(342, 23);
            this.tbProjectDateOfStart.TabIndex = 75;
            this.tbProjectDateOfStart.Click += new System.EventHandler(this.TbProjectDateOfStart_Click);
            // 
            // dtpProjectPlannedDateOfComplete
            // 
            this.dtpProjectPlannedDateOfComplete.Location = new System.Drawing.Point(253, 60);
            this.dtpProjectPlannedDateOfComplete.Name = "dtpProjectPlannedDateOfComplete";
            this.dtpProjectPlannedDateOfComplete.Size = new System.Drawing.Size(140, 20);
            this.dtpProjectPlannedDateOfComplete.TabIndex = 69;
            this.dtpProjectPlannedDateOfComplete.Visible = false;
            this.dtpProjectPlannedDateOfComplete.ValueChanged += new System.EventHandler(this.DtpProjectPlannedDateOfComplete_ValueChanged);
            // 
            // lblProjectDateOfStart
            // 
            this.lblProjectDateOfStart.AutoSize = true;
            this.lblProjectDateOfStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjectDateOfStart.Location = new System.Drawing.Point(6, 16);
            this.lblProjectDateOfStart.Name = "lblProjectDateOfStart";
            this.lblProjectDateOfStart.Size = new System.Drawing.Size(156, 17);
            this.lblProjectDateOfStart.TabIndex = 53;
            this.lblProjectDateOfStart.Text = "Дата  начала проекта";
            // 
            // pbCheckMarkProjectPlannedDateOfComplete
            // 
            this.pbCheckMarkProjectPlannedDateOfComplete.Location = new System.Drawing.Point(601, 64);
            this.pbCheckMarkProjectPlannedDateOfComplete.Name = "pbCheckMarkProjectPlannedDateOfComplete";
            this.pbCheckMarkProjectPlannedDateOfComplete.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkProjectPlannedDateOfComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkProjectPlannedDateOfComplete.TabIndex = 60;
            this.pbCheckMarkProjectPlannedDateOfComplete.TabStop = false;
            this.pbCheckMarkProjectPlannedDateOfComplete.Visible = false;
            // 
            // dtpProjectDateOfStart
            // 
            this.dtpProjectDateOfStart.Location = new System.Drawing.Point(253, 12);
            this.dtpProjectDateOfStart.Name = "dtpProjectDateOfStart";
            this.dtpProjectDateOfStart.Size = new System.Drawing.Size(140, 20);
            this.dtpProjectDateOfStart.TabIndex = 68;
            this.dtpProjectDateOfStart.Visible = false;
            this.dtpProjectDateOfStart.ValueChanged += new System.EventHandler(this.DtpProjectDateOfStart_ValueChanged);
            // 
            // lblCheckProjectDateOfStart
            // 
            this.lblCheckProjectDateOfStart.AutoSize = true;
            this.lblCheckProjectDateOfStart.ForeColor = System.Drawing.Color.Red;
            this.lblCheckProjectDateOfStart.Location = new System.Drawing.Point(6, 43);
            this.lblCheckProjectDateOfStart.Name = "lblCheckProjectDateOfStart";
            this.lblCheckProjectDateOfStart.Size = new System.Drawing.Size(269, 13);
            this.lblCheckProjectDateOfStart.TabIndex = 61;
            this.lblCheckProjectDateOfStart.Text = "Дата начала не может быть позже даты окончания";
            this.lblCheckProjectDateOfStart.Visible = false;
            // 
            // pbCheckMarkProjectDateOfStart
            // 
            this.pbCheckMarkProjectDateOfStart.Location = new System.Drawing.Point(601, 14);
            this.pbCheckMarkProjectDateOfStart.Name = "pbCheckMarkProjectDateOfStart";
            this.pbCheckMarkProjectDateOfStart.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkProjectDateOfStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkProjectDateOfStart.TabIndex = 59;
            this.pbCheckMarkProjectDateOfStart.TabStop = false;
            this.pbCheckMarkProjectDateOfStart.Visible = false;
            // 
            // lblCheckProjectPlannedDateOfComplete
            // 
            this.lblCheckProjectPlannedDateOfComplete.AutoSize = true;
            this.lblCheckProjectPlannedDateOfComplete.ForeColor = System.Drawing.Color.Red;
            this.lblCheckProjectPlannedDateOfComplete.Location = new System.Drawing.Point(6, 90);
            this.lblCheckProjectPlannedDateOfComplete.Name = "lblCheckProjectPlannedDateOfComplete";
            this.lblCheckProjectPlannedDateOfComplete.Size = new System.Drawing.Size(275, 13);
            this.lblCheckProjectPlannedDateOfComplete.TabIndex = 62;
            this.lblCheckProjectPlannedDateOfComplete.Text = "Дата окончания не может быть раньше даты начала";
            this.lblCheckProjectPlannedDateOfComplete.Visible = false;
            // 
            // lblProjectPlanDateOfComplete
            // 
            this.lblProjectPlanDateOfComplete.AutoSize = true;
            this.lblProjectPlanDateOfComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjectPlanDateOfComplete.Location = new System.Drawing.Point(6, 64);
            this.lblProjectPlanDateOfComplete.Name = "lblProjectPlanDateOfComplete";
            this.lblProjectPlanDateOfComplete.Size = new System.Drawing.Size(241, 17);
            this.lblProjectPlanDateOfComplete.TabIndex = 55;
            this.lblProjectPlanDateOfComplete.Text = "Плановая дата окончания проекта";
            // 
            // btnProjectSwitchCancel
            // 
            this.btnProjectSwitchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProjectSwitchCancel.Location = new System.Drawing.Point(644, 108);
            this.btnProjectSwitchCancel.Name = "btnProjectSwitchCancel";
            this.btnProjectSwitchCancel.Size = new System.Drawing.Size(168, 40);
            this.btnProjectSwitchCancel.TabIndex = 67;
            this.btnProjectSwitchCancel.Text = "Отменить";
            this.btnProjectSwitchCancel.UseVisualStyleBackColor = true;
            this.btnProjectSwitchCancel.Visible = false;
            this.btnProjectSwitchCancel.Click += new System.EventHandler(this.BtnProjectSwitchCancel_Click);
            // 
            // btnProjectUpdate
            // 
            this.btnProjectUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProjectUpdate.Location = new System.Drawing.Point(644, 63);
            this.btnProjectUpdate.Name = "btnProjectUpdate";
            this.btnProjectUpdate.Size = new System.Drawing.Size(168, 40);
            this.btnProjectUpdate.TabIndex = 66;
            this.btnProjectUpdate.Text = "Сохранить изменения";
            this.btnProjectUpdate.UseVisualStyleBackColor = true;
            this.btnProjectUpdate.Visible = false;
            this.btnProjectUpdate.Click += new System.EventHandler(this.BtnUpdateProject_Click);
            // 
            // btnProjectCreate
            // 
            this.btnProjectCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProjectCreate.Location = new System.Drawing.Point(644, 19);
            this.btnProjectCreate.Name = "btnProjectCreate";
            this.btnProjectCreate.Size = new System.Drawing.Size(168, 40);
            this.btnProjectCreate.TabIndex = 58;
            this.btnProjectCreate.Text = "Сохранить проект";
            this.btnProjectCreate.UseVisualStyleBackColor = true;
            this.btnProjectCreate.Visible = false;
            this.btnProjectCreate.Click += new System.EventHandler(this.BtnCreateProject_Click);
            // 
            // gbAllProjects
            // 
            this.gbAllProjects.Controls.Add(this.lbllProjectAmountPayments);
            this.gbAllProjects.Controls.Add(this.lblProjectTotalSquare);
            this.gbAllProjects.Controls.Add(this.lbllProjectWorksAmount);
            this.gbAllProjects.Controls.Add(this.button2);
            this.gbAllProjects.Controls.Add(this.button1);
            this.gbAllProjects.Controls.Add(this.btnProjectSwitchStart);
            this.gbAllProjects.Controls.Add(this.buttonSwitchCreateProject);
            this.gbAllProjects.Controls.Add(this.buttonSwitchUpdateProject);
            this.gbAllProjects.Controls.Add(this.groupBoxProjectState);
            this.gbAllProjects.Controls.Add(this.buttonDeleteProject);
            this.gbAllProjects.Controls.Add(this.dgvAllProjects);
            this.gbAllProjects.Controls.Add(this.buttonOpenProject);
            this.gbAllProjects.Location = new System.Drawing.Point(6, 6);
            this.gbAllProjects.Name = "gbAllProjects";
            this.gbAllProjects.Size = new System.Drawing.Size(1080, 899);
            this.gbAllProjects.TabIndex = 0;
            this.gbAllProjects.TabStop = false;
            this.gbAllProjects.Text = "Все проекты";
            // 
            // lbllProjectAmountPayments
            // 
            this.lbllProjectAmountPayments.AutoSize = true;
            this.lbllProjectAmountPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbllProjectAmountPayments.Location = new System.Drawing.Point(425, 80);
            this.lbllProjectAmountPayments.Name = "lbllProjectAmountPayments";
            this.lbllProjectAmountPayments.Size = new System.Drawing.Size(179, 17);
            this.lbllProjectAmountPayments.TabIndex = 15;
            this.lbllProjectAmountPayments.Text = "Сумма выплат по проекту";
            // 
            // lblProjectTotalSquare
            // 
            this.lblProjectTotalSquare.AutoSize = true;
            this.lblProjectTotalSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjectTotalSquare.Location = new System.Drawing.Point(425, 30);
            this.lblProjectTotalSquare.Name = "lblProjectTotalSquare";
            this.lblProjectTotalSquare.Size = new System.Drawing.Size(170, 17);
            this.lblProjectTotalSquare.TabIndex = 14;
            this.lblProjectTotalSquare.Text = "Общая площадь фасада";
            // 
            // lbllProjectWorksAmount
            // 
            this.lbllProjectWorksAmount.AutoSize = true;
            this.lbllProjectWorksAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbllProjectWorksAmount.Location = new System.Drawing.Point(425, 55);
            this.lbllProjectWorksAmount.Name = "lbllProjectWorksAmount";
            this.lbllProjectWorksAmount.Size = new System.Drawing.Size(198, 17);
            this.lbllProjectWorksAmount.TabIndex = 13;
            this.lbllProjectWorksAmount.Text = "Стоимость работ по проекту";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отменить проект";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Завершить проект";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProjectSwitchStart
            // 
            this.btnProjectSwitchStart.Location = new System.Drawing.Point(291, 30);
            this.btnProjectSwitchStart.Name = "btnProjectSwitchStart";
            this.btnProjectSwitchStart.Size = new System.Drawing.Size(109, 33);
            this.btnProjectSwitchStart.TabIndex = 10;
            this.btnProjectSwitchStart.Text = "Старт проекта";
            this.btnProjectSwitchStart.UseVisualStyleBackColor = true;
            this.btnProjectSwitchStart.Click += new System.EventHandler(this.BtnProjectSwitchStart_Click);
            // 
            // buttonSwitchCreateProject
            // 
            this.buttonSwitchCreateProject.Location = new System.Drawing.Point(175, 69);
            this.buttonSwitchCreateProject.Name = "buttonSwitchCreateProject";
            this.buttonSwitchCreateProject.Size = new System.Drawing.Size(110, 33);
            this.buttonSwitchCreateProject.TabIndex = 9;
            this.buttonSwitchCreateProject.Text = "Создать проект";
            this.buttonSwitchCreateProject.UseVisualStyleBackColor = true;
            this.buttonSwitchCreateProject.Click += new System.EventHandler(this.BtnSwitchCreateProject_Click);
            // 
            // buttonSwitchUpdateProject
            // 
            this.buttonSwitchUpdateProject.Location = new System.Drawing.Point(175, 108);
            this.buttonSwitchUpdateProject.Name = "buttonSwitchUpdateProject";
            this.buttonSwitchUpdateProject.Size = new System.Drawing.Size(110, 39);
            this.buttonSwitchUpdateProject.TabIndex = 8;
            this.buttonSwitchUpdateProject.Text = "Редактировать проект";
            this.buttonSwitchUpdateProject.UseVisualStyleBackColor = true;
            this.buttonSwitchUpdateProject.Click += new System.EventHandler(this.BtnSwitchUpdateProject_Click);
            // 
            // groupBoxProjectState
            // 
            this.groupBoxProjectState.Controls.Add(this.buttonViewProjectsByState);
            this.groupBoxProjectState.Controls.Add(this.radioButtonCancelledProjects);
            this.groupBoxProjectState.Controls.Add(this.radioButtonCompletedProjects);
            this.groupBoxProjectState.Controls.Add(this.radioButtonActualProjects);
            this.groupBoxProjectState.Controls.Add(this.radioButtonPlannedProjects);
            this.groupBoxProjectState.Controls.Add(this.radioButtonAllProjects);
            this.groupBoxProjectState.Location = new System.Drawing.Point(6, 19);
            this.groupBoxProjectState.Name = "groupBoxProjectState";
            this.groupBoxProjectState.Size = new System.Drawing.Size(145, 178);
            this.groupBoxProjectState.TabIndex = 7;
            this.groupBoxProjectState.TabStop = false;
            this.groupBoxProjectState.Text = "Статус проекта";
            // 
            // buttonViewProjectsByState
            // 
            this.buttonViewProjectsByState.Location = new System.Drawing.Point(18, 134);
            this.buttonViewProjectsByState.Name = "buttonViewProjectsByState";
            this.buttonViewProjectsByState.Size = new System.Drawing.Size(110, 33);
            this.buttonViewProjectsByState.TabIndex = 8;
            this.buttonViewProjectsByState.Text = "Показать проекты";
            this.buttonViewProjectsByState.UseVisualStyleBackColor = true;
            // 
            // radioButtonCancelledProjects
            // 
            this.radioButtonCancelledProjects.AutoSize = true;
            this.radioButtonCancelledProjects.Location = new System.Drawing.Point(18, 111);
            this.radioButtonCancelledProjects.Name = "radioButtonCancelledProjects";
            this.radioButtonCancelledProjects.Size = new System.Drawing.Size(90, 17);
            this.radioButtonCancelledProjects.TabIndex = 4;
            this.radioButtonCancelledProjects.TabStop = true;
            this.radioButtonCancelledProjects.Text = "Отмененный";
            this.radioButtonCancelledProjects.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompletedProjects
            // 
            this.radioButtonCompletedProjects.AutoSize = true;
            this.radioButtonCompletedProjects.Location = new System.Drawing.Point(18, 88);
            this.radioButtonCompletedProjects.Name = "radioButtonCompletedProjects";
            this.radioButtonCompletedProjects.Size = new System.Drawing.Size(96, 17);
            this.radioButtonCompletedProjects.TabIndex = 3;
            this.radioButtonCompletedProjects.TabStop = true;
            this.radioButtonCompletedProjects.Text = "Завершенный";
            this.radioButtonCompletedProjects.UseVisualStyleBackColor = true;
            // 
            // radioButtonActualProjects
            // 
            this.radioButtonActualProjects.AutoSize = true;
            this.radioButtonActualProjects.Location = new System.Drawing.Point(18, 65);
            this.radioButtonActualProjects.Name = "radioButtonActualProjects";
            this.radioButtonActualProjects.Size = new System.Drawing.Size(70, 17);
            this.radioButtonActualProjects.TabIndex = 2;
            this.radioButtonActualProjects.TabStop = true;
            this.radioButtonActualProjects.Text = "Текущий";
            this.radioButtonActualProjects.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlannedProjects
            // 
            this.radioButtonPlannedProjects.AutoSize = true;
            this.radioButtonPlannedProjects.Location = new System.Drawing.Point(18, 42);
            this.radioButtonPlannedProjects.Name = "radioButtonPlannedProjects";
            this.radioButtonPlannedProjects.Size = new System.Drawing.Size(96, 17);
            this.radioButtonPlannedProjects.TabIndex = 1;
            this.radioButtonPlannedProjects.TabStop = true;
            this.radioButtonPlannedProjects.Text = "Планируемый";
            this.radioButtonPlannedProjects.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllProjects
            // 
            this.radioButtonAllProjects.AutoSize = true;
            this.radioButtonAllProjects.Location = new System.Drawing.Point(18, 19);
            this.radioButtonAllProjects.Name = "radioButtonAllProjects";
            this.radioButtonAllProjects.Size = new System.Drawing.Size(59, 17);
            this.radioButtonAllProjects.TabIndex = 0;
            this.radioButtonAllProjects.TabStop = true;
            this.radioButtonAllProjects.Text = "Любой";
            this.radioButtonAllProjects.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProject
            // 
            this.buttonDeleteProject.Location = new System.Drawing.Point(175, 153);
            this.buttonDeleteProject.Name = "buttonDeleteProject";
            this.buttonDeleteProject.Size = new System.Drawing.Size(110, 33);
            this.buttonDeleteProject.TabIndex = 6;
            this.buttonDeleteProject.Text = "Удалить проект";
            this.buttonDeleteProject.UseVisualStyleBackColor = true;
            this.buttonDeleteProject.Click += new System.EventHandler(this.BtnDeleteProject_Click);
            // 
            // dgvAllProjects
            // 
            this.dgvAllProjects.AllowUserToAddRows = false;
            this.dgvAllProjects.AllowUserToDeleteRows = false;
            this.dgvAllProjects.AllowUserToResizeRows = false;
            this.dgvAllProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnClient,
            this.ColumnState,
            this.ColumnDateOfStart,
            this.ColumnDateOfComplete,
            this.ColumnPlannedDateOfComplete});
            this.dgvAllProjects.Location = new System.Drawing.Point(7, 203);
            this.dgvAllProjects.MultiSelect = false;
            this.dgvAllProjects.Name = "dgvAllProjects";
            this.dgvAllProjects.ReadOnly = true;
            this.dgvAllProjects.RowHeadersVisible = false;
            this.dgvAllProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProjects.Size = new System.Drawing.Size(1067, 50);
            this.dgvAllProjects.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№п/п";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 270;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Адрес";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            this.ColumnAddress.Width = 220;
            // 
            // ColumnClient
            // 
            this.ColumnClient.HeaderText = "Заказчик";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            this.ColumnClient.Width = 210;
            // 
            // ColumnState
            // 
            this.ColumnState.HeaderText = "Статус";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.ReadOnly = true;
            this.ColumnState.Width = 80;
            // 
            // ColumnDateOfStart
            // 
            this.ColumnDateOfStart.HeaderText = "Начало";
            this.ColumnDateOfStart.Name = "ColumnDateOfStart";
            this.ColumnDateOfStart.ReadOnly = true;
            this.ColumnDateOfStart.Width = 80;
            // 
            // ColumnDateOfComplete
            // 
            this.ColumnDateOfComplete.HeaderText = "Окончание";
            this.ColumnDateOfComplete.Name = "ColumnDateOfComplete";
            this.ColumnDateOfComplete.ReadOnly = true;
            this.ColumnDateOfComplete.Width = 80;
            // 
            // ColumnPlannedDateOfComplete
            // 
            this.ColumnPlannedDateOfComplete.HeaderText = "План";
            this.ColumnPlannedDateOfComplete.Name = "ColumnPlannedDateOfComplete";
            this.ColumnPlannedDateOfComplete.ReadOnly = true;
            this.ColumnPlannedDateOfComplete.Width = 80;
            // 
            // buttonOpenProject
            // 
            this.buttonOpenProject.Location = new System.Drawing.Point(175, 30);
            this.buttonOpenProject.Name = "buttonOpenProject";
            this.buttonOpenProject.Size = new System.Drawing.Size(110, 33);
            this.buttonOpenProject.TabIndex = 5;
            this.buttonOpenProject.Text = "Открыть проект";
            this.buttonOpenProject.UseVisualStyleBackColor = true;
            this.buttonOpenProject.Click += new System.EventHandler(this.BtnOpenProject_Click);
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.groupBoxUserPanel);
            this.tabPageUser.Controls.Add(this.gbUsersInProject);
            this.tabPageUser.Controls.Add(this.gbAllUsers);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(1900, 946);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "Пользователи";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // groupBoxUserPanel
            // 
            this.groupBoxUserPanel.Controls.Add(this.buttonUserSwitchCancel);
            this.groupBoxUserPanel.Controls.Add(this.btnCreateUser);
            this.groupBoxUserPanel.Controls.Add(this.gbUserData);
            this.groupBoxUserPanel.Controls.Add(this.gbPasswordPanel);
            this.groupBoxUserPanel.Controls.Add(this.btnUpdateUser);
            this.groupBoxUserPanel.Location = new System.Drawing.Point(982, 6);
            this.groupBoxUserPanel.Name = "groupBoxUserPanel";
            this.groupBoxUserPanel.Size = new System.Drawing.Size(752, 899);
            this.groupBoxUserPanel.TabIndex = 2;
            this.groupBoxUserPanel.TabStop = false;
            this.groupBoxUserPanel.Text = "Данные пользователя";
            // 
            // buttonUserSwitchCancel
            // 
            this.buttonUserSwitchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonUserSwitchCancel.Location = new System.Drawing.Point(9, 382);
            this.buttonUserSwitchCancel.Name = "buttonUserSwitchCancel";
            this.buttonUserSwitchCancel.Size = new System.Drawing.Size(152, 42);
            this.buttonUserSwitchCancel.TabIndex = 50;
            this.buttonUserSwitchCancel.Text = "Отменить";
            this.buttonUserSwitchCancel.UseVisualStyleBackColor = true;
            this.buttonUserSwitchCancel.Click += new System.EventHandler(this.BtnUserSwitchCancel_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateUser.Location = new System.Drawing.Point(485, 382);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(152, 42);
            this.btnCreateUser.TabIndex = 48;
            this.btnCreateUser.Text = "Сохранить нового пользователя";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Visible = false;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // gbUserData
            // 
            this.gbUserData.Controls.Add(this.labelNameUser);
            this.gbUserData.Controls.Add(this.labelUserLogin);
            this.gbUserData.Controls.Add(this.lblCheckUserLogin);
            this.gbUserData.Controls.Add(this.tbUserLogin);
            this.gbUserData.Controls.Add(this.lblCheckUserPassport);
            this.gbUserData.Controls.Add(this.tbUserPassport);
            this.gbUserData.Controls.Add(this.lblCheckUserName);
            this.gbUserData.Controls.Add(this.labelUserPassport);
            this.gbUserData.Controls.Add(this.pbCheckMarkUserLogin);
            this.gbUserData.Controls.Add(this.tbUserName);
            this.gbUserData.Controls.Add(this.pbCheckMarkUserPassport);
            this.gbUserData.Controls.Add(this.labelManagerAccess);
            this.gbUserData.Controls.Add(this.pbCheckMarkUserName);
            this.gbUserData.Controls.Add(this.checkBoxManagerAccess);
            this.gbUserData.Enabled = false;
            this.gbUserData.Location = new System.Drawing.Point(9, 19);
            this.gbUserData.Name = "gbUserData";
            this.gbUserData.Size = new System.Drawing.Size(728, 190);
            this.gbUserData.TabIndex = 49;
            this.gbUserData.TabStop = false;
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameUser.Location = new System.Drawing.Point(6, 26);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(168, 17);
            this.labelNameUser.TabIndex = 24;
            this.labelNameUser.Text = "Фамилия Имя Отчество";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserLogin.Location = new System.Drawing.Point(6, 119);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(47, 17);
            this.labelUserLogin.TabIndex = 28;
            this.labelUserLogin.Text = "Логин";
            // 
            // lblCheckUserLogin
            // 
            this.lblCheckUserLogin.AutoSize = true;
            this.lblCheckUserLogin.ForeColor = System.Drawing.Color.Red;
            this.lblCheckUserLogin.Location = new System.Drawing.Point(6, 145);
            this.lblCheckUserLogin.Name = "lblCheckUserLogin";
            this.lblCheckUserLogin.Size = new System.Drawing.Size(315, 13);
            this.lblCheckUserLogin.TabIndex = 46;
            this.lblCheckUserLogin.Text = "Введите в качестве логина адрес Вашей электронной почты";
            this.lblCheckUserLogin.Visible = false;
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUserLogin.Location = new System.Drawing.Point(225, 119);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(369, 23);
            this.tbUserLogin.TabIndex = 29;
            this.tbUserLogin.TextChanged += new System.EventHandler(this.TbUserLogin_TextChanged);
            // 
            // lblCheckUserPassport
            // 
            this.lblCheckUserPassport.AutoSize = true;
            this.lblCheckUserPassport.ForeColor = System.Drawing.Color.Red;
            this.lblCheckUserPassport.Location = new System.Drawing.Point(6, 100);
            this.lblCheckUserPassport.Name = "lblCheckUserPassport";
            this.lblCheckUserPassport.Size = new System.Drawing.Size(517, 13);
            this.lblCheckUserPassport.TabIndex = 45;
            this.lblCheckUserPassport.Text = "Введите данные в формате: 0000 000000 01.01.2000 г название подразделения выдавше" +
    "го паспорт";
            this.lblCheckUserPassport.Visible = false;
            // 
            // tbUserPassport
            // 
            this.tbUserPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUserPassport.Location = new System.Drawing.Point(225, 74);
            this.tbUserPassport.Name = "tbUserPassport";
            this.tbUserPassport.Size = new System.Drawing.Size(369, 23);
            this.tbUserPassport.TabIndex = 27;
            this.tbUserPassport.TextChanged += new System.EventHandler(this.TbUserPassport_TextChanged);
            // 
            // lblCheckUserName
            // 
            this.lblCheckUserName.AutoSize = true;
            this.lblCheckUserName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckUserName.Location = new System.Drawing.Point(6, 53);
            this.lblCheckUserName.Name = "lblCheckUserName";
            this.lblCheckUserName.Size = new System.Drawing.Size(299, 13);
            this.lblCheckUserName.TabIndex = 44;
            this.lblCheckUserName.Text = "Введите ФИО кирилицей с заглавных букв через пробел";
            this.lblCheckUserName.Visible = false;
            // 
            // labelUserPassport
            // 
            this.labelUserPassport.AutoSize = true;
            this.labelUserPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassport.Location = new System.Drawing.Point(6, 74);
            this.labelUserPassport.Name = "labelUserPassport";
            this.labelUserPassport.Size = new System.Drawing.Size(144, 17);
            this.labelUserPassport.TabIndex = 26;
            this.labelUserPassport.Text = "Паспортные данные";
            // 
            // pbCheckMarkUserLogin
            // 
            this.pbCheckMarkUserLogin.Location = new System.Drawing.Point(601, 119);
            this.pbCheckMarkUserLogin.Name = "pbCheckMarkUserLogin";
            this.pbCheckMarkUserLogin.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkUserLogin.TabIndex = 41;
            this.pbCheckMarkUserLogin.TabStop = false;
            this.pbCheckMarkUserLogin.Visible = false;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUserName.Location = new System.Drawing.Point(225, 26);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(369, 23);
            this.tbUserName.TabIndex = 25;
            this.tbUserName.TextChanged += new System.EventHandler(this.TbUserName_TextChanged);
            // 
            // pbCheckMarkUserPassport
            // 
            this.pbCheckMarkUserPassport.Location = new System.Drawing.Point(601, 74);
            this.pbCheckMarkUserPassport.Name = "pbCheckMarkUserPassport";
            this.pbCheckMarkUserPassport.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkUserPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkUserPassport.TabIndex = 40;
            this.pbCheckMarkUserPassport.TabStop = false;
            this.pbCheckMarkUserPassport.Visible = false;
            // 
            // labelManagerAccess
            // 
            this.labelManagerAccess.AutoSize = true;
            this.labelManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelManagerAccess.Location = new System.Drawing.Point(6, 163);
            this.labelManagerAccess.Name = "labelManagerAccess";
            this.labelManagerAccess.Size = new System.Drawing.Size(184, 17);
            this.labelManagerAccess.TabIndex = 34;
            this.labelManagerAccess.Text = "Права доступа менеджера";
            // 
            // pbCheckMarkUserName
            // 
            this.pbCheckMarkUserName.Location = new System.Drawing.Point(601, 24);
            this.pbCheckMarkUserName.Name = "pbCheckMarkUserName";
            this.pbCheckMarkUserName.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkUserName.TabIndex = 39;
            this.pbCheckMarkUserName.TabStop = false;
            this.pbCheckMarkUserName.Visible = false;
            // 
            // checkBoxManagerAccess
            // 
            this.checkBoxManagerAccess.AutoSize = true;
            this.checkBoxManagerAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxManagerAccess.Location = new System.Drawing.Point(225, 163);
            this.checkBoxManagerAccess.Name = "checkBoxManagerAccess";
            this.checkBoxManagerAccess.Size = new System.Drawing.Size(169, 21);
            this.checkBoxManagerAccess.TabIndex = 35;
            this.checkBoxManagerAccess.Text = "Предоставить доступ";
            this.checkBoxManagerAccess.UseVisualStyleBackColor = true;
            // 
            // gbPasswordPanel
            // 
            this.gbPasswordPanel.Controls.Add(this.labelUserPassword);
            this.gbPasswordPanel.Controls.Add(this.btnChangePassword);
            this.gbPasswordPanel.Controls.Add(this.tbUserPassword);
            this.gbPasswordPanel.Controls.Add(this.labelЗPasswordRepeat);
            this.gbPasswordPanel.Controls.Add(this.tbUserPasswordRepeat);
            this.gbPasswordPanel.Controls.Add(this.lblUserCheckPasswordsIsNotEuals);
            this.gbPasswordPanel.Controls.Add(this.pbCheckMarkUserRepeatPassword);
            this.gbPasswordPanel.Controls.Add(this.lblCheckUserPassword);
            this.gbPasswordPanel.Controls.Add(this.pbCheckMarkUserPassword);
            this.gbPasswordPanel.Location = new System.Drawing.Point(9, 215);
            this.gbPasswordPanel.Name = "gbPasswordPanel";
            this.gbPasswordPanel.Size = new System.Drawing.Size(728, 161);
            this.gbPasswordPanel.TabIndex = 48;
            this.gbPasswordPanel.TabStop = false;
            this.gbPasswordPanel.Visible = false;
            this.gbPasswordPanel.VisibleChanged += new System.EventHandler(this.GbPasswordPanel_VisibleChanged);
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassword.Location = new System.Drawing.Point(6, 25);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(194, 17);
            this.labelUserPassword.TabIndex = 30;
            this.labelUserPassword.Text = "Пароль для входа в систему";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangePassword.Location = new System.Drawing.Point(476, 111);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(152, 42);
            this.btnChangePassword.TabIndex = 47;
            this.btnChangePassword.Text = "Сохранить новый пароль";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUserPassword.Location = new System.Drawing.Point(225, 25);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.PasswordChar = '*';
            this.tbUserPassword.Size = new System.Drawing.Size(369, 23);
            this.tbUserPassword.TabIndex = 31;
            this.tbUserPassword.UseSystemPasswordChar = true;
            this.tbUserPassword.TextChanged += new System.EventHandler(this.TbUserPasswordInput_TextChanged);
            // 
            // labelЗPasswordRepeat
            // 
            this.labelЗPasswordRepeat.AutoSize = true;
            this.labelЗPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelЗPasswordRepeat.Location = new System.Drawing.Point(6, 80);
            this.labelЗPasswordRepeat.Name = "labelЗPasswordRepeat";
            this.labelЗPasswordRepeat.Size = new System.Drawing.Size(130, 17);
            this.labelЗPasswordRepeat.TabIndex = 32;
            this.labelЗPasswordRepeat.Text = "Повторите пароль";
            // 
            // tbUserPasswordRepeat
            // 
            this.tbUserPasswordRepeat.BackColor = System.Drawing.SystemColors.Window;
            this.tbUserPasswordRepeat.Enabled = false;
            this.tbUserPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUserPasswordRepeat.Location = new System.Drawing.Point(225, 80);
            this.tbUserPasswordRepeat.Name = "tbUserPasswordRepeat";
            this.tbUserPasswordRepeat.PasswordChar = '*';
            this.tbUserPasswordRepeat.Size = new System.Drawing.Size(369, 23);
            this.tbUserPasswordRepeat.TabIndex = 33;
            this.tbUserPasswordRepeat.UseSystemPasswordChar = true;
            this.tbUserPasswordRepeat.TextChanged += new System.EventHandler(this.TbPasswordRepeatInput_TextChanged);
            // 
            // lblUserCheckPasswordsIsNotEuals
            // 
            this.lblUserCheckPasswordsIsNotEuals.AutoSize = true;
            this.lblUserCheckPasswordsIsNotEuals.ForeColor = System.Drawing.Color.Red;
            this.lblUserCheckPasswordsIsNotEuals.Location = new System.Drawing.Point(222, 111);
            this.lblUserCheckPasswordsIsNotEuals.Name = "lblUserCheckPasswordsIsNotEuals";
            this.lblUserCheckPasswordsIsNotEuals.Size = new System.Drawing.Size(176, 13);
            this.lblUserCheckPasswordsIsNotEuals.TabIndex = 37;
            this.lblUserCheckPasswordsIsNotEuals.Text = "Введенные пароли не совпадают";
            this.lblUserCheckPasswordsIsNotEuals.Visible = false;
            // 
            // pbCheckMarkUserRepeatPassword
            // 
            this.pbCheckMarkUserRepeatPassword.Location = new System.Drawing.Point(601, 80);
            this.pbCheckMarkUserRepeatPassword.Name = "pbCheckMarkUserRepeatPassword";
            this.pbCheckMarkUserRepeatPassword.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkUserRepeatPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkUserRepeatPassword.TabIndex = 43;
            this.pbCheckMarkUserRepeatPassword.TabStop = false;
            this.pbCheckMarkUserRepeatPassword.Visible = false;
            // 
            // lblCheckUserPassword
            // 
            this.lblCheckUserPassword.AutoSize = true;
            this.lblCheckUserPassword.ForeColor = System.Drawing.Color.Red;
            this.lblCheckUserPassword.Location = new System.Drawing.Point(6, 53);
            this.lblCheckUserPassword.Name = "lblCheckUserPassword";
            this.lblCheckUserPassword.Size = new System.Drawing.Size(631, 13);
            this.lblCheckUserPassword.TabIndex = 38;
            this.lblCheckUserPassword.Text = "Введите пароль от 8 до 16 символов, содержащий не меннее 1 цифры, одной заглавной" +
    " и одной строчной латинских букв";
            this.lblCheckUserPassword.Visible = false;
            // 
            // pbCheckMarkUserPassword
            // 
            this.pbCheckMarkUserPassword.Location = new System.Drawing.Point(601, 25);
            this.pbCheckMarkUserPassword.Name = "pbCheckMarkUserPassword";
            this.pbCheckMarkUserPassword.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkUserPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkUserPassword.TabIndex = 42;
            this.pbCheckMarkUserPassword.TabStop = false;
            this.pbCheckMarkUserPassword.Visible = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateUser.Location = new System.Drawing.Point(494, 225);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(152, 42);
            this.btnUpdateUser.TabIndex = 36;
            this.btnUpdateUser.Text = "Сохранить данные пользователя";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Visible = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // gbUsersInProject
            // 
            this.gbUsersInProject.Controls.Add(this.dgvUserInProject);
            this.gbUsersInProject.Controls.Add(this.buttonRemoveUser);
            this.gbUsersInProject.Location = new System.Drawing.Point(6, 404);
            this.gbUsersInProject.Name = "gbUsersInProject";
            this.gbUsersInProject.Size = new System.Drawing.Size(968, 501);
            this.gbUsersInProject.TabIndex = 1;
            this.gbUsersInProject.TabStop = false;
            this.gbUsersInProject.Text = "Участники текущего проекта";
            // 
            // dgvUserInProject
            // 
            this.dgvUserInProject.AllowUserToAddRows = false;
            this.dgvUserInProject.AllowUserToDeleteRows = false;
            this.dgvUserInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnUserName,
            this.ColumnManagerAccess});
            this.dgvUserInProject.Location = new System.Drawing.Point(6, 19);
            this.dgvUserInProject.MultiSelect = false;
            this.dgvUserInProject.Name = "dgvUserInProject";
            this.dgvUserInProject.ReadOnly = true;
            this.dgvUserInProject.RowHeadersVisible = false;
            this.dgvUserInProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInProject.Size = new System.Drawing.Size(533, 53);
            this.dgvUserInProject.TabIndex = 57;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Id";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 50;
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.HeaderText = "ФИО участника";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            this.ColumnUserName.Width = 400;
            // 
            // ColumnManagerAccess
            // 
            this.ColumnManagerAccess.HeaderText = "Менеджер";
            this.ColumnManagerAccess.Name = "ColumnManagerAccess";
            this.ColumnManagerAccess.ReadOnly = true;
            this.ColumnManagerAccess.Width = 80;
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRemoveUser.Location = new System.Drawing.Point(572, 19);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(169, 26);
            this.buttonRemoveUser.TabIndex = 59;
            this.buttonRemoveUser.Text = "Удалить участника";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.BtnRemoveUser_Click);
            // 
            // gbAllUsers
            // 
            this.gbAllUsers.Controls.Add(this.checkBoxAllUsersVision);
            this.gbAllUsers.Controls.Add(this.buttonAddUserInProject);
            this.gbAllUsers.Controls.Add(this.buttonSwitchChangePassword);
            this.gbAllUsers.Controls.Add(this.buttonDeleteUser);
            this.gbAllUsers.Controls.Add(this.buttonSwitchUpdateUser);
            this.gbAllUsers.Controls.Add(this.buttonSwitchCreateUser);
            this.gbAllUsers.Controls.Add(this.dgvAllUsers);
            this.gbAllUsers.Location = new System.Drawing.Point(6, 6);
            this.gbAllUsers.Name = "gbAllUsers";
            this.gbAllUsers.Size = new System.Drawing.Size(968, 392);
            this.gbAllUsers.TabIndex = 0;
            this.gbAllUsers.TabStop = false;
            this.gbAllUsers.Text = "Все пользователи";
            // 
            // checkBoxAllUsersVision
            // 
            this.checkBoxAllUsersVision.AutoSize = true;
            this.checkBoxAllUsersVision.Location = new System.Drawing.Point(852, 19);
            this.checkBoxAllUsersVision.Name = "checkBoxAllUsersVision";
            this.checkBoxAllUsersVision.Size = new System.Drawing.Size(64, 17);
            this.checkBoxAllUsersVision.TabIndex = 13;
            this.checkBoxAllUsersVision.Text = "Скрыть";
            this.checkBoxAllUsersVision.UseVisualStyleBackColor = true;
            // 
            // buttonAddUserInProject
            // 
            this.buttonAddUserInProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddUserInProject.Location = new System.Drawing.Point(852, 248);
            this.buttonAddUserInProject.Name = "buttonAddUserInProject";
            this.buttonAddUserInProject.Size = new System.Drawing.Size(110, 49);
            this.buttonAddUserInProject.TabIndex = 12;
            this.buttonAddUserInProject.Text = "Добавить пользователя в проект";
            this.buttonAddUserInProject.UseVisualStyleBackColor = true;
            this.buttonAddUserInProject.Click += new System.EventHandler(this.BtnAddUserInProject_Click);
            // 
            // buttonSwitchChangePassword
            // 
            this.buttonSwitchChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSwitchChangePassword.Location = new System.Drawing.Point(852, 166);
            this.buttonSwitchChangePassword.Name = "buttonSwitchChangePassword";
            this.buttonSwitchChangePassword.Size = new System.Drawing.Size(110, 35);
            this.buttonSwitchChangePassword.TabIndex = 11;
            this.buttonSwitchChangePassword.Text = "Сменить пароль пользователя";
            this.buttonSwitchChangePassword.UseVisualStyleBackColor = true;
            this.buttonSwitchChangePassword.Click += new System.EventHandler(this.BtnSwitchChangePassword_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(852, 207);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(110, 35);
            this.buttonDeleteUser.TabIndex = 10;
            this.buttonDeleteUser.Text = "Удалить пользователя";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // buttonSwitchUpdateUser
            // 
            this.buttonSwitchUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSwitchUpdateUser.Location = new System.Drawing.Point(852, 111);
            this.buttonSwitchUpdateUser.Name = "buttonSwitchUpdateUser";
            this.buttonSwitchUpdateUser.Size = new System.Drawing.Size(110, 49);
            this.buttonSwitchUpdateUser.TabIndex = 9;
            this.buttonSwitchUpdateUser.Text = "Редактировать данные пользователя";
            this.buttonSwitchUpdateUser.UseVisualStyleBackColor = true;
            this.buttonSwitchUpdateUser.Click += new System.EventHandler(this.BtnSwitchUpdateUser_Click);
            // 
            // buttonSwitchCreateUser
            // 
            this.buttonSwitchCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSwitchCreateUser.Location = new System.Drawing.Point(852, 56);
            this.buttonSwitchCreateUser.Name = "buttonSwitchCreateUser";
            this.buttonSwitchCreateUser.Size = new System.Drawing.Size(110, 49);
            this.buttonSwitchCreateUser.TabIndex = 8;
            this.buttonSwitchCreateUser.Text = "Добавить нового пользователя";
            this.buttonSwitchCreateUser.UseVisualStyleBackColor = true;
            this.buttonSwitchCreateUser.Click += new System.EventHandler(this.BtnSwitchCreateUser_Click);
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIndexColumn,
            this.userNameColumn,
            this.userPassportColumn,
            this.userLoginColumn,
            this.userManagerAccessColumn});
            this.dgvAllUsers.Location = new System.Drawing.Point(5, 19);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersVisible = false;
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(825, 27);
            this.dgvAllUsers.TabIndex = 7;
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
            this.userManagerAccessColumn.HeaderText = "Менеджер";
            this.userManagerAccessColumn.Name = "userManagerAccessColumn";
            this.userManagerAccessColumn.ReadOnly = true;
            this.userManagerAccessColumn.Width = 90;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.gbAllClients);
            this.tabPageClient.Controls.Add(this.groupBoxClent);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1900, 946);
            this.tabPageClient.TabIndex = 2;
            this.tabPageClient.Text = "Заказчики";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // gbAllClients
            // 
            this.gbAllClients.Controls.Add(this.buttonAddClientToProject);
            this.gbAllClients.Controls.Add(this.buttonDeleteClient);
            this.gbAllClients.Controls.Add(this.buttonSwitchUpdateClient);
            this.gbAllClients.Controls.Add(this.buttonSwitchCreateClient);
            this.gbAllClients.Controls.Add(this.dgvAllClients);
            this.gbAllClients.Location = new System.Drawing.Point(20, 6);
            this.gbAllClients.Name = "gbAllClients";
            this.gbAllClients.Size = new System.Drawing.Size(968, 392);
            this.gbAllClients.TabIndex = 4;
            this.gbAllClients.TabStop = false;
            this.gbAllClients.Text = "Все заказчики";
            // 
            // buttonAddClientToProject
            // 
            this.buttonAddClientToProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddClientToProject.Location = new System.Drawing.Point(852, 193);
            this.buttonAddClientToProject.Name = "buttonAddClientToProject";
            this.buttonAddClientToProject.Size = new System.Drawing.Size(110, 49);
            this.buttonAddClientToProject.TabIndex = 12;
            this.buttonAddClientToProject.Text = "Добавить заказчика в  текущий проект";
            this.buttonAddClientToProject.UseVisualStyleBackColor = true;
            this.buttonAddClientToProject.Click += new System.EventHandler(this.BtnAddClientToProject_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteClient.Location = new System.Drawing.Point(852, 142);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(110, 35);
            this.buttonDeleteClient.TabIndex = 10;
            this.buttonDeleteClient.Text = "Удалить заказчика";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.BtnDeleteClient_Click);
            // 
            // buttonSwitchUpdateClient
            // 
            this.buttonSwitchUpdateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSwitchUpdateClient.Location = new System.Drawing.Point(852, 80);
            this.buttonSwitchUpdateClient.Name = "buttonSwitchUpdateClient";
            this.buttonSwitchUpdateClient.Size = new System.Drawing.Size(110, 49);
            this.buttonSwitchUpdateClient.TabIndex = 9;
            this.buttonSwitchUpdateClient.Text = "Редактировать данные заказчика";
            this.buttonSwitchUpdateClient.UseVisualStyleBackColor = true;
            this.buttonSwitchUpdateClient.Click += new System.EventHandler(this.BtnSwitchUpdateClient_Click);
            // 
            // buttonSwitchCreateClient
            // 
            this.buttonSwitchCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSwitchCreateClient.Location = new System.Drawing.Point(852, 19);
            this.buttonSwitchCreateClient.Name = "buttonSwitchCreateClient";
            this.buttonSwitchCreateClient.Size = new System.Drawing.Size(110, 49);
            this.buttonSwitchCreateClient.TabIndex = 8;
            this.buttonSwitchCreateClient.Text = "Добавить нового заказчика";
            this.buttonSwitchCreateClient.UseVisualStyleBackColor = true;
            this.buttonSwitchCreateClient.Click += new System.EventHandler(this.BtnSwitchCreateClient_Click);
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.AllowUserToAddRows = false;
            this.dgvAllClients.AllowUserToDeleteRows = false;
            this.dgvAllClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumnClientName,
            this.dataGridViewTextBoxColumnClientAddress,
            this.dataGridViewTextBoxColumnClentInn});
            this.dgvAllClients.Location = new System.Drawing.Point(5, 19);
            this.dgvAllClients.MultiSelect = false;
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.ReadOnly = true;
            this.dgvAllClients.RowHeadersVisible = false;
            this.dgvAllClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllClients.Size = new System.Drawing.Size(837, 27);
            this.dgvAllClients.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "№";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumnClientName
            // 
            this.dataGridViewTextBoxColumnClientName.Frozen = true;
            this.dataGridViewTextBoxColumnClientName.HeaderText = "Название заказчика";
            this.dataGridViewTextBoxColumnClientName.Name = "dataGridViewTextBoxColumnClientName";
            this.dataGridViewTextBoxColumnClientName.ReadOnly = true;
            this.dataGridViewTextBoxColumnClientName.Width = 350;
            // 
            // dataGridViewTextBoxColumnClientAddress
            // 
            this.dataGridViewTextBoxColumnClientAddress.HeaderText = "Адрес заказчика";
            this.dataGridViewTextBoxColumnClientAddress.Name = "dataGridViewTextBoxColumnClientAddress";
            this.dataGridViewTextBoxColumnClientAddress.ReadOnly = true;
            this.dataGridViewTextBoxColumnClientAddress.Width = 300;
            // 
            // dataGridViewTextBoxColumnClentInn
            // 
            this.dataGridViewTextBoxColumnClentInn.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumnClentInn.Name = "dataGridViewTextBoxColumnClentInn";
            this.dataGridViewTextBoxColumnClentInn.ReadOnly = true;
            this.dataGridViewTextBoxColumnClentInn.Width = 150;
            // 
            // groupBoxClent
            // 
            this.groupBoxClent.Controls.Add(this.labelActualProjectClient);
            this.groupBoxClent.Controls.Add(this.btnCancelClientSwitch);
            this.groupBoxClent.Controls.Add(this.btnCreateClient);
            this.groupBoxClent.Controls.Add(this.gbClientData);
            this.groupBoxClent.Controls.Add(this.btnUpdateClient);
            this.groupBoxClent.Location = new System.Drawing.Point(994, 6);
            this.groupBoxClent.Name = "groupBoxClent";
            this.groupBoxClent.Size = new System.Drawing.Size(752, 899);
            this.groupBoxClent.TabIndex = 3;
            this.groupBoxClent.TabStop = false;
            this.groupBoxClent.Text = "Данные заказчика";
            // 
            // labelActualProjectClient
            // 
            this.labelActualProjectClient.AutoSize = true;
            this.labelActualProjectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelActualProjectClient.Location = new System.Drawing.Point(15, 281);
            this.labelActualProjectClient.Name = "labelActualProjectClient";
            this.labelActualProjectClient.Size = new System.Drawing.Size(197, 17);
            this.labelActualProjectClient.TabIndex = 0;
            this.labelActualProjectClient.Text = "Заказчик текущего проекта:";
            // 
            // btnCancelClientSwitch
            // 
            this.btnCancelClientSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelClientSwitch.Location = new System.Drawing.Point(18, 225);
            this.btnCancelClientSwitch.Name = "btnCancelClientSwitch";
            this.btnCancelClientSwitch.Size = new System.Drawing.Size(152, 42);
            this.btnCancelClientSwitch.TabIndex = 50;
            this.btnCancelClientSwitch.Text = "Отменить";
            this.btnCancelClientSwitch.UseVisualStyleBackColor = true;
            this.btnCancelClientSwitch.Visible = false;
            this.btnCancelClientSwitch.Click += new System.EventHandler(this.BtnCancelClientSwitch_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateClient.Location = new System.Drawing.Point(320, 225);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(152, 42);
            this.btnCreateClient.TabIndex = 48;
            this.btnCreateClient.Text = "Сохранить нового заказчика";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Visible = false;
            this.btnCreateClient.Click += new System.EventHandler(this.BtnCreateClient_Click);
            // 
            // gbClientData
            // 
            this.gbClientData.Controls.Add(this.labelClientName);
            this.gbClientData.Controls.Add(this.labelInn);
            this.gbClientData.Controls.Add(this.lblCheckClientInn);
            this.gbClientData.Controls.Add(this.tbClientInn);
            this.gbClientData.Controls.Add(this.lblCheckClientAddress);
            this.gbClientData.Controls.Add(this.tbClientAddress);
            this.gbClientData.Controls.Add(this.lblCheckClientName);
            this.gbClientData.Controls.Add(this.labelClientAddress);
            this.gbClientData.Controls.Add(this.pbCheckMarkClientInn);
            this.gbClientData.Controls.Add(this.tbClientName);
            this.gbClientData.Controls.Add(this.pbCheckMarkClientAddress);
            this.gbClientData.Controls.Add(this.pbCheckMarkClientName);
            this.gbClientData.Enabled = false;
            this.gbClientData.Location = new System.Drawing.Point(9, 19);
            this.gbClientData.Name = "gbClientData";
            this.gbClientData.Size = new System.Drawing.Size(728, 190);
            this.gbClientData.TabIndex = 49;
            this.gbClientData.TabStop = false;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelClientName.Location = new System.Drawing.Point(6, 26);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(72, 17);
            this.labelClientName.TabIndex = 24;
            this.labelClientName.Text = "Название";
            // 
            // labelInn
            // 
            this.labelInn.AutoSize = true;
            this.labelInn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelInn.Location = new System.Drawing.Point(6, 119);
            this.labelInn.Name = "labelInn";
            this.labelInn.Size = new System.Drawing.Size(38, 17);
            this.labelInn.TabIndex = 28;
            this.labelInn.Text = "ИНН";
            // 
            // lblCheckClientInn
            // 
            this.lblCheckClientInn.AutoSize = true;
            this.lblCheckClientInn.ForeColor = System.Drawing.Color.Red;
            this.lblCheckClientInn.Location = new System.Drawing.Point(6, 145);
            this.lblCheckClientInn.Name = "lblCheckClientInn";
            this.lblCheckClientInn.Size = new System.Drawing.Size(129, 13);
            this.lblCheckClientInn.TabIndex = 46;
            this.lblCheckClientInn.Text = "Введите 10 или 12 цифр";
            this.lblCheckClientInn.Visible = false;
            // 
            // tbClientInn
            // 
            this.tbClientInn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbClientInn.Location = new System.Drawing.Point(225, 119);
            this.tbClientInn.Name = "tbClientInn";
            this.tbClientInn.Size = new System.Drawing.Size(369, 23);
            this.tbClientInn.TabIndex = 29;
            this.tbClientInn.TextChanged += new System.EventHandler(this.TbClientInn_TextChanged);
            // 
            // lblCheckClientAddress
            // 
            this.lblCheckClientAddress.AutoSize = true;
            this.lblCheckClientAddress.ForeColor = System.Drawing.Color.Red;
            this.lblCheckClientAddress.Location = new System.Drawing.Point(6, 100);
            this.lblCheckClientAddress.Name = "lblCheckClientAddress";
            this.lblCheckClientAddress.Size = new System.Drawing.Size(504, 13);
            this.lblCheckClientAddress.TabIndex = 45;
            this.lblCheckClientAddress.Text = "Введите адрес заказчика от 3 до 100 символов, используя кирилицу цифры и знаки пр" +
    "епинания ";
            this.lblCheckClientAddress.Visible = false;
            // 
            // tbClientAddress
            // 
            this.tbClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbClientAddress.Location = new System.Drawing.Point(225, 74);
            this.tbClientAddress.Name = "tbClientAddress";
            this.tbClientAddress.Size = new System.Drawing.Size(369, 23);
            this.tbClientAddress.TabIndex = 27;
            this.tbClientAddress.TextChanged += new System.EventHandler(this.TbClientAddress_TextChanged);
            // 
            // lblCheckClientName
            // 
            this.lblCheckClientName.AutoSize = true;
            this.lblCheckClientName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckClientName.Location = new System.Drawing.Point(6, 53);
            this.lblCheckClientName.Name = "lblCheckClientName";
            this.lblCheckClientName.Size = new System.Drawing.Size(561, 13);
            this.lblCheckClientName.TabIndex = 44;
            this.lblCheckClientName.Text = "Введите название заказчика длиной от 3 до 100 символов, используя кирилицу цифры " +
    "и знаки препинания ";
            this.lblCheckClientName.Visible = false;
            // 
            // labelClientAddress
            // 
            this.labelClientAddress.AutoSize = true;
            this.labelClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelClientAddress.Location = new System.Drawing.Point(6, 74);
            this.labelClientAddress.Name = "labelClientAddress";
            this.labelClientAddress.Size = new System.Drawing.Size(48, 17);
            this.labelClientAddress.TabIndex = 26;
            this.labelClientAddress.Text = "Адрес";
            // 
            // pbCheckMarkClientInn
            // 
            this.pbCheckMarkClientInn.Location = new System.Drawing.Point(601, 119);
            this.pbCheckMarkClientInn.Name = "pbCheckMarkClientInn";
            this.pbCheckMarkClientInn.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkClientInn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkClientInn.TabIndex = 41;
            this.pbCheckMarkClientInn.TabStop = false;
            this.pbCheckMarkClientInn.Visible = false;
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbClientName.Location = new System.Drawing.Point(225, 26);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(369, 23);
            this.tbClientName.TabIndex = 25;
            this.tbClientName.TextChanged += new System.EventHandler(this.TbClientName_TextChanged);
            // 
            // pbCheckMarkClientAddress
            // 
            this.pbCheckMarkClientAddress.Location = new System.Drawing.Point(601, 74);
            this.pbCheckMarkClientAddress.Name = "pbCheckMarkClientAddress";
            this.pbCheckMarkClientAddress.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkClientAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkClientAddress.TabIndex = 40;
            this.pbCheckMarkClientAddress.TabStop = false;
            this.pbCheckMarkClientAddress.Visible = false;
            // 
            // pbCheckMarkClientName
            // 
            this.pbCheckMarkClientName.Location = new System.Drawing.Point(601, 24);
            this.pbCheckMarkClientName.Name = "pbCheckMarkClientName";
            this.pbCheckMarkClientName.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkClientName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkClientName.TabIndex = 39;
            this.pbCheckMarkClientName.TabStop = false;
            this.pbCheckMarkClientName.Visible = false;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateClient.Location = new System.Drawing.Point(494, 225);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(152, 42);
            this.btnUpdateClient.TabIndex = 36;
            this.btnUpdateClient.Text = "Сохранить данные заказчика";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Visible = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.BtnUpdateClient_Click);
            // 
            // tabPageWork
            // 
            this.tabPageWork.Controls.Add(this.gbWorkPanel);
            this.tabPageWork.Controls.Add(this.gbWorksInActualProject);
            this.tabPageWork.Controls.Add(this.gbAllTypesOfWork);
            this.tabPageWork.Location = new System.Drawing.Point(4, 22);
            this.tabPageWork.Name = "tabPageWork";
            this.tabPageWork.Size = new System.Drawing.Size(1900, 946);
            this.tabPageWork.TabIndex = 3;
            this.tabPageWork.Text = "Работы";
            this.tabPageWork.UseVisualStyleBackColor = true;
            // 
            // gbWorkPanel
            // 
            this.gbWorkPanel.Controls.Add(this.btnWorkSwitchCancel);
            this.gbWorkPanel.Controls.Add(this.gbTypeOfWorkData);
            this.gbWorkPanel.Controls.Add(this.gbWorkInProjectData);
            this.gbWorkPanel.Location = new System.Drawing.Point(979, 3);
            this.gbWorkPanel.Name = "gbWorkPanel";
            this.gbWorkPanel.Size = new System.Drawing.Size(752, 899);
            this.gbWorkPanel.TabIndex = 5;
            this.gbWorkPanel.TabStop = false;
            this.gbWorkPanel.Text = "Данные по виду работ";
            // 
            // btnWorkSwitchCancel
            // 
            this.btnWorkSwitchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWorkSwitchCancel.Location = new System.Drawing.Point(9, 360);
            this.btnWorkSwitchCancel.Name = "btnWorkSwitchCancel";
            this.btnWorkSwitchCancel.Size = new System.Drawing.Size(152, 42);
            this.btnWorkSwitchCancel.TabIndex = 50;
            this.btnWorkSwitchCancel.Text = "Отменить";
            this.btnWorkSwitchCancel.UseVisualStyleBackColor = true;
            this.btnWorkSwitchCancel.Visible = false;
            this.btnWorkSwitchCancel.Click += new System.EventHandler(this.BtnWorkSwitchCancel_Click);
            // 
            // gbTypeOfWorkData
            // 
            this.gbTypeOfWorkData.Controls.Add(this.btnTypeOfWorkUpdate);
            this.gbTypeOfWorkData.Controls.Add(this.btnTypeOfWorkCreate);
            this.gbTypeOfWorkData.Controls.Add(this.cbTypeOfWorkDimension);
            this.gbTypeOfWorkData.Controls.Add(this.tbTypeOfWorkMeasureUnit);
            this.gbTypeOfWorkData.Controls.Add(this.lblCheckTypeOfWorkMeasureUnit);
            this.gbTypeOfWorkData.Controls.Add(this.labelMeasureUnitTypeOfWork);
            this.gbTypeOfWorkData.Controls.Add(this.pbCheckMarkTypeOfWorkMeasureUnit);
            this.gbTypeOfWorkData.Controls.Add(this.labelNameTypeOfWork);
            this.gbTypeOfWorkData.Controls.Add(this.lblCheckTypeOfWorkDimension);
            this.gbTypeOfWorkData.Controls.Add(this.lblCheckTypeOfWorkName);
            this.gbTypeOfWorkData.Controls.Add(this.lblDimensionTypeOfWork);
            this.gbTypeOfWorkData.Controls.Add(this.tbTypeOfWorkName);
            this.gbTypeOfWorkData.Controls.Add(this.pbCheckMarkTypeOfWorkDimension);
            this.gbTypeOfWorkData.Controls.Add(this.pbCheckMarkTypeOfWorkName);
            this.gbTypeOfWorkData.Enabled = false;
            this.gbTypeOfWorkData.Location = new System.Drawing.Point(9, 19);
            this.gbTypeOfWorkData.Name = "gbTypeOfWorkData";
            this.gbTypeOfWorkData.Size = new System.Drawing.Size(728, 217);
            this.gbTypeOfWorkData.TabIndex = 49;
            this.gbTypeOfWorkData.TabStop = false;
            // 
            // btnTypeOfWorkUpdate
            // 
            this.btnTypeOfWorkUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTypeOfWorkUpdate.Location = new System.Drawing.Point(412, 171);
            this.btnTypeOfWorkUpdate.Name = "btnTypeOfWorkUpdate";
            this.btnTypeOfWorkUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnTypeOfWorkUpdate.TabIndex = 51;
            this.btnTypeOfWorkUpdate.Text = "Сохранить изменения";
            this.btnTypeOfWorkUpdate.UseVisualStyleBackColor = true;
            this.btnTypeOfWorkUpdate.Visible = false;
            this.btnTypeOfWorkUpdate.Click += new System.EventHandler(this.BtnTypeOfWorkUpdate_Click);
            // 
            // btnTypeOfWorkCreate
            // 
            this.btnTypeOfWorkCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTypeOfWorkCreate.Location = new System.Drawing.Point(570, 171);
            this.btnTypeOfWorkCreate.Name = "btnTypeOfWorkCreate";
            this.btnTypeOfWorkCreate.Size = new System.Drawing.Size(152, 42);
            this.btnTypeOfWorkCreate.TabIndex = 48;
            this.btnTypeOfWorkCreate.Text = "Сохранить новый вид работ ";
            this.btnTypeOfWorkCreate.UseVisualStyleBackColor = true;
            this.btnTypeOfWorkCreate.Visible = false;
            this.btnTypeOfWorkCreate.Click += new System.EventHandler(this.BtnTypeOfWorkCreate_Click);
            // 
            // cbTypeOfWorkDimension
            // 
            this.cbTypeOfWorkDimension.FormattingEnabled = true;
            this.cbTypeOfWorkDimension.Location = new System.Drawing.Point(225, 77);
            this.cbTypeOfWorkDimension.Name = "cbTypeOfWorkDimension";
            this.cbTypeOfWorkDimension.Size = new System.Drawing.Size(369, 21);
            this.cbTypeOfWorkDimension.TabIndex = 52;
            this.cbTypeOfWorkDimension.SelectedIndexChanged += new System.EventHandler(this.CbTypeOfWorkDimension_SelectedIndexChanged);
            // 
            // tbTypeOfWorkMeasureUnit
            // 
            this.tbTypeOfWorkMeasureUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTypeOfWorkMeasureUnit.Location = new System.Drawing.Point(225, 124);
            this.tbTypeOfWorkMeasureUnit.Name = "tbTypeOfWorkMeasureUnit";
            this.tbTypeOfWorkMeasureUnit.Size = new System.Drawing.Size(369, 23);
            this.tbTypeOfWorkMeasureUnit.TabIndex = 51;
            this.tbTypeOfWorkMeasureUnit.TextChanged += new System.EventHandler(this.TbTypeOfWorkMeasureUnit_TextChanged);
            // 
            // lblCheckTypeOfWorkMeasureUnit
            // 
            this.lblCheckTypeOfWorkMeasureUnit.AutoSize = true;
            this.lblCheckTypeOfWorkMeasureUnit.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTypeOfWorkMeasureUnit.Location = new System.Drawing.Point(6, 150);
            this.lblCheckTypeOfWorkMeasureUnit.Name = "lblCheckTypeOfWorkMeasureUnit";
            this.lblCheckTypeOfWorkMeasureUnit.Size = new System.Drawing.Size(517, 13);
            this.lblCheckTypeOfWorkMeasureUnit.TabIndex = 50;
            this.lblCheckTypeOfWorkMeasureUnit.Text = "Введите данные в формате: 0000 000000 01.01.2000 г название подразделения выдавше" +
    "го паспорт";
            this.lblCheckTypeOfWorkMeasureUnit.Visible = false;
            // 
            // labelMeasureUnitTypeOfWork
            // 
            this.labelMeasureUnitTypeOfWork.AutoSize = true;
            this.labelMeasureUnitTypeOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMeasureUnitTypeOfWork.Location = new System.Drawing.Point(6, 124);
            this.labelMeasureUnitTypeOfWork.Name = "labelMeasureUnitTypeOfWork";
            this.labelMeasureUnitTypeOfWork.Size = new System.Drawing.Size(143, 17);
            this.labelMeasureUnitTypeOfWork.TabIndex = 48;
            this.labelMeasureUnitTypeOfWork.Text = "Еденицы измерения";
            // 
            // pbCheckMarkTypeOfWorkMeasureUnit
            // 
            this.pbCheckMarkTypeOfWorkMeasureUnit.Location = new System.Drawing.Point(601, 124);
            this.pbCheckMarkTypeOfWorkMeasureUnit.Name = "pbCheckMarkTypeOfWorkMeasureUnit";
            this.pbCheckMarkTypeOfWorkMeasureUnit.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfWorkMeasureUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfWorkMeasureUnit.TabIndex = 49;
            this.pbCheckMarkTypeOfWorkMeasureUnit.TabStop = false;
            this.pbCheckMarkTypeOfWorkMeasureUnit.Visible = false;
            // 
            // labelNameTypeOfWork
            // 
            this.labelNameTypeOfWork.AutoSize = true;
            this.labelNameTypeOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameTypeOfWork.Location = new System.Drawing.Point(6, 26);
            this.labelNameTypeOfWork.Name = "labelNameTypeOfWork";
            this.labelNameTypeOfWork.Size = new System.Drawing.Size(150, 17);
            this.labelNameTypeOfWork.TabIndex = 24;
            this.labelNameTypeOfWork.Text = "Название типа работ";
            // 
            // lblCheckTypeOfWorkDimension
            // 
            this.lblCheckTypeOfWorkDimension.AutoSize = true;
            this.lblCheckTypeOfWorkDimension.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTypeOfWorkDimension.Location = new System.Drawing.Point(6, 100);
            this.lblCheckTypeOfWorkDimension.Name = "lblCheckTypeOfWorkDimension";
            this.lblCheckTypeOfWorkDimension.Size = new System.Drawing.Size(517, 13);
            this.lblCheckTypeOfWorkDimension.TabIndex = 45;
            this.lblCheckTypeOfWorkDimension.Text = "Введите данные в формате: 0000 000000 01.01.2000 г название подразделения выдавше" +
    "го паспорт";
            this.lblCheckTypeOfWorkDimension.Visible = false;
            // 
            // lblCheckTypeOfWorkName
            // 
            this.lblCheckTypeOfWorkName.AutoSize = true;
            this.lblCheckTypeOfWorkName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTypeOfWorkName.Location = new System.Drawing.Point(6, 53);
            this.lblCheckTypeOfWorkName.Name = "lblCheckTypeOfWorkName";
            this.lblCheckTypeOfWorkName.Size = new System.Drawing.Size(299, 13);
            this.lblCheckTypeOfWorkName.TabIndex = 44;
            this.lblCheckTypeOfWorkName.Text = "Введите ФИО кирилицей с заглавных букв через пробел";
            this.lblCheckTypeOfWorkName.Visible = false;
            // 
            // lblDimensionTypeOfWork
            // 
            this.lblDimensionTypeOfWork.AutoSize = true;
            this.lblDimensionTypeOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDimensionTypeOfWork.Location = new System.Drawing.Point(6, 74);
            this.lblDimensionTypeOfWork.Name = "lblDimensionTypeOfWork";
            this.lblDimensionTypeOfWork.Size = new System.Drawing.Size(150, 17);
            this.lblDimensionTypeOfWork.TabIndex = 26;
            this.lblDimensionTypeOfWork.Text = "Параметр измерения";
            // 
            // tbTypeOfWorkName
            // 
            this.tbTypeOfWorkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTypeOfWorkName.Location = new System.Drawing.Point(225, 26);
            this.tbTypeOfWorkName.Name = "tbTypeOfWorkName";
            this.tbTypeOfWorkName.Size = new System.Drawing.Size(369, 23);
            this.tbTypeOfWorkName.TabIndex = 25;
            this.tbTypeOfWorkName.TextChanged += new System.EventHandler(this.TbTypeOfWorkName_TextChanged);
            // 
            // pbCheckMarkTypeOfWorkDimension
            // 
            this.pbCheckMarkTypeOfWorkDimension.Location = new System.Drawing.Point(601, 74);
            this.pbCheckMarkTypeOfWorkDimension.Name = "pbCheckMarkTypeOfWorkDimension";
            this.pbCheckMarkTypeOfWorkDimension.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfWorkDimension.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfWorkDimension.TabIndex = 40;
            this.pbCheckMarkTypeOfWorkDimension.TabStop = false;
            this.pbCheckMarkTypeOfWorkDimension.Visible = false;
            // 
            // pbCheckMarkTypeOfWorkName
            // 
            this.pbCheckMarkTypeOfWorkName.Location = new System.Drawing.Point(601, 24);
            this.pbCheckMarkTypeOfWorkName.Name = "pbCheckMarkTypeOfWorkName";
            this.pbCheckMarkTypeOfWorkName.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfWorkName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfWorkName.TabIndex = 39;
            this.pbCheckMarkTypeOfWorkName.TabStop = false;
            this.pbCheckMarkTypeOfWorkName.Visible = false;
            // 
            // gbWorkInProjectData
            // 
            this.gbWorkInProjectData.Controls.Add(this.btnWorkInProjectChangeMultiplicity);
            this.gbWorkInProjectData.Controls.Add(this.btnWorkInProjectUpdate);
            this.gbWorkInProjectData.Controls.Add(this.labelPriceWorkInProject);
            this.gbWorkInProjectData.Controls.Add(this.btnWorkInProjectCreate);
            this.gbWorkInProjectData.Controls.Add(this.tbWorkInProjectPrice);
            this.gbWorkInProjectData.Controls.Add(this.labelMultiplicityWorkInProject);
            this.gbWorkInProjectData.Controls.Add(this.tbWorkInProjectMultiplicity);
            this.gbWorkInProjectData.Controls.Add(this.lblWorkInProjectCheckMultiplicity);
            this.gbWorkInProjectData.Controls.Add(this.pbCheckMarkWorkInProjectMultiplicity);
            this.gbWorkInProjectData.Controls.Add(this.lblWorkInProjectCheckPrice);
            this.gbWorkInProjectData.Controls.Add(this.pbCheckMarkWorkInProjectPrice);
            this.gbWorkInProjectData.Location = new System.Drawing.Point(9, 190);
            this.gbWorkInProjectData.Name = "gbWorkInProjectData";
            this.gbWorkInProjectData.Size = new System.Drawing.Size(728, 161);
            this.gbWorkInProjectData.TabIndex = 48;
            this.gbWorkInProjectData.TabStop = false;
            this.gbWorkInProjectData.Visible = false;
            // 
            // btnWorkInProjectChangeMultiplicity
            // 
            this.btnWorkInProjectChangeMultiplicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWorkInProjectChangeMultiplicity.Location = new System.Drawing.Point(9, 103);
            this.btnWorkInProjectChangeMultiplicity.Name = "btnWorkInProjectChangeMultiplicity";
            this.btnWorkInProjectChangeMultiplicity.Size = new System.Drawing.Size(152, 28);
            this.btnWorkInProjectChangeMultiplicity.TabIndex = 49;
            this.btnWorkInProjectChangeMultiplicity.Text = "Изменить кратность";
            this.btnWorkInProjectChangeMultiplicity.UseVisualStyleBackColor = true;
            this.btnWorkInProjectChangeMultiplicity.Click += new System.EventHandler(this.BtnWorkInProjectChangeMultiplicity_Click);
            // 
            // btnWorkInProjectUpdate
            // 
            this.btnWorkInProjectUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWorkInProjectUpdate.Location = new System.Drawing.Point(412, 111);
            this.btnWorkInProjectUpdate.Name = "btnWorkInProjectUpdate";
            this.btnWorkInProjectUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnWorkInProjectUpdate.TabIndex = 48;
            this.btnWorkInProjectUpdate.Text = "Сохранить изменения";
            this.btnWorkInProjectUpdate.UseVisualStyleBackColor = true;
            this.btnWorkInProjectUpdate.Visible = false;
            this.btnWorkInProjectUpdate.Click += new System.EventHandler(this.BtnWorkInProjectUpdate_Click);
            // 
            // labelPriceWorkInProject
            // 
            this.labelPriceWorkInProject.AutoSize = true;
            this.labelPriceWorkInProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPriceWorkInProject.Location = new System.Drawing.Point(6, 25);
            this.labelPriceWorkInProject.Name = "labelPriceWorkInProject";
            this.labelPriceWorkInProject.Size = new System.Drawing.Size(197, 17);
            this.labelPriceWorkInProject.TabIndex = 30;
            this.labelPriceWorkInProject.Text = "Цена за еденицу измерения";
            // 
            // btnWorkInProjectCreate
            // 
            this.btnWorkInProjectCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWorkInProjectCreate.Location = new System.Drawing.Point(570, 111);
            this.btnWorkInProjectCreate.Name = "btnWorkInProjectCreate";
            this.btnWorkInProjectCreate.Size = new System.Drawing.Size(152, 42);
            this.btnWorkInProjectCreate.TabIndex = 47;
            this.btnWorkInProjectCreate.Text = "Добавить работу в текущий проект";
            this.btnWorkInProjectCreate.UseVisualStyleBackColor = true;
            this.btnWorkInProjectCreate.Visible = false;
            this.btnWorkInProjectCreate.Click += new System.EventHandler(this.BtnWorkInProjectCreate_Click);
            // 
            // tbWorkInProjectPrice
            // 
            this.tbWorkInProjectPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbWorkInProjectPrice.Location = new System.Drawing.Point(225, 25);
            this.tbWorkInProjectPrice.Name = "tbWorkInProjectPrice";
            this.tbWorkInProjectPrice.Size = new System.Drawing.Size(369, 23);
            this.tbWorkInProjectPrice.TabIndex = 31;
            this.tbWorkInProjectPrice.TextChanged += new System.EventHandler(this.TbWorkInProjectPrice_TextChanged);
            // 
            // labelMultiplicityWorkInProject
            // 
            this.labelMultiplicityWorkInProject.AutoSize = true;
            this.labelMultiplicityWorkInProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMultiplicityWorkInProject.Location = new System.Drawing.Point(6, 80);
            this.labelMultiplicityWorkInProject.Name = "labelMultiplicityWorkInProject";
            this.labelMultiplicityWorkInProject.Size = new System.Drawing.Size(153, 17);
            this.labelMultiplicityWorkInProject.TabIndex = 32;
            this.labelMultiplicityWorkInProject.Text = "Кратность параметра";
            // 
            // tbWorkInProjectMultiplicity
            // 
            this.tbWorkInProjectMultiplicity.BackColor = System.Drawing.SystemColors.Window;
            this.tbWorkInProjectMultiplicity.Enabled = false;
            this.tbWorkInProjectMultiplicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbWorkInProjectMultiplicity.Location = new System.Drawing.Point(225, 80);
            this.tbWorkInProjectMultiplicity.Name = "tbWorkInProjectMultiplicity";
            this.tbWorkInProjectMultiplicity.Size = new System.Drawing.Size(369, 23);
            this.tbWorkInProjectMultiplicity.TabIndex = 33;
            this.tbWorkInProjectMultiplicity.TextChanged += new System.EventHandler(this.TbWorkInProjectMultiplicity_TextChanged);
            // 
            // lblWorkInProjectCheckMultiplicity
            // 
            this.lblWorkInProjectCheckMultiplicity.AutoSize = true;
            this.lblWorkInProjectCheckMultiplicity.ForeColor = System.Drawing.Color.Red;
            this.lblWorkInProjectCheckMultiplicity.Location = new System.Drawing.Point(222, 111);
            this.lblWorkInProjectCheckMultiplicity.Name = "lblWorkInProjectCheckMultiplicity";
            this.lblWorkInProjectCheckMultiplicity.Size = new System.Drawing.Size(176, 13);
            this.lblWorkInProjectCheckMultiplicity.TabIndex = 37;
            this.lblWorkInProjectCheckMultiplicity.Text = "Введенные пароли не совпадают";
            this.lblWorkInProjectCheckMultiplicity.Visible = false;
            // 
            // pbCheckMarkWorkInProjectMultiplicity
            // 
            this.pbCheckMarkWorkInProjectMultiplicity.Location = new System.Drawing.Point(601, 80);
            this.pbCheckMarkWorkInProjectMultiplicity.Name = "pbCheckMarkWorkInProjectMultiplicity";
            this.pbCheckMarkWorkInProjectMultiplicity.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkWorkInProjectMultiplicity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkWorkInProjectMultiplicity.TabIndex = 43;
            this.pbCheckMarkWorkInProjectMultiplicity.TabStop = false;
            this.pbCheckMarkWorkInProjectMultiplicity.Visible = false;
            // 
            // lblWorkInProjectCheckPrice
            // 
            this.lblWorkInProjectCheckPrice.AutoSize = true;
            this.lblWorkInProjectCheckPrice.ForeColor = System.Drawing.Color.Red;
            this.lblWorkInProjectCheckPrice.Location = new System.Drawing.Point(6, 53);
            this.lblWorkInProjectCheckPrice.Name = "lblWorkInProjectCheckPrice";
            this.lblWorkInProjectCheckPrice.Size = new System.Drawing.Size(631, 13);
            this.lblWorkInProjectCheckPrice.TabIndex = 38;
            this.lblWorkInProjectCheckPrice.Text = "Введите пароль от 8 до 16 символов, содержащий не меннее 1 цифры, одной заглавной" +
    " и одной строчной латинских букв";
            this.lblWorkInProjectCheckPrice.Visible = false;
            // 
            // pbCheckMarkWorkInProjectPrice
            // 
            this.pbCheckMarkWorkInProjectPrice.Location = new System.Drawing.Point(601, 25);
            this.pbCheckMarkWorkInProjectPrice.Name = "pbCheckMarkWorkInProjectPrice";
            this.pbCheckMarkWorkInProjectPrice.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkWorkInProjectPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkWorkInProjectPrice.TabIndex = 42;
            this.pbCheckMarkWorkInProjectPrice.TabStop = false;
            this.pbCheckMarkWorkInProjectPrice.Visible = false;
            // 
            // gbWorksInActualProject
            // 
            this.gbWorksInActualProject.Controls.Add(this.lblWorksActualProjectNotSaved);
            this.gbWorksInActualProject.Controls.Add(this.dgvWorksInActualProject);
            this.gbWorksInActualProject.Controls.Add(this.btnWorkInProjectDelete);
            this.gbWorksInActualProject.Controls.Add(this.btnWorkInProjectSwitchUpdate);
            this.gbWorksInActualProject.Location = new System.Drawing.Point(3, 401);
            this.gbWorksInActualProject.Name = "gbWorksInActualProject";
            this.gbWorksInActualProject.Size = new System.Drawing.Size(968, 501);
            this.gbWorksInActualProject.TabIndex = 4;
            this.gbWorksInActualProject.TabStop = false;
            this.gbWorksInActualProject.Text = "Работы текущего проекта";
            // 
            // lblWorksActualProjectNotSaved
            // 
            this.lblWorksActualProjectNotSaved.AutoSize = true;
            this.lblWorksActualProjectNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWorksActualProjectNotSaved.ForeColor = System.Drawing.Color.Red;
            this.lblWorksActualProjectNotSaved.Location = new System.Drawing.Point(6, 19);
            this.lblWorksActualProjectNotSaved.Name = "lblWorksActualProjectNotSaved";
            this.lblWorksActualProjectNotSaved.Size = new System.Drawing.Size(201, 17);
            this.lblWorksActualProjectNotSaved.TabIndex = 61;
            this.lblWorksActualProjectNotSaved.Text = "Текущий проект не сохранен";
            this.lblWorksActualProjectNotSaved.Visible = false;
            // 
            // dgvWorksInActualProject
            // 
            this.dgvWorksInActualProject.AllowUserToAddRows = false;
            this.dgvWorksInActualProject.AllowUserToDeleteRows = false;
            this.dgvWorksInActualProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksInActualProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.ColumnWorkInProjectPrice,
            this.ColumnWorkInProjectMultiplicity});
            this.dgvWorksInActualProject.Location = new System.Drawing.Point(5, 50);
            this.dgvWorksInActualProject.Name = "dgvWorksInActualProject";
            this.dgvWorksInActualProject.ReadOnly = true;
            this.dgvWorksInActualProject.RowHeadersVisible = false;
            this.dgvWorksInActualProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorksInActualProject.Size = new System.Drawing.Size(956, 27);
            this.dgvWorksInActualProject.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Название";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 370;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Параметр измерения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Еденицы измерения";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // ColumnWorkInProjectPrice
            // 
            this.ColumnWorkInProjectPrice.HeaderText = "Цена";
            this.ColumnWorkInProjectPrice.Name = "ColumnWorkInProjectPrice";
            this.ColumnWorkInProjectPrice.ReadOnly = true;
            // 
            // ColumnWorkInProjectMultiplicity
            // 
            this.ColumnWorkInProjectMultiplicity.HeaderText = "Кратность параметра";
            this.ColumnWorkInProjectMultiplicity.Name = "ColumnWorkInProjectMultiplicity";
            this.ColumnWorkInProjectMultiplicity.ReadOnly = true;
            this.ColumnWorkInProjectMultiplicity.Width = 150;
            // 
            // btnWorkInProjectDelete
            // 
            this.btnWorkInProjectDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWorkInProjectDelete.Location = new System.Drawing.Point(792, 18);
            this.btnWorkInProjectDelete.Name = "btnWorkInProjectDelete";
            this.btnWorkInProjectDelete.Size = new System.Drawing.Size(169, 26);
            this.btnWorkInProjectDelete.TabIndex = 59;
            this.btnWorkInProjectDelete.Text = "Удалить работу";
            this.btnWorkInProjectDelete.UseVisualStyleBackColor = true;
            this.btnWorkInProjectDelete.Click += new System.EventHandler(this.BtnWorkInProjectDelete_Click);
            // 
            // btnWorkInProjectSwitchUpdate
            // 
            this.btnWorkInProjectSwitchUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorkInProjectSwitchUpdate.Location = new System.Drawing.Point(626, 19);
            this.btnWorkInProjectSwitchUpdate.Name = "btnWorkInProjectSwitchUpdate";
            this.btnWorkInProjectSwitchUpdate.Size = new System.Drawing.Size(132, 25);
            this.btnWorkInProjectSwitchUpdate.TabIndex = 11;
            this.btnWorkInProjectSwitchUpdate.Text = "Редактировать работу";
            this.btnWorkInProjectSwitchUpdate.UseVisualStyleBackColor = true;
            this.btnWorkInProjectSwitchUpdate.Click += new System.EventHandler(this.BtnWorkInProjectSwitchUpdate_Click);
            // 
            // gbAllTypesOfWork
            // 
            this.gbAllTypesOfWork.Controls.Add(this.checkBox2);
            this.gbAllTypesOfWork.Controls.Add(this.btnWorkInProjectSwitchCreate);
            this.gbAllTypesOfWork.Controls.Add(this.btnTypeOfWorkDelete);
            this.gbAllTypesOfWork.Controls.Add(this.btnTypeOfWorkSwitchUpdate);
            this.gbAllTypesOfWork.Controls.Add(this.btnTypeOfWorkSwitchCreate);
            this.gbAllTypesOfWork.Controls.Add(this.dgvAllTypesOfWork);
            this.gbAllTypesOfWork.Location = new System.Drawing.Point(3, 3);
            this.gbAllTypesOfWork.Name = "gbAllTypesOfWork";
            this.gbAllTypesOfWork.Size = new System.Drawing.Size(968, 392);
            this.gbAllTypesOfWork.TabIndex = 3;
            this.gbAllTypesOfWork.TabStop = false;
            this.gbAllTypesOfWork.Text = "Все виды работ";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(852, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Скрыть";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnWorkInProjectSwitchCreate
            // 
            this.btnWorkInProjectSwitchCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorkInProjectSwitchCreate.Location = new System.Drawing.Point(852, 218);
            this.btnWorkInProjectSwitchCreate.Name = "btnWorkInProjectSwitchCreate";
            this.btnWorkInProjectSwitchCreate.Size = new System.Drawing.Size(110, 49);
            this.btnWorkInProjectSwitchCreate.TabIndex = 12;
            this.btnWorkInProjectSwitchCreate.Text = "Добавить работу в проект";
            this.btnWorkInProjectSwitchCreate.UseVisualStyleBackColor = true;
            this.btnWorkInProjectSwitchCreate.Click += new System.EventHandler(this.BtnWorkInProjectSwitchCreate_Click);
            // 
            // btnTypeOfWorkDelete
            // 
            this.btnTypeOfWorkDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeOfWorkDelete.Location = new System.Drawing.Point(851, 169);
            this.btnTypeOfWorkDelete.Name = "btnTypeOfWorkDelete";
            this.btnTypeOfWorkDelete.Size = new System.Drawing.Size(110, 35);
            this.btnTypeOfWorkDelete.TabIndex = 10;
            this.btnTypeOfWorkDelete.Text = "Удалить вид работ";
            this.btnTypeOfWorkDelete.UseVisualStyleBackColor = true;
            this.btnTypeOfWorkDelete.Click += new System.EventHandler(this.BtnTypeOfWorkDelete_Click);
            // 
            // btnTypeOfWorkSwitchUpdate
            // 
            this.btnTypeOfWorkSwitchUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeOfWorkSwitchUpdate.Location = new System.Drawing.Point(852, 111);
            this.btnTypeOfWorkSwitchUpdate.Name = "btnTypeOfWorkSwitchUpdate";
            this.btnTypeOfWorkSwitchUpdate.Size = new System.Drawing.Size(110, 49);
            this.btnTypeOfWorkSwitchUpdate.TabIndex = 9;
            this.btnTypeOfWorkSwitchUpdate.Text = "Редактировать вид работ";
            this.btnTypeOfWorkSwitchUpdate.UseVisualStyleBackColor = true;
            this.btnTypeOfWorkSwitchUpdate.Click += new System.EventHandler(this.BtnTypeOfWorkSwitchUpdate_Click);
            // 
            // btnTypeOfWorkSwitchCreate
            // 
            this.btnTypeOfWorkSwitchCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeOfWorkSwitchCreate.Location = new System.Drawing.Point(852, 56);
            this.btnTypeOfWorkSwitchCreate.Name = "btnTypeOfWorkSwitchCreate";
            this.btnTypeOfWorkSwitchCreate.Size = new System.Drawing.Size(110, 49);
            this.btnTypeOfWorkSwitchCreate.TabIndex = 8;
            this.btnTypeOfWorkSwitchCreate.Text = "Добавить новый вид работ";
            this.btnTypeOfWorkSwitchCreate.UseVisualStyleBackColor = true;
            this.btnTypeOfWorkSwitchCreate.Click += new System.EventHandler(this.BtnTypeOfWorkSwitchCreate_Click);
            // 
            // dgvAllTypesOfWork
            // 
            this.dgvAllTypesOfWork.AllowUserToAddRows = false;
            this.dgvAllTypesOfWork.AllowUserToDeleteRows = false;
            this.dgvAllTypesOfWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTypesOfWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvAllTypesOfWork.Location = new System.Drawing.Point(5, 19);
            this.dgvAllTypesOfWork.Name = "dgvAllTypesOfWork";
            this.dgvAllTypesOfWork.ReadOnly = true;
            this.dgvAllTypesOfWork.RowHeadersVisible = false;
            this.dgvAllTypesOfWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTypesOfWork.Size = new System.Drawing.Size(828, 27);
            this.dgvAllTypesOfWork.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Название";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 400;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Параметр измерения";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Еденицы измерения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 195;
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.Controls.Add(this.gbPaymentPanel);
            this.tabPagePayment.Controls.Add(this.gbPaymentsInActualProject);
            this.tabPagePayment.Controls.Add(this.gbAllPayments);
            this.tabPagePayment.Location = new System.Drawing.Point(4, 22);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Size = new System.Drawing.Size(1900, 946);
            this.tabPagePayment.TabIndex = 4;
            this.tabPagePayment.Text = "Оплата";
            this.tabPagePayment.UseVisualStyleBackColor = true;
            // 
            // gbPaymentPanel
            // 
            this.gbPaymentPanel.Controls.Add(this.gbPaymentData);
            this.gbPaymentPanel.Location = new System.Drawing.Point(977, 3);
            this.gbPaymentPanel.Name = "gbPaymentPanel";
            this.gbPaymentPanel.Size = new System.Drawing.Size(752, 899);
            this.gbPaymentPanel.TabIndex = 6;
            this.gbPaymentPanel.TabStop = false;
            this.gbPaymentPanel.Text = "Данные по виду работ";
            // 
            // gbPaymentData
            // 
            this.gbPaymentData.Controls.Add(this.tbPaymentDate);
            this.gbPaymentData.Controls.Add(this.lblCheckPaymentDate);
            this.gbPaymentData.Controls.Add(this.tbPaymentUser);
            this.gbPaymentData.Controls.Add(this.pbCheckMarkPaymentDate);
            this.gbPaymentData.Controls.Add(this.lblPaymentDate);
            this.gbPaymentData.Controls.Add(this.dtpPaymentDate);
            this.gbPaymentData.Controls.Add(this.btnPaymentSwitchCancel);
            this.gbPaymentData.Controls.Add(this.btnPaymentUpdate);
            this.gbPaymentData.Controls.Add(this.btnPaymentCreate);
            this.gbPaymentData.Controls.Add(this.tbPaymentAmout);
            this.gbPaymentData.Controls.Add(this.lblCheckPaymentAmount);
            this.gbPaymentData.Controls.Add(this.lblPaymentAmount);
            this.gbPaymentData.Controls.Add(this.pbCheckMarkPaymentAmount);
            this.gbPaymentData.Controls.Add(this.lblPaymentProject);
            this.gbPaymentData.Controls.Add(this.lblPaymentUser);
            this.gbPaymentData.Controls.Add(this.tbPaymentProject);
            this.gbPaymentData.Enabled = false;
            this.gbPaymentData.Location = new System.Drawing.Point(9, 19);
            this.gbPaymentData.Name = "gbPaymentData";
            this.gbPaymentData.Size = new System.Drawing.Size(728, 263);
            this.gbPaymentData.TabIndex = 49;
            this.gbPaymentData.TabStop = false;
            // 
            // tbPaymentDate
            // 
            this.tbPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPaymentDate.Location = new System.Drawing.Point(225, 118);
            this.tbPaymentDate.Name = "tbPaymentDate";
            this.tbPaymentDate.ReadOnly = true;
            this.tbPaymentDate.Size = new System.Drawing.Size(369, 23);
            this.tbPaymentDate.TabIndex = 58;
            this.tbPaymentDate.Click += new System.EventHandler(this.TbPaymentDate_Click);
            // 
            // lblCheckPaymentDate
            // 
            this.lblCheckPaymentDate.AutoSize = true;
            this.lblCheckPaymentDate.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPaymentDate.Location = new System.Drawing.Point(6, 150);
            this.lblCheckPaymentDate.Name = "lblCheckPaymentDate";
            this.lblCheckPaymentDate.Size = new System.Drawing.Size(295, 13);
            this.lblCheckPaymentDate.TabIndex = 57;
            this.lblCheckPaymentDate.Text = "Дата оплаты не может быть ранее даты начала проекта";
            this.lblCheckPaymentDate.Visible = false;
            // 
            // tbPaymentUser
            // 
            this.tbPaymentUser.Enabled = false;
            this.tbPaymentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPaymentUser.Location = new System.Drawing.Point(225, 74);
            this.tbPaymentUser.Name = "tbPaymentUser";
            this.tbPaymentUser.ReadOnly = true;
            this.tbPaymentUser.Size = new System.Drawing.Size(369, 23);
            this.tbPaymentUser.TabIndex = 56;
            // 
            // pbCheckMarkPaymentDate
            // 
            this.pbCheckMarkPaymentDate.Location = new System.Drawing.Point(601, 115);
            this.pbCheckMarkPaymentDate.Name = "pbCheckMarkPaymentDate";
            this.pbCheckMarkPaymentDate.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkPaymentDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkPaymentDate.TabIndex = 55;
            this.pbCheckMarkPaymentDate.TabStop = false;
            this.pbCheckMarkPaymentDate.Visible = false;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaymentDate.Location = new System.Drawing.Point(6, 124);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(95, 17);
            this.lblPaymentDate.TabIndex = 54;
            this.lblPaymentDate.Text = "Дата оплаты";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(225, 120);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPaymentDate.TabIndex = 53;
            this.dtpPaymentDate.Visible = false;
            this.dtpPaymentDate.ValueChanged += new System.EventHandler(this.DtpPaymentDate_ValueChanged);
            // 
            // btnPaymentSwitchCancel
            // 
            this.btnPaymentSwitchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPaymentSwitchCancel.Location = new System.Drawing.Point(9, 212);
            this.btnPaymentSwitchCancel.Name = "btnPaymentSwitchCancel";
            this.btnPaymentSwitchCancel.Size = new System.Drawing.Size(152, 42);
            this.btnPaymentSwitchCancel.TabIndex = 50;
            this.btnPaymentSwitchCancel.Text = "Отменить";
            this.btnPaymentSwitchCancel.UseVisualStyleBackColor = true;
            this.btnPaymentSwitchCancel.Visible = false;
            this.btnPaymentSwitchCancel.Click += new System.EventHandler(this.BtnPaymentSwitchCancel_Click);
            // 
            // btnPaymentUpdate
            // 
            this.btnPaymentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPaymentUpdate.Location = new System.Drawing.Point(413, 212);
            this.btnPaymentUpdate.Name = "btnPaymentUpdate";
            this.btnPaymentUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnPaymentUpdate.TabIndex = 51;
            this.btnPaymentUpdate.Text = "Сохранить изменения";
            this.btnPaymentUpdate.UseVisualStyleBackColor = true;
            this.btnPaymentUpdate.Visible = false;
            this.btnPaymentUpdate.Click += new System.EventHandler(this.BtnPaymentUpdate_Click);
            // 
            // btnPaymentCreate
            // 
            this.btnPaymentCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPaymentCreate.Location = new System.Drawing.Point(571, 212);
            this.btnPaymentCreate.Name = "btnPaymentCreate";
            this.btnPaymentCreate.Size = new System.Drawing.Size(152, 42);
            this.btnPaymentCreate.TabIndex = 48;
            this.btnPaymentCreate.Text = "Сохранить оплату";
            this.btnPaymentCreate.UseVisualStyleBackColor = true;
            this.btnPaymentCreate.Visible = false;
            this.btnPaymentCreate.Click += new System.EventHandler(this.BtnPaymentCreate_Click);
            // 
            // tbPaymentAmout
            // 
            this.tbPaymentAmout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPaymentAmout.Location = new System.Drawing.Point(225, 168);
            this.tbPaymentAmout.Name = "tbPaymentAmout";
            this.tbPaymentAmout.Size = new System.Drawing.Size(369, 23);
            this.tbPaymentAmout.TabIndex = 51;
            this.tbPaymentAmout.TextChanged += new System.EventHandler(this.TbPaymentAmout_TextChanged);
            // 
            // lblCheckPaymentAmount
            // 
            this.lblCheckPaymentAmount.AutoSize = true;
            this.lblCheckPaymentAmount.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPaymentAmount.Location = new System.Drawing.Point(6, 194);
            this.lblCheckPaymentAmount.Name = "lblCheckPaymentAmount";
            this.lblCheckPaymentAmount.Size = new System.Drawing.Size(413, 13);
            this.lblCheckPaymentAmount.TabIndex = 50;
            this.lblCheckPaymentAmount.Text = "Введите сумму оплаты с точкой разделителем и двумя знаками после запятой";
            this.lblCheckPaymentAmount.Visible = false;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaymentAmount.Location = new System.Drawing.Point(6, 168);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(103, 17);
            this.lblPaymentAmount.TabIndex = 48;
            this.lblPaymentAmount.Text = "Сумма оплаты";
            // 
            // pbCheckMarkPaymentAmount
            // 
            this.pbCheckMarkPaymentAmount.Location = new System.Drawing.Point(601, 167);
            this.pbCheckMarkPaymentAmount.Name = "pbCheckMarkPaymentAmount";
            this.pbCheckMarkPaymentAmount.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkPaymentAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkPaymentAmount.TabIndex = 49;
            this.pbCheckMarkPaymentAmount.TabStop = false;
            this.pbCheckMarkPaymentAmount.Visible = false;
            // 
            // lblPaymentProject
            // 
            this.lblPaymentProject.AutoSize = true;
            this.lblPaymentProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaymentProject.Location = new System.Drawing.Point(6, 26);
            this.lblPaymentProject.Name = "lblPaymentProject";
            this.lblPaymentProject.Size = new System.Drawing.Size(56, 17);
            this.lblPaymentProject.TabIndex = 24;
            this.lblPaymentProject.Text = "Проект";
            // 
            // lblPaymentUser
            // 
            this.lblPaymentUser.AutoSize = true;
            this.lblPaymentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaymentUser.Location = new System.Drawing.Point(6, 74);
            this.lblPaymentUser.Name = "lblPaymentUser";
            this.lblPaymentUser.Size = new System.Drawing.Size(95, 17);
            this.lblPaymentUser.TabIndex = 26;
            this.lblPaymentUser.Text = "Исполнитель";
            // 
            // tbPaymentProject
            // 
            this.tbPaymentProject.Enabled = false;
            this.tbPaymentProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPaymentProject.Location = new System.Drawing.Point(225, 26);
            this.tbPaymentProject.Name = "tbPaymentProject";
            this.tbPaymentProject.ReadOnly = true;
            this.tbPaymentProject.Size = new System.Drawing.Size(369, 23);
            this.tbPaymentProject.TabIndex = 25;
            // 
            // gbPaymentsInActualProject
            // 
            this.gbPaymentsInActualProject.Controls.Add(this.dgvPaymentsByUserInProject);
            this.gbPaymentsInActualProject.Controls.Add(this.lblPaymentsBySelectedUser);
            this.gbPaymentsInActualProject.Controls.Add(this.lblPaymentsActualProjectNotSaved);
            this.gbPaymentsInActualProject.Controls.Add(this.dgvPaymentsInActualProjectByUsers);
            this.gbPaymentsInActualProject.Location = new System.Drawing.Point(3, 401);
            this.gbPaymentsInActualProject.Name = "gbPaymentsInActualProject";
            this.gbPaymentsInActualProject.Size = new System.Drawing.Size(968, 501);
            this.gbPaymentsInActualProject.TabIndex = 5;
            this.gbPaymentsInActualProject.TabStop = false;
            this.gbPaymentsInActualProject.Text = "Платежи текущего проекта";
            // 
            // dgvPaymentsByUserInProject
            // 
            this.dgvPaymentsByUserInProject.AllowUserToAddRows = false;
            this.dgvPaymentsByUserInProject.AllowUserToDeleteRows = false;
            this.dgvPaymentsByUserInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentsByUserInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTbColumnDate,
            this.dgvTbColumnAmount});
            this.dgvPaymentsByUserInProject.Location = new System.Drawing.Point(533, 39);
            this.dgvPaymentsByUserInProject.Name = "dgvPaymentsByUserInProject";
            this.dgvPaymentsByUserInProject.ReadOnly = true;
            this.dgvPaymentsByUserInProject.RowHeadersVisible = false;
            this.dgvPaymentsByUserInProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentsByUserInProject.Size = new System.Drawing.Size(289, 25);
            this.dgvPaymentsByUserInProject.TabIndex = 63;
            // 
            // dgvTbColumnDate
            // 
            this.dgvTbColumnDate.Frozen = true;
            this.dgvTbColumnDate.HeaderText = "Дата оплаты";
            this.dgvTbColumnDate.Name = "dgvTbColumnDate";
            this.dgvTbColumnDate.ReadOnly = true;
            this.dgvTbColumnDate.Width = 150;
            // 
            // dgvTbColumnAmount
            // 
            this.dgvTbColumnAmount.HeaderText = "Сумма ";
            this.dgvTbColumnAmount.Name = "dgvTbColumnAmount";
            this.dgvTbColumnAmount.ReadOnly = true;
            this.dgvTbColumnAmount.Width = 130;
            // 
            // lblPaymentsBySelectedUser
            // 
            this.lblPaymentsBySelectedUser.AutoSize = true;
            this.lblPaymentsBySelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaymentsBySelectedUser.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentsBySelectedUser.Location = new System.Drawing.Point(530, 19);
            this.lblPaymentsBySelectedUser.Name = "lblPaymentsBySelectedUser";
            this.lblPaymentsBySelectedUser.Size = new System.Drawing.Size(168, 17);
            this.lblPaymentsBySelectedUser.TabIndex = 62;
            this.lblPaymentsBySelectedUser.Text = "Исполнитель не выбран";
            this.lblPaymentsBySelectedUser.Visible = false;
            // 
            // lblPaymentsActualProjectNotSaved
            // 
            this.lblPaymentsActualProjectNotSaved.AutoSize = true;
            this.lblPaymentsActualProjectNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaymentsActualProjectNotSaved.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentsActualProjectNotSaved.Location = new System.Drawing.Point(6, 19);
            this.lblPaymentsActualProjectNotSaved.Name = "lblPaymentsActualProjectNotSaved";
            this.lblPaymentsActualProjectNotSaved.Size = new System.Drawing.Size(201, 17);
            this.lblPaymentsActualProjectNotSaved.TabIndex = 61;
            this.lblPaymentsActualProjectNotSaved.Text = "Текущий проект не сохранен";
            this.lblPaymentsActualProjectNotSaved.Visible = false;
            // 
            // dgvPaymentsInActualProjectByUsers
            // 
            this.dgvPaymentsInActualProjectByUsers.AllowUserToAddRows = false;
            this.dgvPaymentsInActualProjectByUsers.AllowUserToDeleteRows = false;
            this.dgvPaymentsInActualProjectByUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentsInActualProjectByUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTbColumnUserId,
            this.dgvColumnUserName,
            this.dgvTbColumnPayments});
            this.dgvPaymentsInActualProjectByUsers.Location = new System.Drawing.Point(6, 39);
            this.dgvPaymentsInActualProjectByUsers.Name = "dgvPaymentsInActualProjectByUsers";
            this.dgvPaymentsInActualProjectByUsers.ReadOnly = true;
            this.dgvPaymentsInActualProjectByUsers.RowHeadersVisible = false;
            this.dgvPaymentsInActualProjectByUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentsInActualProjectByUsers.Size = new System.Drawing.Size(506, 25);
            this.dgvPaymentsInActualProjectByUsers.TabIndex = 60;
            this.dgvPaymentsInActualProjectByUsers.SelectionChanged += new System.EventHandler(this.DgvPaymentsInActualProjectByUsers_SelectionChanged);
            // 
            // dgvTbColumnUserId
            // 
            this.dgvTbColumnUserId.Frozen = true;
            this.dgvTbColumnUserId.HeaderText = "Id исп";
            this.dgvTbColumnUserId.Name = "dgvTbColumnUserId";
            this.dgvTbColumnUserId.ReadOnly = true;
            this.dgvTbColumnUserId.Width = 70;
            // 
            // dgvColumnUserName
            // 
            this.dgvColumnUserName.Frozen = true;
            this.dgvColumnUserName.HeaderText = "ФИО исполнителя";
            this.dgvColumnUserName.Name = "dgvColumnUserName";
            this.dgvColumnUserName.ReadOnly = true;
            this.dgvColumnUserName.Width = 300;
            // 
            // dgvTbColumnPayments
            // 
            this.dgvTbColumnPayments.HeaderText = "Сумма выплат";
            this.dgvTbColumnPayments.Name = "dgvTbColumnPayments";
            this.dgvTbColumnPayments.ReadOnly = true;
            this.dgvTbColumnPayments.Width = 130;
            // 
            // gbAllPayments
            // 
            this.gbAllPayments.Controls.Add(this.lblPaymentsByProjects);
            this.gbAllPayments.Controls.Add(this.dgvPaymentsByProject);
            this.gbAllPayments.Controls.Add(this.gbPaymentRbDgv);
            this.gbAllPayments.Controls.Add(this.dgvSumPaymentsByProject);
            this.gbAllPayments.Controls.Add(this.btnPaymentDelete);
            this.gbAllPayments.Controls.Add(this.btnPaymentSwitchUpdate);
            this.gbAllPayments.Controls.Add(this.btnPaymentSwitchCreate);
            this.gbAllPayments.Controls.Add(this.dgvAllPayments);
            this.gbAllPayments.Location = new System.Drawing.Point(3, 3);
            this.gbAllPayments.Name = "gbAllPayments";
            this.gbAllPayments.Size = new System.Drawing.Size(968, 392);
            this.gbAllPayments.TabIndex = 4;
            this.gbAllPayments.TabStop = false;
            this.gbAllPayments.Text = "Все платежи";
            // 
            // lblPaymentsByProjects
            // 
            this.lblPaymentsByProjects.AutoSize = true;
            this.lblPaymentsByProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaymentsByProjects.Location = new System.Drawing.Point(393, 19);
            this.lblPaymentsByProjects.Name = "lblPaymentsByProjects";
            this.lblPaymentsByProjects.Size = new System.Drawing.Size(206, 17);
            this.lblPaymentsByProjects.TabIndex = 59;
            this.lblPaymentsByProjects.Text = "Платежи выбранного проекта";
            this.lblPaymentsByProjects.Visible = false;
            // 
            // dgvPaymentsByProject
            // 
            this.dgvPaymentsByProject.AllowUserToAddRows = false;
            this.dgvPaymentsByProject.AllowUserToDeleteRows = false;
            this.dgvPaymentsByProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentsByProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdPayment,
            this.ColumnUserName1,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14});
            this.dgvPaymentsByProject.Location = new System.Drawing.Point(393, 38);
            this.dgvPaymentsByProject.Name = "dgvPaymentsByProject";
            this.dgvPaymentsByProject.ReadOnly = true;
            this.dgvPaymentsByProject.RowHeadersVisible = false;
            this.dgvPaymentsByProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentsByProject.Size = new System.Drawing.Size(453, 25);
            this.dgvPaymentsByProject.TabIndex = 64;
            // 
            // ColumnIdPayment
            // 
            this.ColumnIdPayment.HeaderText = "id";
            this.ColumnIdPayment.Name = "ColumnIdPayment";
            this.ColumnIdPayment.ReadOnly = true;
            this.ColumnIdPayment.Visible = false;
            // 
            // ColumnUserName1
            // 
            this.ColumnUserName1.HeaderText = "ФИО исполнителя";
            this.ColumnUserName1.Name = "ColumnUserName1";
            this.ColumnUserName1.ReadOnly = true;
            this.ColumnUserName1.Width = 250;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата оплаты";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Сумма ";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // gbPaymentRbDgv
            // 
            this.gbPaymentRbDgv.Controls.Add(this.rbAllPayments);
            this.gbPaymentRbDgv.Controls.Add(this.rbPaymentsByProjects);
            this.gbPaymentRbDgv.Location = new System.Drawing.Point(865, 4);
            this.gbPaymentRbDgv.Name = "gbPaymentRbDgv";
            this.gbPaymentRbDgv.Size = new System.Drawing.Size(103, 63);
            this.gbPaymentRbDgv.TabIndex = 17;
            this.gbPaymentRbDgv.TabStop = false;
            this.gbPaymentRbDgv.Text = "Вид";
            // 
            // rbAllPayments
            // 
            this.rbAllPayments.AutoSize = true;
            this.rbAllPayments.Checked = true;
            this.rbAllPayments.Location = new System.Drawing.Point(0, 19);
            this.rbAllPayments.Name = "rbAllPayments";
            this.rbAllPayments.Size = new System.Drawing.Size(90, 17);
            this.rbAllPayments.TabIndex = 15;
            this.rbAllPayments.TabStop = true;
            this.rbAllPayments.Text = "Все платежи";
            this.rbAllPayments.UseVisualStyleBackColor = true;
            // 
            // rbPaymentsByProjects
            // 
            this.rbPaymentsByProjects.AutoSize = true;
            this.rbPaymentsByProjects.Location = new System.Drawing.Point(0, 40);
            this.rbPaymentsByProjects.Name = "rbPaymentsByProjects";
            this.rbPaymentsByProjects.Size = new System.Drawing.Size(91, 17);
            this.rbPaymentsByProjects.TabIndex = 16;
            this.rbPaymentsByProjects.Text = "По проектам";
            this.rbPaymentsByProjects.UseVisualStyleBackColor = true;
            this.rbPaymentsByProjects.CheckedChanged += new System.EventHandler(this.RbPaymentsByProjects_CheckedChanged);
            // 
            // dgvSumPaymentsByProject
            // 
            this.dgvSumPaymentsByProject.AllowUserToAddRows = false;
            this.dgvSumPaymentsByProject.AllowUserToDeleteRows = false;
            this.dgvSumPaymentsByProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumPaymentsByProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdProject,
            this.dataGridViewTextBoxColumn13,
            this.dgvTbColumnAmountByProject});
            this.dgvSumPaymentsByProject.Location = new System.Drawing.Point(0, 19);
            this.dgvSumPaymentsByProject.Name = "dgvSumPaymentsByProject";
            this.dgvSumPaymentsByProject.ReadOnly = true;
            this.dgvSumPaymentsByProject.RowHeadersVisible = false;
            this.dgvSumPaymentsByProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSumPaymentsByProject.Size = new System.Drawing.Size(387, 27);
            this.dgvSumPaymentsByProject.TabIndex = 14;
            this.dgvSumPaymentsByProject.Visible = false;
            this.dgvSumPaymentsByProject.SelectionChanged += new System.EventHandler(this.DgvSumPaymentsByProject_SelectionChanged);
            // 
            // ColumnIdProject
            // 
            this.ColumnIdProject.HeaderText = "id";
            this.ColumnIdProject.Name = "ColumnIdProject";
            this.ColumnIdProject.ReadOnly = true;
            this.ColumnIdProject.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Проект";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 250;
            // 
            // dgvTbColumnAmountByProject
            // 
            this.dgvTbColumnAmountByProject.HeaderText = "Сумма по проекту";
            this.dgvTbColumnAmountByProject.Name = "dgvTbColumnAmountByProject";
            this.dgvTbColumnAmountByProject.ReadOnly = true;
            this.dgvTbColumnAmountByProject.Width = 130;
            // 
            // btnPaymentDelete
            // 
            this.btnPaymentDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaymentDelete.Location = new System.Drawing.Point(851, 208);
            this.btnPaymentDelete.Name = "btnPaymentDelete";
            this.btnPaymentDelete.Size = new System.Drawing.Size(110, 35);
            this.btnPaymentDelete.TabIndex = 10;
            this.btnPaymentDelete.Text = "Удалить оплату";
            this.btnPaymentDelete.UseVisualStyleBackColor = true;
            this.btnPaymentDelete.Click += new System.EventHandler(this.BtnPaymentDelete_Click);
            // 
            // btnPaymentSwitchUpdate
            // 
            this.btnPaymentSwitchUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaymentSwitchUpdate.Location = new System.Drawing.Point(852, 150);
            this.btnPaymentSwitchUpdate.Name = "btnPaymentSwitchUpdate";
            this.btnPaymentSwitchUpdate.Size = new System.Drawing.Size(110, 49);
            this.btnPaymentSwitchUpdate.TabIndex = 9;
            this.btnPaymentSwitchUpdate.Text = "Редактировать оплату";
            this.btnPaymentSwitchUpdate.UseVisualStyleBackColor = true;
            this.btnPaymentSwitchUpdate.Click += new System.EventHandler(this.BtnPaymentSwitchUpdate_Click);
            // 
            // btnPaymentSwitchCreate
            // 
            this.btnPaymentSwitchCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaymentSwitchCreate.Location = new System.Drawing.Point(852, 95);
            this.btnPaymentSwitchCreate.Name = "btnPaymentSwitchCreate";
            this.btnPaymentSwitchCreate.Size = new System.Drawing.Size(110, 49);
            this.btnPaymentSwitchCreate.TabIndex = 8;
            this.btnPaymentSwitchCreate.Text = "Добавить оплату";
            this.btnPaymentSwitchCreate.UseVisualStyleBackColor = true;
            this.btnPaymentSwitchCreate.Click += new System.EventHandler(this.BtnPaymentSwitchCreate_Click);
            // 
            // dgvAllPayments
            // 
            this.dgvAllPayments.AllowUserToAddRows = false;
            this.dgvAllPayments.AllowUserToDeleteRows = false;
            this.dgvAllPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dgvTbColumnProject,
            this.dgvTbColumnUser,
            this.dgvTbColumnDateOfPayment,
            this.dgvTbAmount});
            this.dgvAllPayments.Location = new System.Drawing.Point(5, 19);
            this.dgvAllPayments.Name = "dgvAllPayments";
            this.dgvAllPayments.ReadOnly = true;
            this.dgvAllPayments.RowHeadersVisible = false;
            this.dgvAllPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPayments.Size = new System.Drawing.Size(841, 27);
            this.dgvAllPayments.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "Id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 30;
            // 
            // dgvTbColumnProject
            // 
            this.dgvTbColumnProject.Frozen = true;
            this.dgvTbColumnProject.HeaderText = "Проект";
            this.dgvTbColumnProject.Name = "dgvTbColumnProject";
            this.dgvTbColumnProject.ReadOnly = true;
            this.dgvTbColumnProject.Width = 300;
            // 
            // dgvTbColumnUser
            // 
            this.dgvTbColumnUser.HeaderText = "Исполнитель";
            this.dgvTbColumnUser.Name = "dgvTbColumnUser";
            this.dgvTbColumnUser.ReadOnly = true;
            this.dgvTbColumnUser.Width = 200;
            // 
            // dgvTbColumnDateOfPayment
            // 
            this.dgvTbColumnDateOfPayment.HeaderText = "Дата";
            this.dgvTbColumnDateOfPayment.Name = "dgvTbColumnDateOfPayment";
            this.dgvTbColumnDateOfPayment.ReadOnly = true;
            this.dgvTbColumnDateOfPayment.Width = 150;
            // 
            // dgvTbAmount
            // 
            this.dgvTbAmount.HeaderText = "Сумма";
            this.dgvTbAmount.Name = "dgvTbAmount";
            this.dgvTbAmount.ReadOnly = true;
            this.dgvTbAmount.Width = 150;
            // 
            // tabPageTypeOfElement
            // 
            this.tabPageTypeOfElement.Controls.Add(this.gbTypeOfElementPanel);
            this.tabPageTypeOfElement.Controls.Add(this.gbTypeOfElementInProject);
            this.tabPageTypeOfElement.Controls.Add(this.gbAllTypesOfElement);
            this.tabPageTypeOfElement.Location = new System.Drawing.Point(4, 22);
            this.tabPageTypeOfElement.Name = "tabPageTypeOfElement";
            this.tabPageTypeOfElement.Size = new System.Drawing.Size(1900, 946);
            this.tabPageTypeOfElement.TabIndex = 5;
            this.tabPageTypeOfElement.Text = "Элементы фасада";
            this.tabPageTypeOfElement.UseVisualStyleBackColor = true;
            // 
            // gbTypeOfElementPanel
            // 
            this.gbTypeOfElementPanel.Controls.Add(this.btnTypeOfElementSwitchCancel);
            this.gbTypeOfElementPanel.Controls.Add(this.btnTypeOfElementCreate);
            this.gbTypeOfElementPanel.Controls.Add(this.gbTypeOfElementData);
            this.gbTypeOfElementPanel.Controls.Add(this.btnTypeOfElementUpdate);
            this.gbTypeOfElementPanel.Location = new System.Drawing.Point(979, 3);
            this.gbTypeOfElementPanel.Name = "gbTypeOfElementPanel";
            this.gbTypeOfElementPanel.Size = new System.Drawing.Size(752, 899);
            this.gbTypeOfElementPanel.TabIndex = 5;
            this.gbTypeOfElementPanel.TabStop = false;
            this.gbTypeOfElementPanel.Text = "Данные элемента фасада";
            // 
            // btnTypeOfElementSwitchCancel
            // 
            this.btnTypeOfElementSwitchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTypeOfElementSwitchCancel.Location = new System.Drawing.Point(9, 340);
            this.btnTypeOfElementSwitchCancel.Name = "btnTypeOfElementSwitchCancel";
            this.btnTypeOfElementSwitchCancel.Size = new System.Drawing.Size(152, 42);
            this.btnTypeOfElementSwitchCancel.TabIndex = 50;
            this.btnTypeOfElementSwitchCancel.Text = "Отменить";
            this.btnTypeOfElementSwitchCancel.UseVisualStyleBackColor = true;
            this.btnTypeOfElementSwitchCancel.Click += new System.EventHandler(this.BtnTypeOfElementSwitchCancel_Click);
            // 
            // btnTypeOfElementCreate
            // 
            this.btnTypeOfElementCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTypeOfElementCreate.Location = new System.Drawing.Point(585, 340);
            this.btnTypeOfElementCreate.Name = "btnTypeOfElementCreate";
            this.btnTypeOfElementCreate.Size = new System.Drawing.Size(152, 42);
            this.btnTypeOfElementCreate.TabIndex = 48;
            this.btnTypeOfElementCreate.Text = "Сохранить элемент";
            this.btnTypeOfElementCreate.UseVisualStyleBackColor = true;
            this.btnTypeOfElementCreate.Visible = false;
            this.btnTypeOfElementCreate.Click += new System.EventHandler(this.BtnTypeOfElementCreate_Click);
            // 
            // gbTypeOfElementData
            // 
            this.gbTypeOfElementData.Controls.Add(this.btnTypeOfElementCancelPicture);
            this.gbTypeOfElementData.Controls.Add(this.btnTypeOfElementSetPicture);
            this.gbTypeOfElementData.Controls.Add(this.pbCheckMarkTypeOfElementPicture);
            this.gbTypeOfElementData.Controls.Add(this.dgvTypeOfElementSetPicture);
            this.gbTypeOfElementData.Controls.Add(this.btnTypeOfElementSwitchSetPicture);
            this.gbTypeOfElementData.Controls.Add(this.pbTypeOfElementPicture);
            this.gbTypeOfElementData.Controls.Add(this.lblCheckTypeOfElementLength);
            this.gbTypeOfElementData.Controls.Add(this.tbTypeOfElementLength);
            this.gbTypeOfElementData.Controls.Add(this.lblTypeOfElementLength);
            this.gbTypeOfElementData.Controls.Add(this.pbCheckMarkTypeOfElementLength);
            this.gbTypeOfElementData.Controls.Add(this.lblCheckTypeOfElementHeight);
            this.gbTypeOfElementData.Controls.Add(this.tbTypeOfElementHeight);
            this.gbTypeOfElementData.Controls.Add(this.lblTypeOfElementHeight);
            this.gbTypeOfElementData.Controls.Add(this.pbCheckMarkTypeOfElementHeight);
            this.gbTypeOfElementData.Controls.Add(this.lblTypeOfElementName);
            this.gbTypeOfElementData.Controls.Add(this.lblCheckTypeOfElementSquare);
            this.gbTypeOfElementData.Controls.Add(this.tbTypeOfElementSquare);
            this.gbTypeOfElementData.Controls.Add(this.lblCheckTypeOfElementName);
            this.gbTypeOfElementData.Controls.Add(this.lblTypeOfElementSquare);
            this.gbTypeOfElementData.Controls.Add(this.tbTypeOfElementName);
            this.gbTypeOfElementData.Controls.Add(this.pbCheckMarkTypeOfElementSquare);
            this.gbTypeOfElementData.Controls.Add(this.pbCheckMarkTypeOfElementName);
            this.gbTypeOfElementData.Enabled = false;
            this.gbTypeOfElementData.Location = new System.Drawing.Point(9, 19);
            this.gbTypeOfElementData.Name = "gbTypeOfElementData";
            this.gbTypeOfElementData.Size = new System.Drawing.Size(728, 315);
            this.gbTypeOfElementData.TabIndex = 49;
            this.gbTypeOfElementData.TabStop = false;
            // 
            // btnTypeOfElementCancelPicture
            // 
            this.btnTypeOfElementCancelPicture.Location = new System.Drawing.Point(634, 266);
            this.btnTypeOfElementCancelPicture.Name = "btnTypeOfElementCancelPicture";
            this.btnTypeOfElementCancelPicture.Size = new System.Drawing.Size(77, 34);
            this.btnTypeOfElementCancelPicture.TabIndex = 59;
            this.btnTypeOfElementCancelPicture.Text = "Отменить";
            this.btnTypeOfElementCancelPicture.UseVisualStyleBackColor = true;
            this.btnTypeOfElementCancelPicture.Visible = false;
            this.btnTypeOfElementCancelPicture.Click += new System.EventHandler(this.BtnTypeOfElementCancelPicture_Click);
            // 
            // btnTypeOfElementSetPicture
            // 
            this.btnTypeOfElementSetPicture.Location = new System.Drawing.Point(551, 266);
            this.btnTypeOfElementSetPicture.Name = "btnTypeOfElementSetPicture";
            this.btnTypeOfElementSetPicture.Size = new System.Drawing.Size(77, 34);
            this.btnTypeOfElementSetPicture.TabIndex = 58;
            this.btnTypeOfElementSetPicture.Text = "Выбрать";
            this.btnTypeOfElementSetPicture.UseVisualStyleBackColor = true;
            this.btnTypeOfElementSetPicture.Visible = false;
            this.btnTypeOfElementSetPicture.Click += new System.EventHandler(this.BtnTypeOfElementSetPicture_Click);
            // 
            // pbCheckMarkTypeOfElementPicture
            // 
            this.pbCheckMarkTypeOfElementPicture.Location = new System.Drawing.Point(601, 216);
            this.pbCheckMarkTypeOfElementPicture.Name = "pbCheckMarkTypeOfElementPicture";
            this.pbCheckMarkTypeOfElementPicture.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfElementPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfElementPicture.TabIndex = 57;
            this.pbCheckMarkTypeOfElementPicture.TabStop = false;
            this.pbCheckMarkTypeOfElementPicture.Visible = false;
            // 
            // dgvTypeOfElementSetPicture
            // 
            this.dgvTypeOfElementSetPicture.AllowUserToAddRows = false;
            this.dgvTypeOfElementSetPicture.AllowUserToDeleteRows = false;
            this.dgvTypeOfElementSetPicture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeOfElementSetPicture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.dgvTypeOfElementSetPicture.Location = new System.Drawing.Point(9, 273);
            this.dgvTypeOfElementSetPicture.Name = "dgvTypeOfElementSetPicture";
            this.dgvTypeOfElementSetPicture.ReadOnly = true;
            this.dgvTypeOfElementSetPicture.RowHeadersVisible = false;
            this.dgvTypeOfElementSetPicture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeOfElementSetPicture.Size = new System.Drawing.Size(536, 27);
            this.dgvTypeOfElementSetPicture.TabIndex = 56;
            this.dgvTypeOfElementSetPicture.Visible = false;
            this.dgvTypeOfElementSetPicture.SelectionChanged += new System.EventHandler(this.DgvTypeOfElementSetPicture_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.Frozen = true;
            this.dataGridViewTextBoxColumn24.HeaderText = "№";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 30;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.Frozen = true;
            this.dataGridViewTextBoxColumn25.HeaderText = "Название";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 500;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.Frozen = true;
            this.dataGridViewTextBoxColumn26.HeaderText = "Picture";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // btnTypeOfElementSwitchSetPicture
            // 
            this.btnTypeOfElementSwitchSetPicture.Location = new System.Drawing.Point(9, 233);
            this.btnTypeOfElementSwitchSetPicture.Name = "btnTypeOfElementSwitchSetPicture";
            this.btnTypeOfElementSwitchSetPicture.Size = new System.Drawing.Size(133, 34);
            this.btnTypeOfElementSwitchSetPicture.TabIndex = 55;
            this.btnTypeOfElementSwitchSetPicture.Text = "Выбрать изображение";
            this.btnTypeOfElementSwitchSetPicture.UseVisualStyleBackColor = true;
            this.btnTypeOfElementSwitchSetPicture.Click += new System.EventHandler(this.BtnTypeOfElementSwitchSetPicture_Click);
            // 
            // pbTypeOfElementPicture
            // 
            this.pbTypeOfElementPicture.Location = new System.Drawing.Point(394, 74);
            this.pbTypeOfElementPicture.Name = "pbTypeOfElementPicture";
            this.pbTypeOfElementPicture.Size = new System.Drawing.Size(200, 167);
            this.pbTypeOfElementPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTypeOfElementPicture.TabIndex = 55;
            this.pbTypeOfElementPicture.TabStop = false;
            // 
            // lblCheckTypeOfElementLength
            // 
            this.lblCheckTypeOfElementLength.AutoSize = true;
            this.lblCheckTypeOfElementLength.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTypeOfElementLength.Location = new System.Drawing.Point(6, 202);
            this.lblCheckTypeOfElementLength.Name = "lblCheckTypeOfElementLength";
            this.lblCheckTypeOfElementLength.Size = new System.Drawing.Size(205, 13);
            this.lblCheckTypeOfElementLength.TabIndex = 53;
            this.lblCheckTypeOfElementLength.Text = "Введите целое неотрицательное число";
            this.lblCheckTypeOfElementLength.Visible = false;
            // 
            // tbTypeOfElementLength
            // 
            this.tbTypeOfElementLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTypeOfElementLength.Location = new System.Drawing.Point(225, 176);
            this.tbTypeOfElementLength.Name = "tbTypeOfElementLength";
            this.tbTypeOfElementLength.Size = new System.Drawing.Size(110, 23);
            this.tbTypeOfElementLength.TabIndex = 51;
            this.tbTypeOfElementLength.TextChanged += new System.EventHandler(this.TbTypeOfElementLength_TextChanged);
            // 
            // lblTypeOfElementLength
            // 
            this.lblTypeOfElementLength.AutoSize = true;
            this.lblTypeOfElementLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTypeOfElementLength.Location = new System.Drawing.Point(6, 176);
            this.lblTypeOfElementLength.Name = "lblTypeOfElementLength";
            this.lblTypeOfElementLength.Size = new System.Drawing.Size(59, 17);
            this.lblTypeOfElementLength.TabIndex = 50;
            this.lblTypeOfElementLength.Text = "Ширина";
            // 
            // pbCheckMarkTypeOfElementLength
            // 
            this.pbCheckMarkTypeOfElementLength.Location = new System.Drawing.Point(341, 176);
            this.pbCheckMarkTypeOfElementLength.Name = "pbCheckMarkTypeOfElementLength";
            this.pbCheckMarkTypeOfElementLength.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfElementLength.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfElementLength.TabIndex = 52;
            this.pbCheckMarkTypeOfElementLength.TabStop = false;
            this.pbCheckMarkTypeOfElementLength.Visible = false;
            // 
            // lblCheckTypeOfElementHeight
            // 
            this.lblCheckTypeOfElementHeight.AutoSize = true;
            this.lblCheckTypeOfElementHeight.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTypeOfElementHeight.Location = new System.Drawing.Point(6, 150);
            this.lblCheckTypeOfElementHeight.Name = "lblCheckTypeOfElementHeight";
            this.lblCheckTypeOfElementHeight.Size = new System.Drawing.Size(205, 13);
            this.lblCheckTypeOfElementHeight.TabIndex = 49;
            this.lblCheckTypeOfElementHeight.Text = "Введите целое неотрицательное число";
            this.lblCheckTypeOfElementHeight.Visible = false;
            // 
            // tbTypeOfElementHeight
            // 
            this.tbTypeOfElementHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTypeOfElementHeight.Location = new System.Drawing.Point(225, 124);
            this.tbTypeOfElementHeight.Name = "tbTypeOfElementHeight";
            this.tbTypeOfElementHeight.Size = new System.Drawing.Size(110, 23);
            this.tbTypeOfElementHeight.TabIndex = 47;
            this.tbTypeOfElementHeight.TextChanged += new System.EventHandler(this.TbTypeOfElementHeight_TextChanged);
            // 
            // lblTypeOfElementHeight
            // 
            this.lblTypeOfElementHeight.AutoSize = true;
            this.lblTypeOfElementHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTypeOfElementHeight.Location = new System.Drawing.Point(6, 124);
            this.lblTypeOfElementHeight.Name = "lblTypeOfElementHeight";
            this.lblTypeOfElementHeight.Size = new System.Drawing.Size(57, 17);
            this.lblTypeOfElementHeight.TabIndex = 46;
            this.lblTypeOfElementHeight.Text = "Высота";
            // 
            // pbCheckMarkTypeOfElementHeight
            // 
            this.pbCheckMarkTypeOfElementHeight.Location = new System.Drawing.Point(341, 124);
            this.pbCheckMarkTypeOfElementHeight.Name = "pbCheckMarkTypeOfElementHeight";
            this.pbCheckMarkTypeOfElementHeight.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfElementHeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfElementHeight.TabIndex = 48;
            this.pbCheckMarkTypeOfElementHeight.TabStop = false;
            this.pbCheckMarkTypeOfElementHeight.Visible = false;
            // 
            // lblTypeOfElementName
            // 
            this.lblTypeOfElementName.AutoSize = true;
            this.lblTypeOfElementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTypeOfElementName.Location = new System.Drawing.Point(6, 26);
            this.lblTypeOfElementName.Name = "lblTypeOfElementName";
            this.lblTypeOfElementName.Size = new System.Drawing.Size(72, 17);
            this.lblTypeOfElementName.TabIndex = 24;
            this.lblTypeOfElementName.Text = "Название";
            // 
            // lblCheckTypeOfElementSquare
            // 
            this.lblCheckTypeOfElementSquare.AutoSize = true;
            this.lblCheckTypeOfElementSquare.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTypeOfElementSquare.Location = new System.Drawing.Point(6, 100);
            this.lblCheckTypeOfElementSquare.Name = "lblCheckTypeOfElementSquare";
            this.lblCheckTypeOfElementSquare.Size = new System.Drawing.Size(205, 13);
            this.lblCheckTypeOfElementSquare.TabIndex = 45;
            this.lblCheckTypeOfElementSquare.Text = "Введите целое неотрицательное число";
            this.lblCheckTypeOfElementSquare.Visible = false;
            // 
            // tbTypeOfElementSquare
            // 
            this.tbTypeOfElementSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTypeOfElementSquare.Location = new System.Drawing.Point(225, 74);
            this.tbTypeOfElementSquare.Name = "tbTypeOfElementSquare";
            this.tbTypeOfElementSquare.Size = new System.Drawing.Size(110, 23);
            this.tbTypeOfElementSquare.TabIndex = 27;
            this.tbTypeOfElementSquare.TextChanged += new System.EventHandler(this.TbTypeOfElementSquare_TextChanged);
            // 
            // lblCheckTypeOfElementName
            // 
            this.lblCheckTypeOfElementName.AutoSize = true;
            this.lblCheckTypeOfElementName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTypeOfElementName.Location = new System.Drawing.Point(6, 53);
            this.lblCheckTypeOfElementName.Name = "lblCheckTypeOfElementName";
            this.lblCheckTypeOfElementName.Size = new System.Drawing.Size(505, 13);
            this.lblCheckTypeOfElementName.TabIndex = 44;
            this.lblCheckTypeOfElementName.Text = "Введите название длиной от 3 до 100 символов, используя кирилицу цифры и знаки пр" +
    "епинания ";
            this.lblCheckTypeOfElementName.Visible = false;
            // 
            // lblTypeOfElementSquare
            // 
            this.lblTypeOfElementSquare.AutoSize = true;
            this.lblTypeOfElementSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTypeOfElementSquare.Location = new System.Drawing.Point(6, 74);
            this.lblTypeOfElementSquare.Name = "lblTypeOfElementSquare";
            this.lblTypeOfElementSquare.Size = new System.Drawing.Size(68, 17);
            this.lblTypeOfElementSquare.TabIndex = 26;
            this.lblTypeOfElementSquare.Text = "Площадь";
            // 
            // tbTypeOfElementName
            // 
            this.tbTypeOfElementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTypeOfElementName.Location = new System.Drawing.Point(225, 26);
            this.tbTypeOfElementName.Name = "tbTypeOfElementName";
            this.tbTypeOfElementName.Size = new System.Drawing.Size(369, 23);
            this.tbTypeOfElementName.TabIndex = 25;
            this.tbTypeOfElementName.TextChanged += new System.EventHandler(this.TbTypeOfElementName_TextChanged);
            // 
            // pbCheckMarkTypeOfElementSquare
            // 
            this.pbCheckMarkTypeOfElementSquare.Location = new System.Drawing.Point(341, 74);
            this.pbCheckMarkTypeOfElementSquare.Name = "pbCheckMarkTypeOfElementSquare";
            this.pbCheckMarkTypeOfElementSquare.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfElementSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfElementSquare.TabIndex = 40;
            this.pbCheckMarkTypeOfElementSquare.TabStop = false;
            this.pbCheckMarkTypeOfElementSquare.Visible = false;
            // 
            // pbCheckMarkTypeOfElementName
            // 
            this.pbCheckMarkTypeOfElementName.Location = new System.Drawing.Point(601, 24);
            this.pbCheckMarkTypeOfElementName.Name = "pbCheckMarkTypeOfElementName";
            this.pbCheckMarkTypeOfElementName.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkTypeOfElementName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkTypeOfElementName.TabIndex = 39;
            this.pbCheckMarkTypeOfElementName.TabStop = false;
            this.pbCheckMarkTypeOfElementName.Visible = false;
            // 
            // btnTypeOfElementUpdate
            // 
            this.btnTypeOfElementUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTypeOfElementUpdate.Location = new System.Drawing.Point(427, 340);
            this.btnTypeOfElementUpdate.Name = "btnTypeOfElementUpdate";
            this.btnTypeOfElementUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnTypeOfElementUpdate.TabIndex = 36;
            this.btnTypeOfElementUpdate.Text = "Сохранить изменения";
            this.btnTypeOfElementUpdate.UseVisualStyleBackColor = true;
            this.btnTypeOfElementUpdate.Visible = false;
            this.btnTypeOfElementUpdate.Click += new System.EventHandler(this.BtnTypeOfElementUpdate_Click);
            // 
            // gbTypeOfElementInProject
            // 
            this.gbTypeOfElementInProject.Controls.Add(this.lblTypesOfElementActualProjectNotSaved);
            this.gbTypeOfElementInProject.Controls.Add(this.pbTypeOfElementSelectedDgvInProject);
            this.gbTypeOfElementInProject.Controls.Add(this.dgvTypesOfElementInProject);
            this.gbTypeOfElementInProject.Controls.Add(this.btnTypeOfElementDeleteFromProject);
            this.gbTypeOfElementInProject.Location = new System.Drawing.Point(3, 401);
            this.gbTypeOfElementInProject.Name = "gbTypeOfElementInProject";
            this.gbTypeOfElementInProject.Size = new System.Drawing.Size(968, 501);
            this.gbTypeOfElementInProject.TabIndex = 4;
            this.gbTypeOfElementInProject.TabStop = false;
            this.gbTypeOfElementInProject.Text = "Элементы фасада текущего проекта";
            // 
            // lblTypesOfElementActualProjectNotSaved
            // 
            this.lblTypesOfElementActualProjectNotSaved.AutoSize = true;
            this.lblTypesOfElementActualProjectNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTypesOfElementActualProjectNotSaved.ForeColor = System.Drawing.Color.Red;
            this.lblTypesOfElementActualProjectNotSaved.Location = new System.Drawing.Point(6, 16);
            this.lblTypesOfElementActualProjectNotSaved.Name = "lblTypesOfElementActualProjectNotSaved";
            this.lblTypesOfElementActualProjectNotSaved.Size = new System.Drawing.Size(201, 17);
            this.lblTypesOfElementActualProjectNotSaved.TabIndex = 62;
            this.lblTypesOfElementActualProjectNotSaved.Text = "Текущий проект не сохранен";
            this.lblTypesOfElementActualProjectNotSaved.Visible = false;
            // 
            // pbTypeOfElementSelectedDgvInProject
            // 
            this.pbTypeOfElementSelectedDgvInProject.Location = new System.Drawing.Point(646, 36);
            this.pbTypeOfElementSelectedDgvInProject.Name = "pbTypeOfElementSelectedDgvInProject";
            this.pbTypeOfElementSelectedDgvInProject.Size = new System.Drawing.Size(200, 167);
            this.pbTypeOfElementSelectedDgvInProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTypeOfElementSelectedDgvInProject.TabIndex = 61;
            this.pbTypeOfElementSelectedDgvInProject.TabStop = false;
            // 
            // dgvTypesOfElementInProject
            // 
            this.dgvTypesOfElementInProject.AllowUserToAddRows = false;
            this.dgvTypesOfElementInProject.AllowUserToDeleteRows = false;
            this.dgvTypesOfElementInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypesOfElementInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.ColumnTypeOfElementInProjectIdElementPicture});
            this.dgvTypesOfElementInProject.Location = new System.Drawing.Point(5, 36);
            this.dgvTypesOfElementInProject.Name = "dgvTypesOfElementInProject";
            this.dgvTypesOfElementInProject.ReadOnly = true;
            this.dgvTypesOfElementInProject.RowHeadersVisible = false;
            this.dgvTypesOfElementInProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypesOfElementInProject.Size = new System.Drawing.Size(635, 27);
            this.dgvTypesOfElementInProject.TabIndex = 60;
            this.dgvTypesOfElementInProject.SelectionChanged += new System.EventHandler(this.DgvTypesOfElementInProject_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.Frozen = true;
            this.dataGridViewTextBoxColumn15.HeaderText = "№";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 30;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.Frozen = true;
            this.dataGridViewTextBoxColumn16.HeaderText = "Название";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 300;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.Frozen = true;
            this.dataGridViewTextBoxColumn17.HeaderText = "Площадь";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.Frozen = true;
            this.dataGridViewTextBoxColumn27.HeaderText = "Высота";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.Frozen = true;
            this.dataGridViewTextBoxColumn28.HeaderText = "Ширина";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // ColumnTypeOfElementInProjectIdElementPicture
            // 
            this.ColumnTypeOfElementInProjectIdElementPicture.Frozen = true;
            this.ColumnTypeOfElementInProjectIdElementPicture.HeaderText = "Picture";
            this.ColumnTypeOfElementInProjectIdElementPicture.Name = "ColumnTypeOfElementInProjectIdElementPicture";
            this.ColumnTypeOfElementInProjectIdElementPicture.ReadOnly = true;
            this.ColumnTypeOfElementInProjectIdElementPicture.Visible = false;
            // 
            // btnTypeOfElementDeleteFromProject
            // 
            this.btnTypeOfElementDeleteFromProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTypeOfElementDeleteFromProject.Location = new System.Drawing.Point(852, 36);
            this.btnTypeOfElementDeleteFromProject.Name = "btnTypeOfElementDeleteFromProject";
            this.btnTypeOfElementDeleteFromProject.Size = new System.Drawing.Size(110, 46);
            this.btnTypeOfElementDeleteFromProject.TabIndex = 59;
            this.btnTypeOfElementDeleteFromProject.Text = "Удалить из проекта";
            this.btnTypeOfElementDeleteFromProject.UseVisualStyleBackColor = true;
            this.btnTypeOfElementDeleteFromProject.Click += new System.EventHandler(this.BtnTypeOfElementDeleteFromProject_Click);
            // 
            // gbAllTypesOfElement
            // 
            this.gbAllTypesOfElement.Controls.Add(this.pbTypeOfElementSelectedDgvAll);
            this.gbAllTypesOfElement.Controls.Add(this.checkBox3);
            this.gbAllTypesOfElement.Controls.Add(this.btnTypeOfElementAddToProject);
            this.gbAllTypesOfElement.Controls.Add(this.btnTypeOfElementDelete);
            this.gbAllTypesOfElement.Controls.Add(this.btnTypeOfElementSwitchUpdate);
            this.gbAllTypesOfElement.Controls.Add(this.btnTypeOfElementSwitchCreate);
            this.gbAllTypesOfElement.Controls.Add(this.dgvAllTypesOfElement);
            this.gbAllTypesOfElement.Location = new System.Drawing.Point(3, 3);
            this.gbAllTypesOfElement.Name = "gbAllTypesOfElement";
            this.gbAllTypesOfElement.Size = new System.Drawing.Size(968, 392);
            this.gbAllTypesOfElement.TabIndex = 3;
            this.gbAllTypesOfElement.TabStop = false;
            this.gbAllTypesOfElement.Text = "Все элементы фасада";
            // 
            // pbTypeOfElementSelectedDgvAll
            // 
            this.pbTypeOfElementSelectedDgvAll.Location = new System.Drawing.Point(646, 19);
            this.pbTypeOfElementSelectedDgvAll.Name = "pbTypeOfElementSelectedDgvAll";
            this.pbTypeOfElementSelectedDgvAll.Size = new System.Drawing.Size(200, 167);
            this.pbTypeOfElementSelectedDgvAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTypeOfElementSelectedDgvAll.TabIndex = 54;
            this.pbTypeOfElementSelectedDgvAll.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(852, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Скрыть";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnTypeOfElementAddToProject
            // 
            this.btnTypeOfElementAddToProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeOfElementAddToProject.Location = new System.Drawing.Point(852, 208);
            this.btnTypeOfElementAddToProject.Name = "btnTypeOfElementAddToProject";
            this.btnTypeOfElementAddToProject.Size = new System.Drawing.Size(110, 49);
            this.btnTypeOfElementAddToProject.TabIndex = 12;
            this.btnTypeOfElementAddToProject.Text = "Добавить элемент в проект";
            this.btnTypeOfElementAddToProject.UseVisualStyleBackColor = true;
            this.btnTypeOfElementAddToProject.Click += new System.EventHandler(this.BtnTypeOfElementAddToProject_Click);
            // 
            // btnTypeOfElementDelete
            // 
            this.btnTypeOfElementDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeOfElementDelete.Location = new System.Drawing.Point(852, 167);
            this.btnTypeOfElementDelete.Name = "btnTypeOfElementDelete";
            this.btnTypeOfElementDelete.Size = new System.Drawing.Size(110, 35);
            this.btnTypeOfElementDelete.TabIndex = 10;
            this.btnTypeOfElementDelete.Text = "Удалить элемент";
            this.btnTypeOfElementDelete.UseVisualStyleBackColor = true;
            this.btnTypeOfElementDelete.Click += new System.EventHandler(this.BtnTypeOfElementDelete_Click);
            // 
            // btnTypeOfElementSwitchUpdate
            // 
            this.btnTypeOfElementSwitchUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeOfElementSwitchUpdate.Location = new System.Drawing.Point(852, 111);
            this.btnTypeOfElementSwitchUpdate.Name = "btnTypeOfElementSwitchUpdate";
            this.btnTypeOfElementSwitchUpdate.Size = new System.Drawing.Size(110, 49);
            this.btnTypeOfElementSwitchUpdate.TabIndex = 9;
            this.btnTypeOfElementSwitchUpdate.Text = "Редактировать элемент";
            this.btnTypeOfElementSwitchUpdate.UseVisualStyleBackColor = true;
            this.btnTypeOfElementSwitchUpdate.Click += new System.EventHandler(this.BtnTypeOfElementSwitchUpdate_Click);
            // 
            // btnTypeOfElementSwitchCreate
            // 
            this.btnTypeOfElementSwitchCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeOfElementSwitchCreate.Location = new System.Drawing.Point(852, 56);
            this.btnTypeOfElementSwitchCreate.Name = "btnTypeOfElementSwitchCreate";
            this.btnTypeOfElementSwitchCreate.Size = new System.Drawing.Size(110, 49);
            this.btnTypeOfElementSwitchCreate.TabIndex = 8;
            this.btnTypeOfElementSwitchCreate.Text = "Добавить новый элемент";
            this.btnTypeOfElementSwitchCreate.UseVisualStyleBackColor = true;
            this.btnTypeOfElementSwitchCreate.Click += new System.EventHandler(this.BtnTypeOfElementSwitchCreate_Click);
            // 
            // dgvAllTypesOfElement
            // 
            this.dgvAllTypesOfElement.AllowUserToAddRows = false;
            this.dgvAllTypesOfElement.AllowUserToDeleteRows = false;
            this.dgvAllTypesOfElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTypesOfElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.ColumnIdElementPicture});
            this.dgvAllTypesOfElement.Location = new System.Drawing.Point(5, 19);
            this.dgvAllTypesOfElement.Name = "dgvAllTypesOfElement";
            this.dgvAllTypesOfElement.ReadOnly = true;
            this.dgvAllTypesOfElement.RowHeadersVisible = false;
            this.dgvAllTypesOfElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTypesOfElement.Size = new System.Drawing.Size(635, 27);
            this.dgvAllTypesOfElement.TabIndex = 7;
            this.dgvAllTypesOfElement.SelectionChanged += new System.EventHandler(this.DgvAllTypesOfElement_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.Frozen = true;
            this.dataGridViewTextBoxColumn18.HeaderText = "№";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 30;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.Frozen = true;
            this.dataGridViewTextBoxColumn19.HeaderText = "Название";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 300;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.Frozen = true;
            this.dataGridViewTextBoxColumn20.HeaderText = "Площадь";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.Frozen = true;
            this.dataGridViewTextBoxColumn21.HeaderText = "Высота";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.Frozen = true;
            this.dataGridViewTextBoxColumn22.HeaderText = "Ширина";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // ColumnIdElementPicture
            // 
            this.ColumnIdElementPicture.Frozen = true;
            this.ColumnIdElementPicture.HeaderText = "Picture";
            this.ColumnIdElementPicture.Name = "ColumnIdElementPicture";
            this.ColumnIdElementPicture.ReadOnly = true;
            this.ColumnIdElementPicture.Visible = false;
            // 
            // tabPageElementPicture
            // 
            this.tabPageElementPicture.Controls.Add(this.gbElementPictureData);
            this.tabPageElementPicture.Controls.Add(this.gbAllElementPicture);
            this.tabPageElementPicture.Location = new System.Drawing.Point(4, 22);
            this.tabPageElementPicture.Name = "tabPageElementPicture";
            this.tabPageElementPicture.Size = new System.Drawing.Size(1900, 946);
            this.tabPageElementPicture.TabIndex = 6;
            this.tabPageElementPicture.Text = "Изображения элементов";
            this.tabPageElementPicture.UseVisualStyleBackColor = true;
            // 
            // gbElementPictureData
            // 
            this.gbElementPictureData.Controls.Add(this.btnElementPictureSwitchCancel);
            this.gbElementPictureData.Controls.Add(this.btnElementPictureUpdate);
            this.gbElementPictureData.Controls.Add(this.gbElementPictureNamePicture);
            this.gbElementPictureData.Controls.Add(this.btnElementPictureCreate);
            this.gbElementPictureData.Location = new System.Drawing.Point(979, 3);
            this.gbElementPictureData.Name = "gbElementPictureData";
            this.gbElementPictureData.Size = new System.Drawing.Size(752, 899);
            this.gbElementPictureData.TabIndex = 7;
            this.gbElementPictureData.TabStop = false;
            this.gbElementPictureData.Text = "Изображение";
            // 
            // btnElementPictureSwitchCancel
            // 
            this.btnElementPictureSwitchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnElementPictureSwitchCancel.Location = new System.Drawing.Point(18, 228);
            this.btnElementPictureSwitchCancel.Name = "btnElementPictureSwitchCancel";
            this.btnElementPictureSwitchCancel.Size = new System.Drawing.Size(152, 42);
            this.btnElementPictureSwitchCancel.TabIndex = 50;
            this.btnElementPictureSwitchCancel.Text = "Отменить";
            this.btnElementPictureSwitchCancel.UseVisualStyleBackColor = true;
            this.btnElementPictureSwitchCancel.Click += new System.EventHandler(this.BtnElementPictureSwitchCancel_Click);
            // 
            // btnElementPictureUpdate
            // 
            this.btnElementPictureUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnElementPictureUpdate.Location = new System.Drawing.Point(427, 228);
            this.btnElementPictureUpdate.Name = "btnElementPictureUpdate";
            this.btnElementPictureUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnElementPictureUpdate.TabIndex = 48;
            this.btnElementPictureUpdate.Text = "Сохранить изменения";
            this.btnElementPictureUpdate.UseVisualStyleBackColor = true;
            this.btnElementPictureUpdate.Visible = false;
            this.btnElementPictureUpdate.Click += new System.EventHandler(this.BtnElementPictureUpdate_Click);
            // 
            // gbElementPictureNamePicture
            // 
            this.gbElementPictureNamePicture.Controls.Add(this.btnElementPictureOpenFile);
            this.gbElementPictureNamePicture.Controls.Add(this.pbElementPictureLoadContent);
            this.gbElementPictureNamePicture.Controls.Add(this.lblElementPictureName);
            this.gbElementPictureNamePicture.Controls.Add(this.lblCheckElementPictureName);
            this.gbElementPictureNamePicture.Controls.Add(this.tbElementPictureName);
            this.gbElementPictureNamePicture.Controls.Add(this.pbCheckMarkElementPictureLoadContent);
            this.gbElementPictureNamePicture.Controls.Add(this.pbCheckMarkElementPictureName);
            this.gbElementPictureNamePicture.Enabled = false;
            this.gbElementPictureNamePicture.Location = new System.Drawing.Point(9, 19);
            this.gbElementPictureNamePicture.Name = "gbElementPictureNamePicture";
            this.gbElementPictureNamePicture.Size = new System.Drawing.Size(728, 190);
            this.gbElementPictureNamePicture.TabIndex = 49;
            this.gbElementPictureNamePicture.TabStop = false;
            // 
            // btnElementPictureOpenFile
            // 
            this.btnElementPictureOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnElementPictureOpenFile.Location = new System.Drawing.Point(9, 74);
            this.btnElementPictureOpenFile.Name = "btnElementPictureOpenFile";
            this.btnElementPictureOpenFile.Size = new System.Drawing.Size(152, 42);
            this.btnElementPictureOpenFile.TabIndex = 51;
            this.btnElementPictureOpenFile.Text = "Открыть файл";
            this.btnElementPictureOpenFile.UseVisualStyleBackColor = true;
            this.btnElementPictureOpenFile.Click += new System.EventHandler(this.BtnElementPictureOpenFile_Click);
            // 
            // pbElementPictureLoadContent
            // 
            this.pbElementPictureLoadContent.Location = new System.Drawing.Point(225, 74);
            this.pbElementPictureLoadContent.Name = "pbElementPictureLoadContent";
            this.pbElementPictureLoadContent.Size = new System.Drawing.Size(131, 109);
            this.pbElementPictureLoadContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbElementPictureLoadContent.TabIndex = 52;
            this.pbElementPictureLoadContent.TabStop = false;
            this.pbElementPictureLoadContent.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PbElementPictureLoadContent_LoadCompleted);
            // 
            // lblElementPictureName
            // 
            this.lblElementPictureName.AutoSize = true;
            this.lblElementPictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblElementPictureName.Location = new System.Drawing.Point(6, 26);
            this.lblElementPictureName.Name = "lblElementPictureName";
            this.lblElementPictureName.Size = new System.Drawing.Size(72, 17);
            this.lblElementPictureName.TabIndex = 24;
            this.lblElementPictureName.Text = "Название";
            // 
            // lblCheckElementPictureName
            // 
            this.lblCheckElementPictureName.AutoSize = true;
            this.lblCheckElementPictureName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckElementPictureName.Location = new System.Drawing.Point(6, 53);
            this.lblCheckElementPictureName.Name = "lblCheckElementPictureName";
            this.lblCheckElementPictureName.Size = new System.Drawing.Size(505, 13);
            this.lblCheckElementPictureName.TabIndex = 44;
            this.lblCheckElementPictureName.Text = "Введите название длиной от 3 до 100 символов, используя кирилицу цифры и знаки пр" +
    "епинания ";
            this.lblCheckElementPictureName.Visible = false;
            // 
            // tbElementPictureName
            // 
            this.tbElementPictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbElementPictureName.Location = new System.Drawing.Point(225, 26);
            this.tbElementPictureName.Name = "tbElementPictureName";
            this.tbElementPictureName.Size = new System.Drawing.Size(369, 23);
            this.tbElementPictureName.TabIndex = 25;
            this.tbElementPictureName.TextChanged += new System.EventHandler(this.TbElementPictureName_TextChanged);
            // 
            // pbCheckMarkElementPictureLoadContent
            // 
            this.pbCheckMarkElementPictureLoadContent.Location = new System.Drawing.Point(601, 74);
            this.pbCheckMarkElementPictureLoadContent.Name = "pbCheckMarkElementPictureLoadContent";
            this.pbCheckMarkElementPictureLoadContent.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkElementPictureLoadContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkElementPictureLoadContent.TabIndex = 40;
            this.pbCheckMarkElementPictureLoadContent.TabStop = false;
            this.pbCheckMarkElementPictureLoadContent.Visible = false;
            // 
            // pbCheckMarkElementPictureName
            // 
            this.pbCheckMarkElementPictureName.Location = new System.Drawing.Point(601, 24);
            this.pbCheckMarkElementPictureName.Name = "pbCheckMarkElementPictureName";
            this.pbCheckMarkElementPictureName.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkElementPictureName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkElementPictureName.TabIndex = 39;
            this.pbCheckMarkElementPictureName.TabStop = false;
            this.pbCheckMarkElementPictureName.Visible = false;
            // 
            // btnElementPictureCreate
            // 
            this.btnElementPictureCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnElementPictureCreate.Location = new System.Drawing.Point(585, 228);
            this.btnElementPictureCreate.Name = "btnElementPictureCreate";
            this.btnElementPictureCreate.Size = new System.Drawing.Size(152, 42);
            this.btnElementPictureCreate.TabIndex = 36;
            this.btnElementPictureCreate.Text = "Сохранить изображение";
            this.btnElementPictureCreate.UseVisualStyleBackColor = true;
            this.btnElementPictureCreate.Visible = false;
            this.btnElementPictureCreate.Click += new System.EventHandler(this.BtnElementPictureCreate_Click);
            // 
            // gbAllElementPicture
            // 
            this.gbAllElementPicture.Controls.Add(this.pbElementPictureSelectedDgv);
            this.gbAllElementPicture.Controls.Add(this.btnElementPictureDelete);
            this.gbAllElementPicture.Controls.Add(this.btnElementPictureSwitchUpdate);
            this.gbAllElementPicture.Controls.Add(this.btnElementPictureSwitchCreate);
            this.gbAllElementPicture.Controls.Add(this.dgvAllElementPicture);
            this.gbAllElementPicture.Location = new System.Drawing.Point(3, 3);
            this.gbAllElementPicture.Name = "gbAllElementPicture";
            this.gbAllElementPicture.Size = new System.Drawing.Size(968, 899);
            this.gbAllElementPicture.TabIndex = 6;
            this.gbAllElementPicture.TabStop = false;
            this.gbAllElementPicture.Text = "Все изображения";
            // 
            // pbElementPictureSelectedDgv
            // 
            this.pbElementPictureSelectedDgv.Location = new System.Drawing.Point(596, 19);
            this.pbElementPictureSelectedDgv.Name = "pbElementPictureSelectedDgv";
            this.pbElementPictureSelectedDgv.Size = new System.Drawing.Size(250, 201);
            this.pbElementPictureSelectedDgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbElementPictureSelectedDgv.TabIndex = 53;
            this.pbElementPictureSelectedDgv.TabStop = false;
            // 
            // btnElementPictureDelete
            // 
            this.btnElementPictureDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElementPictureDelete.Location = new System.Drawing.Point(852, 130);
            this.btnElementPictureDelete.Name = "btnElementPictureDelete";
            this.btnElementPictureDelete.Size = new System.Drawing.Size(110, 35);
            this.btnElementPictureDelete.TabIndex = 10;
            this.btnElementPictureDelete.Text = "Удалить изображение";
            this.btnElementPictureDelete.UseVisualStyleBackColor = true;
            this.btnElementPictureDelete.Click += new System.EventHandler(this.BtnElementPictureDelete_Click);
            // 
            // btnElementPictureSwitchUpdate
            // 
            this.btnElementPictureSwitchUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElementPictureSwitchUpdate.Location = new System.Drawing.Point(852, 74);
            this.btnElementPictureSwitchUpdate.Name = "btnElementPictureSwitchUpdate";
            this.btnElementPictureSwitchUpdate.Size = new System.Drawing.Size(110, 49);
            this.btnElementPictureSwitchUpdate.TabIndex = 9;
            this.btnElementPictureSwitchUpdate.Text = "Редактировать изображение";
            this.btnElementPictureSwitchUpdate.UseVisualStyleBackColor = true;
            this.btnElementPictureSwitchUpdate.Click += new System.EventHandler(this.BtnElementPictureSwitchUpdate_Click);
            // 
            // btnElementPictureSwitchCreate
            // 
            this.btnElementPictureSwitchCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElementPictureSwitchCreate.Location = new System.Drawing.Point(852, 19);
            this.btnElementPictureSwitchCreate.Name = "btnElementPictureSwitchCreate";
            this.btnElementPictureSwitchCreate.Size = new System.Drawing.Size(110, 49);
            this.btnElementPictureSwitchCreate.TabIndex = 8;
            this.btnElementPictureSwitchCreate.Text = "Добавить изображение";
            this.btnElementPictureSwitchCreate.UseVisualStyleBackColor = true;
            this.btnElementPictureSwitchCreate.Click += new System.EventHandler(this.BtnElementPictureSwitchCreate_Click);
            // 
            // dgvAllElementPicture
            // 
            this.dgvAllElementPicture.AllowUserToAddRows = false;
            this.dgvAllElementPicture.AllowUserToDeleteRows = false;
            this.dgvAllElementPicture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllElementPicture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dgvTbColumnPictureName,
            this.ColumnElementPicturePicture});
            this.dgvAllElementPicture.Location = new System.Drawing.Point(5, 19);
            this.dgvAllElementPicture.Name = "dgvAllElementPicture";
            this.dgvAllElementPicture.ReadOnly = true;
            this.dgvAllElementPicture.RowHeadersVisible = false;
            this.dgvAllElementPicture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllElementPicture.Size = new System.Drawing.Size(536, 27);
            this.dgvAllElementPicture.TabIndex = 7;
            this.dgvAllElementPicture.SelectionChanged += new System.EventHandler(this.DgvAllElementPicture_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.Frozen = true;
            this.dataGridViewTextBoxColumn23.HeaderText = "№";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 30;
            // 
            // dgvTbColumnPictureName
            // 
            this.dgvTbColumnPictureName.Frozen = true;
            this.dgvTbColumnPictureName.HeaderText = "Название";
            this.dgvTbColumnPictureName.Name = "dgvTbColumnPictureName";
            this.dgvTbColumnPictureName.ReadOnly = true;
            this.dgvTbColumnPictureName.Width = 500;
            // 
            // ColumnElementPicturePicture
            // 
            this.ColumnElementPicturePicture.Frozen = true;
            this.ColumnElementPicturePicture.HeaderText = "Picture";
            this.ColumnElementPicturePicture.Name = "ColumnElementPicturePicture";
            this.ColumnElementPicturePicture.ReadOnly = true;
            this.ColumnElementPicturePicture.Visible = false;
            // 
            // tabPageSectionOfBuilding
            // 
            this.tabPageSectionOfBuilding.Controls.Add(this.btnSectionOfBuildingCancelWork);
            this.tabPageSectionOfBuilding.Controls.Add(this.gbSectionOfBuildingPanel);
            this.tabPageSectionOfBuilding.Controls.Add(this.btnSectionOfBuildingSetWork);
            this.tabPageSectionOfBuilding.Controls.Add(this.gbTypeOfElementInProjectBySectionOfBuilding);
            this.tabPageSectionOfBuilding.Controls.Add(this.btnSectionOfBuildingSwitchSetWork);
            this.tabPageSectionOfBuilding.Controls.Add(this.gbAllSectionsOfBuilding);
            this.tabPageSectionOfBuilding.Controls.Add(this.btnSectionOfBuildingSwitchModelCancel);
            this.tabPageSectionOfBuilding.Controls.Add(this.btnSectionOfBuildingSwitchModelUpdate);
            this.tabPageSectionOfBuilding.Controls.Add(this.btnSectionOfBuildingModelUpdate);
            this.tabPageSectionOfBuilding.Location = new System.Drawing.Point(4, 22);
            this.tabPageSectionOfBuilding.Name = "tabPageSectionOfBuilding";
            this.tabPageSectionOfBuilding.Size = new System.Drawing.Size(1951, 946);
            this.tabPageSectionOfBuilding.TabIndex = 7;
            this.tabPageSectionOfBuilding.Text = "Модель фасада";
            this.tabPageSectionOfBuilding.UseVisualStyleBackColor = true;
            // 
            // gbSectionOfBuildingPanel
            // 
            this.gbSectionOfBuildingPanel.Controls.Add(this.SectionOfBuildingModel);
            this.gbSectionOfBuildingPanel.Controls.Add(this.btnSectionOfBuildingSwitchCancel);
            this.gbSectionOfBuildingPanel.Controls.Add(this.btnSectionOfBuildingCreate);
            this.gbSectionOfBuildingPanel.Controls.Add(this.gbSectionOfBuildingData);
            this.gbSectionOfBuildingPanel.Controls.Add(this.btnSectionOfBuildingUpdate);
            this.gbSectionOfBuildingPanel.Location = new System.Drawing.Point(766, 3);
            this.gbSectionOfBuildingPanel.Name = "gbSectionOfBuildingPanel";
            this.gbSectionOfBuildingPanel.Size = new System.Drawing.Size(965, 916);
            this.gbSectionOfBuildingPanel.TabIndex = 8;
            this.gbSectionOfBuildingPanel.TabStop = false;
            this.gbSectionOfBuildingPanel.Text = "Данные модели участка фасада";
            // 
            // SectionOfBuildingModel
            // 
            this.SectionOfBuildingModel.Controls.Add(this.dgvSectionOfBuildingModel);
            this.SectionOfBuildingModel.Location = new System.Drawing.Point(4, 137);
            this.SectionOfBuildingModel.Name = "SectionOfBuildingModel";
            this.SectionOfBuildingModel.Size = new System.Drawing.Size(955, 773);
            this.SectionOfBuildingModel.TabIndex = 51;
            this.SectionOfBuildingModel.TabStop = false;
            this.SectionOfBuildingModel.Text = "Модель фасада";
            // 
            // btnSectionOfBuildingCancelWork
            // 
            this.btnSectionOfBuildingCancelWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingCancelWork.Location = new System.Drawing.Point(1737, 256);
            this.btnSectionOfBuildingCancelWork.Name = "btnSectionOfBuildingCancelWork";
            this.btnSectionOfBuildingCancelWork.Size = new System.Drawing.Size(171, 42);
            this.btnSectionOfBuildingCancelWork.TabIndex = 67;
            this.btnSectionOfBuildingCancelWork.Text = "Отменить назначение";
            this.btnSectionOfBuildingCancelWork.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingCancelWork.Visible = false;
            this.btnSectionOfBuildingCancelWork.Click += new System.EventHandler(this.BtnSectionOfBuildingCancelWork_Click);
            // 
            // btnSectionOfBuildingSetWork
            // 
            this.btnSectionOfBuildingSetWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingSetWork.Location = new System.Drawing.Point(1737, 208);
            this.btnSectionOfBuildingSetWork.Name = "btnSectionOfBuildingSetWork";
            this.btnSectionOfBuildingSetWork.Size = new System.Drawing.Size(171, 42);
            this.btnSectionOfBuildingSetWork.TabIndex = 66;
            this.btnSectionOfBuildingSetWork.Text = "Назначить работу";
            this.btnSectionOfBuildingSetWork.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingSetWork.Visible = false;
            this.btnSectionOfBuildingSetWork.Click += new System.EventHandler(this.BtnSectionOfBuildingSetWork_Click);
            // 
            // btnSectionOfBuildingSwitchSetWork
            // 
            this.btnSectionOfBuildingSwitchSetWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSectionOfBuildingSwitchSetWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingSwitchSetWork.Location = new System.Drawing.Point(1737, 159);
            this.btnSectionOfBuildingSwitchSetWork.Name = "btnSectionOfBuildingSwitchSetWork";
            this.btnSectionOfBuildingSwitchSetWork.Size = new System.Drawing.Size(171, 43);
            this.btnSectionOfBuildingSwitchSetWork.TabIndex = 65;
            this.btnSectionOfBuildingSwitchSetWork.Text = "Работы на фасаде";
            this.btnSectionOfBuildingSwitchSetWork.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingSwitchSetWork.Visible = false;
            this.btnSectionOfBuildingSwitchSetWork.Click += new System.EventHandler(this.BtnSectionOfBuildingSwitchSetWork_Click);
            // 
            // btnSectionOfBuildingSwitchModelCancel
            // 
            this.btnSectionOfBuildingSwitchModelCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingSwitchModelCancel.Location = new System.Drawing.Point(1737, 111);
            this.btnSectionOfBuildingSwitchModelCancel.Name = "btnSectionOfBuildingSwitchModelCancel";
            this.btnSectionOfBuildingSwitchModelCancel.Size = new System.Drawing.Size(171, 42);
            this.btnSectionOfBuildingSwitchModelCancel.TabIndex = 52;
            this.btnSectionOfBuildingSwitchModelCancel.Text = "Назад";
            this.btnSectionOfBuildingSwitchModelCancel.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingSwitchModelCancel.Visible = false;
            this.btnSectionOfBuildingSwitchModelCancel.Click += new System.EventHandler(this.BtnSectionOfBuildingSwitchModelCancel_Click);
            // 
            // btnSectionOfBuildingModelUpdate
            // 
            this.btnSectionOfBuildingModelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingModelUpdate.Location = new System.Drawing.Point(1737, 61);
            this.btnSectionOfBuildingModelUpdate.Name = "btnSectionOfBuildingModelUpdate";
            this.btnSectionOfBuildingModelUpdate.Size = new System.Drawing.Size(171, 42);
            this.btnSectionOfBuildingModelUpdate.TabIndex = 52;
            this.btnSectionOfBuildingModelUpdate.Text = "Сохранить изменения";
            this.btnSectionOfBuildingModelUpdate.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingModelUpdate.Visible = false;
            this.btnSectionOfBuildingModelUpdate.Click += new System.EventHandler(this.BtnSectionOfBuildingModelUpdate_Click);
            // 
            // btnSectionOfBuildingSwitchModelUpdate
            // 
            this.btnSectionOfBuildingSwitchModelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSectionOfBuildingSwitchModelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingSwitchModelUpdate.Location = new System.Drawing.Point(1737, 8);
            this.btnSectionOfBuildingSwitchModelUpdate.Name = "btnSectionOfBuildingSwitchModelUpdate";
            this.btnSectionOfBuildingSwitchModelUpdate.Size = new System.Drawing.Size(171, 42);
            this.btnSectionOfBuildingSwitchModelUpdate.TabIndex = 64;
            this.btnSectionOfBuildingSwitchModelUpdate.Text = "Редактировать модель ";
            this.btnSectionOfBuildingSwitchModelUpdate.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingSwitchModelUpdate.Visible = false;
            this.btnSectionOfBuildingSwitchModelUpdate.Click += new System.EventHandler(this.BtnSectionOfBuildingSwitchModelUpdate_Click);
            // 
            // dgvSectionOfBuildingModel
            // 
            this.dgvSectionOfBuildingModel.AllowDrop = true;
            this.dgvSectionOfBuildingModel.AllowUserToAddRows = false;
            this.dgvSectionOfBuildingModel.AllowUserToDeleteRows = false;
            this.dgvSectionOfBuildingModel.AllowUserToResizeColumns = false;
            this.dgvSectionOfBuildingModel.AllowUserToResizeRows = false;
            this.dgvSectionOfBuildingModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSectionOfBuildingModel.Location = new System.Drawing.Point(6, 19);
            this.dgvSectionOfBuildingModel.Name = "dgvSectionOfBuildingModel";
            this.dgvSectionOfBuildingModel.Size = new System.Drawing.Size(943, 748);
            this.dgvSectionOfBuildingModel.TabIndex = 1;
            this.dgvSectionOfBuildingModel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvSectionOfBuildingModel_DragDrop);
            this.dgvSectionOfBuildingModel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DgvSectionOfBuildingModel_DragEnter);
            // 
            // btnSectionOfBuildingSwitchCancel
            // 
            this.btnSectionOfBuildingSwitchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingSwitchCancel.Location = new System.Drawing.Point(682, 47);
            this.btnSectionOfBuildingSwitchCancel.Name = "btnSectionOfBuildingSwitchCancel";
            this.btnSectionOfBuildingSwitchCancel.Size = new System.Drawing.Size(152, 31);
            this.btnSectionOfBuildingSwitchCancel.TabIndex = 50;
            this.btnSectionOfBuildingSwitchCancel.Text = "Отменить";
            this.btnSectionOfBuildingSwitchCancel.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingSwitchCancel.Visible = false;
            this.btnSectionOfBuildingSwitchCancel.Click += new System.EventHandler(this.BtnSectionOfBuildingSwitchCancel_Click);
            // 
            // btnSectionOfBuildingCreate
            // 
            this.btnSectionOfBuildingCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingCreate.Location = new System.Drawing.Point(682, 12);
            this.btnSectionOfBuildingCreate.Name = "btnSectionOfBuildingCreate";
            this.btnSectionOfBuildingCreate.Size = new System.Drawing.Size(152, 29);
            this.btnSectionOfBuildingCreate.TabIndex = 48;
            this.btnSectionOfBuildingCreate.Text = "Сохранить модель";
            this.btnSectionOfBuildingCreate.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingCreate.Visible = false;
            this.btnSectionOfBuildingCreate.Click += new System.EventHandler(this.BtnSectionOfBuildingCreate_Click);
            // 
            // gbSectionOfBuildingData
            // 
            this.gbSectionOfBuildingData.Controls.Add(this.lblSectuinOfBuildingSquare);
            this.gbSectionOfBuildingData.Controls.Add(this.lblCheckSectionOfBuildingQuantityByWidth);
            this.gbSectionOfBuildingData.Controls.Add(this.tbSectionOfBuildingQuantityByWidth);
            this.gbSectionOfBuildingData.Controls.Add(this.lblSectionOfBuildingQuantityByWidth);
            this.gbSectionOfBuildingData.Controls.Add(this.pbCheckMarkSectionOfBuildingQuantityByWidth);
            this.gbSectionOfBuildingData.Controls.Add(this.lblSectionOfBuildingName);
            this.gbSectionOfBuildingData.Controls.Add(this.lblCheckSectionOfBuildingQuantityByHeight);
            this.gbSectionOfBuildingData.Controls.Add(this.tbSectionOfBuildingQuantityByHeight);
            this.gbSectionOfBuildingData.Controls.Add(this.lblCheckSectionOfBuildingName);
            this.gbSectionOfBuildingData.Controls.Add(this.lblSectionOfBuildingQuantityByHeight);
            this.gbSectionOfBuildingData.Controls.Add(this.tbSectionOfBuildingName);
            this.gbSectionOfBuildingData.Controls.Add(this.pbCheckMarkSectionOfBuildingQuantityByHeight);
            this.gbSectionOfBuildingData.Controls.Add(this.pbCheckMarkSectionOfBuildingName);
            this.gbSectionOfBuildingData.Enabled = false;
            this.gbSectionOfBuildingData.Location = new System.Drawing.Point(4, 10);
            this.gbSectionOfBuildingData.Name = "gbSectionOfBuildingData";
            this.gbSectionOfBuildingData.Size = new System.Drawing.Size(655, 121);
            this.gbSectionOfBuildingData.TabIndex = 49;
            this.gbSectionOfBuildingData.TabStop = false;
            // 
            // lblSectuinOfBuildingSquare
            // 
            this.lblSectuinOfBuildingSquare.AutoSize = true;
            this.lblSectuinOfBuildingSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectuinOfBuildingSquare.Location = new System.Drawing.Point(393, 61);
            this.lblSectuinOfBuildingSquare.Name = "lblSectuinOfBuildingSquare";
            this.lblSectuinOfBuildingSquare.Size = new System.Drawing.Size(120, 17);
            this.lblSectuinOfBuildingSquare.TabIndex = 50;
            this.lblSectuinOfBuildingSquare.Text = "Общая площадь ";
            // 
            // lblCheckSectionOfBuildingQuantityByWidth
            // 
            this.lblCheckSectionOfBuildingQuantityByWidth.AutoSize = true;
            this.lblCheckSectionOfBuildingQuantityByWidth.ForeColor = System.Drawing.Color.Red;
            this.lblCheckSectionOfBuildingQuantityByWidth.Location = new System.Drawing.Point(6, 107);
            this.lblCheckSectionOfBuildingQuantityByWidth.Name = "lblCheckSectionOfBuildingQuantityByWidth";
            this.lblCheckSectionOfBuildingQuantityByWidth.Size = new System.Drawing.Size(205, 13);
            this.lblCheckSectionOfBuildingQuantityByWidth.TabIndex = 49;
            this.lblCheckSectionOfBuildingQuantityByWidth.Text = "Введите целое неотрицательное число";
            this.lblCheckSectionOfBuildingQuantityByWidth.Visible = false;
            // 
            // tbSectionOfBuildingQuantityByWidth
            // 
            this.tbSectionOfBuildingQuantityByWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSectionOfBuildingQuantityByWidth.Location = new System.Drawing.Point(244, 89);
            this.tbSectionOfBuildingQuantityByWidth.Name = "tbSectionOfBuildingQuantityByWidth";
            this.tbSectionOfBuildingQuantityByWidth.Size = new System.Drawing.Size(110, 23);
            this.tbSectionOfBuildingQuantityByWidth.TabIndex = 47;
            this.tbSectionOfBuildingQuantityByWidth.TextChanged += new System.EventHandler(this.TbSectionOfBuildingQuantityByWidth_TextChanged);
            // 
            // lblSectionOfBuildingQuantityByWidth
            // 
            this.lblSectionOfBuildingQuantityByWidth.AutoSize = true;
            this.lblSectionOfBuildingQuantityByWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuildingQuantityByWidth.Location = new System.Drawing.Point(6, 89);
            this.lblSectionOfBuildingQuantityByWidth.Name = "lblSectionOfBuildingQuantityByWidth";
            this.lblSectionOfBuildingQuantityByWidth.Size = new System.Drawing.Size(235, 17);
            this.lblSectionOfBuildingQuantityByWidth.TabIndex = 46;
            this.lblSectionOfBuildingQuantityByWidth.Text = "Количество элементов по ширине";
            // 
            // pbCheckMarkSectionOfBuildingQuantityByWidth
            // 
            this.pbCheckMarkSectionOfBuildingQuantityByWidth.Location = new System.Drawing.Point(360, 89);
            this.pbCheckMarkSectionOfBuildingQuantityByWidth.Name = "pbCheckMarkSectionOfBuildingQuantityByWidth";
            this.pbCheckMarkSectionOfBuildingQuantityByWidth.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkSectionOfBuildingQuantityByWidth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkSectionOfBuildingQuantityByWidth.TabIndex = 48;
            this.pbCheckMarkSectionOfBuildingQuantityByWidth.TabStop = false;
            this.pbCheckMarkSectionOfBuildingQuantityByWidth.Visible = false;
            // 
            // lblSectionOfBuildingName
            // 
            this.lblSectionOfBuildingName.AutoSize = true;
            this.lblSectionOfBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuildingName.Location = new System.Drawing.Point(6, 14);
            this.lblSectionOfBuildingName.Name = "lblSectionOfBuildingName";
            this.lblSectionOfBuildingName.Size = new System.Drawing.Size(182, 17);
            this.lblSectionOfBuildingName.TabIndex = 24;
            this.lblSectionOfBuildingName.Text = "Название участка фасада";
            // 
            // lblCheckSectionOfBuildingQuantityByHeight
            // 
            this.lblCheckSectionOfBuildingQuantityByHeight.AutoSize = true;
            this.lblCheckSectionOfBuildingQuantityByHeight.ForeColor = System.Drawing.Color.Red;
            this.lblCheckSectionOfBuildingQuantityByHeight.Location = new System.Drawing.Point(6, 74);
            this.lblCheckSectionOfBuildingQuantityByHeight.Name = "lblCheckSectionOfBuildingQuantityByHeight";
            this.lblCheckSectionOfBuildingQuantityByHeight.Size = new System.Drawing.Size(205, 13);
            this.lblCheckSectionOfBuildingQuantityByHeight.TabIndex = 45;
            this.lblCheckSectionOfBuildingQuantityByHeight.Text = "Введите целое неотрицательное число";
            this.lblCheckSectionOfBuildingQuantityByHeight.Visible = false;
            // 
            // tbSectionOfBuildingQuantityByHeight
            // 
            this.tbSectionOfBuildingQuantityByHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSectionOfBuildingQuantityByHeight.Location = new System.Drawing.Point(244, 56);
            this.tbSectionOfBuildingQuantityByHeight.Name = "tbSectionOfBuildingQuantityByHeight";
            this.tbSectionOfBuildingQuantityByHeight.Size = new System.Drawing.Size(110, 23);
            this.tbSectionOfBuildingQuantityByHeight.TabIndex = 27;
            this.tbSectionOfBuildingQuantityByHeight.TextChanged += new System.EventHandler(this.TbSectionOfBuildingQuantityByHeight_TextChanged);
            // 
            // lblCheckSectionOfBuildingName
            // 
            this.lblCheckSectionOfBuildingName.AutoSize = true;
            this.lblCheckSectionOfBuildingName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckSectionOfBuildingName.Location = new System.Drawing.Point(6, 41);
            this.lblCheckSectionOfBuildingName.Name = "lblCheckSectionOfBuildingName";
            this.lblCheckSectionOfBuildingName.Size = new System.Drawing.Size(505, 13);
            this.lblCheckSectionOfBuildingName.TabIndex = 44;
            this.lblCheckSectionOfBuildingName.Text = "Введите название длиной от 3 до 100 символов, используя кирилицу цифры и знаки пр" +
    "епинания ";
            this.lblCheckSectionOfBuildingName.Visible = false;
            // 
            // lblSectionOfBuildingQuantityByHeight
            // 
            this.lblSectionOfBuildingQuantityByHeight.AutoSize = true;
            this.lblSectionOfBuildingQuantityByHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuildingQuantityByHeight.Location = new System.Drawing.Point(6, 56);
            this.lblSectionOfBuildingQuantityByHeight.Name = "lblSectionOfBuildingQuantityByHeight";
            this.lblSectionOfBuildingQuantityByHeight.Size = new System.Drawing.Size(137, 17);
            this.lblSectionOfBuildingQuantityByHeight.TabIndex = 26;
            this.lblSectionOfBuildingQuantityByHeight.Text = "Количество этажей";
            // 
            // tbSectionOfBuildingName
            // 
            this.tbSectionOfBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSectionOfBuildingName.Location = new System.Drawing.Point(244, 14);
            this.tbSectionOfBuildingName.Name = "tbSectionOfBuildingName";
            this.tbSectionOfBuildingName.Size = new System.Drawing.Size(369, 23);
            this.tbSectionOfBuildingName.TabIndex = 25;
            this.tbSectionOfBuildingName.TextChanged += new System.EventHandler(this.TbSectionOfBuildingName_TextChanged);
            // 
            // pbCheckMarkSectionOfBuildingQuantityByHeight
            // 
            this.pbCheckMarkSectionOfBuildingQuantityByHeight.Location = new System.Drawing.Point(360, 56);
            this.pbCheckMarkSectionOfBuildingQuantityByHeight.Name = "pbCheckMarkSectionOfBuildingQuantityByHeight";
            this.pbCheckMarkSectionOfBuildingQuantityByHeight.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkSectionOfBuildingQuantityByHeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkSectionOfBuildingQuantityByHeight.TabIndex = 40;
            this.pbCheckMarkSectionOfBuildingQuantityByHeight.TabStop = false;
            this.pbCheckMarkSectionOfBuildingQuantityByHeight.Visible = false;
            // 
            // pbCheckMarkSectionOfBuildingName
            // 
            this.pbCheckMarkSectionOfBuildingName.Location = new System.Drawing.Point(620, 12);
            this.pbCheckMarkSectionOfBuildingName.Name = "pbCheckMarkSectionOfBuildingName";
            this.pbCheckMarkSectionOfBuildingName.Size = new System.Drawing.Size(27, 25);
            this.pbCheckMarkSectionOfBuildingName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheckMarkSectionOfBuildingName.TabIndex = 39;
            this.pbCheckMarkSectionOfBuildingName.TabStop = false;
            this.pbCheckMarkSectionOfBuildingName.Visible = false;
            // 
            // btnSectionOfBuildingUpdate
            // 
            this.btnSectionOfBuildingUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSectionOfBuildingUpdate.Location = new System.Drawing.Point(682, 84);
            this.btnSectionOfBuildingUpdate.Name = "btnSectionOfBuildingUpdate";
            this.btnSectionOfBuildingUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnSectionOfBuildingUpdate.TabIndex = 36;
            this.btnSectionOfBuildingUpdate.Text = "Сохранить изменения";
            this.btnSectionOfBuildingUpdate.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingUpdate.Visible = false;
            this.btnSectionOfBuildingUpdate.Click += new System.EventHandler(this.BtnSectionOfBuildingUpdate_Click);
            // 
            // gbTypeOfElementInProjectBySectionOfBuilding
            // 
            this.gbTypeOfElementInProjectBySectionOfBuilding.Controls.Add(this.lblSectionOfBuildingWorksAmount);
            this.gbTypeOfElementInProjectBySectionOfBuilding.Controls.Add(this.dgvSectionOfBuildingWorkInProject);
            this.gbTypeOfElementInProjectBySectionOfBuilding.Controls.Add(this.lvSectionOfBuildingTypesOfElementInProject);
            this.gbTypeOfElementInProjectBySectionOfBuilding.Controls.Add(this.lblSectionOfBuldingActualProjectNotSaved2);
            this.gbTypeOfElementInProjectBySectionOfBuilding.Location = new System.Drawing.Point(3, 401);
            this.gbTypeOfElementInProjectBySectionOfBuilding.Name = "gbTypeOfElementInProjectBySectionOfBuilding";
            this.gbTypeOfElementInProjectBySectionOfBuilding.Size = new System.Drawing.Size(761, 518);
            this.gbTypeOfElementInProjectBySectionOfBuilding.TabIndex = 7;
            this.gbTypeOfElementInProjectBySectionOfBuilding.TabStop = false;
            this.gbTypeOfElementInProjectBySectionOfBuilding.Text = "Элементы фасада текущего проекта";
            // 
            // lblSectionOfBuildingWorksAmount
            // 
            this.lblSectionOfBuildingWorksAmount.AutoSize = true;
            this.lblSectionOfBuildingWorksAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuildingWorksAmount.ForeColor = System.Drawing.Color.Black;
            this.lblSectionOfBuildingWorksAmount.Location = new System.Drawing.Point(2, 16);
            this.lblSectionOfBuildingWorksAmount.Name = "lblSectionOfBuildingWorksAmount";
            this.lblSectionOfBuildingWorksAmount.Size = new System.Drawing.Size(222, 17);
            this.lblSectionOfBuildingWorksAmount.TabIndex = 66;
            this.lblSectionOfBuildingWorksAmount.Text = "Общая стоимость работ модели";
            // 
            // dgvSectionOfBuildingWorkInProject
            // 
            this.dgvSectionOfBuildingWorkInProject.AllowUserToAddRows = false;
            this.dgvSectionOfBuildingWorkInProject.AllowUserToDeleteRows = false;
            this.dgvSectionOfBuildingWorkInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSectionOfBuildingWorkInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.ColumnSectionValue,
            this.ColumnSectionCost});
            this.dgvSectionOfBuildingWorkInProject.Location = new System.Drawing.Point(0, 36);
            this.dgvSectionOfBuildingWorkInProject.Name = "dgvSectionOfBuildingWorkInProject";
            this.dgvSectionOfBuildingWorkInProject.ReadOnly = true;
            this.dgvSectionOfBuildingWorkInProject.RowHeadersVisible = false;
            this.dgvSectionOfBuildingWorkInProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSectionOfBuildingWorkInProject.Size = new System.Drawing.Size(755, 27);
            this.dgvSectionOfBuildingWorkInProject.TabIndex = 63;
            this.dgvSectionOfBuildingWorkInProject.Visible = false;
            this.dgvSectionOfBuildingWorkInProject.SelectionChanged += new System.EventHandler(this.DgvSectionOfBuildingWorkInProject_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.Frozen = true;
            this.dataGridViewTextBoxColumn29.HeaderText = "Id";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 30;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.Frozen = true;
            this.dataGridViewTextBoxColumn30.HeaderText = "Название";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 330;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.Frozen = true;
            this.dataGridViewTextBoxColumn42.HeaderText = "Ед. изм.";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 80;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.Frozen = true;
            this.dataGridViewTextBoxColumn43.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 60;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.Frozen = true;
            this.dataGridViewTextBoxColumn44.HeaderText = "Коэф.";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Width = 70;
            // 
            // ColumnSectionValue
            // 
            this.ColumnSectionValue.Frozen = true;
            this.ColumnSectionValue.HeaderText = "Объем";
            this.ColumnSectionValue.Name = "ColumnSectionValue";
            this.ColumnSectionValue.ReadOnly = true;
            this.ColumnSectionValue.Width = 70;
            // 
            // ColumnSectionCost
            // 
            this.ColumnSectionCost.Frozen = true;
            this.ColumnSectionCost.HeaderText = "Стоимость";
            this.ColumnSectionCost.Name = "ColumnSectionCost";
            this.ColumnSectionCost.ReadOnly = true;
            // 
            // lvSectionOfBuildingTypesOfElementInProject
            // 
            this.lvSectionOfBuildingTypesOfElementInProject.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvSectionOfBuildingTypesOfElementInProject.AllowDrop = true;
            this.lvSectionOfBuildingTypesOfElementInProject.Enabled = false;
            this.lvSectionOfBuildingTypesOfElementInProject.GridLines = true;
            this.lvSectionOfBuildingTypesOfElementInProject.Location = new System.Drawing.Point(5, 36);
            this.lvSectionOfBuildingTypesOfElementInProject.MultiSelect = false;
            this.lvSectionOfBuildingTypesOfElementInProject.Name = "lvSectionOfBuildingTypesOfElementInProject";
            this.lvSectionOfBuildingTypesOfElementInProject.Size = new System.Drawing.Size(635, 476);
            this.lvSectionOfBuildingTypesOfElementInProject.TabIndex = 1;
            this.lvSectionOfBuildingTypesOfElementInProject.UseCompatibleStateImageBehavior = false;
            this.lvSectionOfBuildingTypesOfElementInProject.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvSectionOfBuildingTypesOfElementInProject_ItemDrag);
            // 
            // lblSectionOfBuldingActualProjectNotSaved2
            // 
            this.lblSectionOfBuldingActualProjectNotSaved2.AutoSize = true;
            this.lblSectionOfBuldingActualProjectNotSaved2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuldingActualProjectNotSaved2.ForeColor = System.Drawing.Color.Red;
            this.lblSectionOfBuldingActualProjectNotSaved2.Location = new System.Drawing.Point(554, 16);
            this.lblSectionOfBuldingActualProjectNotSaved2.Name = "lblSectionOfBuldingActualProjectNotSaved2";
            this.lblSectionOfBuldingActualProjectNotSaved2.Size = new System.Drawing.Size(201, 17);
            this.lblSectionOfBuldingActualProjectNotSaved2.TabIndex = 62;
            this.lblSectionOfBuldingActualProjectNotSaved2.Text = "Текущий проект не сохранен";
            this.lblSectionOfBuldingActualProjectNotSaved2.Visible = false;
            // 
            // gbAllSectionsOfBuilding
            // 
            this.gbAllSectionsOfBuilding.Controls.Add(this.lblSectionOfBuildingActualProjectWorksAmount);
            this.gbAllSectionsOfBuilding.Controls.Add(this.lblSectionOfBuildingActualProjectTotalSquare);
            this.gbAllSectionsOfBuilding.Controls.Add(this.lblSectionOfBuldingActualProjectNotSaved1);
            this.gbAllSectionsOfBuilding.Controls.Add(this.btnSectionOfBuildingDelete);
            this.gbAllSectionsOfBuilding.Controls.Add(this.btnSectionOfBuildingSwitchUpdate);
            this.gbAllSectionsOfBuilding.Controls.Add(this.btnSectionOfBuildingSwitchCreate);
            this.gbAllSectionsOfBuilding.Controls.Add(this.dgvSectionsOfBuildingByActualProject);
            this.gbAllSectionsOfBuilding.Location = new System.Drawing.Point(3, 3);
            this.gbAllSectionsOfBuilding.Name = "gbAllSectionsOfBuilding";
            this.gbAllSectionsOfBuilding.Size = new System.Drawing.Size(761, 392);
            this.gbAllSectionsOfBuilding.TabIndex = 6;
            this.gbAllSectionsOfBuilding.TabStop = false;
            this.gbAllSectionsOfBuilding.Text = "Все модели текущего проекта";
            // 
            // lblSectionOfBuildingActualProjectWorksAmount
            // 
            this.lblSectionOfBuildingActualProjectWorksAmount.AutoSize = true;
            this.lblSectionOfBuildingActualProjectWorksAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuildingActualProjectWorksAmount.ForeColor = System.Drawing.Color.Black;
            this.lblSectionOfBuildingActualProjectWorksAmount.Location = new System.Drawing.Point(6, 31);
            this.lblSectionOfBuildingActualProjectWorksAmount.Name = "lblSectionOfBuildingActualProjectWorksAmount";
            this.lblSectionOfBuildingActualProjectWorksAmount.Size = new System.Drawing.Size(219, 17);
            this.lblSectionOfBuildingActualProjectWorksAmount.TabIndex = 65;
            this.lblSectionOfBuildingActualProjectWorksAmount.Text = "Общая стоимость работ проект";
            // 
            // lblSectionOfBuildingActualProjectTotalSquare
            // 
            this.lblSectionOfBuildingActualProjectTotalSquare.AutoSize = true;
            this.lblSectionOfBuildingActualProjectTotalSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuildingActualProjectTotalSquare.ForeColor = System.Drawing.Color.Black;
            this.lblSectionOfBuildingActualProjectTotalSquare.Location = new System.Drawing.Point(6, 13);
            this.lblSectionOfBuildingActualProjectTotalSquare.Name = "lblSectionOfBuildingActualProjectTotalSquare";
            this.lblSectionOfBuildingActualProjectTotalSquare.Size = new System.Drawing.Size(170, 17);
            this.lblSectionOfBuildingActualProjectTotalSquare.TabIndex = 64;
            this.lblSectionOfBuildingActualProjectTotalSquare.Text = "Общая площадь фасада";
            // 
            // lblSectionOfBuldingActualProjectNotSaved1
            // 
            this.lblSectionOfBuldingActualProjectNotSaved1.AutoSize = true;
            this.lblSectionOfBuldingActualProjectNotSaved1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSectionOfBuldingActualProjectNotSaved1.ForeColor = System.Drawing.Color.Red;
            this.lblSectionOfBuldingActualProjectNotSaved1.Location = new System.Drawing.Point(555, 10);
            this.lblSectionOfBuldingActualProjectNotSaved1.Name = "lblSectionOfBuldingActualProjectNotSaved1";
            this.lblSectionOfBuldingActualProjectNotSaved1.Size = new System.Drawing.Size(201, 17);
            this.lblSectionOfBuldingActualProjectNotSaved1.TabIndex = 63;
            this.lblSectionOfBuldingActualProjectNotSaved1.Text = "Текущий проект не сохранен";
            this.lblSectionOfBuldingActualProjectNotSaved1.Visible = false;
            // 
            // btnSectionOfBuildingDelete
            // 
            this.btnSectionOfBuildingDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSectionOfBuildingDelete.Enabled = false;
            this.btnSectionOfBuildingDelete.Location = new System.Drawing.Point(645, 136);
            this.btnSectionOfBuildingDelete.Name = "btnSectionOfBuildingDelete";
            this.btnSectionOfBuildingDelete.Size = new System.Drawing.Size(110, 35);
            this.btnSectionOfBuildingDelete.TabIndex = 10;
            this.btnSectionOfBuildingDelete.Text = "Удалить модель фасада";
            this.btnSectionOfBuildingDelete.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingDelete.Click += new System.EventHandler(this.BtnSectionOfBuildingDelete_Click);
            // 
            // btnSectionOfBuildingSwitchUpdate
            // 
            this.btnSectionOfBuildingSwitchUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSectionOfBuildingSwitchUpdate.Enabled = false;
            this.btnSectionOfBuildingSwitchUpdate.Location = new System.Drawing.Point(647, 95);
            this.btnSectionOfBuildingSwitchUpdate.Name = "btnSectionOfBuildingSwitchUpdate";
            this.btnSectionOfBuildingSwitchUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnSectionOfBuildingSwitchUpdate.TabIndex = 9;
            this.btnSectionOfBuildingSwitchUpdate.Text = "Редактировать  название";
            this.btnSectionOfBuildingSwitchUpdate.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingSwitchUpdate.Click += new System.EventHandler(this.BtnSectionOfBuildingSwitchUpdate_Click);
            // 
            // btnSectionOfBuildingSwitchCreate
            // 
            this.btnSectionOfBuildingSwitchCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSectionOfBuildingSwitchCreate.Location = new System.Drawing.Point(647, 56);
            this.btnSectionOfBuildingSwitchCreate.Name = "btnSectionOfBuildingSwitchCreate";
            this.btnSectionOfBuildingSwitchCreate.Size = new System.Drawing.Size(110, 35);
            this.btnSectionOfBuildingSwitchCreate.TabIndex = 8;
            this.btnSectionOfBuildingSwitchCreate.Text = "Добавить модель фасада";
            this.btnSectionOfBuildingSwitchCreate.UseVisualStyleBackColor = true;
            this.btnSectionOfBuildingSwitchCreate.Click += new System.EventHandler(this.BtnSectionOfBuildingSwitchCreate_Click);
            // 
            // dgvSectionsOfBuildingByActualProject
            // 
            this.dgvSectionsOfBuildingByActualProject.AllowUserToAddRows = false;
            this.dgvSectionsOfBuildingByActualProject.AllowUserToDeleteRows = false;
            this.dgvSectionsOfBuildingByActualProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSectionsOfBuildingByActualProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.ColumnSquareSectionOfBuilding});
            this.dgvSectionsOfBuildingByActualProject.Location = new System.Drawing.Point(5, 49);
            this.dgvSectionsOfBuildingByActualProject.Name = "dgvSectionsOfBuildingByActualProject";
            this.dgvSectionsOfBuildingByActualProject.ReadOnly = true;
            this.dgvSectionsOfBuildingByActualProject.RowHeadersVisible = false;
            this.dgvSectionsOfBuildingByActualProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSectionsOfBuildingByActualProject.Size = new System.Drawing.Size(635, 27);
            this.dgvSectionsOfBuildingByActualProject.TabIndex = 7;
            this.dgvSectionsOfBuildingByActualProject.SelectionChanged += new System.EventHandler(this.DgvSectionsOfBuildingByActualProject_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.Frozen = true;
            this.dataGridViewTextBoxColumn38.HeaderText = "№";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Width = 30;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.Frozen = true;
            this.dataGridViewTextBoxColumn39.HeaderText = "Название участка фасада";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 300;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.Frozen = true;
            this.dataGridViewTextBoxColumn40.HeaderText = "Этажей";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.Frozen = true;
            this.dataGridViewTextBoxColumn41.HeaderText = "Элементов";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // ColumnSquareSectionOfBuilding
            // 
            this.ColumnSquareSectionOfBuilding.Frozen = true;
            this.ColumnSquareSectionOfBuilding.HeaderText = "Площадь";
            this.ColumnSquareSectionOfBuilding.Name = "ColumnSquareSectionOfBuilding";
            this.ColumnSquareSectionOfBuilding.ReadOnly = true;
            // 
            // labelActualProjectName
            // 
            this.labelActualProjectName.AutoSize = true;
            this.labelActualProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelActualProjectName.Location = new System.Drawing.Point(16, 28);
            this.labelActualProjectName.Name = "labelActualProjectName";
            this.labelActualProjectName.Size = new System.Drawing.Size(124, 17);
            this.labelActualProjectName.TabIndex = 3;
            this.labelActualProjectName.Text = "Текущий проект: ";
            // 
            // labelActualUserName
            // 
            this.labelActualUserName.AutoSize = true;
            this.labelActualUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelActualUserName.Location = new System.Drawing.Point(942, 28);
            this.labelActualUserName.Name = "labelActualUserName";
            this.labelActualUserName.Size = new System.Drawing.Size(169, 17);
            this.labelActualUserName.TabIndex = 4;
            this.labelActualUserName.Text = "Текущий пользователь: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1959, 987);
            this.Controls.Add(this.labelActualUserName);
            this.Controls.Add(this.labelActualProjectName);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProject.ResumeLayout(false);
            this.gblProjectPanel.ResumeLayout(false);
            this.gbProjectData.ResumeLayout(false);
            this.gbProjectDataComplete.ResumeLayout(false);
            this.gbProjectDataComplete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChekMarkProjectDateOfComplete)).EndInit();
            this.gbProjectDataName.ResumeLayout(false);
            this.gbProjectDataName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectName)).EndInit();
            this.gbProjectDataStart.ResumeLayout(false);
            this.gbProjectDataStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectPlannedDateOfComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkProjectDateOfStart)).EndInit();
            this.gbAllProjects.ResumeLayout(false);
            this.gbAllProjects.PerformLayout();
            this.groupBoxProjectState.ResumeLayout(false);
            this.groupBoxProjectState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProjects)).EndInit();
            this.tabPageUser.ResumeLayout(false);
            this.groupBoxUserPanel.ResumeLayout(false);
            this.gbUserData.ResumeLayout(false);
            this.gbUserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserPassport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserName)).EndInit();
            this.gbPasswordPanel.ResumeLayout(false);
            this.gbPasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserRepeatPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkUserPassword)).EndInit();
            this.gbUsersInProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInProject)).EndInit();
            this.gbAllUsers.ResumeLayout(false);
            this.gbAllUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.tabPageClient.ResumeLayout(false);
            this.gbAllClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.groupBoxClent.ResumeLayout(false);
            this.groupBoxClent.PerformLayout();
            this.gbClientData.ResumeLayout(false);
            this.gbClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkClientInn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkClientAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkClientName)).EndInit();
            this.tabPageWork.ResumeLayout(false);
            this.gbWorkPanel.ResumeLayout(false);
            this.gbTypeOfWorkData.ResumeLayout(false);
            this.gbTypeOfWorkData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfWorkMeasureUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfWorkDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfWorkName)).EndInit();
            this.gbWorkInProjectData.ResumeLayout(false);
            this.gbWorkInProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkWorkInProjectMultiplicity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkWorkInProjectPrice)).EndInit();
            this.gbWorksInActualProject.ResumeLayout(false);
            this.gbWorksInActualProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksInActualProject)).EndInit();
            this.gbAllTypesOfWork.ResumeLayout(false);
            this.gbAllTypesOfWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTypesOfWork)).EndInit();
            this.tabPagePayment.ResumeLayout(false);
            this.gbPaymentPanel.ResumeLayout(false);
            this.gbPaymentData.ResumeLayout(false);
            this.gbPaymentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkPaymentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkPaymentAmount)).EndInit();
            this.gbPaymentsInActualProject.ResumeLayout(false);
            this.gbPaymentsInActualProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsByUserInProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsInActualProjectByUsers)).EndInit();
            this.gbAllPayments.ResumeLayout(false);
            this.gbAllPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsByProject)).EndInit();
            this.gbPaymentRbDgv.ResumeLayout(false);
            this.gbPaymentRbDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumPaymentsByProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).EndInit();
            this.tabPageTypeOfElement.ResumeLayout(false);
            this.gbTypeOfElementPanel.ResumeLayout(false);
            this.gbTypeOfElementData.ResumeLayout(false);
            this.gbTypeOfElementData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeOfElementSetPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeOfElementPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkTypeOfElementName)).EndInit();
            this.gbTypeOfElementInProject.ResumeLayout(false);
            this.gbTypeOfElementInProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeOfElementSelectedDgvInProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypesOfElementInProject)).EndInit();
            this.gbAllTypesOfElement.ResumeLayout(false);
            this.gbAllTypesOfElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeOfElementSelectedDgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTypesOfElement)).EndInit();
            this.tabPageElementPicture.ResumeLayout(false);
            this.gbElementPictureData.ResumeLayout(false);
            this.gbElementPictureNamePicture.ResumeLayout(false);
            this.gbElementPictureNamePicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbElementPictureLoadContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkElementPictureLoadContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkElementPictureName)).EndInit();
            this.gbAllElementPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbElementPictureSelectedDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllElementPicture)).EndInit();
            this.tabPageSectionOfBuilding.ResumeLayout(false);
            this.gbSectionOfBuildingPanel.ResumeLayout(false);
            this.SectionOfBuildingModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionOfBuildingModel)).EndInit();
            this.gbSectionOfBuildingData.ResumeLayout(false);
            this.gbSectionOfBuildingData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkSectionOfBuildingQuantityByWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkSectionOfBuildingQuantityByHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMarkSectionOfBuildingName)).EndInit();
            this.gbTypeOfElementInProjectBySectionOfBuilding.ResumeLayout(false);
            this.gbTypeOfElementInProjectBySectionOfBuilding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionOfBuildingWorkInProject)).EndInit();
            this.gbAllSectionsOfBuilding.ResumeLayout(false);
            this.gbAllSectionsOfBuilding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionsOfBuildingByActualProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
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
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageProject;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.GroupBox gbAllUsers;
        private System.Windows.Forms.Button buttonAddUserInProject;
        private System.Windows.Forms.Button buttonSwitchChangePassword;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonSwitchUpdateUser;
        private System.Windows.Forms.Button buttonSwitchCreateUser;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassportColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userManagerAccessColumn;
        private System.Windows.Forms.GroupBox gbUsersInProject;
        private System.Windows.Forms.CheckBox checkBoxAllUsersVision;
        private System.Windows.Forms.DataGridView dgvUserInProject;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.GroupBox groupBoxUserPanel;
        private System.Windows.Forms.Label labelActualProjectName;
        private System.Windows.Forms.Label labelActualUserName;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblCheckUserLogin;
        private System.Windows.Forms.Label lblCheckUserPassport;
        private System.Windows.Forms.Label lblCheckUserName;
        private System.Windows.Forms.PictureBox pbCheckMarkUserRepeatPassword;
        private System.Windows.Forms.PictureBox pbCheckMarkUserPassword;
        private System.Windows.Forms.PictureBox pbCheckMarkUserLogin;
        private System.Windows.Forms.PictureBox pbCheckMarkUserPassport;
        private System.Windows.Forms.PictureBox pbCheckMarkUserName;
        private System.Windows.Forms.Label lblCheckUserPassword;
        private System.Windows.Forms.Label lblUserCheckPasswordsIsNotEuals;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.CheckBox checkBoxManagerAccess;
        private System.Windows.Forms.Label labelManagerAccess;
        private System.Windows.Forms.TextBox tbUserPasswordRepeat;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelЗPasswordRepeat;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Label labelUserPassport;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox tbUserPassport;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.GroupBox gbPasswordPanel;
        private System.Windows.Forms.GroupBox gbUserData;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button buttonUserSwitchCancel;
        private System.Windows.Forms.GroupBox gbAllProjects;
        private System.Windows.Forms.GroupBox groupBoxProjectState;
        private System.Windows.Forms.RadioButton radioButtonCancelledProjects;
        private System.Windows.Forms.RadioButton radioButtonCompletedProjects;
        private System.Windows.Forms.RadioButton radioButtonActualProjects;
        private System.Windows.Forms.RadioButton radioButtonPlannedProjects;
        private System.Windows.Forms.RadioButton radioButtonAllProjects;
        private System.Windows.Forms.Button buttonDeleteProject;
        private System.Windows.Forms.DataGridView dgvAllProjects;
        private System.Windows.Forms.Button buttonOpenProject;
        private System.Windows.Forms.GroupBox gblProjectPanel;
        private System.Windows.Forms.GroupBox gbProjectData;
        private System.Windows.Forms.Label lblCheckProjectAddress;
        private System.Windows.Forms.Label lblCheckProjectName;
        private System.Windows.Forms.PictureBox pbCheckMarkProjectAddress;
        private System.Windows.Forms.PictureBox pbCheckMarkProjectName;
        private System.Windows.Forms.Button btnProjectCreate;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label lblProjectAddress;
        private System.Windows.Forms.TextBox tbProjectAddress;
        private System.Windows.Forms.Button buttonViewProjectsByState;
        private System.Windows.Forms.Button buttonSwitchUpdateProject;
        private System.Windows.Forms.Button buttonSwitchCreateProject;
        private System.Windows.Forms.GroupBox groupBoxClent;
        private System.Windows.Forms.Button btnCancelClientSwitch;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.GroupBox gbClientData;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelInn;
        private System.Windows.Forms.Label lblCheckClientInn;
        private System.Windows.Forms.TextBox tbClientInn;
        private System.Windows.Forms.Label lblCheckClientAddress;
        private System.Windows.Forms.TextBox tbClientAddress;
        private System.Windows.Forms.Label lblCheckClientName;
        private System.Windows.Forms.Label labelClientAddress;
        private System.Windows.Forms.PictureBox pbCheckMarkClientInn;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.PictureBox pbCheckMarkClientAddress;
        private System.Windows.Forms.PictureBox pbCheckMarkClientName;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.GroupBox gbAllClients;
        private System.Windows.Forms.Button buttonAddClientToProject;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonSwitchUpdateClient;
        private System.Windows.Forms.Button buttonSwitchCreateClient;
        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClientAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClentInn;
        private System.Windows.Forms.Label labelActualProjectClient;
        private System.Windows.Forms.Button btnProjectUpdate;
        private System.Windows.Forms.Button btnProjectSwitchCancel;
        private System.Windows.Forms.PictureBox pbCheckMarkProjectClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManagerAccess;
        private System.Windows.Forms.TabPage tabPageWork;
        private System.Windows.Forms.GroupBox gbWorkPanel;
        private System.Windows.Forms.Button btnWorkSwitchCancel;
        private System.Windows.Forms.Button btnTypeOfWorkCreate;
        private System.Windows.Forms.GroupBox gbTypeOfWorkData;
        private System.Windows.Forms.Label labelNameTypeOfWork;
        private System.Windows.Forms.Label lblCheckTypeOfWorkDimension;
        private System.Windows.Forms.Label lblCheckTypeOfWorkName;
        private System.Windows.Forms.Label lblDimensionTypeOfWork;
        private System.Windows.Forms.TextBox tbTypeOfWorkName;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfWorkDimension;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfWorkName;
        private System.Windows.Forms.GroupBox gbWorkInProjectData;
        private System.Windows.Forms.Label labelPriceWorkInProject;
        private System.Windows.Forms.Button btnWorkInProjectCreate;
        private System.Windows.Forms.TextBox tbWorkInProjectPrice;
        private System.Windows.Forms.Label labelMultiplicityWorkInProject;
        private System.Windows.Forms.TextBox tbWorkInProjectMultiplicity;
        private System.Windows.Forms.Label lblWorkInProjectCheckMultiplicity;
        private System.Windows.Forms.PictureBox pbCheckMarkWorkInProjectMultiplicity;
        private System.Windows.Forms.Label lblWorkInProjectCheckPrice;
        private System.Windows.Forms.PictureBox pbCheckMarkWorkInProjectPrice;
        private System.Windows.Forms.GroupBox gbWorksInActualProject;
        private System.Windows.Forms.Button btnWorkInProjectDelete;
        private System.Windows.Forms.GroupBox gbAllTypesOfWork;
        private System.Windows.Forms.Button btnWorkInProjectSwitchCreate;
        private System.Windows.Forms.Button btnWorkInProjectSwitchUpdate;
        private System.Windows.Forms.Button btnTypeOfWorkDelete;
        private System.Windows.Forms.Button btnTypeOfWorkSwitchUpdate;
        private System.Windows.Forms.Button btnTypeOfWorkSwitchCreate;
        private System.Windows.Forms.DataGridView dgvAllTypesOfWork;
        private System.Windows.Forms.TextBox tbTypeOfWorkMeasureUnit;
        private System.Windows.Forms.Label lblCheckTypeOfWorkMeasureUnit;
        private System.Windows.Forms.Label labelMeasureUnitTypeOfWork;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfWorkMeasureUnit;
        private System.Windows.Forms.DataGridView dgvWorksInActualProject;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnTypeOfWorkUpdate;
        private System.Windows.Forms.Button btnWorkInProjectUpdate;
        private System.Windows.Forms.ComboBox cbTypeOfWorkDimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnWorkInProjectChangeMultiplicity;
        private System.Windows.Forms.Label lblWorksActualProjectNotSaved;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWorkInProjectPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWorkInProjectMultiplicity;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.GroupBox gbAllPayments;
        private System.Windows.Forms.Button btnPaymentDelete;
        private System.Windows.Forms.Button btnPaymentSwitchUpdate;
        private System.Windows.Forms.Button btnPaymentSwitchCreate;
        private System.Windows.Forms.DataGridView dgvAllPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnDateOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbAmount;
        private System.Windows.Forms.GroupBox gbPaymentPanel;
        private System.Windows.Forms.GroupBox gbPaymentData;
        private System.Windows.Forms.PictureBox pbCheckMarkPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Button btnPaymentSwitchCancel;
        private System.Windows.Forms.Button btnPaymentUpdate;
        private System.Windows.Forms.Button btnPaymentCreate;
        private System.Windows.Forms.TextBox tbPaymentAmout;
        private System.Windows.Forms.Label lblCheckPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.PictureBox pbCheckMarkPaymentAmount;
        private System.Windows.Forms.Label lblPaymentProject;
        private System.Windows.Forms.Label lblPaymentUser;
        private System.Windows.Forms.TextBox tbPaymentProject;
        private System.Windows.Forms.GroupBox gbPaymentsInActualProject;
        private System.Windows.Forms.DataGridView dgvPaymentsByUserInProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnAmount;
        private System.Windows.Forms.Label lblPaymentsBySelectedUser;
        private System.Windows.Forms.Label lblPaymentsActualProjectNotSaved;
        private System.Windows.Forms.DataGridView dgvPaymentsInActualProjectByUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnPayments;
        private System.Windows.Forms.DataGridView dgvSumPaymentsByProject;
        private System.Windows.Forms.TextBox tbPaymentUser;
        private System.Windows.Forms.Label lblCheckPaymentDate;
        private System.Windows.Forms.Button btnProjectSwitchStart;
        private System.Windows.Forms.DateTimePicker dtpProjectPlannedDateOfComplete;
        private System.Windows.Forms.DateTimePicker dtpProjectDateOfStart;
        private System.Windows.Forms.Label lblProjectDateOfStart;
        private System.Windows.Forms.Label lblProjectPlanDateOfComplete;
        private System.Windows.Forms.Label lblCheckProjectPlannedDateOfComplete;
        private System.Windows.Forms.PictureBox pbCheckMarkProjectDateOfStart;
        private System.Windows.Forms.Label lblCheckProjectDateOfStart;
        private System.Windows.Forms.PictureBox pbCheckMarkProjectPlannedDateOfComplete;
        private System.Windows.Forms.GroupBox gbProjectDataName;
        private System.Windows.Forms.GroupBox gbProjectDataStart;
        private System.Windows.Forms.DataGridView dgvProjectClients;
        private System.Windows.Forms.Button btnProjectClientSelect;
        private System.Windows.Forms.Button btnProjectClientSelectCancel;
        private System.Windows.Forms.Button btnProjectSetClient;
        private System.Windows.Forms.TextBox tbProjectClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnClient;
        private System.Windows.Forms.Label lblCheckProjectClient;
        private System.Windows.Forms.TextBox tbProjectPlannedDateOfComplete;
        private System.Windows.Forms.TextBox tbProjectDateOfStart;
        private System.Windows.Forms.TextBox tbPaymentDate;
        private System.Windows.Forms.GroupBox gbPaymentRbDgv;
        private System.Windows.Forms.RadioButton rbAllPayments;
        private System.Windows.Forms.RadioButton rbPaymentsByProjects;
        private System.Windows.Forms.DataGridView dgvPaymentsByProject;
        private System.Windows.Forms.Label lblPaymentsByProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnAmountByProject;
        private System.Windows.Forms.TabPage tabPageTypeOfElement;
        private System.Windows.Forms.GroupBox gbTypeOfElementPanel;
        private System.Windows.Forms.Button btnTypeOfElementSwitchCancel;
        private System.Windows.Forms.Button btnTypeOfElementCreate;
        private System.Windows.Forms.GroupBox gbTypeOfElementData;
        private System.Windows.Forms.Label lblTypeOfElementName;
        private System.Windows.Forms.Label lblCheckTypeOfElementSquare;
        private System.Windows.Forms.TextBox tbTypeOfElementSquare;
        private System.Windows.Forms.Label lblCheckTypeOfElementName;
        private System.Windows.Forms.Label lblTypeOfElementSquare;
        private System.Windows.Forms.TextBox tbTypeOfElementName;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfElementSquare;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfElementName;
        private System.Windows.Forms.Button btnTypeOfElementUpdate;
        private System.Windows.Forms.GroupBox gbTypeOfElementInProject;
        private System.Windows.Forms.Button btnTypeOfElementDeleteFromProject;
        private System.Windows.Forms.GroupBox gbAllTypesOfElement;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btnTypeOfElementAddToProject;
        private System.Windows.Forms.Button btnTypeOfElementDelete;
        private System.Windows.Forms.Button btnTypeOfElementSwitchUpdate;
        private System.Windows.Forms.Button btnTypeOfElementSwitchCreate;
        private System.Windows.Forms.DataGridView dgvAllTypesOfElement;
        private System.Windows.Forms.OpenFileDialog ofdElementOpenImage;
        private System.Windows.Forms.TabPage tabPageElementPicture;
        private System.Windows.Forms.GroupBox gbElementPictureData;
        private System.Windows.Forms.PictureBox pbElementPictureLoadContent;
        private System.Windows.Forms.Button btnElementPictureOpenFile;
        private System.Windows.Forms.Button btnElementPictureSwitchCancel;
        private System.Windows.Forms.Button btnElementPictureUpdate;
        private System.Windows.Forms.GroupBox gbElementPictureNamePicture;
        private System.Windows.Forms.Label lblElementPictureName;
        private System.Windows.Forms.Label lblCheckElementPictureName;
        private System.Windows.Forms.TextBox tbElementPictureName;
        private System.Windows.Forms.PictureBox pbCheckMarkElementPictureLoadContent;
        private System.Windows.Forms.PictureBox pbCheckMarkElementPictureName;
        private System.Windows.Forms.Button btnElementPictureCreate;
        private System.Windows.Forms.GroupBox gbAllElementPicture;
        private System.Windows.Forms.Button btnElementPictureDelete;
        private System.Windows.Forms.Button btnElementPictureSwitchUpdate;
        private System.Windows.Forms.Button btnElementPictureSwitchCreate;
        private System.Windows.Forms.DataGridView dgvAllElementPicture;
        private System.Windows.Forms.PictureBox pbElementPictureSelectedDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTbColumnPictureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnElementPicturePicture;
        private System.Windows.Forms.PictureBox pbTypeOfElementSelectedDgvAll;
        private System.Windows.Forms.Label lblCheckTypeOfElementLength;
        private System.Windows.Forms.TextBox tbTypeOfElementLength;
        private System.Windows.Forms.Label lblTypeOfElementLength;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfElementLength;
        private System.Windows.Forms.Label lblCheckTypeOfElementHeight;
        private System.Windows.Forms.TextBox tbTypeOfElementHeight;
        private System.Windows.Forms.Label lblTypeOfElementHeight;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfElementHeight;
        private System.Windows.Forms.Button btnTypeOfElementCancelPicture;
        private System.Windows.Forms.Button btnTypeOfElementSetPicture;
        private System.Windows.Forms.PictureBox pbCheckMarkTypeOfElementPicture;
        private System.Windows.Forms.DataGridView dgvTypeOfElementSetPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.Button btnTypeOfElementSwitchSetPicture;
        private System.Windows.Forms.PictureBox pbTypeOfElementPicture;
        private System.Windows.Forms.Label lblTypesOfElementActualProjectNotSaved;
        private System.Windows.Forms.PictureBox pbTypeOfElementSelectedDgvInProject;
        private System.Windows.Forms.DataGridView dgvTypesOfElementInProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdElementPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeOfElementInProjectIdElementPicture;
        private System.Windows.Forms.TabPage tabPageSectionOfBuilding;
        private System.Windows.Forms.GroupBox gbSectionOfBuildingPanel;
        private System.Windows.Forms.Button btnSectionOfBuildingSwitchCancel;
        private System.Windows.Forms.Button btnSectionOfBuildingCreate;
        private System.Windows.Forms.GroupBox gbSectionOfBuildingData;
        private System.Windows.Forms.Label lblCheckSectionOfBuildingQuantityByWidth;
        private System.Windows.Forms.TextBox tbSectionOfBuildingQuantityByWidth;
        private System.Windows.Forms.Label lblSectionOfBuildingQuantityByWidth;
        private System.Windows.Forms.PictureBox pbCheckMarkSectionOfBuildingQuantityByWidth;
        private System.Windows.Forms.Label lblSectionOfBuildingName;
        private System.Windows.Forms.Label lblCheckSectionOfBuildingQuantityByHeight;
        private System.Windows.Forms.TextBox tbSectionOfBuildingQuantityByHeight;
        private System.Windows.Forms.Label lblCheckSectionOfBuildingName;
        private System.Windows.Forms.Label lblSectionOfBuildingQuantityByHeight;
        private System.Windows.Forms.TextBox tbSectionOfBuildingName;
        private System.Windows.Forms.PictureBox pbCheckMarkSectionOfBuildingQuantityByHeight;
        private System.Windows.Forms.PictureBox pbCheckMarkSectionOfBuildingName;
        private System.Windows.Forms.Button btnSectionOfBuildingUpdate;
        private System.Windows.Forms.GroupBox gbTypeOfElementInProjectBySectionOfBuilding;
        private System.Windows.Forms.Label lblSectionOfBuldingActualProjectNotSaved2;
        private System.Windows.Forms.GroupBox gbAllSectionsOfBuilding;
        private System.Windows.Forms.Label lblSectionOfBuldingActualProjectNotSaved1;
        private System.Windows.Forms.Button btnSectionOfBuildingDelete;
        private System.Windows.Forms.Button btnSectionOfBuildingSwitchUpdate;
        private System.Windows.Forms.Button btnSectionOfBuildingSwitchCreate;
        private System.Windows.Forms.DataGridView dgvSectionsOfBuildingByActualProject;
        private System.Windows.Forms.GroupBox SectionOfBuildingModel;
        private System.Windows.Forms.ListView lvSectionOfBuildingTypesOfElementInProject;
        private System.Windows.Forms.DataGridView dgvSectionOfBuildingModel;
        private System.Windows.Forms.Button btnSectionOfBuildingSwitchModelCancel;
        private System.Windows.Forms.Button btnSectionOfBuildingModelUpdate;
        private System.Windows.Forms.Button btnSectionOfBuildingSwitchModelUpdate;
        private System.Windows.Forms.Label lblSectuinOfBuildingSquare;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSquareSectionOfBuilding;
        private System.Windows.Forms.Label lblSectionOfBuildingActualProjectTotalSquare;
        private System.Windows.Forms.Button btnSectionOfBuildingSwitchSetWork;
        private System.Windows.Forms.DataGridView dgvSectionOfBuildingWorkInProject;
        private System.Windows.Forms.Button btnSectionOfBuildingCancelWork;
        private System.Windows.Forms.Button btnSectionOfBuildingSetWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlannedDateOfComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSectionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSectionCost;
        private System.Windows.Forms.Label lblSectionOfBuildingActualProjectWorksAmount;
        private System.Windows.Forms.Label lblSectionOfBuildingWorksAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbProjectDataComplete;
        private System.Windows.Forms.TextBox tbProjectDateOfComplete;
        private System.Windows.Forms.Label lblProjectDateOfComplete;
        private System.Windows.Forms.DateTimePicker dtpProjectDateOfComplete;
        private System.Windows.Forms.Label lblCheckProjectDateOfComplete;
        private System.Windows.Forms.PictureBox pbChekMarkProjectDateOfComplete;
        private System.Windows.Forms.Label lbllProjectWorksAmount;
        private System.Windows.Forms.Label lblProjectTotalSquare;
        private System.Windows.Forms.Label lbllProjectAmountPayments;
    }
}